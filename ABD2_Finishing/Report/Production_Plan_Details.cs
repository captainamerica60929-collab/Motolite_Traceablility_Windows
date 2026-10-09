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
    public partial class Production_Plan_Details : Form
    {
        public Production_Plan_Details()
        {
            InitializeComponent();
        }

        private void Production_Plan_Details_Load(object sender, EventArgs e)
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
                DataTable dt = dbFunctions.getTable("pr_get_Production_PlanDetails  '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "'");
                dgv1.Form_Name = this.Name;
                dgv1.DataSource = dt;
                dgv1._Zerovisible = false;
                dgv1.Title = "Production Plan Details";
                dgv1.Left_Data.Rows.Clear();

            }
            catch { }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
