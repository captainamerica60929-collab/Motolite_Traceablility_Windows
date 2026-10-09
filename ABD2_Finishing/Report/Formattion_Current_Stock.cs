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
    public partial class Formattion_Current_Stock : Form
    {
        public Formattion_Current_Stock()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formattion_Current_Stock_Load(object sender, EventArgs e)
        {
            //DataTable dt = dbFunctions.getTable("pr_get_Formation_Stock");
            //dgv1.DataSource = dt;
            //dbFunctions.DGVStyle(dgv1);

            try
            {

                dgv1.DataSource = null;
                dgv1.flag = true;
                DataTable dt = dbFunctions.getTable("pr_get_Formation_Stock  ");
                dgv1.Form_Name = this.Name;
                dgv1.DataSource = dt;
                dgv1._Zerovisible = false;
                dgv1.Title = "Formattion Details";
                dgv1.Left_Data.Rows.Clear();

            }
            catch { }
        }
    }
}
