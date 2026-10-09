using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace ABD2_Finishing.Report
{
    public partial class Product_Details : Form
    {
        public Product_Details()
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
            display();
        }


        public void display()
        {
            try
            {

                dgv1.DataSource = null;
                dgv1.flag = true;
                
                DataTable dt = dbFunctions.getTable("pr_get_scan_Summary  '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "'");//  " + LEDGER_ID.SelectedValue + ",'" + From_Date.Value.ToString("dd-MMM-yyyy") + "','" + To_Date.Value.ToString("dd-MMM-yyyy") + "'," + dbFunctions.Company_ID);
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
            display1();

        }


        public void display1()
        {
            try
            {
                dgv1.DataSource = null;
                dgv1.flag = true;

                DataTable dt = dbFunctions.getTable("pr_get_scan_Summary1  '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "'");//  " + LEDGER_ID.SelectedValue + ",'" + From_Date.Value.ToString("dd-MMM-yyyy") + "','" + To_Date.Value.ToString("dd-MMM-yyyy") + "'," + dbFunctions.Company_ID);
                dgv1.Form_Name = this.Name;
                dgv1.DataSource = dt;
                dgv1._Zerovisible = false;
                dgv1.Title = "Product Details";
                dgv1.Left_Data.Rows.Clear();

            }
            catch { }
        }

    }
}
