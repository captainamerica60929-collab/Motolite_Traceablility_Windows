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
    public partial class Item_Master : Form
    {
        public Item_Master()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        public string arrow = "Up";
        public int Distance = 254;
        private void vinLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
        public string ErrorMessage = "";
        public string ID = "0";
       
        private void Item_Master_Load(object sender, EventArgs e)
        {
            display();
            //IM_Type.Focus();
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
                com.CommandText = "Pr_Insert_Product_Master";
                com.Parameters.Add("@PM_Barcode", SqlDbType.VarChar).Value = "";
                com.Parameters.Add("@PM_Model_Name", SqlDbType.VarChar).Value = PM_Model_Name.Text.ToString();
                com.Parameters.Add("@PM_Serial_Nos", SqlDbType.VarChar).Value = PM_Serial_Nos.Text.ToString();
                com.Parameters.Add("@PM_Date_of_Manufacture", SqlDbType.VarChar).Value = PM_Date_of_Manufacture.Value.ToString("dd-MMM-yyyy");
                com.Parameters.Add("@PM_Tested_By", SqlDbType.VarChar).Value = PM_Tested_By.Text.ToString();
                com.Parameters.Add("@PM_Factory_Name", SqlDbType.VarChar).Value = PM_Factory_Name.Text.ToString();
                com.Parameters.Add("@PM_Warranty_Expiry", SqlDbType.VarChar).Value = PM_Warranty_Expiry.Value.ToString("dd-MMM-yyyy");
                com.Parameters.Add("@PM_User_Hours", SqlDbType.VarChar).Value = PM_User_Hours.Text.ToString();
                com.Parameters.Add("@PM_Working_Status", SqlDbType.VarChar).Value = PM_Working_Status.Text.ToString();
                com.Parameters.Add("@PM_Service_Status", SqlDbType.VarChar).Value = PM_Service_Status.Text.ToString();
                com.Parameters.Add("@PM_Invoiced_to", SqlDbType.VarChar).Value = PM_Invoiced_to.Text.ToString();
                com.Parameters.Add("@PM_Date_of_Invoice", SqlDbType.VarChar).Value = PM_Date_of_Invoice.Text.ToString();
                com.Parameters.Add("@PM_Invoice_Number", SqlDbType.VarChar).Value = PM_Invoice_Number.Text.ToString();
                com.Parameters.Add("@PM_Date_of_Despatch", SqlDbType.VarChar).Value = PM_Date_of_Despatch.Value.ToString("dd-MMM-yyyy");
                com.Parameters.Add("@PM_Date_of_Installation", SqlDbType.VarChar).Value = PM_Date_of_Installation.Value.ToString("dd-MMM-yyyy");
                com.Parameters.Add("@PM_Installed_Hopsital_Name", SqlDbType.VarChar).Value = PM_Installed_Hopsital_Name.Text.ToString();
                com.Parameters.Add("@PM_Installed_Place", SqlDbType.VarChar).Value = PM_Installed_Place.Text.ToString();
                com.Parameters.Add("@PM_Last_Hospital_Scanned", SqlDbType.VarChar).Value = PM_Last_Hospital_Scanned.Text.ToString();
                com.Parameters.Add("@PM_Last_Dept_scanned", SqlDbType.VarChar).Value = PM_Last_Dept_scanned.Text.ToString();
                com.Parameters.Add("@PM_Last_Scanned_Date", SqlDbType.VarChar).Value = PM_Last_Scanned_Date.Value.ToString("dd-MMM-yyyy");
                com.Parameters.Add("@PM_Created_by", SqlDbType.VarChar).Value = dbFunctions.username;
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
                com.CommandText = "Pr_Update_Product_Master";
                com.Parameters.Add("@PM_ID", SqlDbType.VarChar).Value = ID;
                com.Parameters.Add("@PM_Barcode", SqlDbType.VarChar).Value = "";
                com.Parameters.Add("@PM_Model_Name", SqlDbType.VarChar).Value = PM_Model_Name.Text.ToString();
                com.Parameters.Add("@PM_Serial_Nos", SqlDbType.VarChar).Value = PM_Serial_Nos.Text.ToString();
                com.Parameters.Add("@PM_Date_of_Manufacture", SqlDbType.VarChar).Value = PM_Date_of_Manufacture.Value.ToString("dd-MMM-yyyy");
                com.Parameters.Add("@PM_Tested_By", SqlDbType.VarChar).Value = PM_Tested_By.Text.ToString();
                com.Parameters.Add("@PM_Factory_Name", SqlDbType.VarChar).Value = PM_Factory_Name.Text.ToString();
                com.Parameters.Add("@PM_Warranty_Expiry", SqlDbType.VarChar).Value = PM_Warranty_Expiry.Value.ToString("dd-MMM-yyyy");
                com.Parameters.Add("@PM_User_Hours", SqlDbType.VarChar).Value = PM_User_Hours.Text.ToString();
                com.Parameters.Add("@PM_Working_Status", SqlDbType.VarChar).Value = PM_Working_Status.Text.ToString();
                com.Parameters.Add("@PM_Service_Status", SqlDbType.VarChar).Value = PM_Service_Status.Text.ToString();
                com.Parameters.Add("@PM_Invoiced_to", SqlDbType.VarChar).Value = PM_Invoiced_to.Text.ToString();
                com.Parameters.Add("@PM_Date_of_Invoice", SqlDbType.VarChar).Value = PM_Date_of_Invoice.Text.ToString();
                com.Parameters.Add("@PM_Invoice_Number", SqlDbType.VarChar).Value = PM_Invoice_Number.Text.ToString();
                com.Parameters.Add("@PM_Date_of_Despatch", SqlDbType.VarChar).Value = PM_Date_of_Despatch.Value.ToString("dd-MMM-yyyy");
                com.Parameters.Add("@PM_Date_of_Installation", SqlDbType.VarChar).Value = PM_Date_of_Installation.Value.ToString("dd-MMM-yyyy");
                com.Parameters.Add("@PM_Installed_Hopsital_Name", SqlDbType.VarChar).Value = PM_Installed_Hopsital_Name.Text.ToString();
                com.Parameters.Add("@PM_Installed_Place", SqlDbType.VarChar).Value = PM_Installed_Place.Text.ToString();
                com.Parameters.Add("@PM_Last_Hospital_Scanned", SqlDbType.VarChar).Value = PM_Last_Hospital_Scanned.Text.ToString();
                com.Parameters.Add("@PM_Last_Dept_scanned", SqlDbType.VarChar).Value = PM_Last_Dept_scanned.Text.ToString();
                com.Parameters.Add("@PM_Last_Scanned_Date", SqlDbType.VarChar).Value = PM_Last_Scanned_Date.Value.ToString("dd-MMM-yyyy");
                com.Parameters.Add("@PM_Created_by", SqlDbType.VarChar).Value = dbFunctions.username;
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
                DataTable dt = dbFunctions.getTable("Pr_Fetch_Product_Master_ByID  " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                ID = dt.Rows[0]["PM_ID"].ToString();
                
                PM_Model_Name.Text = dt.Rows[0]["PM_Model_Name"].ToString();
                PM_Serial_Nos.Text = dt.Rows[0]["PM_Serial_Nos"].ToString();
                PM_Date_of_Manufacture.Text = dt.Rows[0]["PM_Date_of_Manufacture"].ToString();
                PM_Tested_By.Text = dt.Rows[0]["PM_Tested_By"].ToString();
                PM_Factory_Name.Text = dt.Rows[0]["PM_Factory_Name"].ToString();
                PM_Warranty_Expiry.Text = dt.Rows[0]["PM_Warranty_Expiry"].ToString();
                PM_User_Hours.Text = dt.Rows[0]["PM_User_Hours"].ToString();
                PM_Working_Status.Text = dt.Rows[0]["PM_Working_Status"].ToString();
                PM_Service_Status.Text = dt.Rows[0]["PM_Service_Status"].ToString();
                PM_Invoiced_to.Text = dt.Rows[0]["PM_Invoiced_to"].ToString();
                PM_Date_of_Invoice.Text = dt.Rows[0]["PM_Date_of_Invoice"].ToString();
                PM_Invoice_Number.Text = dt.Rows[0]["PM_Invoice_Number"].ToString();
                PM_Date_of_Despatch.Text = dt.Rows[0]["PM_Date_of_Despatch"].ToString();
                PM_Date_of_Installation.Text = dt.Rows[0]["PM_Date_of_Installation"].ToString();
                PM_Installed_Hopsital_Name.Text = dt.Rows[0]["PM_Installed_Hopsital_Name"].ToString();
                PM_Installed_Place.Text = dt.Rows[0]["PM_Installed_Place"].ToString();
                PM_Last_Hospital_Scanned.Text = dt.Rows[0]["PM_Last_Hospital_Scanned"].ToString();
                PM_Last_Dept_scanned.Text = dt.Rows[0]["PM_Last_Dept_scanned"].ToString();
                PM_Last_Scanned_Date.Text = dt.Rows[0]["PM_Last_Scanned_Date"].ToString();
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
                    DataTable dt = dbFunctions.getTable("Pr_Delete_Product_Master " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
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
            DataTable dt = dbFunctions.getTable("Pr_Fetch_Product_Master_Details");
            dataGridView1.DataSource = dt;
            dbFunctions.DGVStyle(dataGridView1);
        }


        public void Clear()
        {
            PM_Model_Name.Text = "";
            PM_Serial_Nos.Text = "";
            PM_Date_of_Manufacture.Text = "";
            PM_Tested_By.Text = "";
            PM_Factory_Name.Text = "";
            PM_Warranty_Expiry.Text = "";
            PM_User_Hours.Text = "";
            PM_Working_Status.Text = "";
            PM_Service_Status.Text = "";
            PM_Invoiced_to.Text = "";
            PM_Date_of_Invoice.Text = "";
            PM_Invoice_Number.Text = "";
            PM_Date_of_Despatch.Text = "";
            PM_Date_of_Installation.Text = "";
            PM_Installed_Hopsital_Name.Text = "";
            PM_Installed_Place.Text = "";
            PM_Last_Hospital_Scanned.Text = "";
            PM_Last_Dept_scanned.Text = "";
            PM_Last_Scanned_Date.Text = "";
            btnsave.Text = "&Save    ";
            PM_Model_Name.Focus();
        }


        public bool Validate()
        {
            return false;
        }

       

        private void button8_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dbFunctions.ExportExcel(dataGridView1);
            Cursor.Current = Cursors.Default;
        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxX1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxX1.Text))
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Part_No] like '%{0}%' or [PartName] like '%{0}%' or [Type] like '%{0}%'  or [Store] like '%{0}%'", textBoxX1.Text);
                }
            }
            catch (Exception ex)
            {

            }

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
                PM_Model_Name.Focus();
            }
            else
            {
                insert();
                PM_Model_Name.Focus();
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

        private void IM_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            display();
        }

        private void IM_PartName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(PM_Tested_By.Text))
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(" [PartName] like '%{0}%' ", PM_Tested_By.Text);
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void IM_Model_TextChanged(object sender, EventArgs e)
        {

        }

        private void IM_ReorderLevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click_3(object sender, EventArgs e)
        {
            this.Close();
        }

       
       

    }
}
