using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ABD2_Finishing.Report
{
    public partial class Formattion_Outward : Form
    {
        public Formattion_Outward()
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

                //dgv1.DataSource = null;
                //dgv1.flag = true;
                //DataTable dt = dbFunctions.getTable("pr_get_Formattion_Outward_Stock  '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "'");
                //dgv1.Form_Name = this.Name;
                //dgv1.DataSource = dt;
                //dgv1._Zerovisible = false;
                //dgv1.Title = "Formattion Outward Details";
                //dgv1.Left_Data.Rows.Clear();

                dgv1.DataSource = null;
                dgv1.flag = true;
                //DataTable dt = dbFunctions.getTable("pr_fetchOutward_details  '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "'");
                DataTable dt = dbFunctions.getTable("pr_fetch_stock_details  '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "'");
                dgv1.Form_Name = this.Name;
                dgv1.DataSource = dt;
                dgv1._Zerovisible = false;
                dgv1.Title = "Formattion Outward Details";
                dgv1.Left_Data.Rows.Clear();

            }
            catch { }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formattion_Outward_Load(object sender, EventArgs e)
        {
            get_data();
            display();
        }

        void get_data()
        {

            DataTable dt = dbFunctions.getTable("pr_fetch_ReferenceGroup_Value '" + "Rework_Remarks" + "'");
            textBox1.DataSource = dt;
            textBox1.DisplayMember = "RGV_vDesciption";
            textBox1.ValueMember = "RGV_vDesciption";
            textBox1.SelectedIndex = -1;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (!(textBox2.Text.ToLower().Equals("abd2345")))
            {
                MessageBox.Show("Invalid Password");
                return;
            }


            if (textBox1.Text == "")
            {
                MessageBox.Show("Reason Should not Empty");
                return;
            }


            if (dgv1.SelectedRows.Count > 0)
            {
                
                    try
                    {

                        DataTable dt1 = dbFunctions.getTable("insert into Formation_Stock_D select ID, Type, Barcode, Part_No, Skid_Qty, Rack_No, In_Qty, Out_Qty, Date, InDate, Out_Date, Createdby, getdate() as Created_Date, Status, Vehicle,'" + textBox1.Text + "' from Formation_Stock where Barcode='" + dgv1.SelectedRows[0].Cells["Barcode"].Value.ToString() + "' and [type]!='Inward'");

                        DataTable dt = dbFunctions.getTable("delete from Formation_Stock where Barcode='" + dgv1.SelectedRows[0].Cells["Barcode"].Value.ToString() + "'");
                        display();
                        textBox2.Text = "";
                        panel1.Visible = false;

                    }
                    catch { }
                }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = null;
            dgv1.flag = true;
            DataTable dt = dbFunctions.getTable("pr_fetch_total_stock");
            dgv1.Form_Name = this.Name;
            dgv1.DataSource = dt;
            dgv1._Zerovisible = false;
            dgv1.Title = "Formattion Outward Details";
            dgv1.Left_Data.Rows.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = null;
            dgv1.flag = true;
            DataTable dt = dbFunctions.getTable("pr_fetch_total_Rack_stock");
            dgv1.Form_Name = this.Name;
            dgv1.DataSource = dt;
            dgv1._Zerovisible = false;
            dgv1.Title = "Formattion Outward Details";
            dgv1.Left_Data.Rows.Clear();        
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                getdata();
                panel9.Visible = true;

            }
            if (e.ColumnIndex == 5)
            {
                button9.Visible = true;
                outwars_getdata();
                panel9.Visible = true;

            }
            if (e.ColumnIndex == 4)
            {
                button9.Visible = false;
                Inward_getdata();
                panel9.Visible = true;

            }
            if (e.ColumnIndex == 6)
            {
                button9.Visible = false;
                CLOSING_getdata();
                panel9.Visible = true;

            }
        }

        private void CLOSING_getdata()
        {
            DataTable dt = dbFunctions.getTable("pr_fetch_closing_barcodes_LIST '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "','" + dgv1.SelectedRows[0].Cells["Model"].Value + "','" + dgv1.SelectedRows[0].Cells["Item Code"].Value + "','" + dgv1.SelectedRows[0].Cells["Rack"].Value + "'");
            dataGridView3.DataSource = dt;
        }

        private void Inward_getdata()
        {
            DataTable dt = dbFunctions.getTable("pr_fetch_stock_Inward_details '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "','" + dgv1.SelectedRows[0].Cells["Model"].Value + "','" + dgv1.SelectedRows[0].Cells["Item Code"].Value + "','" + dgv1.SelectedRows[0].Cells["Rack"].Value + "'");
            dataGridView3.DataSource = dt;
        }

        private void outwars_getdata()
        {
            DataTable dt = dbFunctions.getTable("pr_fetch_stock_outward_details '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "','" + dgv1.SelectedRows[0].Cells["Model"].Value + "','" + dgv1.SelectedRows[0].Cells["Item Code"].Value + "','" + dgv1.SelectedRows[0].Cells["Rack"].Value + "'");
            dataGridView3.DataSource = dt;
            dataGridView3.Columns["ID"].Visible = false;
        }

        private void getdata()
        {
            DataTable dt = dbFunctions.getTable("pr_fetch_total_details '" + dgv1.SelectedRows[0].Cells["Rack No"].Value + "'");
            dataGridView3.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            display();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            dgv1.DataSource = null;
            dgv1.flag = true;
            DataTable dt = dbFunctions.getTable("pr_get_Formattion_Outward_Stock  '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "'");
            dgv1.Form_Name = this.Name;
            dgv1.DataSource = dt;
            dgv1._Zerovisible = false;
            dgv1.Title = "Formattion Outward Details";
            dgv1.Left_Data.Rows.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (dataGridView3.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are You Sure Want to Delete Press YES", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    DataTable dt = dbFunctions.getTable(@"UPDATE Scan_Details
                    SET
                        SD_FinishingOutStatus = NULL,
                        SD_FinishingOutQty = NULL,
                        SD_FinishingBalQty = NULL,
                        SD_FinishingOutDate = NULL,
                        SD_FinishingOutBy = NULL
                    WHERE SD_ID = '" + dataGridView3.SelectedRows[0].Cells["ID"].Value.ToString() + "'");
                                  MessageBox.Show("Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            outwars_getdata();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dbFunctions.ExportExcel(dataGridView3);
            Cursor.Current = Cursors.Default;
        }
    }
}
