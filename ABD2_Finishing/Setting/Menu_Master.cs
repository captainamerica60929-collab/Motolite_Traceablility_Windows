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
    public partial class Menu_Master : Form
    {
        public Menu_Master()
        {
            InitializeComponent();
        }

        public string ID = "0";
        public string ErrorMessage = "";

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
                com.CommandText = "Pr_Insert_S_Menu_Master";
                com.Parameters.Add("@MM_Module", SqlDbType.VarChar).Value = MM_Module.Text.ToString();
                com.Parameters.Add("@MM_Menu_Name", SqlDbType.VarChar).Value = MM_Menu_Name.Text.ToString();
                com.Parameters.Add("@MM_Display_Name", SqlDbType.VarChar).Value = MM_Display_Name.Text.ToString();
                com.Parameters.Add("@MM_Menu_Order", SqlDbType.VarChar).Value = MM_Menu_Order.Text.ToString();
                com.Parameters.Add("@MM_MenuLevel", SqlDbType.VarChar).Value = MM_MenuLevel.Text.ToString();
                com.Parameters.Add("@MM_ParentID", SqlDbType.VarChar).Value = MM_ParentID.SelectedValue.ToString();
                com.Parameters.Add("@MM_Icon", SqlDbType.VarChar).Value = MM_Icon.Text.ToString();
                com.Parameters.Add("@MM_Createdby", SqlDbType.VarChar).Value = dbFunctions.username;
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
                com.CommandText = "Pr_Update_S_Menu_Master";
                com.Parameters.Add("@MM_ID", SqlDbType.VarChar).Value = ID;
                com.Parameters.Add("@MM_Module", SqlDbType.VarChar).Value = MM_Module.Text.ToString();
                com.Parameters.Add("@MM_Menu_Name", SqlDbType.VarChar).Value = MM_Menu_Name.Text.ToString();
                com.Parameters.Add("@MM_Display_Name", SqlDbType.VarChar).Value = MM_Display_Name.Text.ToString();
                com.Parameters.Add("@MM_Menu_Order", SqlDbType.VarChar).Value = MM_Menu_Order.Text.ToString();
                com.Parameters.Add("@MM_MenuLevel", SqlDbType.VarChar).Value = MM_MenuLevel.Text.ToString();
                com.Parameters.Add("@MM_ParentID", SqlDbType.VarChar).Value = MM_ParentID.SelectedValue.ToString();
                com.Parameters.Add("@MM_Icon", SqlDbType.VarChar).Value = MM_Icon.Text.ToString();
                com.Parameters.Add("@MM_Createdby", SqlDbType.VarChar).Value = dbFunctions.username;
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
                DataTable dt = dbFunctions.getTable("Pr_Fetch_S_Menu_Master_ByID  " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                ID = dt.Rows[0]["MM_ID"].ToString();
                MM_Module.Text = dt.Rows[0]["MM_Module"].ToString();
                MM_Menu_Name.Text = dt.Rows[0]["MM_Menu_Name"].ToString();
                MM_Display_Name.Text = dt.Rows[0]["MM_Display_Name"].ToString();
                MM_Menu_Order.Text = dt.Rows[0]["MM_Menu_Order"].ToString();
                MM_MenuLevel.Text = dt.Rows[0]["MM_MenuLevel"].ToString();
                MM_ParentID.SelectedValue = dt.Rows[0]["MM_ParentID"].ToString();
                MM_Icon.Text = dt.Rows[0]["MM_Icon"].ToString();
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
                    DataTable dt = dbFunctions.getTable("Pr_Delete_S_Menu_Master " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
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
            DataTable dt = dbFunctions.getTable("Pr_Fetch_S_Menu_Master_Details");
            dataGridView1.DataSource = dt;
            dbFunctions.DGVStyle(dataGridView1);
        }


        public void Clear()
        {
            MM_Module.Text = "";
            MM_Menu_Name.Text = "";
            MM_Display_Name.Text = "";
            MM_Menu_Order.Text = "";
            MM_MenuLevel.Text = "";
            MM_ParentID.Text = "";
            MM_Icon.Text = "";
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

        private void Menu_Master_Load(object sender, EventArgs e)
        {
            display();
            get_Module();
        }

        public void get_Module()
        {
            DataTable dt = dbFunctions.getTable("pr_get_Module");
            MM_Module.DataSource = dt;
            MM_Module.DisplayMember = "MM_Module";
            MM_Module.ValueMember = "MM_Module";
            MM_Module.SelectedIndex = -1;

        }

        private void MM_Module_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Parent_Menu();


        }

        public void Load_Parent_Menu()
        {
            try
            {
                DataTable dd = dbFunctions.getTable("pr_get_Menu_Master_by_Module '" + MM_Module.Text + "'," + MM_MenuLevel.Text);
                MM_ParentID.DataSource = dd;
                MM_ParentID.DisplayMember = "MM_Display_Name";
                MM_ParentID.ValueMember = "MM_ID";
                MM_ParentID.SelectedIndex = -1;
            }
            catch { }
        }

        private void MM_MenuLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Parent_Menu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ArrowButton_Click(object sender, EventArgs e)
        {

        }
    }
}
