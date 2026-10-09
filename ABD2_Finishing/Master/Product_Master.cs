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
    public partial class Product_Master : Form
    {
        public Product_Master()
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
                com.Parameters.Add("@PM_Item_Code", SqlDbType.VarChar).Value = PM_Item_Code.Text.ToString();
                com.Parameters.Add("@PM_Mold", SqlDbType.VarChar).Value = PM_Mold.Text.ToString();
                com.Parameters.Add("@PM_Sector", SqlDbType.VarChar).Value = PM_Sector.Text.ToString();
                com.Parameters.Add("@PM_Description", SqlDbType.VarChar).Value = PM_Description.Text.ToString();
                com.Parameters.Add("@PM_Variant_Code", SqlDbType.VarChar).Value = PM_Variant_Code.Text.ToString();
                com.Parameters.Add("@PM_Skid_Qty", SqlDbType.VarChar).Value = PM_Skid_Qty.Text.ToString();
                com.Parameters.Add("@PM_MOQ_Qty", SqlDbType.VarChar).Value = PM_MOQ_Qty.Text.ToString();
                com.Parameters.Add("@PM_Created_by", SqlDbType.VarChar).Value = dbFunctions.username;
                com.Parameters.Add("@SerialStart", SqlDbType.VarChar).Value = SerialStart.Text.ToString();
                com.Parameters.Add("@SerialEnd", SqlDbType.VarChar).Value = SerialEnd.Text.ToString();
                com.Parameters.Add("@VStart", SqlDbType.VarChar).Value = VStart.Text.ToString();
                com.Parameters.Add("@VEnd", SqlDbType.VarChar).Value = VEnd.Text.ToString();
                com.Parameters.Add("@PM_WarrantyType", SqlDbType.VarChar).Value = type.Text.ToString();
                com.Parameters.Add("@PM_Warrantytime", SqlDbType.VarChar).Value = days.Text.ToString();
                com.Parameters.Add("@compare_code", SqlDbType.VarChar).Value = compare_code.Text.ToString();
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
                com.Parameters.Add("@PM_iID", SqlDbType.VarChar).Value = ID;
                com.Parameters.Add("@PM_Item_Code", SqlDbType.VarChar).Value = PM_Item_Code.Text.ToString();
                com.Parameters.Add("@PM_Mold", SqlDbType.VarChar).Value = PM_Mold.Text.ToString();
                com.Parameters.Add("@PM_Sector", SqlDbType.VarChar).Value = PM_Sector.Text.ToString();
                com.Parameters.Add("@PM_Description", SqlDbType.VarChar).Value = PM_Description.Text.ToString();
                com.Parameters.Add("@PM_Variant_Code", SqlDbType.VarChar).Value = PM_Variant_Code.Text.ToString();
                com.Parameters.Add("@PM_Skid_Qty", SqlDbType.VarChar).Value = PM_Skid_Qty.Text.ToString();
                com.Parameters.Add("@PM_MOQ_Qty", SqlDbType.VarChar).Value = PM_MOQ_Qty.Text.ToString();
                com.Parameters.Add("@PM_Created_by", SqlDbType.VarChar).Value = dbFunctions.username;

                com.Parameters.Add("@SerialStart", SqlDbType.VarChar).Value = SerialStart.Text.ToString();
                com.Parameters.Add("@SerialEnd", SqlDbType.VarChar).Value = SerialEnd.Text.ToString();
                com.Parameters.Add("@VStart", SqlDbType.VarChar).Value = VStart.Text.ToString();
                com.Parameters.Add("@VEnd", SqlDbType.VarChar).Value = VEnd.Text.ToString();
                com.Parameters.Add("@PM_WarrantyType", SqlDbType.VarChar).Value = type.Text.ToString();
                com.Parameters.Add("@PM_Warrantytime", SqlDbType.VarChar).Value = days.Text.ToString();
                com.Parameters.Add("@compare_code", SqlDbType.VarChar).Value = compare_code.Text.ToString();

                

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
                ID = dt.Rows[0]["PM_iID"].ToString();
                PM_Item_Code.Text = dt.Rows[0]["PM_Item_Code"].ToString();
                PM_Mold.Text = dt.Rows[0]["PM_Mold"].ToString();
                PM_Sector.Text = dt.Rows[0]["PM_Sector"].ToString();
                PM_Description.Text = dt.Rows[0]["PM_Description"].ToString();
                PM_Variant_Code.Text = dt.Rows[0]["PM_Variant_Code"].ToString();
                PM_Skid_Qty.Text = dt.Rows[0]["PM_Skid_Qty"].ToString();
                PM_MOQ_Qty.Text = dt.Rows[0]["PM_MOQ_Qty"].ToString();


                SerialStart.Text = dt.Rows[0]["SerialStart"].ToString();
                SerialEnd.Text = dt.Rows[0]["SerialEnd"].ToString();
                VStart.Text = dt.Rows[0]["VStart"].ToString();
                VEnd.Text = dt.Rows[0]["VEnd"].ToString();
                compare_code.Text = dt.Rows[0]["compare_code"].ToString();
                days.Text = dt.Rows[0]["PM_Warrantytime"].ToString();
                type.SelectedItem = dt.Rows[0]["PM_WarrantyType"].ToString();

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

        public bool Validate()
        {
            if (string.IsNullOrEmpty(days.Text.Trim()))
            {
                ErrorMessage = "Warranty Should Not Be Empty";
                return true;
            }
            if (string.IsNullOrEmpty(type.Text.Trim()))
            {
                ErrorMessage = "Warranty should Not Be Empty";
                return true;
            }
            return false;
        }
        public void display()
        {
            DataTable dt = dbFunctions.getTable("Pr_Fetch_Product_Master_Details");
            dataGridView1.DataSource = dt;
            dbFunctions.DGVStyle(dataGridView1);
        }


        public void Clear()
        {
            PM_Item_Code.Text = "";
            PM_Mold.Text = "";
            PM_Sector.Text = "";
            PM_Description.Text = "";
            PM_Variant_Code.Text = "";
            PM_Skid_Qty.Text = "";
            PM_MOQ_Qty.Text = "";
            btnsave.Text = "&Save    ";
        }


        //public bool Validate()
        //{
        //    return false;
        //}


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
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Item_Code] like '%{0}%' ", textBoxX1.Text);
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


            //if (PM_Item_Code.Text.Length <= 15)
            //{
            //    MessageBox.Show("Product Code Must Be 16 Digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            if (btnsave.Text.ToString().Equals("&Update"))
            {
                Update();
                
            }
            else
            {
                insert();
                
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

        private void vinTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PM_Date_of_Manufacture_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void PM_Warranty_Expiry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void vinTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void vinTextBox5_TextChanged(object sender, EventArgs e)
        {
            compare_code.Text = PM_Variant_Code.Text;
        }

        private void vinTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void vinTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void vinTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void PM_Serial_Nos_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vinTextBox1_TextChanged_1(object sender, EventArgs e)
        {
          
        }

       
       

    }
}
