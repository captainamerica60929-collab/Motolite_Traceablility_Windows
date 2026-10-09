using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using VINCONTROL;

namespace ABD2_Finishing.Setting
{
    public partial class Style_Setting : Form
    {
        public Style_Setting()
        {
            InitializeComponent();
        }

        private void Style_Setting_Load(object sender, EventArgs e)
        {
            SS_Object_Name.Enabled = false;
            SS_Object_Name.Text = "Label";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert();
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
                com.CommandText = "Pr_Insert_S_Style_Setting";
                com.Parameters.Add("@SS_Object_Name", SqlDbType.VarChar).Value = SS_Object_Name.Text.ToString();
                com.Parameters.Add("@SS_Font", SqlDbType.VarChar).Value = SS_Font.Text.ToString();
                com.Parameters.Add("@SS_Size", SqlDbType.VarChar).Value = SS_Size.Text.ToString();
                com.Parameters.Add("@SS_Font_Style", SqlDbType.VarChar).Value = SS_Font_Style.Text.ToString();
                com.Parameters.Add("@SS_Fore_Color", SqlDbType.VarChar).Value = SS_Fore_Color.Text.ToString();
                com.Parameters.Add("@SS_Back_Color", SqlDbType.VarChar).Value = SS_Back_Color.Text.ToString();
                com.Parameters.Add("@SS_OnFocus_Color", SqlDbType.VarChar).Value = SS_OnFocus_Color.Text.ToString();

                com.Parameters.Add("@SS_OnFocus_BGColor", SqlDbType.VarChar).Value = SS_OnFocus_BGColor.Text.ToString();
                com.Parameters.Add("@SS_OnLossFocus_BGColor", SqlDbType.VarChar).Value = SS_OnLossFocus_BGColor.Text.ToString();


                com.Parameters.Add("@SS_OnLossFocus_Color", SqlDbType.VarChar).Value = SS_OnLossFocus_Color.Text.ToString();
                com.Parameters.Add("@SS_Created_by", SqlDbType.VarChar).Value = dbFunctions.username;
                com.ExecuteNonQuery();
                com.Connection.Close();
                MessageBox.Show("Details Saved Successfully ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (Exception Ex)
            {
                dbFunctions.Logs(Ex.Message, dbFunctions.username);
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                SS_Fore_Color.Text = "#"+(colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                SS_Fore_Color.BackColor = colorDialog1.Color;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                SS_Back_Color.Text = "#" + (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                SS_Back_Color.BackColor = colorDialog1.Color;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                SS_OnFocus_Color.Text = "#" + (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                SS_OnFocus_Color.BackColor = colorDialog1.Color;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                SS_OnLossFocus_Color.Text = "#" + (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                SS_OnLossFocus_Color.BackColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                string fontName;
                float fontSize;
                SS_Font.Text = fontDialog1.Font.Name.ToString();
                SS_Size.Text = fontDialog1.Font.Size.ToString();
                SS_Font_Style.Text = fontDialog1.Font.Style.ToString();
                
            }
        }

        private void SS_Object_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = dbFunctions.getTable("Pr_Fetch_S_Style_Setting_ByID  '" + SS_Object_Name.Text + "'");
                SS_Font.Text = dt.Rows[0]["SS_Font"].ToString();
                SS_Size.Text = dt.Rows[0]["SS_Size"].ToString();
                SS_Font_Style.Text = dt.Rows[0]["SS_Font_Style"].ToString();
                SS_Fore_Color.Text = dt.Rows[0]["SS_Fore_Color"].ToString();
                SS_Back_Color.Text = dt.Rows[0]["SS_Back_Color"].ToString();
                SS_OnFocus_Color.Text = dt.Rows[0]["SS_OnFocus_Color"].ToString();
                SS_OnLossFocus_Color.Text = dt.Rows[0]["SS_OnLossFocus_Color"].ToString();
                SS_OnFocus_BGColor.Text = dt.Rows[0]["SS_OnFocus_BGColor"].ToString();
                SS_OnLossFocus_BGColor.Text = dt.Rows[0]["SS_OnLossFocus_BGColor"].ToString();

            }
            catch { }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                SS_OnFocus_BGColor.Text = "#" + (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                SS_OnFocus_BGColor.BackColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                SS_OnLossFocus_BGColor.Text = "#" + (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                SS_OnLossFocus_BGColor.BackColor = colorDialog1.Color;
            }
        }
    }
}
