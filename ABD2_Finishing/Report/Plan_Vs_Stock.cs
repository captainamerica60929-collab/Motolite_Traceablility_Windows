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
    public partial class Plan_Vs_Stock : Form
    {
        public Plan_Vs_Stock()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {


                DataTable dt = dbFunctions.getTable("select  Part_No, Plan_Qty From Production_Plan where  convert(Varchar,Plan_Date,112)= '" + From_Date.Value.ToString("yyyyMMdd") + "'");
                dataGridView1.DataSource = dt;
                dbFunctions.DGVStyle(dataGridView1);
                dataGridView1.Columns[0].Visible = true;

            }
            catch { }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv1.DataSource = null;
            dgv1.flag = true;
            DataTable dt = dbFunctions.getTable("pr_get_Formation_FIFO '" +dataGridView1.SelectedRows[0].Cells[0].Value.ToString()+ "'");
            
            dgv1.Form_Name = this.Name;
            dgv1.DataSource = dt;
            dgv1._Zerovisible = false;
            dgv1.Title = "Formattion Inward Details";
            dgv1.Left_Data.Rows.Clear();

        }
    }
}
