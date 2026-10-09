using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Maintanence_Printing_Tool;
using System.Data.SqlClient;
namespace ABD2_Finishing.Setting
{
    public partial class Rights_Master : Form
    {
        public Rights_Master()
        {
            InitializeComponent();
        }

        private void Rights_Master_Load(object sender, EventArgs e)
        {
            get_Rights();
            get_Module();
        }

        public void get_Module()
        {
            DataTable dt = dbFunctions.getTable("pr_get_Module");
            Module.DataSource = dt;
            Module.DisplayMember = "MM_Module";
            Module.ValueMember = "MM_Module";
            Module.SelectedIndex = -1;

        }

        public void get_Rights()
        {
            DataTable dt = dbFunctions.getTable("Pr_Load_RGV_vDesciption1   'User_Role'");
            RA_Rights_ID.DataSource = dt;
            RA_Rights_ID.DisplayMember = "RGV_vDesciption";
            RA_Rights_ID.ValueMember = "RGV_iID";
            RA_Rights_ID.SelectedIndex = -1;
        }

        private void MM_Module_SelectedIndexChanged(object sender, EventArgs e)
        {
            Get_Menus();
        }

        public void Get_Menus()
        {
            dataGridView1.Rows.Clear();
            try
            {
                DataTable dt = dbFunctions.getTable("pr_get_Menus_by_rights '" + Module.Text + "'," + RA_Rights_ID.SelectedValue.ToString());
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();

                }
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Columns[0].Visible = false;

                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[5].Width = 100;
                dataGridView1.Columns[6].Width = 100;

            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Get_Menus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insert();
        }

        public void insert()
        {
            SqlConnection con = new SqlConnection(dbFunctions.connectionstring);
            bool flag=true;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    com.Connection = con;
                    com.CommandType = CommandType.StoredProcedure;
                    com.CommandText = "Pr_Insert_S_Rights_Master";
                    com.Parameters.Add("@RA_Menu_ID", SqlDbType.VarChar).Value = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    com.Parameters.Add("@RA_Rights_ID", SqlDbType.VarChar).Value = RA_Rights_ID.SelectedValue.ToString();
                    com.Parameters.Add("@RA_Display", SqlDbType.VarChar).Value = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    com.Parameters.Add("@RA_Save", SqlDbType.VarChar).Value = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    com.Parameters.Add("@RA_Edit", SqlDbType.VarChar).Value = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    com.Parameters.Add("@RA_Delete", SqlDbType.VarChar).Value = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    com.Parameters.Add("@RA_Createby", SqlDbType.VarChar).Value = dbFunctions.username;
                    com.ExecuteNonQuery();
                    com.Connection.Close();
                   
                }
                catch (Exception Ex)
                {
                    flag=false;
                    MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (flag)
            {
                MessageBox.Show("Details Saved Successfully ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                Get_Menus();
            }
        }


        private void vinComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Get_Menus();

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string flag="0";
            
            if(checkBox1.Checked==true)
                 flag="1";
             else
                 flag="0";

            for(int i=0;i<dataGridView1.Rows.Count;i++)
            {
                dataGridView1.Rows[i].Cells[3].Value = flag;
            }
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            string flag = "0";

            if (checkBox2.Checked == true)
                flag = "1";
            else
                flag = "0";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[4].Value = flag;
            }
           

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            string flag = "0";

            if (checkBox3.Checked == true)
                flag = "1";
            else
                flag = "0";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[5].Value = flag;
            }
           
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            string flag = "0";

            if (checkBox4.Checked == true)
                flag = "1";
            else
                flag = "0";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[6].Value = flag;
            }
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
