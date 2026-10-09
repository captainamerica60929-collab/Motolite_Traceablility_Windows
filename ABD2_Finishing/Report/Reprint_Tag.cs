using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using Maintanence_Printing_Tool;
using Shasun_Printing_Toll.Masters;

namespace ABD2_Finishing.Report
{
    public partial class Reprint_Tag : Form
    {
        public Reprint_Tag()
        {
            InitializeComponent();
        }

       

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Product_Details_Load(object sender, EventArgs e)
        {
            display();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            print_Lable();
        }

        private void print_Lable()
        {

            if (dgv1.SelectedRows.Count> 0)
            {


                string PrinterName = dataClass.printerName.ToString();
                string text = System.IO.File.ReadAllText(dbFunctions.Label_Path);



                string ReplaceText1 = text.Replace("@Date@", dgv1.SelectedRows[0].Cells["Created_date"].Value.ToString());



                ReplaceText1 = ReplaceText1.Replace("@Desc@", dgv1.SelectedRows[0].Cells["Part_No"].Value.ToString());
              


                string SNo = dgv1.SelectedRows[0].Cells["S_No"].Value.ToString() + "                                                                                                                                                                                                                                                                                                                                                                                                                                            .";
          
                ReplaceText1 = ReplaceText1.Replace("@S_No@", SNo.Substring(0, 26));
                ReplaceText1 = ReplaceText1.Replace("@S1@", SNo.Substring(26, 52));
                ReplaceText1 = ReplaceText1.Replace("@S2@", SNo.Substring(52, 105));
                    ReplaceText1 = ReplaceText1.Replace("@Qty@", dgv1.SelectedRows[0].Cells["Skid_Qty"].Value.ToString());
                    ReplaceText1 = ReplaceText1.Replace("@Lot@", "");
                    ReplaceText1 = ReplaceText1.Replace("@Line@", "Finishing");
                    ReplaceText1 = ReplaceText1.Replace("@Operator@", dgv1.SelectedRows[0].Cells["Inspector"].Value.ToString());
                ReplaceText1 = ReplaceText1.Replace("@model@", dgv1.SelectedRows[0].Cells["Model"].Value.ToString());
                ReplaceText1 = ReplaceText1.Replace("@Bar@", dgv1.SelectedRows[0].Cells["Barcode"].Value.ToString());
                    ReplaceText1 = ReplaceText1.Replace("@Inspector@", dgv1.SelectedRows[0].Cells["Inspector"].Value.ToString());
                    ReplaceText1 = ReplaceText1.Replace("@Barcode@", dgv1.SelectedRows[0].Cells["Barcode"].Value.ToString() + "~" + dgv1.SelectedRows[0].Cells["S_No"].Value.ToString() + "~" + dgv1.SelectedRows[0].Cells["Part_No"].Value.ToString() + "~" + dgv1.SelectedRows[0].Cells["Switch_of"].Value.ToString() + "~" + dgv1.SelectedRows[0].Cells["Skid_Qty"].Value.ToString() + "~" + dgv1.SelectedRows[0].Cells["Inspector"].Value.ToString());
                    ReplaceText1 = ReplaceText1.Replace("@Switch@", dgv1.SelectedRows[0].Cells["Switch_of"].Value.ToString());
                    ReplaceText1 = ReplaceText1.Replace("@Remarks@", dgv1.SelectedRows[0].Cells["Remarks"].Value.ToString());
                ReplaceText1 = ReplaceText1.Replace("@Barcode1@", dgv1.SelectedRows[0].Cells["FULL_Barcode"].Value.ToString());

                RawPrinterHelper.SendStringToPrinter(PrinterName, ReplaceText1);

                
            }
        }
    

        public void display()
        {
            try
            {

                dgv1.DataSource = null;
                dgv1.flag = true;

                DataTable dt = dbFunctions.getTable("select Barocde as Barcode,Part_No,PM_Mold as [Model], Switch_of,Remarks,S_No,Inpector as Inspector,Skid_Qty,Crated_Date as Created_date,FULL_Barcode  from Formation_Production_Data   left outer join Product_Master on Part_No=PM_Item_Code  where  convert(Varchar,Crated_Date,112)>='" + From_Date.Value.ToString("yyyyMMdd") + "' and convert(Varchar,Crated_Date,112)<='" + To_Date.Value.ToString("yyyyMMdd") + "'");//  " + LEDGER_ID.SelectedValue + ",'" + From_Date.Value.ToString("dd-MMM-yyyy") + "','" + To_Date.Value.ToString("dd-MMM-yyyy") + "'," + dbFunctions.Company_ID);
                dgv1.Form_Name = this.Name;
                dgv1.DataSource = dt;
                dgv1._Zerovisible = false;
                dgv1.Title = "Product Details";
                dgv1.Left_Data.Rows.Clear();

            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display();

        }


    
    }
}
