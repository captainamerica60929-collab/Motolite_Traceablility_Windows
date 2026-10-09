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
using System.Diagnostics;
using VINCONTROL;
using System.IO;
using ABD2_Finishing;
using Newtonsoft.Json.Linq;
using System.IO.Ports;


namespace  ABD2_Finishing
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
       
            
        }
        Main objMain = new Main();
        public void get_Connections()
        {

            string Data = "";
            try
            {

                string text1 = System.IO.File.ReadAllText(dbFunctions.Con_path);
            }
            catch
            {
                string s = "";
                System.IO.File.WriteAllText(dbFunctions.Con_path, s);
            }
            try
            {
                string text = System.IO.File.ReadAllText(dbFunctions.Con_path);
                JObject jsonData = JObject.Parse(text);

                Data = "Data Source=@server@;Initial Catalog=@db@;Persist Security Info=True;User ID=@usr@;Password=@pw@";
                dynamic json = jsonData;



                Data = Data.Replace("@server@", isnull(json.Server_Name, ""));
                Data = Data.Replace("@usr@", isnull(json.User_ID, ""));
                Data = Data.Replace("@pw@", isnull(json.Password, ""));
                Data = Data.Replace("@db@", isnull(json.DB_Name, ""));

                dbFunctions.Line_No = isnull(json.Line, "");
                dataClass.printerName = isnull(json.Pinter, "");
                dbFunctions.Port = isnull(json.Port, "");
                dbFunctions.Label_Path = isnull(json.Label, "");

                Line_txt.Text = "Line No :" + dbFunctions.Line_No;
                Port_txt.Text = "Port No :" + dbFunctions.Port;
            }
            catch (Exception ex) { }
            dbFunctions.connectionstring = Data;

           

            

            
        }


        public string isnull(dynamic data, string d1)
        {

            if (string.IsNullOrEmpty(Convert.ToString(data)))
            {
                return d1;
            }
            else
            {
                return data;
            }
        }


      

        private void Login_Load(object sender, EventArgs e)
        {

            get_Connections();
     /*     dbFunctions.connectionstring="Data Source=VINO-PC\\SQLEXPRESS;Initial Catalog=ABD2_Finishing;Integrated Security = true";
            dbFunctions.connectionstring1="Data Source=VINO-PC\\SQLEXPRESS;Initial Catalog=ABD2_Finishing;Integrated Security = true";
            dbFunctions.Port = "Com4";*/
            Load_Style();
            txtusername.Focus();
         
        }

        string NotePath = "\\Year.txt";
        DataTable myDataTable = new DataTable();
        private void get_year()
        {
            String line;

            try
            {

                DataColumn myDataColumn;
                myDataColumn = new DataColumn();

                myDataColumn.DataType = Type.GetType("System.String");
                myDataColumn.ColumnName = "Year";

                myDataTable.Columns.Add(myDataColumn);
                string path_string = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string path = AppDomain.CurrentDomain.BaseDirectory;

                StreamReader sr = new StreamReader(path+NotePath);
                //Read the first line of text
                line = sr.ReadLine();
                List<string> fi = new List<string>();

                using (sr = new StreamReader(path+NotePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] variables = line.Split(' ');

                        if (variables[0] != "")
                        {
                            string EmpId = variables[0];

                            try
                            {

                                DataRow row;
                                row = myDataTable.NewRow();

                                row["Year"] = EmpId;

                                myDataTable.Rows.Add(row);

                                fi.Add(line); //add to list
                            }
                            catch (Exception ex)
                            {
                                //MessageBox.Show(ex.Message);
                            }
                            //}


                        }
                    }
                    // }

                    //Year.DataSource = myDataTable;
                    //Year.DisplayMember = "Year";
                    //Year.ValueMember = "Year";
                    //Year.SelectedIndex = 0;

                    sr.Close();
                    Console.ReadLine();
                    //MessageBox.Show("Process Completed","Success",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {

            }
        }

        public void Load_Style()
        {
           VINCONTROL.VinClass.connectionstring = dbFunctions.connectionstring;
            VinClass.Path = System.Configuration.ConfigurationSettings.AppSettings["VinPath"];
            //vinGridTextBox1.SQL_Query = "Select LedgerID,LM_Ledger_Name,LM_Unique_Name,LM_Unique_Name from Ledger_Master";
            VinClass.Excel_img = ABD2_Finishing.Properties.Resources.excel;
           VinClass.Pdf_img = ABD2_Finishing.Properties.Resources.pdf;
           VinClass.Filter_img = ABD2_Finishing.Properties.Resources.filter;
           VinClass.Setting_img = ABD2_Finishing.Properties.Resources.settings;
            
            DataTable dtx = VinClass.getTable("select * from S_Style_Setting");
            if (dtx.Rows.Count > 0)
            {
                Object_Style.Lable_Font_gotFocus_Color = dtx.Rows[0]["SS_OnFocus_Color"].ToString();
                Object_Style.Lable_Font_gotFocus_bgColor = dtx.Rows[0]["SS_OnFocus_BGColor"].ToString();
                Object_Style.Lable_Font_lossFocus_Color = dtx.Rows[0]["SS_OnLossFocus_Color"].ToString();
                Object_Style.Lable_Font_lossFocus_bgColor = dtx.Rows[0]["SS_OnLossFocus_BGColor"].ToString();
            }

         
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {


            get_Login();

          DataTable dt = dbFunctions.getTable("Pr_Fetch_Company_Master_ByID  " + Company.SelectedValue);
          if (dt.Rows.Count > 0)
          {
             dbFunctions.Company_ID=Company.SelectedValue.ToString();
             dbFunctions.Company_Name = dt.Rows[0]["CM_Name"].ToString().Replace("\n", "");
             dbFunctions.Company_Address = dt.Rows[0]["CM_Address"].ToString().Replace("\n","");
             dbFunctions.Company_Phone_No = dt.Rows[0]["CM_Phone_No"].ToString();
             dbFunctions.Company_Mobile_No = dt.Rows[0]["CM_Mobile_No"].ToString();
             dbFunctions.Company_Pan_No = dt.Rows[0]["CM_Pan_No"].ToString();
             dbFunctions.Company_GST_No = dt.Rows[0]["CM_GST_No"].ToString();
             dbFunctions.Company_Email_ID = dt.Rows[0]["CM_Email_ID"].ToString();

             dbFunctions.Address1 = dt.Rows[0]["CM_Address1"].ToString().Replace("\n", ""); ;
             dbFunctions.Address2 = dt.Rows[0]["CM_Address2"].ToString().Replace("\n", ""); ;
             dbFunctions.Address3 = dt.Rows[0]["CM_Address3"].ToString().Replace("\n", ""); ;
             dbFunctions.Address4 = dt.Rows[0]["CM_Address4"].ToString().Replace("\n", ""); ;



             dbFunctions.Reg_Send = dt.Rows[0]["Reg_No1"].ToString().Replace("\n", ""); ;
             dbFunctions.Reg_Despatch = dt.Rows[0]["Reg_No2"].ToString().Replace("\n", ""); ;
             dbFunctions.Reg_Rej = dt.Rows[0]["Reg_No4"].ToString().Replace("\n", ""); ;
             dbFunctions.Reg_Misbrand = dt.Rows[0]["Reg_No3"].ToString().Replace("\n", ""); ;


             dbFunctions.Footer1 = dt.Rows[0]["Footer1"].ToString().Replace("\n", ""); ;
             dbFunctions.Footer2 = dt.Rows[0]["Footer2"].ToString().Replace("\n", ""); ;
             dbFunctions.Footer3 = dt.Rows[0]["Footer3"].ToString().Replace("\n", ""); ;



             

             objMain.Head2.Text = dbFunctions.Company_Name;
             objMain.Head1.Text = dbFunctions.Company_Name;
             objMain.Mail.Text = dbFunctions.Company_Email_ID;
          }

          string Str=dt.Rows[0][0].ToString();

           //Backup();
        }
        //public void Backup()
        //{
        //    int days = 0;

        //    DataTable dtb = dbFunctions.getTable("pr_getDAte");
        //    days = Convert.ToInt32(dtb.Rows[0]["HourDiff"].ToString());
            
        //    if (days > 120)
        //    {
        //        DialogResult result = MessageBox.Show("Need a Backup? Press YES", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        //        if (result == DialogResult.Yes)
        //        {
        //            savedate();
        //            DataTable dt = dbFunctions.getTable("pr_GetBackup");
        //            MessageBox.Show("Backup Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
                  
        //        }

        //    }
        //}
        //public void savedate()
        //{
        //    SqlConnection con = new SqlConnection(dbFunctions.connectionstring);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = con;
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "pr_InsertDate";
        //        cmd.Parameters.Add("@Bk_Datetime", SqlDbType.DateTime).Value = DateTime.Now.ToString();

        //        cmd.ExecuteNonQuery();
        //        cmd.Connection.Close();
        //    }
        //    catch
        //    {
        //    }

        //}
        void get_Login()
        {

            SqlConnection objCon = new SqlConnection(dbFunctions.connectionstring);
            try
            {
                if (txtusername.Text.Trim() != "" && txtpassword.Text.Trim() != "")
                {
                    // string enc = DecryptThis("BurWAhQFGrvQz5PcbAWHfw==", "Enc");

                     string Password =txtpassword.Text;// EncryptThis(txtpassword.Text.Trim(), "Enc");

                    DataTable dt = dbFunctions.getTable("pr_getLogin  '" + txtusername.Text + "','" + Password + "'");
                    if (dt.Rows.Count > 0)
                    {

                       dbFunctions.username = txtusername.Text;
                       dbFunctions.rights = dt.Rows[0]["UM_Rights"].ToString();

                        this.Hide();
                       // Main objMain = new Main();
                        objMain.Show();



                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name And Password","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        txtpassword.Text = "";
                        txtusername.Text = "";
                        
                        txtusername.Focus();


                    }
                }
                else
                {
                    MessageBox.Show("Login Details Incorrect", "Error");
                    txtpassword.Text = "";
                    txtusername.Text = "";

                    return;
                }



            }




            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                txtusername.Focus();
                objCon.Close();
            }


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

      
        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtpassword.Focus();



            }

            if (e.KeyCode == Keys.F12)
            {
                Config_Data ob = new Config_Data();
                ob.ShowDialog();
                get_Connections();
            }

        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Company.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk");

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            
        }

        public void load_Company_Details()
        {
            DataTable dd = dbFunctions.getTable("pr_get_Customer_Details");
            Company.DataSource = dd;
            Company.DisplayMember = "CM_Name";
            Company.ValueMember = "CM_ID";
            Company.SelectedIndex = 0;
        }

        public void load_Year()
        {
            DataTable dd = dbFunctions.getTable("pr_get_Customer_Details");
            Company.DataSource = dd;
            Company.DisplayMember = "CM_Name";
            Company.ValueMember = "CM_ID";
            Company.SelectedIndex = 0;
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            load_Company_Details();
            Company.Focus();
        }

        private void Company_KeyDown(object sender, KeyEventArgs e)
        {
//            button2.Focus();
        }
      
    }
}
