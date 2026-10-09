using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABD2_Finishing.Report
{
    public partial class Warehouse_Stock : Form
    {
        public Warehouse_Stock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void display()
        {
            try
            {

                dgv1.DataSource = null;
                dgv1.flag = true;
                DataTable dt = dbFunctions.getTable("pr_fetch_total_stock_Warehouse'" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "'");
                dgv1.Form_Name = this.Name;
                dgv1.DataSource = dt;
                dgv1._Zerovisible = false;
                dgv1.Title = "Ware House Stock";
                dgv1.Left_Data.Rows.Clear();

            }
            catch { }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //display();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //dgv1.DataSource = null;
            //dgv1.flag = true;
            //DataTable dt = dbFunctions.getTable("pr_get_Formattion_Outward_Stock  '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "'");
            //dgv1.Form_Name = this.Name;
            //dgv1.DataSource = dt;
            //dgv1._Zerovisible = false;
            //dgv1.Title = "Ware House Stock";
            //dgv1.Left_Data.Rows.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgv1.DataSource = null;
            dgv1.flag = true;
            DataTable dt = dbFunctions.getTable("pr_fetch_total_stock_Warehouse");
            dgv1.Form_Name = this.Name;
            dgv1.DataSource = dt;
            dgv1._Zerovisible = false;
            dgv1.Title = "Ware House Stock";
            dgv1.Left_Data.Rows.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //dgv1.DataSource = null;
            //dgv1.flag = true;
            //DataTable dt = dbFunctions.getTable("pr_fetch_total_Rack_stock");
            //dgv1.Form_Name = this.Name;
            //dgv1.DataSource = dt;
            //dgv1._Zerovisible = false;
            //dgv1.Title = "Ware House Stock";
            //dgv1.Left_Data.Rows.Clear();
        }

        private void Warehouse_Stock_Load(object sender, EventArgs e)
        {
            display();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 2)
            {
                getdata();
                panel9.Visible = true;

            }
        }

        private void getdata()
        {
            DataTable dt = dbFunctions.getTable("pr_fetch_total_details '" + dgv1.SelectedRows[0].Cells["Rack No"].Value + "'");
            dataGridView3.DataSource = dt;
        }
    }
}
