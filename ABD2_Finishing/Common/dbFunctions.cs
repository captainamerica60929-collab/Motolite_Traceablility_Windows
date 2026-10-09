using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using ABD2_Finishing.Transaction;

namespace ABD2_Finishing
{
    public class fetchid
    {
        public static string 
            id;
    }
    class dbFunctions
    {

        public static Print_Lable  objPrint_Lable = null;
        public static string username="";
        public static string rights="";
        public static string status = "";
        public static string Company_ID = "1";

        public static string Barcode="";

        public static string Con_path = @"C:\ProgramData\QConfig.json";


        public static string Job_ID = "";

        public static string Job_Part_ID = "";


        public static string Route_Card_ID = "";
        public static string connectionstring = System.Configuration.ConfigurationSettings.AppSettings["ConStr"];
        public static string Warehouse = System.Configuration.ConfigurationSettings.AppSettings["Warehouse"];
        public static string connectionstring1 = System.Configuration.ConfigurationSettings.AppSettings["Server_ConStr"];
        public static string path = System.Configuration.ConfigurationSettings.AppSettings["Path"];

        public static string Line_No = "";
        public static string Port = "Comp4";
        public static string Label_Path = System.Configuration.ConfigurationSettings.AppSettings["Path"];
        public static string Printer_Name = "";

        public static string Company_Name = "";
        public static string Company_Address = "";
        public static string Address1 = "";
        public static string Address2 = "";
        public static string Address3 = "";
        public static string Address4 = "";

        public static string Company_Phone_No = "";
        public static string Company_Mobile_No = "";
        public static string Company_GST_No = "";
        public static string Company_Pan_No = "";
        public static string Company_Email_ID = "";


        public static string Reg_Send = "";
        public static string Reg_Despatch = "";
        public static string Reg_Rej = "";
        public static string Reg_Misbrand = "";


        public static string Footer1 = "";
        public static string Footer2 = "";
        public static string Footer3 = "";
        


    
        public static DataTable getTable(string sqlQuery)
        {
            
            Cursor.Current = Cursors.WaitCursor;
            DataTable dt = new DataTable();
            try
            {

                SqlConnection con = new SqlConnection(connectionstring);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.Connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter(cmd);
                sqlDA.Fill(dt);
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
          //   MessageBox.Show(ex.Message);
                //Logs(ex.ToString(), dbFunctions.username);
            }

            Cursor.Current = Cursors.Default;
            return dt;
        }


        public static DataTable getTable1(string sqlQuery)
        {

            Cursor.Current = Cursors.WaitCursor;
            DataTable dt = new DataTable();
            try
            {

                SqlConnection con = new SqlConnection(connectionstring1);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.Connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter(cmd);
                sqlDA.Fill(dt);
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                //   MessageBox.Show(ex.Message);
                //Logs(ex.ToString(), dbFunctions.username);
            }

            Cursor.Current = Cursors.Default;
            return dt;
        }


        public static void Logs(string Error,string User)
        {
            
            //SqlConnection con = new SqlConnection(dbFunctions.connectionstring);
            //try
            //{
            //    con.Open();
            //    SqlCommand com = new SqlCommand();
            //    com.Connection = con;
            //    com.CommandType = CommandType.StoredProcedure;
            //    com.CommandText = "pr_insertLogs";
            //    com.Parameters.Add("@L_Error_Details", SqlDbType.VarChar).Value = Error;
            //    com.Parameters.Add("@L_User", SqlDbType.VarChar).Value = User;

            //    com.ExecuteNonQuery();
            //}
            //catch { }
        }


        public static bool Numeric_DecimalOnly(char KeyChar, TextBox textBox)
        {
            bool IsHandled = false;
            if (!char.IsControl(KeyChar) && !char.IsDigit(KeyChar) && KeyChar != '.')
            {
                IsHandled = true;
            }

            // only allow one decimal point
            if (KeyChar == '.'
                && textBox.Text.IndexOf('.') > -1)
            {
                IsHandled = true;
            }
            return IsHandled;
        }

        public static string getRows(DataGridView dgv)
        {
            return "Rows : " + dgv.Rows.Count;
        }

        public static void DGVStyle_DB(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245,250,250);

            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;


            dgv.EnableHeadersVisualStyles = false;
            // dgv.RowHeadersWidth = 55;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersHeight = 60;
            // dgv.ReadOnly = true;
            //        dgv.ColumnHeadersBorderStyle =
            //DataGridViewHeaderBorderStyle.Single;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dgv.ReadOnly = true;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;//System.Drawing.SystemColors.GrayText;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgv.RowHeadersVisible = false;

