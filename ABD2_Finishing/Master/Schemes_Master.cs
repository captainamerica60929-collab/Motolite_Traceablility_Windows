using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Maintanence_Printing_Tool;
using System.Data.SqlClient;

namespace ABD2_Finishing.Master
{

    public partial class Schemes_Master : Form
    {
        public string arrow = "Up";
        public int Distance = 181;
        public string ID = "";
        string ErrorMessage = "";
        public Schemes_Master()
        {
            InitializeComponent();
            dbFunctions.DGVStyle(dataGridView1);
        }




        private void ItemMaster_Shown(object sender, EventArgs e)
        {
            display();
            splitContainer1.SplitterDistance = Distance;
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
        void Load_Schems()
        {
            try
            {
                DataTable dt = dbFunctions.getTable("pr_fetch_ReferenceGroup_Value '" + "Scheme" + "'");
                RGV_iRG_ID.DataSource = dt;
                RGV_iRG_ID.DisplayMember = "RGV_vDesciption";
                RGV_iRG_ID.ValueMember = "RGV_iID";
                RGV_iRG_ID.SelectedIndex = -1;
            }
            catch { }
        }
        private void ItemMaster_Load(object sender, EventArgs e)
        {
            try
            {
                
                RGV_iRG_ID.Focus();
                Load_RG_vDescription();
                Load_Schems();
                display();
                
            }
            catch { }
        }

        public void Load_RG_vDescription()
        {
            try
            {
                DataTable dt = dbFunctions.getTable("Pr_Load_RG_vDescription");
                RGV_iRG_ID.DataSource = dt;
                RGV_iRG_ID.DisplayMember = "RG_vDescription";
                RGV_iRG_ID.ValueMember = "RG_iID";
                RGV_iRG_ID.SelectedIndex = -1;
            }
            catch { }
        }



        private void btnDisplay_Click(object sender, EventArgs e)
        {
            display();
             
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Validate())
            {
                MessageBox.Show(ErrorMessage,"Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if (btnsave.Text.ToString().Equals("&Update"))
            {
                Update();
                RGV_vDesciption.Focus();
            }
            else
            {
                insert();
                RGV_vDesciption.Focus();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
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
                com.CommandText = "Pr_Insert_ReferenceGroup_Value";
                com.Parameters.Add("@RGV_iRG_ID", SqlDbType.VarChar).Value = RGV_iRG_ID.SelectedValue.ToString();
                com.Parameters.Add("@RGV_vCode", SqlDbType.VarChar).Value = RGV_vCode.Text.ToString();
                com.Parameters.Add("@RGV_vDesciption", SqlDbType.VarChar).Value = RGV_vDesciption.Text.ToString();
                com.Parameters.Add("@RGV_vUpdatedBy", SqlDbType.VarChar).Value = dbFunctions.username;
                com.Parameters.Add("@RGV_Address1", SqlDbType.VarChar).Value = "";
                com.Parameters.Add("@RGV_Address2", SqlDbType.VarChar).Value = "";
                com.Parameters.Add("@RGV_Address3", SqlDbType.VarChar).Value = "";
                com.Parameters.Add("@RGV_Address4", SqlDbType.VarChar).Value = "";
                com.Parameters.Add("@RGV_Address5", SqlDbType.VarChar).Value = "";
                com.Parameters.Add("@RGV_Contact_Person", SqlDbType.VarChar).Value = "";
                com.Parameters.Add("@RGV_Contact_Number", SqlDbType.VarChar).Value = "";

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
                com.CommandText = "Pr_Update_ReferenceGroup_Value";
                com.Parameters.Add("@RGV_iID", SqlDbType.VarChar).Value = ID;
                com.Parameters.Add("@RGV_iRG_ID", SqlDbType.VarChar).Value = RGV_iRG_ID.SelectedValue.ToString();
                com.Parameters.Add("@RGV_vCode", SqlDbType.VarChar).Value = RGV_vCode.Text.ToString();
                com.Parameters.Add("@RGV_vDesciption", SqlDbType.VarChar).Value = RGV_vDesciption.Text.ToString();
                com.Parameters.Add("@RGV_vUpdatedBy", SqlDbType.VarChar).Value = dbFunctions.username;

                com.Parameters.Add("@RGV_Address1", SqlDbType.VarChar).Value = "";
                com.Parameters.Add("@RGV_Address2", SqlDbType.VarChar).Value = "";
                com.Parameters.Add("@RGV_Address3", SqlDbType.VarChar).Value = "";
                com.Parameters.Add("@RGV_Address4", SqlDbType.VarChar).Value = "";
                com.Parameters.Add("@RGV_Address5", SqlDbType.VarChar).Value = "";
                com.Parameters.Add("@RGV_Contact_Person", SqlDbType.VarChar).Value = "";
                com.Parameters.Add("@RGV_Contact_Number", SqlDbType.VarChar).Value = "";

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
                DataTable dt = dbFunctions.getTable("Pr_Fetch_ReferenceGroup_Value_ByID  " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                ID = dt.Rows[0]["RGV_iID"].ToString();
                RGV_iRG_ID.SelectedValue = dt.Rows[0]["RGV_iRG_ID"].ToString();
                RGV_vCode.Text = dt.Rows[0]["RGV_vCode"].ToString();
                RGV_vDesciption.Text = dt.Rows[0]["RGV_vDesciption"].ToString();
               
              //  RGV_vUpdatedBy.Text = dt.Rows[0]["RGV_vUpdatedBy"].ToString();
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
                    DataTable dt = dbFunctions.getTable("Pr_Delete_ReferenceGroup_Value " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
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
            try
            {
                DataTable dt = dbFunctions.getTable("Pr_Fetch_ReferenceGroup_Value_Details_Scheme  " + RGV_iRG_ID.SelectedValue.ToString());
                dataGridView1.DataSource = dt;
                dbFunctions.DGVStyle(dataGridView1);
            }
            catch { }
        }


        public void Clear()
        {
            RGV_iRG_ID.Text = "";
            RGV_vCode.Text = "";
            RGV_vDesciption.Text = "";
           
          //  RGV_vUpdatedBy.Text = "";
            btnsave.Text = "&Save    ";
            Get_RGV_vCode();
        }


        public bool Validate()
        {


            if ((string.IsNullOrEmpty(RGV_iRG_ID.Text.Trim())))
            {
                ErrorMessage = "Type Should Not be Empty";
                RGV_iRG_ID.Focus();
                return true;
            }


            if ((string.IsNullOrEmpty(RGV_vCode.Text.Trim())))
            {
                ErrorMessage = "Code Should Not be Empty";
                RGV_vCode.Focus();
                return true;
            }
            if ((string.IsNullOrEmpty(RGV_vDesciption.Text.Trim())))
            {
                ErrorMessage = "Desciption Should Not be Empty";
                RGV_vDesciption.Focus();
                return true;
            }
            return false;
        }

        private void RGV_iRG_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            display();
            Get_RGV_vCode();
        }

        public void Get_RGV_vCode()
        {
            try
            {
                DataTable dt = dbFunctions.getTable("Pr_Fetch_RGV_vCode_Scheme  '" + RGV_iRG_ID.SelectedValue + "'");
                RGV_vCode.Text = dt.Rows[0][0].ToString();
            }
            catch { }
        }

        private void Reference_Master_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void RGV_vDesciption_KeyDown(object sender, KeyEventArgs e)
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
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Order No] LIKE '%{0}%' OR  [Amount] LIKE '%{0}%'", textBoxX1.Text);
                }
            }
            catch (Exception ex)
            {
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


   }
}