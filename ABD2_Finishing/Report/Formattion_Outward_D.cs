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
    public partial class Formattion_Outward_D : Form
    {
        public Formattion_Outward_D()
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

                dgv1.DataSource = null;
                dgv1.flag = true;
                DataTable dt = dbFunctions.getTable("pr_get_Formattion_Outward_StockD  '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "'");
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
            display();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dgv1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are You Sure Want to Delete Press YES", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DataTable dt = dbFunctions.getTable("delete from Formation_Stock where Barcode='" + dgv1.SelectedRows[0].Cells["Barcode"].Value.ToString() + "'");
                        display();
                       
                    }
                    catch { }
                }
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
