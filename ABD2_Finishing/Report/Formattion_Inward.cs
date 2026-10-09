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
    public partial class Formattion_Inward : Form
    {
        public Formattion_Inward()
        {
            InitializeComponent();
        }

        private void Formattion_Inward_Load(object sender, EventArgs e)
        {
            DataTable dt = dbFunctions.getTable("pr_get_Code");
            SD_Item_Code.DataSource = dt;
            SD_Item_Code.DisplayMember = "PM_Item_Code";
            SD_Item_Code.ValueMember = "PM_Item_Code";
            SD_Item_Code.SelectedIndex = -1;

            display();
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
                //DataTable dt = dbFunctions.getTable("pr_get_Formattion_Inward_Stock  '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "'");
                //dgv1.Form_Name = this.Name;
                //dgv1.DataSource = dt;
                //dgv1._Zerovisible = false;
                //dgv1.Title = "Formattion Inward Details";
                //dgv1.Left_Data.Rows.Clear();
                dgv1.DataSource = null;
                dgv1.flag = true;
                DataTable dt = dbFunctions.getTable("pr_fetchInward_details '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "'");
                dgv1.Form_Name = this.Name;
                dgv1.DataSource = dt;
                dgv1._Zerovisible = false;
                dgv1.Title = "Formattion Inward Details";
                dgv1.Left_Data.Rows.Clear();
               // get_color();

            }
            catch { }
        }



        public void display1()
        {
            try
            {

                dgv1.DataSource = null;
                dgv1.flag = true;
                DataTable dt = dbFunctions.getTable("pr_fetchInward_details_Item_Code  '" + SD_Item_Code.Text+ "'");
                dgv1.Form_Name = this.Name;
                dgv1.DataSource = dt;
                dgv1._Zerovisible = false;
                dgv1.Title = "Formattion Inward Details";
                dgv1.Left_Data.Rows.Clear();

                get_color();

                dgv1.ClearSelection();

            }
            catch { }
        }

        public void get_color()
        {
        //    for (int i = 0; i < dgv1.Rows.Count; i++)
        //    {
              
        //        if (decimal.Parse(dgv1.Rows[i].Cells["Age"].Value.ToString())>=6)
        //        {
        //            dgv1.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
        //        }

        //        if (dgv1.Rows[i].Cells["isalloted"].Value.ToString().ToLower().Equals("yes"))
        //        {
        //            dgv1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
        //        }
        //    }
        //    dgv1.ClearSelection();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void From_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label37_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void To_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv1.SelectedRows.Count; i++)
            {
                DataTable dt = dbFunctions.getTable("pr_get_Stock_Details '" + dgv1.SelectedRows[i].Cells["Barcode"].Value.ToString() + "'");
                if (dt.Rows[0]["Status"].ToString().ToLower().Equals("ok"))
                {
                    DataTable dd = dbFunctions.getTable("update Formation_Stock set isalloted='Yes',Vehicle='" + textBoxX1.Text + "' where Barcode='" + dgv1.SelectedRows[i].Cells["Barcode"].Value.ToString() + "'");
                }
                else
                {
                    MessageBox.Show("FIFO Not Followed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            display();
        }

        private void Formattion_Inward_VisibleChanged(object sender, EventArgs e)
        {
            get_color();
        }

        private void Formattion_Inward_Shown(object sender, EventArgs e)
        {
            get_color();
        }

        private void dgv1_DataSourceChanged(object sender, EventArgs e)
        {
            get_color();
        }

        private void dgv1_Sorted(object sender, EventArgs e)
        {
            get_color();
        }

        private void SD_Item_Code_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display1();
        }

        private void dgv1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            get_color();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv1.SelectedRows.Count; i++)
            {
                DataTable dt = dbFunctions.getTable("pr_get_Stock_Details '" + dgv1.SelectedRows[i].Cells["Barcode"].Value.ToString() + "'");
                if (dt.Rows[0]["Status"].ToString().ToLower().Equals("ok"))
                {
                    DataTable dd = dbFunctions.getTable("update Formation_Stock set isalloted='No',Vehicle='' where Barcode='" + dgv1.SelectedRows[i].Cells["Barcode"].Value.ToString() + "'");
                }
                else
                {
                    MessageBox.Show("FIFO Not Followed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            display();
        }

        private void textBoxX2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int i = 0;
                decimal x=0;
                do
                {
                    if (dgv1.Rows[i].Cells["isalloted"].Value.ToString().ToLower().Equals("no"))
                    {
                        dgv1.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                        x = x + decimal.Parse(dgv1.Rows[i].Cells["SkidQty"].Value.ToString());
                    }
                    i++;
                } while (int.Parse(textBoxX2.Text) >= x);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {

                dgv1.DataSource = null;
                dgv1.flag = true;
                DataTable dt = dbFunctions.getTable("pr_get_Inward_Details  '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "'");
                dgv1.Form_Name = this.Name;
                dgv1.DataSource = dt;
                dgv1._Zerovisible = false;
                dgv1.Title = "Formattion Inward Details";
                dgv1.Left_Data.Rows.Clear();

                get_color();

            }
            catch { }
        }
    }
}
