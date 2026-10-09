using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ABD2_Finishing.Master
{
    public partial class Rack_Master : Form
    {
        public Rack_Master()
        {
            InitializeComponent();
        }

        public string ErrorMessage = "";
        public string ID = "0";
        

        private void Rack_Master_Load(object sender, EventArgs e)
        {
            display();
        }

        public void insert()
        {
            SqlConnection con = new SqlConnection(dbFunctions.connectionstring);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "Pr_Insert_Rack_Master";
                com.Parameters.Add("@RR_Rack_Name", SqlDbType.VarChar).Value = RR_Rack_Name.Text.ToString();
                com.Parameters.Add("@RR_Rack_Code", SqlDbType.VarChar).Value = RR_Rack_Code.Text.ToString();
                com.Parameters.Add("@RR_Created_by", SqlDbType.VarChar).Value = dbFunctions.username;
                com.ExecuteNonQuery();
                com.Connection.Close();
                MessageBox.Show("Details Saved Successfully ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                display();
            }
            catch (Exception Ex)
            {
                dbFunctions.Logs(Ex.Message, dbFunctions.username);
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Update()
        {
            SqlConnection con = new SqlConnection(dbFunctions.connectionstring);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "Pr_Update_Rack_Master";
                com.Parameters.Add("@RR_ID", SqlDbType.VarChar).Value = ID;
                com.Parameters.Add("@RR_Rack_Name", SqlDbType.VarChar).Value = RR_Rack_Name.Text.ToString();
                com.Parameters.Add("@RR_Rack_Code", SqlDbType.VarChar).Value = RR_Rack_Code.Text.ToString();
                com.Parameters.Add("@RR_Created_by", SqlDbType.VarChar).Value = dbFunctions.username;
                com.ExecuteNonQuery();
                com.Connection.Close();
                MessageBox.Show("Details Updated Successfully ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                display();
            }
            catch (Exception Ex)
            {
                dbFunctions.Logs(Ex.Message, dbFunctions.username);
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Edit()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataTable dt = dbFunctions.getTable("Pr_Fetch_Rack_Master_ByID  " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                ID = dt.Rows[0]["RR_ID"].ToString();
                RR_Rack_Name.Text = dt.Rows[0]["RR_Rack_Name"].ToString();
                RR_Rack_Code.Text = dt.Rows[0]["RR_Rack_Code"].ToString();
             //   RR_Created_by.Text = dt.Rows[0]["RR_Created_by"].ToString();
                btnsave.Text = "&Update";
            }
            else
            {
                MessageBox.Show("Please Select Row", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Delete()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are You Sure Want to Delete Press YES", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    DataTable dt = dbFunctions.getTable("Pr_Delete_Rack_Master " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    MessageBox.Show("Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    display();
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Please Select Row", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void display()
        {
            DataTable dt = dbFunctions.getTable("Pr_Fetch_Rack_Master_Details");
            dataGridView1.DataSource = dt;
            dbFunctions.DGVStyle(dataGridView1);
        }


        public void Clear()
        {
            RR_Rack_Name.Text = "";
            RR_Rack_Code.Text = "";
          
            btnsave.Text = "&Save    ";
        }


        public bool Validate()
        {
            return false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (Validate())
            {

                MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (btnsave.Text.ToString().Equals("&Update"))
            {
                Update();
                //  PM_Model_Name.Focus();
            }
            else
            {
                insert();
                //PM_Model_Name.Focus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

    }
}
