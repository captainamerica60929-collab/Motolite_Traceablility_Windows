using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maintanence_Printing_Tool;
using Shasun_Printing_Toll.Masters;
using System.IO.Ports;
using System.Globalization;
using System.Data.SqlClient;

namespace ABD2_Finishing.Transaction
{
    public partial class Print_Label_New : Form
    {
        public Print_Label_New()
        {
            InitializeComponent();
        }

        public static string rate = System.Configuration.ConfigurationSettings.AppSettings["rate"];

        SerialPort mySerialPort = new SerialPort(dbFunctions.Port);


        public void GET_Operator()
        {
            DataTable dt = dbFunctions.getTable("pr_get_Operator");
            SD_Operator.DataSource = dt;
            SD_Operator.DisplayMember = "Name";
            SD_Operator.ValueMember = "ID";
            SD_Operator.SelectedIndex = -1;
        }


        public void GET_Incharge()
        {
            DataTable dt = dbFunctions.getTable("pr_get_Incharge");
            SD_Inspector.DataSource = dt;
            SD_Inspector.DisplayMember = "Name";
            SD_Inspector.ValueMember = "ID";
            SD_Inspector.SelectedIndex = -1;
        }

        public Boolean line_Check = true;
        private void SD_Barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                key_Data();
            }
        }

        public void key_Data()
        {
            label29.Text = SD_Barcode.Text;
            //Serial_No.Text = SD_Barcode.Text;


            //if ((string.IsNullOrEmpty(asscode.Text.Trim())))
            //{
            //    Message = "Enter the Ass Code";
            //    SD_Barcode.Text = "";
            //    asscode.Focus();

            //    label16.BackColor = Color.OrangeRed;

            //    label16.ForeColor = Color.Black;
            //    label16.Text = Message;
            //    return;
            //}

            if (SD_Barcode.Text.ToLower().Equals(cr_Barcode_Last.ToLower()))
            {
                SD_Barcode.Text = "";
                label16.BackColor = Color.OrangeRed;

                label16.ForeColor = Color.Black;
                label16.Text = "Barcode  Already Scanned..";
                return;
            }

            insert();
            cr_Barcode_Last = label29.Text;
            // cr_Barcode_Last = "";
        }

        public string Message = "";

        string cr_Barcode = "";
        string cr_Barcode_Last = "";
        public bool Validates()
        {
            try
            {



                cr_Barcode = SD_Barcode.Text;


                DataTable dd = dbFunctions.getTable("pr_check_barcode_Duplicate  '" + SD_Barcode.Text + "'");
                if (dd.Rows.Count > 0)
                {
                    Message = "Barcode  Already Scanned..";
                    return true;
                }


                string vc = cr_Barcode.Substring(int.Parse(VStart.Text), int.Parse(VEnd.Text));


                if (!vc.ToUpper().Equals(compare_code.Text.ToUpper()))
                {
                    Message = "Varient Code Missmatch..";
                    return true;
                }

                if ((string.IsNullOrEmpty(SD_van_no.Text.Trim())))
                {
                    Message = "Enter the Van No";
                    //cr_Barcode_Last = "";
                    SD_van_no.Focus();
                    return true;
                }




                //if(line_Check==true)
                //{
                //    try
                //    {
                //        string Line = cr_Barcode.Substring((int.Parse(VStart.Text) + int.Parse(VEnd.Text) + 3), 1);


                //        if (int.Parse(Line_No.Text) != int.Parse(Line))
                //        {
                //            Message = "Line Miss Match..";
                //            return true;
                //        }
                //    }
                //    catch {
                //        Message = "Line Miss Match..";
                //        return true;
                //    }
                //}



                /*   if (int.Parse(Txt_Count.Text) >int.Parse(SD_MOQ_Qty.Text))
                   {
                       Message = "Scan Qty more than Skid Qty.. pls Check..";
                       return true;
                   }
                   */
                /*DataTable dds = dbFunctions.getTable("Pr_Fetch_Min_SNo '" + SD_Item_Code.Text+ "'");
                if (dds.Rows.Count > 0)
                {
                    if (Last_Barcode == "00000")
                        return false;
                

                    int MIN_ = int.Parse(dds.Rows[0][0].ToString());
                    int Max_ = int.Parse(dds.Rows[0][0].ToString()) + int.Parse(SD_MOQ_Qty.Text);

                    int Current = int.Parse(cr_Barcode.Substring(int.Parse(SerialStart.Text), int.Parse(SerialEnd.Text)));

                    if (Current > MIN_ && Current <= Max_)
                    {
                    }
                    else
                    {
                        Message = "Serial No Missmatch Found";

                        label16.BackColor = Color.OrangeRed;

                        label16.ForeColor = Color.Black;
                        label16.Text = Message;
                        return true;
                    }
                }

                */

                try
                {
                    if (Last_Barcode == "00000")
                        return false;

                    int clenght = cr_Barcode.Length;
                    int rlenght = Last_Barcode.Length;
                    if (clenght != rlenght)
                    {
                        Message = "Barcode Lenght Missmatch Found";

                        label16.BackColor = Color.OrangeRed;

                        label16.ForeColor = Color.Black;
                        label16.Text = Message;
                        return true;
                    }

                    string Left = Last_Barcode.Substring(0, int.Parse(SerialStart.Text)).ToUpper();
                    string Right = cr_Barcode.Substring(0, int.Parse(SerialStart.Text)).ToUpper();
                    if (!Left.Equals(Right))
                    {
                        Message = "Barcode Data Missmatch Found";

                        label16.BackColor = Color.OrangeRed;

                        label16.ForeColor = Color.Black;
                        label16.Text = Message;
                        return true;
                    }


                    //Decimal Current1 = Decimal.Parse(cr_Barcode.Substring(int.Parse(SerialStart.Text), int.Parse(SerialEnd.Text)));
                    //if (Current1 == 0)
                    //{

                    //    Message = "Zero Not Accepted";

                    //    label16.BackColor = Color.OrangeRed;

                    //    label16.ForeColor = Color.Black;
                    //    label16.Text = Message;
                    //    return true;
                    //}

                    /*int last = int.Parse(Last_Barcode.Substring(int.Parse(SerialStart.Text), int.Parse(SerialEnd.Text)));
                    int Current = int.Parse(cr_Barcode.Substring(int.Parse(SerialStart.Text), int.Parse(SerialEnd.Text))) - 1;

                    if (Current > last && Last_Barcode != "00000")
                    {
                        Message = "Scanned Barcode Serious Missmatch Found";

                        label16.BackColor = Color.OrangeRed;

                        label16.ForeColor = Color.Black;
                        label16.Text = Message;

                        // SD_Barcode.Text = "";
                        SD_Barcode.Focus();

                        Application.DoEvents();
                        //System.Media.SoundPlayer player = new System.Media.SoundPlayer(NG_Sound);
                        //player.Play();
                        if (checkBox1.Checked == false)
                            return true;
                    }
                    */
                }
                catch (Exception ex)
                {
                    Message = "Invalid Barcode Scanned..";
                    return true;
                }

            }
            catch (Exception ex)
            {
                Message = "Invalid Barcode Scanned..";
                return true;
            }
            return false;


        }

        public void insert()
        {
            if (Validates())
            {
                label16.BackColor = Color.OrangeRed;

                label16.ForeColor = Color.Black;
                label16.Text = Message;

                SD_Barcode.Text = "";
                SD_Barcode.Focus();

                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(NG_Sound);
                //player.Play();

                Application.DoEvents();
                return;
            }



            if (SD_MOQ_Barcode.Text == "-")
            {
                DataTable dt = dbFunctions.getTable("pr_get_Barcode");
                SD_MOQ_Barcode.Text = dt.Rows[0][0].ToString();

            }

            SqlConnection con = new SqlConnection(dbFunctions.connectionstring);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "c";
                com.CommandText = "Pr_Insert_Scan_Details_NEW";
                com.Parameters.Add("@Line_No", SqlDbType.VarChar).Value = dbFunctions.Line_No;

                com.Parameters.Add("@SD_Barcode", SqlDbType.VarChar).Value = SD_Barcode.Text.ToString();
                com.Parameters.Add("@SD_Item_Code", SqlDbType.VarChar).Value = SD_Item_Code.Text.ToString();
                com.Parameters.Add("@SD_MOQ_Qty", SqlDbType.VarChar).Value = SD_MOQ_Qty.Text.ToString();
                com.Parameters.Add("@SD_Operator", SqlDbType.VarChar).Value = SD_Operator.Text.ToString();
                com.Parameters.Add("@SD_Inspector", SqlDbType.VarChar).Value = SD_Inspector.Text.ToString();

                com.Parameters.Add("@SD_MOQ_Barcode", SqlDbType.VarChar).Value = SD_MOQ_Barcode.Text.ToString();
                com.Parameters.Add("@SD_Scan_Qty", SqlDbType.VarChar).Value = "1";
                com.Parameters.Add("@SD_Type", SqlDbType.VarChar).Value = PM_Variant_Code.Text.ToString();
                com.Parameters.Add("@SD_ASS_Code", SqlDbType.VarChar).Value = asscode.Text.ToString();
                com.Parameters.Add("@SD_van_no", SqlDbType.VarChar).Value = SD_van_no.Text.ToString();
                com.Parameters.Add("@SD_Print_Status", SqlDbType.VarChar).Value = "Pending";
                com.Parameters.Add("@SD_Ctedate_by", SqlDbType.VarChar).Value = dbFunctions.username;
                com.Parameters.Add("@SD_Warehouse", SqlDbType.VarChar).Value = dbFunctions.Warehouse;
                com.ExecuteNonQuery();
                com.Connection.Close();

                if (string.IsNullOrWhiteSpace(Serial_No.Text))
                {
                    Serial_No.Text = SD_Barcode.Text;
                }
                else
                {
                    Serial_No.Text += "," + SD_Barcode.Text;
                }
                //  MessageBox.Show("Details Saved Successfully ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear();



                DataTable dt2 = dbFunctions.getTable("update Old_Data set Operator='" + SD_Operator.Text + "'");
                DataTable dt3 = dbFunctions.getTable("update Old_Data set Inspector='" + SD_Inspector.Text + "'");


                display();
                panel2.Enabled = false;
                label16.BackColor = Color.Green;
                label16.ForeColor = Color.White;
                label16.Text = "Barcode Scanned Successfully";
                SD_Barcode.Text = "";
                // cr_Barcode_Last = "";
                SD_Barcode.Focus();
                Application.DoEvents();
                SD_Item_Code.Enabled = false;

                if (int.Parse(Txt_Count.Text) == int.Parse(SD_MOQ_Qty.Text))
                {
                    print_Lable();
                    //SD_Item_Code.TEXT.Enabled = true;
                    // Enable a ComboBox named cmb_ItemCode
                    //panel2.Enabled = false;
                    SD_Item_Code.Enabled = true;




                }
            }
            catch (Exception Ex)
            {
                dbFunctions.Logs(Ex.Message, dbFunctions.username);
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string Last_Barcode = "00000";
        string yearCode;

        public void display()
        {
            DataTable dt = dbFunctions.getTable("Pr_Fetch_Scan_Details_Details_NEW  '" + SD_Item_Code.Text + "','" + dbFunctions.Line_No + "'");
            Txt_Count.Text = dt.Rows.Count.ToString();
            // yearCode = (DateTime.Now.Year == 2024) ? "Y" : "Z";

            //if (DateTime.Now.Year == 2025 && DateTime.Now.Month == 1 && DateTime.Now.Day == 1 && DateTime.Now.TimeOfDay >= TimeSpan.FromHours(0) &&DateTime.Now.TimeOfDay <= TimeSpan.FromHours(6))
            //{
            //    yearCode = "Y";
            //}
            //else if(DateTime.Now.Year == 2024)
            //{
            //    yearCode = "Y";
            //}
            //else
            //{
            //    yearCode = "Z";
            //}
            //DataTable dt_yearcode = dbFunctions.getTable("pr_fetch_yearcode");
            //yearCode = dt_yearcode.Rows[0][0].ToString();

            dataGridView1.DataSource = dt;
            dbFunctions.DGVStyle(dataGridView1);


            if (dt.Rows.Count > 0)
            {
                Last_Barcode = dt.Rows[0]["Barcode"].ToString();

            }
            else
            {
                Last_Barcode = "00000";
                Serial_No.Text = "";
            }

            try
            {
                int n = dt.Rows.Count;
                string Min = dt.Rows[n - 1]["Barcode"].ToString();
                string Max = dt.Rows[0]["Barcode"].ToString();

                int st = int.Parse(Min.Substring(int.Parse(SerialStart.Text), 9));
                int end = int.Parse(Max.Substring(int.Parse(SerialStart.Text), 9));
                int l = 1, r = 0;
                dataGridView2.Rows.Clear();
                dataGridView2.RowTemplate.Height = 40;
                dataGridView2.RowsDefaultCellStyle.Font = new System.Drawing.Font("Verdana", 17F);
                //dbFunctions.DGVStyle(dataGridView2);
                for (int i = st; i < end; i++)
                {
                    int k = int.Parse(dt.Rows[n - l]["Barcode"].ToString().Substring(int.Parse(SerialStart.Text), int.Parse(SerialEnd.Text)));
                    if (k != i)
                    {
                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[r++].Cells[0].Value = i.ToString("00000");
                    }
                    else
                    {
                        l++;
                    }
                }

                label28.Text = dataGridView2.Rows.Count.ToString();

            }
            catch (Exception ex)
            {
            }

            /*  DataTable Dsp = dbFunctions.getTable("Pr_Fetch_Scan_sno '" + SD_Item_Code.Text + "'");
              if (Dsp.Rows.Count > 0)
              {
                  Serial_No.Text = Dsp.Rows[0]["S_No"].ToString();
              }
              else
              {
                  Serial_No.Text = "-";
              }*/

            try
            {
                int count = 1;
                int len = int.Parse(SerialEnd.Text);
                string S = "";
                int First = int.Parse(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Barcode"].Value.ToString().Substring(int.Parse(SerialStart.Text), int.Parse(SerialEnd.Text)));
                int x = 1;
                int Nxt = 0;
                int Now = 0;

                for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
                {
                    try
                    {

                        Nxt = int.Parse(dataGridView1.Rows[i - 1].Cells["Barcode"].Value.ToString().Substring(int.Parse(SerialStart.Text), int.Parse(SerialEnd.Text)));

                        if (First + x == Nxt)
                        {

                            x++;
                            count++;
                        }
                        else
                        {
                            Now = int.Parse(dataGridView1.Rows[i].Cells["Barcode"].Value.ToString().Substring(int.Parse(SerialStart.Text), int.Parse(SerialEnd.Text)));
                            if (count != 1)
                            {
                                S += "C" + PM_Variant_Code.Text + GetWeekNumber() + "Z" + int.Parse(Line_No.Text) + Round(First, len) + " to " + Round(Now, len) + ",";
                                //S +=  PM_Variant_Code.Text +  Round(First, len) + " to " + Round(Now, len) + ",";
                            }
                            else
                            {
                                //S += "C" + PM_Variant_Code.Text + GetWeekNumber() + "Z" + int.Parse(Line_No.Text) + Round(First, len) + ",";
                                S += "C" + PM_Variant_Code.Text + GetWeekNumber() + "Z" + int.Parse(Line_No.Text) + Round(First, len) + ",";
                                //S +=  PM_Variant_Code.Text +    First  + ",";
                            }

                            First = Nxt;
                            x = 1;
                            count = 1;
                        }

                    }
                    catch (Exception ex) { }



                }

                Now = int.Parse(dataGridView1.Rows[0].Cells["Barcode"].Value.ToString().Substring(int.Parse(SerialStart.Text), int.Parse(SerialEnd.Text)));
                if (count != 1)
                {
                    //S += "C" + PM_Variant_Code.Text + GetWeekNumber() + "Z" + int.Parse(Line_No.Text) + Round(First, len) + " to " + Round(Now, len) + "";
                    S += PM_Variant_Code.Text + GetWeekNumber() + Round(First, len) + " to " + Round(Now, len) + "";
                }
                else
                {
                    //S += "C" + PM_Variant_Code.Text + GetWeekNumber() + "Z" + int.Parse(Line_No.Text)+Round(First, len) + "";
                    S += PM_Variant_Code.Text + GetWeekNumber() + Round(First, len) + "";
                }
                First = Nxt;

                x = 1;

                Serial_No.Text = S;

            }
            catch (Exception ex) { }

        }
        public void valid_()
        {

            String checkSerialNo = textBox1.Text;
            if (checkSerialNo.Length == 14)
            {
                if (char.IsLetter(checkSerialNo[0]) && char.IsLetter(checkSerialNo[1]) && char.IsLetter(checkSerialNo[2]) // First 3 are letters
                    && char.IsDigit(checkSerialNo[3]) && char.IsDigit(checkSerialNo[4]) && char.IsDigit(checkSerialNo[5]) && char.IsDigit(checkSerialNo[6]) // Next 4 are digits
                    && char.IsLetter(checkSerialNo[7])
                    && char.IsDigit(checkSerialNo[8]) && char.IsDigit(checkSerialNo[9]) && char.IsDigit(checkSerialNo[10]) && char.IsDigit(checkSerialNo[11]) && char.IsDigit(checkSerialNo[12]) && char.IsDigit(checkSerialNo[13]))
                {
                    DataTable dd = dbFunctions.getTable("select * from Scan_Details_NEW where  SDN_Barcode='" + textBox1.Text + "'");
                    if (dd.Rows.Count <= 0)
                    {
                        textBox1.Text = checkSerialNo.ToUpper();
                        textBox3.Text = "";
                        textBox3.Enabled = true;
                        Serial_No.Text = textBox1.Text + " to " + textBox3.Text;
                        textBox3.Focus();
                    }
                    else
                    {
                        textBox3.Text = "";
                        textBox3.Enabled = false;
                        Serial_No.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Serial Number should be in Correct Format");
                }
            }
            else
            {
                MessageBox.Show("Serial Number should be in 14 Letters Only");
                //textBox1.Focus();
            }

        }
        public string GetWeekNumber()
        {
            DataTable dt = null;
            if (System.DateTime.Now.ToString("ddMM").Equals("0101"))
            {
                dt = dbFunctions.getTable("select right('00'+  cast(datepart(wk,dateadd(hh,-6,getdate())) as varchar),2)");
            }
            else if ((System.DateTime.Now.Hour >= 6 && System.DateTime.Now.Hour < 24) && DateTime.Now.DayOfWeek.ToString() != "Sunday")
            {
                dt = dbFunctions.getTable("SELECT RIGHT('00' + CAST(DATEPART(WEEK, GETDATE()) AS VARCHAR), 2)");
            }
            else if ((System.DateTime.Now.Hour < 6 && DateTime.Now.DayOfWeek.ToString() == "Monday"))
            {
                dt = dbFunctions.getTable("SELECT RIGHT('00' + CAST(DATEPART(WEEK, DATEADD(DAY, -2, GETDATE())) AS VARCHAR), 2)");
            }
            else
            {
                dt = dbFunctions.getTable("SELECT RIGHT('00' + CAST(DATEPART(WEEK, DATEADD(DAY, -1, GETDATE())) AS VARCHAR), 2)");
            }

            return "" + dt.Rows[0][0];
        }

        public string Round(int Nos, int Len)
        {
            string mystring = "00000000" + Nos;
            return mystring.Substring(mystring.Length - Len);
        }
        public Boolean isTest = false;
        string NG_Sound = System.Configuration.ConfigurationSettings.AppSettings["NG"];
        private void print_Lable()
        {

            if (int.Parse(Txt_Count.Text) > 0)
            {


                string PrinterName = dataClass.printerName.ToString();
                string text = System.IO.File.ReadAllText(dbFunctions.Label_Path);


                DataTable dd = dbFunctions.getTable("select '" + int.Parse(Line_No.Text).ToString("00") + "'+ convert(Varchar,getdate(),112)+ right('0000'+cast(isnull(max(cast(right(Barocde,5)as int)),0)+1 as varchar(33)),5) from Formation_Production_Data where convert(varchar,getdate(),112)=convert(varchar,Crated_Date,112) and left(Barocde,2)='" + int.Parse(Line_No.Text).ToString("00") + "'");
                string bb = dd.Rows[0][0].ToString();

                string ReplaceText1 = text.Replace("@Date@", System.DateTime.Now.ToString("dd/MM/yy HH:mm"));


                if (isTest == true)
                {
                    ReplaceText1 = ReplaceText1.Replace("@Desc@", "TEST");
                    ReplaceText1 = ReplaceText1.Replace("@S_No@", "TEST");
                    ReplaceText1 = ReplaceText1.Replace("@Qty@", "TEST");
                    ReplaceText1 = ReplaceText1.Replace("@Lot@", "");
                    ReplaceText1 = ReplaceText1.Replace("@Line@", "TEST");
                    ReplaceText1 = ReplaceText1.Replace("@Operator@", "TEST");
                    ReplaceText1 = ReplaceText1.Replace("@Inspector@", "TEST");
                    ReplaceText1 = ReplaceText1.Replace("@Barcode@", "");
                    ReplaceText1 = ReplaceText1.Replace("@Barcode1@", "");
                    ReplaceText1 = ReplaceText1.Replace("@Switch@", "TEST");
                    ReplaceText1 = ReplaceText1.Replace("@Remarks@", "TEST");
                }
                else
                {
                    ReplaceText1 = ReplaceText1.Replace("@Desc@", SD_Item_Code.Text);


                    string SNo = Serial_No.Text + "                                                                                                                                                                                                                                                                                                                                                                                                                                            .";

                    ReplaceText1 = ReplaceText1.Replace("@S_No@", SNo.Substring(0, 26));
                    ReplaceText1 = ReplaceText1.Replace("@S1@", SNo.Substring(26, 52));
                    ReplaceText1 = ReplaceText1.Replace("@S2@", SNo.Substring(52, 105));
                    ReplaceText1 = ReplaceText1.Replace("@Qty@", Txt_Count.Text);
                    ReplaceText1 = ReplaceText1.Replace("@Lot@", "");
                    ReplaceText1 = ReplaceText1.Replace("@Line@", "Finishing");
                    ReplaceText1 = ReplaceText1.Replace("@Operator@", SD_Operator.Text);
                    ReplaceText1 = ReplaceText1.Replace("@Bar@", bb);
                    ReplaceText1 = ReplaceText1.Replace("@Inspector@", SD_Inspector.Text);
                    ReplaceText1 = ReplaceText1.Replace("@Barcode@", bb + "~" + Serial_No.Text + "~" + SD_Item_Code.Text + "~" + Switch_on_Date.Text + "~" + Txt_Count.Text + "~" + SD_Inspector.Text);
                    ReplaceText1 = ReplaceText1.Replace("@Barcode1@", Serial_No.Text + "#" + bb + "~" + SD_Item_Code.Text + "~" + Switch_on_Date.Text + "~" + Txt_Count.Text + "~" + SD_Inspector.Text);
                    ReplaceText1 = ReplaceText1.Replace("@Switch@", Switch_on_Date.Text);
                    ReplaceText1 = ReplaceText1.Replace("@Remarks@", Remarks.Text);
                    ReplaceText1 = ReplaceText1.Replace("@model1@", PM_Mold.Text);
                    ReplaceText1 = ReplaceText1.Replace("@Vanno@", SD_van_no.Text);


                }
                RawPrinterHelper.SendStringToPrinter(PrinterName, ReplaceText1);

                DataTable dsd = dbFunctions.getTable("pr_print_MOQ_Label_NEW  '" + bb + "','" + SD_Operator.Text + "','" + SD_Inspector.Text + "','" + Switch_on_Date.Text + "','" + Remarks.Text + "','" + Serial_No.Text + "','" + dbFunctions.Line_No + "','" + SD_Item_Code.Text + "'");

                string FullBarcode = Serial_No.Text + "#" + bb + "~" + SD_Item_Code.Text + "~" + Switch_on_Date.Text + "~" + Txt_Count.Text + "~" + SD_Inspector.Text;

                DataTable dt = dbFunctions.getTable("pr_Update_Scan_Details_Full '" + bb + "','" + FullBarcode.ToString() + "'");

                SD_MOQ_Barcode.Text = "-";



                if (isTest == false)
                {
                    DataTable dsp = dbFunctions.getTable(" insert into Formation_Production_Data ( Barocde,Part_No,Switch_Of,Remarks,S_No,Inpector,Skid_qty,Created_by,Crated_Date,Status,SW_Date, FULL_Barcode ) values ( '" + bb + "', '" + SD_Item_Code.Text + "', '" + Switch_on_Date.Text + "','" + Remarks.Text + "', '" + Serial_No.Text + "' ,'" + SD_Inspector.Text + "', '" + Txt_Count.Text + "','" + dbFunctions.username + "' ,getdate(),'A','" + Switch_on_Date.Value.ToString("dd-MMM-yyyy") + "','" + FullBarcode + "' )");
                    //DataTable dsp1 = dbFunctions.getTable1(" insert into Formation_Production_Data ( Barocde,Part_No,Switch_Of,Remarks,S_No,Inpector,Skid_qty,Created_by,Crated_Date,Status ) values ( '" + bb + "', '" + SD_Item_Code.Text + "', '" + Switch_on_Date.Text + "','" + Remarks.Text + "', '" + Serial_No.Text + "' ,'" + SD_Inspector.Text + "', '" + Txt_Count.Text + "','" + dbFunctions.username + "' ,getdate(),'A' )");
                }
                isTest = false;
                display();
            }
        }

        public string indata = "";
        private void DataReceivedHandler(
                       object sender,
                       SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                // int s= sp.ReadByte();
                //indata =sp.ReadExisting();

                byte[] buf = new byte[sp.BytesToRead];
                //Console.WriteLine("DATA RECEIVED!");
                sp.Read(buf, 0, buf.Length);
                foreach (Byte b in buf)
                {
                    indata += (char)b;
                }

                this.Invoke(new EventHandler(DisplayText));
                indata = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex.Message);
            }

        }
        private void DisplayText(object sender, EventArgs e)
        {
            try
            {

                SD_Barcode.Text = indata;
                //label17.Text = indata;

                key_Data();

            }
            catch (Exception ex)
            {
                label17.Text = ex.Message;
            }
        }

        private void Print_Label_New_Load(object sender, EventArgs e)
        {



            Line_No.Text = dbFunctions.Line_No;

            label33.Text = dataClass.printerName;


            DataTable cd = dbFunctions.getTable("select * from shift_");
            if (cd.Rows.Count > 0)
            {
                textBox2.Text = cd.Rows[0][0].ToString();
            }

            DataTable dt = dbFunctions.getTable("pr_get_Code");
            SD_Item_Code.DataSource = dt;
            SD_Item_Code.DisplayMember = "PM_Item_Code";
            SD_Item_Code.ValueMember = "PM_Item_Code";
            SD_Item_Code.SelectedIndex = -1;
            GET_Incharge();
            GET_Operator();
            Clear();


            cmbPrinter.Text = dataClass.printerName;

            SD_Item_Code.Focus();


            Switch_on_Date.Text = System.DateTime.Now.ToString("dd.MM.yy");

            DataTable dk = dbFunctions.getTable("select * from Old_Data");
            if (dk.Rows.Count > 0)
            {

                SD_Operator.Text = dk.Rows[0][0].ToString();
                SD_Inspector.Text = dk.Rows[0][1].ToString();
            }
            Txt_Count.Text = "0";



            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.RtsEnable = true;

            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            try
            {
                mySerialPort.Open();
            }
            catch (Exception ex)
            {

                label17.Text = ex.Message;
                MessageBox.Show(ex.Message);
            }

            if (dbFunctions.username.ToLower().Equals("admin"))
            {
                button8.Enabled = true;
                checkBox2.Enabled = true;
                checkBox1.Enabled = true;
                button1.Enabled = true;
            }   
        }


        public void Clear()
        {
            textBox1.Text = "";
            textBox3.Text = "";
            SD_Item_Code.Text = "";
            PM_Description.Text = "";
            SD_MOQ_Qty.Text = "";
            SD_Operator.Text = "";
            SD_Inspector.Text = "";
            SD_MOQ_Barcode.Text = "-";
            Last_Barcode = "00000";
            SD_Barcode.Text = "";
            SD_Item_Code.Focus();

            PM_Skid_Qty.Text = "";
            PM_Sector.Text = "";
            PM_Variant_Code.Text = "";
            PM_Mold.Text = "";
        }

        private void SD_Item_Code_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (SD_Item_Code.Text == "" || SD_Item_Code.Text == "System.Data.DataRowView")
                return;
            try
            {
                DataTable dt = dbFunctions.getTable("Pr_Fetch_Product_Master_By_Code  '" + SD_Item_Code.Text + "'");
                PM_Mold.Text = dt.Rows[0]["PM_Mold"].ToString();
                PM_Sector.Text = dt.Rows[0]["PM_Sector"].ToString();
                PM_Description.Text = dt.Rows[0]["PM_Description"].ToString();
                PM_Variant_Code.Text = dt.Rows[0]["PM_Variant_Code"].ToString();
                PM_Skid_Qty.Text = dt.Rows[0]["PM_Skid_Qty"].ToString();
                SD_MOQ_Qty.Text = dt.Rows[0]["PM_MOQ_Qty"].ToString();
                SerialEnd.Text = dt.Rows[0]["SerialEnd"].ToString();

                SerialStart.Text = dt.Rows[0]["SerialStart"].ToString();
                VStart.Text = dt.Rows[0]["VStart"].ToString();
                VEnd.Text = dt.Rows[0]["VEnd"].ToString();
                compare_code.Text = dt.Rows[0]["compare_code"].ToString();

                SD_Barcode.Focus();
                display();
            }
            catch { }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                line_Check = true;
            else
                line_Check = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Last_Barcode = "00000";
            cr_Barcode_Last = "00000";
            SD_Barcode.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isTest = true;
            print_Lable();
            SD_Barcode.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are You Sure Want to Delete Press YES", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DataTable dt = dbFunctions.getTable("delete from Scan_Details where SD_Barcode='" + dataGridView1.SelectedRows[0].Cells["Barcode"].Value.ToString() + "'");
                        display();
                        SD_Barcode.Focus();
                    }
                    catch { }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            print_Lable();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
