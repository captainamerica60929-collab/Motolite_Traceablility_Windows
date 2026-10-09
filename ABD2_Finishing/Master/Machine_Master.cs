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
    public partial class Machine_Master : Form
    {
        public Machine_Master()
        {
            InitializeComponent();
        }
        public string arrow = "Up";
        public int Distance = 336;
        
        private void vinLabel2_Click(object sender, EventArgs e)
        {

        }

        private void vinLabel9_Click(object sender, EventArgs e)
        {

        }

        private void CM_PAN_No_TextChanged(object sender, EventArgs e)
        {

        }
        void fetch_Machine_Category()
        {
            DataTable dt = dbFunctions.getTable("pr_fetch_ReferenceGroup_Value '"+"Machine Categroy" +"'");
            MM_MachineCategroy.DataSource = dt;
            MM_MachineCategroy.DisplayMember = "RGV_vDesciption";
            MM_MachineCategroy.ValueMember = "RGV_iID";
            MM_MachineCategroy.SelectedIndex = -1;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string ErrorMessage = "";
        public string ID = "0";
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
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[MachineID] like '%{0}%' or [Name] like '%{0}%' or [MachineCategroy] like '%{0}%'", textBoxX1.Text);
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
                MM_MachineID.Focus();
            }
            else
            {
                insert();
                MM_MachineID.Focus();
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
                com.CommandText = "Pr_Insert_Machine_Master";
                com.Parameters.Add("@MM_MachineID", SqlDbType.VarChar).Value = MM_MachineID.Text.ToString();
                com.Parameters.Add("@MM_Name", SqlDbType.VarChar).Value = MM_Name.Text.ToString();
                com.Parameters.Add("@MM_SerialNo", SqlDbType.VarChar).Value = MM_SerialNo.Text.ToString();
                com.Parameters.Add("@MM_MachineCategroy", SqlDbType.VarChar).Value = MM_MachineCategroy.SelectedValue.ToString();
                com.Parameters.Add("@MM_WorkHoursPerDay", SqlDbType.VarChar).Value = MM_WorkHoursPerDay.Text.ToString();
                com.Parameters.Add("@MM_Model", SqlDbType.VarChar).Value = MM_Model.Text.ToString();
                com.Parameters.Add("@MM_Manufacture", SqlDbType.VarChar).Value = MM_Manufacture.Text.ToString();
                com.Parameters.Add("@MM_Year_Of_FG", SqlDbType.VarChar).Value = MM_Year_Of_FG.Text.ToString();
                com.Parameters.Add("@MM_Country", SqlDbType.VarChar).Value = MM_Country.Text.ToString();
                com.Parameters.Add("@MM_Price", SqlDbType.VarChar).Value = MM_Price.Text.ToString();
                com.Parameters.Add("@MM_Currency", SqlDbType.VarChar).Value = MM_Currency.Text.ToString();
                com.Parameters.Add("@MM_Date_of_Purchase", SqlDbType.VarChar).Value = MM_Date_of_Purchase.Value.ToString("dd-MMM-yyyy");
                com.Parameters.Add("@MM_Vendo_Name", SqlDbType.VarChar).Value = MM_Vendo_Name.SelectedValue.ToString();
                com.Parameters.Add("@MM_WarantyExpDate", SqlDbType.VarChar).Value = MM_WarantyExpDate.Value.ToString("dd-MMM-yyyy");
                com.Parameters.Add("@MM_AMCExpDate", SqlDbType.VarChar).Value = MM_AMCExpDate.Value.ToString("dd-MMM-yyyy");
                com.Parameters.Add("@MM_Date_of_Installlation", SqlDbType.VarChar).Value = MM_Date_of_Installlation.Value.ToString("dd-MMM-yyyy");
                com.Parameters.Add("@MM_Installation_Place", SqlDbType.VarChar).Value = MM_Installation_Place.Text.ToString();
                com.Parameters.Add("@MM_Remarks", SqlDbType.VarChar).Value = MM_Remarks.Text.ToString();
                com.Parameters.Add("@MM_User", SqlDbType.VarChar).Value = dbFunctions.username;
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

            // Generated By vino  10-Aug-2018 7:50:15 PM
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
                com.CommandText = "Pr_Update_Machine_Master";
                com.Parameters.Add("@MM_ID", SqlDbType.VarChar).Value = ID;
                com.Parameters.Add("@MM_MachineID", SqlDbType.VarChar).Value = MM_MachineID.Text.ToString();
                com.Parameters.Add("@MM_Name", SqlDbType.VarChar).Value = MM_Name.Text.ToString();
                com.Parameters.Add("@MM_SerialNo", SqlDbType.VarChar).Value = MM_SerialNo.Text.ToString();
                com.Parameters.Add("@MM_MachineCategroy", SqlDbType.VarChar).Value = MM_MachineCategroy.SelectedValue.ToString();
                com.Parameters.Add("@MM_WorkHoursPerDay", SqlDbType.VarChar).Value = MM_WorkHoursPerDay.Text.ToString();
                com.Parameters.Add("@MM_Model", SqlDbType.VarChar).Value = MM_Model.Text.ToString();
                com.Parameters.Add("@MM_Manufacture", SqlDbType.VarChar).Value = MM_Manufacture.Text.ToString();
                com.Parameters.Add("@MM_Year_Of_FG", SqlDbType.VarChar).Value = MM_Year_Of_FG.Text.ToString();
                com.Parameters.Add("@MM_Country", SqlDbType.VarChar).Value = MM_Country.Text.ToString();
                com.Parameters.Add("@MM_Price", SqlDbType.VarChar).Value = MM_Price.Text.ToString();
                com.Parameters.Add("@MM_Currency", SqlDbType.VarChar).Value = MM_Currency.Text.ToString();
                com.Parameters.Add("@MM_Date_of_Purchase", SqlDbType.VarChar).Value = MM_Date_of_Purchase.Text.ToString();
                com.Parameters.Add("@MM_Vendo_Name", SqlDbType.VarChar).Value = MM_Vendo_Name.SelectedValue.ToString();
                com.Parameters.Add("@MM_WarantyExpDate", SqlDbType.VarChar).Value = MM_WarantyExpDate.Text.ToString();
                com.Parameters.Add("@MM_AMCExpDate", SqlDbType.VarChar).Value = MM_AMCExpDate.Text.ToString();
                com.Parameters.Add("@MM_Date_of_Installlation", SqlDbType.VarChar).Value = MM_Date_of_Installlation.Text.ToString();
                com.Parameters.Add("@MM_Installation_Place", SqlDbType.VarChar).Value = MM_Installation_Place.Text.ToString();
                com.Parameters.Add("@MM_Remarks", SqlDbType.VarChar).Value = MM_Remarks.Text.ToString();
                com.Parameters.Add("@MM_User", SqlDbType.VarChar).Value = dbFunctions.username;
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

            // Generated By vino  10-Aug-2018 7:50:15 PM
        }


        public void Edit()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataTable dt = dbFunctions.getTable("Pr_Fetch_Machine_Master_ByID  " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                ID = dt.Rows[0]["MM_ID"].ToString();
                MM_MachineID.Text = dt.Rows[0]["MM_MachineID"].ToString();
                MM_Name.Text = dt.Rows[0]["MM_Name"].ToString();
                MM_SerialNo.Text = dt.Rows[0]["MM_SerialNo"].ToString();
                MM_MachineCategroy.SelectedValue = dt.Rows[0]["MM_MachineCategroy"].ToString();
                MM_WorkHoursPerDay.Text = dt.Rows[0]["MM_WorkHoursPerDay"].ToString();
                MM_Model.Text = dt.Rows[0]["MM_Model"].ToString();
                MM_Manufacture.Text = dt.Rows[0]["MM_Manufacture"].ToString();
                MM_Year_Of_FG.Text = dt.Rows[0]["MM_Year_Of_FG"].ToString();
                MM_Country.Text = dt.Rows[0]["MM_Country"].ToString();
                MM_Price.Text = dt.Rows[0]["MM_Price"].ToString();
                MM_Currency.Text = dt.Rows[0]["MM_Currency"].ToString();
                MM_Date_of_Purchase.Text = dt.Rows[0]["MM_Date_of_Purchase"].ToString();
                MM_Vendo_Name.SelectedValue = dt.Rows[0]["MM_Vendo_Name"].ToString();
                MM_WarantyExpDate.Text = dt.Rows[0]["MM_WarantyExpDate"].ToString();
                MM_AMCExpDate.Text = dt.Rows[0]["MM_AMCExpDate"].ToString();
                MM_Date_of_Installlation.Text = dt.Rows[0]["MM_Date_of_Installlation"].ToString();
                MM_Installation_Place.Text = dt.Rows[0]["MM_Installation_Place"].ToString();
                MM_Remarks.Text = dt.Rows[0]["MM_Remarks"].ToString();
               
                btnsave.Text = "&Update";
            }
            else
            {
                MessageBox.Show("Please Select Row", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Generated By vino  10-Aug-2018 7:50:15 PM
        }


        public void Delete()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are You Sure Want to Delete Press YES", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    DataTable dt = dbFunctions.getTable("Pr_Delete_Machine_Master " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    MessageBox.Show("Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    display();
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Please Select Row", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Generated By vino  10-Aug-2018 7:50:15 PM
        }


        public void display()
        {
            DataTable dt = dbFunctions.getTable("Pr_Fetch_Machine_Master_Details");
            dataGridView1.DataSource = dt;
            dbFunctions.DGVStyle(dataGridView1);

            // Generated By vino  10-Aug-2018 7:50:15 PM
        }


        public void Clear()
        {
            MM_MachineID.Text = "";
            MM_Name.Text = "";
            MM_SerialNo.Text = "";
            MM_MachineCategroy.Text = "";
            MM_WorkHoursPerDay.Text = "0.00";
            MM_Model.Text = "";
            MM_Manufacture.Text = "";
            MM_Year_Of_FG.Text = "";
            MM_Country.Text = "";
            MM_Price.Text = "0.00";
            MM_Currency.Text = "";
            MM_Date_of_Purchase.Text = "";
            MM_Vendo_Name.SelectedIndex = -1;
            MM_WarantyExpDate.Text = "";
            MM_AMCExpDate.Text = "";
            MM_Date_of_Installlation.Text = "";
            MM_Installation_Place.Text = "";
            MM_Remarks.Text = "";
            
            btnsave.Text = "&Save    ";
            // Generated By vino  10-Aug-2018 7:50:15 PM
        }


        public bool Validate()
        {
            if ((string.IsNullOrEmpty(MM_MachineID.Text.Trim())))
            {
                ErrorMessage = "MachineID Should Not be Empty";
                MM_MachineID.Focus();
                return true;
            }
            if ((string.IsNullOrEmpty(MM_Name.Text.Trim())))
            {
                ErrorMessage = "Name Should Not be Empty";
                MM_Name.Focus();
                return true;
            }
            //if ((string.IsNullOrEmpty(MM_SerialNo.Text.Trim())))
            //{
            //    ErrorMessage = "SerialNo Should Not be Empty";
            //    MM_SerialNo.Focus();
            //    return true;
            //}
            //if ((string.IsNullOrEmpty(MM_WorkHoursPerDay.Text.Trim())))
            //{
            //    ErrorMessage = "WorkHoursPerDay Should Not be Empty";
            //    MM_WorkHoursPerDay.Focus();
             
            //    return true;
            //}
            if ((string.IsNullOrEmpty(MM_Year_Of_FG.Text.Trim())))
            {
                ErrorMessage = "Year_Of_FG Should Not be Empty";
                MM_Year_Of_FG.Focus();
                return true;
            }
            if ((string.IsNullOrEmpty(MM_MachineCategroy.Text.Trim())))
            {
                ErrorMessage = "Machine Categroy Should Not be Empty";
                MM_MachineCategroy.Focus();
                return true;
            }
            
            if ((string.IsNullOrEmpty(MM_Vendo_Name.Text.Trim())))
            {
                ErrorMessage = "Vendo_Name Should Not be Empty";
                MM_Vendo_Name.Focus();
                return true;
            }
            return false;
        }
        void Fetch_vendor()
        {
            try
            {
                DataTable dt = dbFunctions.getTable("Pr_Fetch_Supplier_name");
                MM_Vendo_Name.DataSource = dt;
                MM_Vendo_Name.DisplayMember = "SM_SupplierName";
                MM_Vendo_Name.ValueMember = "SM_Id";
                MM_Vendo_Name.SelectedIndex = -1;

            }
            catch { }
        }

        private void Machine_Master_Load(object sender, EventArgs e)
        {
            fetch_Machine_Category();
                     display();
                     Fetch_vendor();
                     MM_MachineID.Focus();
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

        private void button8_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dbFunctions.ExportExcel(dataGridView1);
            Cursor.Current = Cursors.Default;
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