            dgv.GridColor = Color.FromArgb(234,243,232);
            dgv.BackgroundColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.PaleGreen;//5 Color.FromArgb(173, 219, 255);// Color.FromArgb(251, 228, 141);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.RowTemplate.Height = 40;
           
            // new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Verdana", 13F);
            
            dgv.RowsDefaultCellStyle.Font = new System.Drawing.Font("Verdana", 11F);
        }
        public static void DGVStyle(DataGridView dgv)
        {
            
            try
            {

               dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //for (int i = 0; i < dgv.Rows.Count - 1; i++)
                //{
                //    dgv.Rows[i].HeaderCell.Value = (i + 1).ToString();
                //    dgv.Rows[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

                //    if (i % 2 == 0)
                //    {
                //        dgv.Rows[i].DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
                //    }
                //}


                for (int i = 1; i < dgv.Columns.Count - 1; i++)
                {
                    dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; ;
                }

                // dgv.RowsDefaultCellStyle.BackColor = Color.LightGray;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 249, 249);

                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;


                //dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption; //System.Drawing.SystemColors.SlateGray;
                //dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

                // dgv.GridColor = Color.Teal; ;

                //  dgv.DefaultCellStyle.SelectionBackColor = Color.Lavender;//Color.FromArgb(239, 243, 250);
                // dgv.DefaultCellStyle.SelectionForeColor = Color.DarkRed;

                //dgv.DefaultCellStyle.ForeColor = Color.DimGray;


                dgv.EnableHeadersVisualStyles = false;
                // dgv.RowHeadersWidth = 55;
                dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                dgv.ColumnHeadersHeight = 27;
                // dgv.ReadOnly = true;
        //        dgv.ColumnHeadersBorderStyle =
        //DataGridViewHeaderBorderStyle.Single;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(54, 54, 54);//System.Drawing.SystemColors.GrayText;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(208, 214, 224);
                dgv.RowHeadersWidth = 25;
              
                dgv.GridColor = Color.FromArgb(218, 220, 221);
                dgv.BackgroundColor = Color.White;
                dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 219, 255);// Color.FromArgb(251, 228, 141);
                dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
                

                // new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Verdana", 9.75F);
                dgv.Rows[0].Selected = false;
                dgv.Columns[0].Visible = false;
                dgv.RowsDefaultCellStyle.Font = new System.Drawing.Font("Verdana", 9.75F);

            }
            catch { }
        }

        public static void DGVStyleAutoSizeColumn(DataGridView dgv)
        {

            try
            {

                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 249, 249);

                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;



                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                dgv.ColumnHeadersHeight = 27;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(54, 54, 54);//System.Drawing.SystemColors.GrayText;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(223, 227, 232);
                dgv.RowHeadersWidth = 25;

                dgv.GridColor = Color.FromArgb(218, 220, 221);
                dgv.BackgroundColor = Color.White;
                dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(183, 219, 255);// Color.FromArgb(251, 228, 141);
                dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
                dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Verdana", 9.75F);
                dgv.Rows[0].Selected = false;
                dgv.Columns[0].Visible = false;
                dgv.RowsDefaultCellStyle.Font = new System.Drawing.Font("Verdana", 9.75F);

            }
            catch { }
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


        public static bool sendsms(string msg, string PhoneNo)
        {
            DataTable dt = dbFunctions.getTable("select * from Sms_Settings");

            try
            {
               // HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("http://203.212.70.200/smpp/sendsms?username=srivijaya&password=srivijaya123&to=" + PhoneNo + "&from=SVVBMS&udh=&text=" + msg + "&dlr-mask=19");
                HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(dt.Rows[0]["SM_ConStr1"].ToString() + PhoneNo + dt.Rows[0]["SM_ConStr2"].ToString() + msg + dt.Rows[0]["SM_ConStr3"].ToString());
                
                HttpWebResponse myResp = (HttpWebResponse)myReq.GetResponse();
                System.IO.StreamReader respStreamReader = new System.IO.StreamReader(myResp.GetResponseStream());
                string responseString = respStreamReader.ReadToEnd();
                respStreamReader.Close();
                // MessageBox.Show("hai");
                myResp.Close();
                
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }




        public static void ExportExcel(DataGridView dgvGrid)
        {
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;

            try
            {
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
                worksheet.Name = "Sheet1";
                for (int i = 1; i < dgvGrid.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvGrid.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvGrid.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvGrid.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvGrid.Rows[i].Cells[j].Value.ToString();
                    }
                }

            }
            catch (System.Exception ex)
            {

            }
            finally
            {
                app.Quit();
                workbook = null;
                app = null;
            }
            Cursor.Current = Cursors.Default;
        }
       
    }
}
