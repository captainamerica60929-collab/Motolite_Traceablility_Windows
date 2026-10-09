using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABD2_Finishing.Report
{
    public partial class Rework_Rejection : Form
    {
        public string ID = "";
        private SqlConnection con;

        public Rework_Rejection()
        {
            InitializeComponent();
        }

        private void Rework_Rejection_Load(object sender, EventArgs e)
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
                DataTable dt = dbFunctions.getTable("pr_fetchRework_details  '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "'");
                dgv1.Form_Name = this.Name;
                dgv1.DataSource = dt;
                dgv1._Zerovisible = false;
                dgv1.Title = "Rework And Rejection Details";
                dgv1.Left_Data.Rows.Clear();

            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
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
                DataTable dt = dbFunctions.getTable("pr_fetchRework_details '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "'");
                dgv1.Form_Name = this.Name;
                dgv1.DataSource = dt;
                dgv1._Zerovisible = false;
                dgv1.Title = "Rework And Rejection Details";
                dgv1.Left_Data.Rows.Clear();

            }
            catch { }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Password.Visible = true;
            Password.Focus();
            string correctPassword = "Admin@123#";
            string input = Password.Text;

            if (input == correctPassword)
            {
                MessageBox.Show("Access granted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Enter Password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (input != correctPassword)
            {
                MessageBox.Show("Enter Correct password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection con = new SqlConnection(dbFunctions.connectionstring);
            try
            {

                { con.Open(); }
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "pr_Update_Rework_Rejection";
                com.Parameters.Add("@Rework_Status", SqlDbType.VarChar).Value = Rework_Status.Text.ToString();
                com.Parameters.Add("@Battery_Sno", SqlDbType.VarChar).Value = Battery_Sno.Text.ToString();
                com.ExecuteNonQuery();
                com.Connection.Close();
               
                MessageBox.Show("Details Updated Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display();


                Rework_Status.Text = "";
                Battery_Sno.Text = "";
                Password.Visible = false;
                Password.Text = "";
            }
            catch (Exception Ex)
            {
                dbFunctions.Logs(Ex.Message, dbFunctions.username);
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Rework_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pr_Fetch_Consolidate_RR_Report

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
                DataTable dt = dbFunctions.getTable("pr_fetch_RR_by_Type  '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "','"+ Rework_Status.Text + "' ");
                dgv1.Form_Name = this.Name;
                dgv1.DataSource = dt;
                dgv1._Zerovisible = false;
                dgv1.Title = "Rework And Rejection Details";
                dgv1.Left_Data.Rows.Clear();

            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
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
                DataTable dt = dbFunctions.getTable("pr_Fetch_Consolidate_RR_Report  '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "'");
                dgv1.Form_Name = this.Name;
                dgv1.DataSource = dt;
                dgv1._Zerovisible = false;
                dgv1.Title = "Rework And Rejection Details";
                dgv1.Left_Data.Rows.Clear();

            }
            catch { }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                getdata();
                panel9.Visible = true;

            }
            //if (e.RowIndex < 0) return;

            //if (dgv1.Columns[e.ColumnIndex].Name == "COUNT")
            //{
            //    getdata();
            //    panel9.Visible = true;
            //}
        }

        private void getdata()
        {
            DataTable dt = dbFunctions.getTable("pr_Fetch_CHARGEING_CELLS '" + dgv1.SelectedRows[0].Cells["Material Code"].Value + "','" + dgv1.SelectedRows[0].Cells["Status"].Value + "','" + dgv1.SelectedRows[0].Cells["Date"].Value + "'");
            dataGridView3.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            dgv1.DataSource = null;
            dgv1.flag = true;
            //DataTable dt = dbFunctions.getTable("pr_fetchOutward_details  '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "'");
            DataTable dt = dbFunctions.getTable("pr_Fetch_Consolidate_RR_Report  '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "'");
            dgv1.Form_Name = this.Name;
            dgv1.DataSource = dt;
            dgv1._Zerovisible = false;
            dgv1.Title = "Rework And Rejection Details";
            dgv1.Left_Data.Rows.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = null;
            dgv1.flag = true;
            //DataTable dt = dbFunctions.getTable("pr_fetchOutward_details  '" + From_Date.Value.ToString("yyyyMMdd") + "','" + To_Date.Value.ToString("yyyyMMdd") + "'");
            DataTable dt = dbFunctions.getTable("rejection_data ");
            dgv1.Form_Name = this.Name;
            dgv1.DataSource = dt;
            dgv1._Zerovisible = false;
            dgv1.Title = "Rework And Rejection Details";
            dgv1.Left_Data.Rows.Clear();
        }
    }
}

    
