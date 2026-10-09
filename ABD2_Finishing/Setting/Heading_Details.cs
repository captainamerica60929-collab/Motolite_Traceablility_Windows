using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ABD2_Finishing.Setting
{
    public partial class Heading_Details : Form
    {

        public string arrow = "Up";
        public int Distance = 380;
        public string ID = "";
        string ErrorMessage = "";

        public Heading_Details()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
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
            }
            else
            {
                insert();

            }
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
                com.CommandText = "Pr_Insert_Heading_Details";
                com.Parameters.Add("@HD_Code", SqlDbType.VarChar).Value = HD_Code.Text.ToString();
                com.Parameters.Add("@HD_Details", SqlDbType.VarChar).Value = HD_Details.Text.ToString();
                com.Parameters.Add("@HD_Company", SqlDbType.VarChar).Value = dbFunctions.Company_ID;
                com.Parameters.Add("@HD_Created_by", SqlDbType.VarChar).Value = dbFunctions.username;
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
                com.CommandText = "Pr_Update_Heading_Details";
                com.Parameters.Add("@HD_ID", SqlDbType.VarChar).Value = ID;
                com.Parameters.Add("@HD_Code", SqlDbType.VarChar).Value = HD_Code.Text.ToString();
                com.Parameters.Add("@HD_Details", SqlDbType.VarChar).Value = HD_Details.Text.ToString();
                com.Parameters.Add("@HD_Company", SqlDbType.VarChar).Value = dbFunctions.Company_ID;
                com.Parameters.Add("@HD_Created_by", SqlDbType.VarChar).Value = dbFunctions.username;
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
                DataTable dt = dbFunctions.getTable("Pr_Fetch_Heading_Details_ByID  " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                ID = dt.Rows[0]["HD_ID"].ToString();
                HD_Code.Text = dt.Rows[0]["HD_Code"].ToString();
                HD_Details.Text = dt.Rows[0]["HD_Details"].ToString();
                
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
                    DataTable dt = dbFunctions.getTable("Pr_Delete_Heading_Details " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
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
            DataTable dt = dbFunctions.getTable("Pr_Fetch_Heading_Details_Details");
            dataGridView1.DataSource = dt;
            dbFunctions.DGVStyle(dataGridView1);
        }


        public void Clear()
        {
            HD_Code.Text = "";
            HD_Details.Text = "";
           
            btnsave.Text = "&Save    ";
        }


        public bool Validate()
        {
            if ((string.IsNullOrEmpty(HD_Code.Text.Trim())))
            {
                ErrorMessage = "Code Should Not be Empty";
                HD_Code.Focus();
                return true;
            }
            if ((string.IsNullOrEmpty(HD_Details.Text.Trim())))
            {
                ErrorMessage = "Details Should Not be Empty";
                HD_Details.Focus();
                return true;
            }
            return false;
        }

        private void Heading_Details_Load(object sender, EventArgs e)
        {
            display();
            HD_Code.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }


    }
}
