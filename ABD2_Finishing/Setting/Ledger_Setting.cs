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
    public partial class Ledger_Setting : Form
    {
        public Ledger_Setting()
        {
            InitializeComponent();
        }

        public string arrow = "Up";
        public int Distance = 380;
        public string ID = "";
        string ErrorMessage = "";

        private void Ledger_Setting_Load(object sender, EventArgs e)
        {
            get_Ledger_Type();
            display();
            LS_Type.Focus();


        }

        public void get_Ledger_Type()
        {
            DataTable dt = dbFunctions.getTable("Pr_Load_RGV_vDesciption   'Ledger_Type'");
            LS_Type.DataSource = dt;
            LS_Type.DisplayMember = "RGV_vDesciption";
            LS_Type.ValueMember = "RGV_vCode";
            LS_Type.SelectedIndex = -1;
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
                com.CommandText = "Pr_Insert_Ledger_Setting";
                com.Parameters.Add("@LS_Type", SqlDbType.VarChar).Value = LS_Type.Text.ToString();
                com.Parameters.Add("@LS_Code", SqlDbType.VarChar).Value = LS_Code.Text.ToString();
                com.Parameters.Add("@LS_Ledger_ID", SqlDbType.VarChar).Value = LS_Ledger_ID.SelectedValue.ToString();
                com.Parameters.Add("@LS_Company", SqlDbType.VarChar).Value = dbFunctions.Company_ID;
                com.Parameters.Add("@LS_Created_by", SqlDbType.VarChar).Value = dbFunctions.username;
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
                com.CommandText = "Pr_Update_Ledger_Setting";
                com.Parameters.Add("@LS_ID", SqlDbType.VarChar).Value = ID;
                com.Parameters.Add("@LS_Type", SqlDbType.VarChar).Value = LS_Type.Text.ToString();
                com.Parameters.Add("@LS_Code", SqlDbType.VarChar).Value = LS_Code.Text.ToString();
                com.Parameters.Add("@LS_Ledger_ID", SqlDbType.VarChar).Value = LS_Ledger_ID.SelectedValue.ToString();
                com.Parameters.Add("@LS_Company", SqlDbType.VarChar).Value = dbFunctions.Company_ID;
                com.Parameters.Add("@LS_Created_by", SqlDbType.VarChar).Value = dbFunctions.username;
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
                DataTable dt = dbFunctions.getTable("Pr_Fetch_Ledger_Setting_ByID  " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                ID = dt.Rows[0]["LS_ID"].ToString();
                LS_Type.Text = dt.Rows[0]["LS_Type"].ToString();
                LS_Code.Text = dt.Rows[0]["LS_Code"].ToString();
                LS_Ledger_ID.SelectedValue = dt.Rows[0]["LS_Ledger_ID"].ToString();
              
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
                    DataTable dt = dbFunctions.getTable("Pr_Delete_Ledger_Setting " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
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
            DataTable dt = dbFunctions.getTable("Pr_Fetch_Ledger_Setting_Details");
            dataGridView1.DataSource = dt;
            dbFunctions.DGVStyle(dataGridView1);
        }


        public void Clear()
        {
            LS_Type.Text = "";
            LS_Code.Text = "";
            LS_Ledger_ID.Text = "";
           
            btnsave.Text = "&Save    ";
            LS_Type.Focus();
        }


        public bool Validate()
        {
            if ((string.IsNullOrEmpty(LS_Type.Text.Trim())))
            {
                ErrorMessage = "Type Should Not be Empty";
                LS_Type.Focus();
                return true;
            }
            if ((string.IsNullOrEmpty(LS_Code.Text.Trim())))
            {
                ErrorMessage = "Code Should Not be Empty";
                LS_Code.Focus();
                return true;
            }
            if ((string.IsNullOrEmpty(LS_Ledger_ID.Text.Trim())))
            {
                ErrorMessage = "Ledger_ID Should Not be Empty";
                LS_Ledger_ID.Focus();
                return true;
            }
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

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            display();
        }

        private void LS_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = dbFunctions.getTable("pr_get_Ledger_by_Type  '" + LS_Type.SelectedValue.ToString() + "'");
                LS_Ledger_ID.DataSource = dt;
                LS_Ledger_ID.DisplayMember = "LM_Ledger_Name";
                LS_Ledger_ID.ValueMember = "LedgerID";
                LS_Ledger_ID.SelectedIndex = -1;
            }
            catch { }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
