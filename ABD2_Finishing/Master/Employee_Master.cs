using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using  ABD2_Finishing;

namespace ABD2_Finishing.Master
{
    public partial class Employee_Master : Form
    {
        public Employee_Master()
        {
            InitializeComponent();
        }


        public string ErrorMessage = "";
        public string ID = "";

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
                com.CommandText = "Pr_Insert_Employee_Master";
                com.Parameters.Add("@EM_vCode", SqlDbType.VarChar).Value = EM_vCode.Text.ToString();
                com.Parameters.Add("@EM_vName", SqlDbType.VarChar).Value = EM_vName.Text.ToString();
                com.Parameters.Add("@EM_vDepartment", SqlDbType.VarChar).Value = EM_vDepartment.Text.ToString();
                com.Parameters.Add("@EM_vDesignation", SqlDbType.VarChar).Value = EM_vDesignation.Text.ToString();
                com.Parameters.Add("@EM_vCreated_By", SqlDbType.VarChar).Value = dbFunctions.username;
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
                com.CommandText = "Pr_Update_Employee_Master";
                com.Parameters.Add("@EM_iID", SqlDbType.VarChar).Value = ID;
                com.Parameters.Add("@EM_vCode", SqlDbType.VarChar).Value = EM_vCode.Text.ToString();
                com.Parameters.Add("@EM_vName", SqlDbType.VarChar).Value = EM_vName.Text.ToString();
                com.Parameters.Add("@EM_vDepartment", SqlDbType.VarChar).Value = EM_vDepartment.Text.ToString();
                com.Parameters.Add("@EM_vDesignation", SqlDbType.VarChar).Value = EM_vDesignation.Text.ToString();
                com.Parameters.Add("@EM_vCreated_By", SqlDbType.VarChar).Value = dbFunctions.username;
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
                DataTable dt = dbFunctions.getTable("Pr_Fetch_Employee_Master_ByID  " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                ID = dt.Rows[0]["EM_iID"].ToString();
                EM_vCode.Text = dt.Rows[0]["EM_vCode"].ToString();
                EM_vName.Text = dt.Rows[0]["EM_vName"].ToString();
                EM_vDepartment.Text = dt.Rows[0]["EM_vDepartment"].ToString();
                EM_vDesignation.Text = dt.Rows[0]["EM_vDesignation"].ToString();
             //  EM_vCreated_By.Text = dt.Rows[0]["EM_vCreated_By"].ToString();
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
                    DataTable dt = dbFunctions.getTable("Pr_Delete_Employee_Master " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
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
            DataTable dt = dbFunctions.getTable("Pr_Fetch_Employee_Master_Details");
            dataGridView1.DataSource = dt;
            dbFunctions.DGVStyle(dataGridView1);
        }


        public void Clear()
        {
            EM_vCode.Text = "";
            EM_vName.Text = "";
            EM_vDepartment.Text = "";
            EM_vDesignation.Text = "";
           // EM_vCreated_By.Text = "";
            btnsave.Text = "&Save    ";
        }


        public bool Validate()
        {
            return false;
        }


        private void Block_Master_Load(object sender, EventArgs e)
        {
            get_Load_Designation();
            get_Load_Department();
            display();
        }


        void get_Load_Department()
        {
            DataTable dt = dbFunctions.getTable("pr_fetch_ReferenceGroup 'Department'");
            EM_vDepartment.DataSource = dt;
            EM_vDepartment.DisplayMember = "RGV_vDesciption";
            EM_vDepartment.ValueMember = "RGV_vDesciption";
            EM_vDepartment.SelectedIndex = -1;
        }

        void get_Load_Designation()
        {
            DataTable dt = dbFunctions.getTable("pr_fetch_ReferenceGroup 'Designation'");
            EM_vDesignation.DataSource = dt;
            EM_vDesignation.DisplayMember = "RGV_vDesciption";
            EM_vDesignation.ValueMember = "RGV_vDesciption";
            EM_vDesignation.SelectedIndex = -1;
        }



        private void ArrowButton_Click(object sender, EventArgs e)
        {
            if (arrow.ToString().Equals("Up"))
            {
                splitContainer1.SplitterDistance = 25;
                arrow = "Down";
                ArrowButton.Image = ABD2_Finishing.Properties.Resources.Down;

            }
            else
            {
                splitContainer1.SplitterDistance = Distance;
                arrow = "Up";
                ArrowButton.Image = ABD2_Finishing.Properties.Resources.Up;
            }

        }

        public string arrow = "Up";
        public int Distance = 254;

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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxX1.Text))
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Code] like '%{0}%' or [Block_Name] like '%{0}%' or [District] like '%{0}%'  or [Incharge_Name] like '%{0}%'", textBoxX1.Text);
                }
            }
            catch (Exception ex)
            {

            }

        }

    }
}
