using ABD2_Finishing.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ABD2_Finishing.Report
{
    public partial class Formation_Stock : Form
    {
        public Formation_Stock()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display();
        }

        public void display()
        {
            try
            {

                del = false;
                dgv1.DataSource = null;
                dgv1.flag = true;
                DataTable dt = dbFunctions.getTable("select FPD.Part_No, PM.PM_Mold as [Model No], cast(sum(FPD.Skid_Qty) as decimal(18,2)) as Qty " + "from Formation_Production_Data FPD " + "LEFT OUTER JOIN Product_Master PM ON PM.PM_Item_Code = FPD.Part_No " +
                                                    "where convert(varchar, FPD.Crated_Date, 112) >= '" + From_Date.Value.ToString("yyyyMMdd") + "' " +
                                                    "and convert(varchar, FPD.Crated_Date, 112) <= '" + To_Date.Value.ToString("yyyyMMdd") + "' " +
                                                    "group by FPD.Part_No, PM.PM_Mold");
                //DataTable dt = dbFunctions.getTable("select Part_No, cast(sum(Skid_Qty) as decimal(18,2)) as Qty from  Formation_Production_Data where convert(varchar,Crated_Date,112)>=   '" + From_Date.Value.ToString("yyyyMMdd") + "' and  convert(varchar,Crated_Date,112)<='" + To_Date.Value.ToString("yyyyMMdd") + "' group by Part_No");//  " + LEDGER_ID.SelectedValue + ",'" + From_Date.Value.ToString("dd-MMM-yyyy") + "','" + To_Date.Value.ToString("dd-MMM-yyyy") + "' select Part_No,sum(Skid_Qty) as Qty from  Formation_Production_Data group by  Part_No");
                dgv1.Form_Name = this.Name;
                dgv1.DataSource = dt;
                dgv1._Zerovisible = false;
                dgv1.Title = "Product Details";
                dgv1.Left_Data.Rows.Clear();

            }
            catch { }
        }


        public void hold_color()
        {

            for (int i = 0; i < dgv1.Rows.Count; i++)
            {
                if (dgv1.Rows[i].Cells["Remarks"].Value.ToString().ToLower().Equals("hold"))
                {
                    dgv1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display1();
           
        }

        public void display1()
        {
            try
            {
                del = true;

                dgv1.DataSource = null;
                dgv1.flag = true;

                DataTable dt = dbFunctions.getTable("select [ID],[Barocde],[Part_No],[Switch_Of],[S_No], cast([Skid_qty] as decimal(18,2)) as [Skid_qty],[Remarks],[Inpector],[Created_by],[Crated_Date] from  Formation_Production_Data where convert(varchar,Crated_Date,112)>=   '" + From_Date.Value.ToString("yyyyMMdd") + "' and  convert(varchar,Crated_Date,112)<='" + To_Date.Value.ToString("yyyyMMdd") + "' order by Barocde desc");//  " + LEDGER_ID.SelectedValue + ",'" + From_Date.Value.ToString("dd-MMM-yyyy") + "','" + To_Date.Value.ToString("dd-MMM-yyyy") + "' select Part_No,sum(Skid_Qty) as Qty from  Formation_Production_Data group by  Part_No");
                dgv1.Form_Name = this.Name;
                dgv1.DataSource = dt;
                dgv1._Zerovisible = false;
                dgv1.Title = "Product Details";
                dgv1.Left_Data.Rows.Clear();
                hold_color();
            }
            catch { }
        }

        public bool del = true;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are You Sure Want to Delete Press YES", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    DataTable dt = dbFunctions.getTable("delete  from  Formation_Production_Data where Barocde='" + dgv1.SelectedRows[0].Cells["Barocde"].Value.ToString()+"'");
                    DataTable dt1 = dbFunctions.getTable1("delete  from  Formation_Production_Data where Barocde='" + dgv1.SelectedRows[0].Cells["Barocde"].Value.ToString() + "'");
                    MessageBox.Show("Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    display1();
                    
                }
            }
            else
            {
                MessageBox.Show("Please Select Row", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                del = true;

                dgv1.DataSource = null;
                dgv1.flag = true;

                //DataTable dt = dbFunctions.getTable("select [ID],[Barocde],[Part_No],[Switch_Of],[S_No], cast([Skid_qty] as decimal(18,2)) as [Skid_qty],[Remarks],[Inpector],[Created_by],[Crated_Date] from  Formation_Production_Data where [Barocde] not in (select i.Barcode from Formation_Stock i) and  convert(varchar,Crated_Date,112)>=   '" + From_Date.Value.ToString("yyyyMMdd") + "' and  convert(varchar,Crated_Date,112)<='" + To_Date.Value.ToString("yyyyMMdd") + "' order by Barocde desc");//  " + LEDGER_ID.SelectedValue + ",'" + From_Date.Value.ToString("dd-MMM-yyyy") + "','" + To_Date.Value.ToString("dd-MMM-yyyy") + "' select Part_No,sum(Skid_Qty) as Qty from  Formation_Production_Data group by  Part_No");
                DataTable dt = dbFunctions.getTable(@"
                            SELECT
                                f.ID,
                                f.Barocde,
                                f.Part_No,
                                p.PM_Mold AS Model,
                                f.Switch_Of,
                                f.S_No,
                                CAST(f.Skid_qty AS DECIMAL(18,2)) AS Skid_qty,
                                f.Remarks,
                                f.Inpector,
                                f.Created_by,
                                f.Crated_Date
                            FROM Formation_Production_Data f
                            LEFT JOIN Product_Master p
                                ON f.Part_No = p.PM_Item_Code
                            WHERE NOT EXISTS
                            (
                                SELECT 1
                                FROM Scan_Details s
                                WHERE s.SD_MOQ_Barcode = f.Barocde
                                  AND s.SD_FinishingInStatus = 'Inward'
                            )
                            AND f.Crated_Date >= '" + From_Date.Value.ToString("yyyy-MM-dd") + @"'
                            AND f.Crated_Date < DATEADD(DAY,1,'" + To_Date.Value.ToString("yyyy-MM-dd") + @"')
                            ORDER BY f.Barocde DESC");
                dgv1.Form_Name = this.Name;
                dgv1.DataSource = dt;
                dgv1._Zerovisible = false;
                dgv1.Title = "Product Details";
                dgv1.Left_Data.Rows.Clear();
                hold_color();
            }
            catch { }
        }
    }
}
