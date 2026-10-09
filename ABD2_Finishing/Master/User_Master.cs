using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Maintanence_Printing_Tool;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace ABD2_Finishing.Master
{

    public partial class User_Master : Form
    {
        public string arrow = "Up";
        public int Distance = 230;
        public string ID = "";
        public string ErrorMessage = "";
        public User_Master()
        {
            InitializeComponent();
            dbFunctions.DGVStyle(dataGridView1);
        }




        private void ItemMaster_Shown(object sender, EventArgs e)
        {
           // display();
            splitContainer1.SplitterDistance = Distance;
        }


        private void ArrowButton_Click(object sender, EventArgs e)
        {
            if (arrow.ToString().Equals("Up"))
            {
                splitContainer1.SplitterDistance = 25;
                arrow = "Down";
               // ArrowButton.Image = GenuineHR.Properties.Resources.Down;

            }
            else
            {
                splitContainer1.SplitterDistance = Distance;
                arrow = "Up";
               // ArrowButton.Image = GenuineHR.Properties.Resources.Up;
            }

        }

        private void ItemMaster_Load(object sender, EventArgs e)
        {
            display();
            get_Rights();
            get_Company();
        }


        public void get_Rights()
        {
            DataTable dt = dbFunctions.getTable("Pr_Load_RGV_vDesciption   'User_Role'");
            UM_Rights.DataSource = dt;
            UM_Rights.DisplayMember = "RGV_vDesciption";
            UM_Rights.ValueMember = "RGV_iID";
            UM_Rights.SelectedIndex = -1;

        }

        public void get_Company()
        {
            DataTable dt = dbFunctions.getTable("pr_get_Company_All");
            UM_Company.DataSource = dt;
            UM_Company.DisplayMember = "CM_Name";
            UM_Company.ValueMember = "CM_ID";
            UM_Company.SelectedIndex = -1;

        }


        private void btnDisplay_Click(object sender, EventArgs e)
        {
            display();
        }

        public static string DecryptThis(string ToDecrypt, string Keys)
        {
            byte[] IV = new byte[8] { 210, 1, 25, 101, 0, 76, 173, 59 };
            byte[] buffer = Convert.FromBase64String(ToDecrypt);
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
            des.Key = MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Keys));
            des.IV = IV;
            return Encoding.ASCII.GetString(
            des.CreateDecryptor().TransformFinalBlock(
            buffer,
            0,
            buffer.Length
            )
            );

        }


        public static string EncryptThis(string ToEncrypt, string Keys)
        {
            byte[] IV = new byte[8] { 210, 1, 25, 101, 0, 76, 173, 59 };
            byte[] buffer = Encoding.ASCII.GetBytes(ToEncrypt);
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
            des.Key = MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Keys));
            des.IV = IV;
            return Convert.ToBase64String(
            des.CreateEncryptor().TransformFinalBlock(
            buffer,
            0,
            buffer.Length
            )
            );
        }
        public string  Password="";
        private void btnSave_Click(object sender, EventArgs e)
        {
                if (Validate())
                {
                    MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void button8_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dbFunctions.ExportExcel(dataGridView1);
            Cursor.Current = Cursors.Default;
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
                com.CommandText = "Pr_Insert_User_Master";
                com.Parameters.Add("@UM_Full_Name", SqlDbType.VarChar).Value = UM_Full_Name.Text.ToString();
                com.Parameters.Add("@UM_User_Name", SqlDbType.VarChar).Value = UM_User_Name.Text.ToString();
                com.Parameters.Add("@UM_Password", SqlDbType.VarChar).Value = UM_Password.Text.ToString();
                com.Parameters.Add("@UM_Rights", SqlDbType.VarChar).Value = UM_Rights.SelectedValue.ToString();
                com.Parameters.Add("@UM_Company", SqlDbType.VarChar).Value = UM_Company.SelectedValue.ToString();
                com.Parameters.Add("@UM_Created_By", SqlDbType.VarChar).Value = Mobile_No.Text;
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
                com.CommandText = "Pr_Update_User_Master";
                com.Parameters.Add("@UM_ID", SqlDbType.VarChar).Value = ID;
                com.Parameters.Add("@UM_Full_Name", SqlDbType.VarChar).Value = UM_Full_Name.Text.ToString();
                com.Parameters.Add("@UM_User_Name", SqlDbType.VarChar).Value = UM_User_Name.Text.ToString();
                com.Parameters.Add("@UM_Password", SqlDbType.VarChar).Value = UM_Password.Text.ToString();
                com.Parameters.Add("@UM_Rights", SqlDbType.VarChar).Value = UM_Rights.SelectedValue.ToString();
                com.Parameters.Add("@UM_Company", SqlDbType.VarChar).Value = UM_Company.SelectedValue.ToString();
                com.Parameters.Add("@UM_Created_By", SqlDbType.VarChar).Value = Mobile_No.Text;
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
                DataTable dt = dbFunctions.getTable("Pr_Fetch_User_Master_ByID  " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                ID = dt.Rows[0]["UM_ID"].ToString();
                UM_Full_Name.Text = dt.Rows[0]["UM_Full_Name"].ToString();
                UM_User_Name.Text = dt.Rows[0]["UM_User_Name"].ToString();
                UM_Password.Text = dt.Rows[0]["UM_Password"].ToString();
                UM_Rights.SelectedValue = dt.Rows[0]["UM_Rights"].ToString();
                UM_Company.SelectedValue = dt.Rows[0]["UM_Company"].ToString();
                Mobile_No.Text = dt.Rows[0]["UM_Created_By"].ToString();
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
                    DataTable dt = dbFunctions.getTable("Pr_Delete_User_Master " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
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
            DataTable dt = dbFunctions.getTable("Pr_Fetch_User_Master_Details  "+dbFunctions.Company_ID);
            dataGridView1.DataSource = dt;
            dbFunctions.DGVStyle(dataGridView1);
        }


        public void Clear()
        {
            UM_Full_Name.Text = "";
            UM_User_Name.Text = "";
            UM_Password.Text = "";
            UM_Rights.SelectedIndex = -1;
            UM_Company.SelectedIndex = -1;
            Mobile_No.Text = "";
            btnsave.Text = "&Save    ";
        }


        public bool Validate()
        {
            return false;
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

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}