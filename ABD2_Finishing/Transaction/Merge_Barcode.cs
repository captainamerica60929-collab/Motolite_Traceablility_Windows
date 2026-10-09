using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using Maintanence_Printing_Tool;
using Shasun_Printing_Toll.Masters;

namespace ABD2_Finishing.Transaction
{
    public partial class Merge_Barcode : Form
    {
        public Merge_Barcode()
        {
            InitializeComponent();
        }

        private void Split_Barcode_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SD_Barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                    DataTable dd = dbFunctions.getTable("select * from Formation_Production_Data where  Barocde ='" + SD_Barcode.Text + "'");
                if(dd.Rows.Count>0)
                {
                    Part_No.Text = dd.Rows[0]["Part_No"].ToString();
                    Switch_Of.Text = dd.Rows[0]["Switch_Of"].ToString();
                    Remarks.Text = dd.Rows[0]["Remarks"].ToString();
                    S_No.Text = dd.Rows[0]["S_No"].ToString();
                    Inpector.Text = dd.Rows[0]["Inpector"].ToString();
                    Skid_qty.Text = dd.Rows[0]["Skid_qty"].ToString();
                    Crated_Date.Text = dd.Rows[0]["Crated_Date"].ToString();
                    Full_Barcode1.Text = dd.Rows[0]["FULL_Barcode"].ToString();

                }
                else
                {
                    Part_No.Text = "";
                    Switch_Of.Text = "";
                    Remarks.Text = "";
                    S_No.Text = "";
                    Inpector.Text = "";
                    Skid_qty.Text = "";
                    MessageBox.Show("Invalid Barcode Sacnned");
                    SD_Barcode.Text = "";
                    Full_Barcode1.Text = "";
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //try
            //{

            //    Tag2.Text = (decimal.Parse(Skid_qty.Text) - decimal.Parse(Tag1.Text)).ToString();
            //}
            //catch {

            //    Tag2.Text = "";
            //}
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           //try{


            if (Barcode2.Text == "")
            {
                MessageBox.Show("Brcode2 Should not be empty");
                return;
            }
            if (SD_Barcode.Text == "")
            {
                MessageBox.Show("Brcode1 Should not be empty");
                return;
            }

            if (SD_Barcode.Text.Trim()== Barcode2.Text.Trim())
            {
                MessageBox.Show("Barcode Should not be Same");
                return;
            }


            try
            {

                DateTime do1 = DateTime.Parse(Switch_Of.Text.Replace("@",""));
            }
            catch {

                MessageBox.Show("Invalid Switch off Date");
                return;
            }

            try
            {
                DateTime d23 = DateTime.Parse(Switchoff_2.Text.Replace("@", ""));
            }
            catch {

                MessageBox.Show("Invalid Switch off Date");
                return;
            }

            if (DateTime.Parse(Switchoff_2.Text.Replace("@", "")) > DateTime.Parse(Switch_Of.Text.Replace("@", "")))
            {
                MessageBox.Show("First Barcode Should Be Less Swithc of Date");
                return;
            }


            string[] tokens = Full_Barcode1.Text.Split('#');

            string New_Full_Barcode = S_No.Text + "," + S_No2.Text + "#" + tokens[1].ToString();

            DataTable d = dbFunctions.getTable("update Formation_Production_Data set Switch_Of='" + Switch_Of.Text + "," + Switchoff_2.Text + "', Skid_qty=" + (decimal.Parse(Skid_qty2.Text) + decimal.Parse(Skid_qty.Text)) + ",S_No='" + S_No.Text + "," + S_No2.Text + "',FULL_Barcode ='"+ New_Full_Barcode + "' where FULL_Barcode='" + Full_Barcode1.Text + "'");

                DataTable ds = dbFunctions.getTable("delete from Formation_Production_Data where   FULL_Barcode='" + Full_Barcode2.Text + "'");


            DataTable di = dbFunctions.getTable("update Scan_Details set SD_FULL_Barcode='" + New_Full_Barcode + "' where  SD_FULL_Barcode='" + Full_Barcode2.Text+"'");


            DataTable dj = dbFunctions.getTable("update Scan_Details set SD_FULL_Barcode='" + New_Full_Barcode + "' where  SD_FULL_Barcode='" + Full_Barcode1.Text + "'");

            //DataTable dd = dbFunctions.getTable("select '" + int.Parse(SD_Barcode.Text.Substring(0, 2)).ToString("00") + "'+ convert(Varchar,cast( '" + Crated_Date.Text + "' as datetime),112)+ right('0000'+cast(isnull(max(cast(right(Barocde,5)as int)),0)+1 as varchar(33)),5) from Formation_Production_Data where convert(varchar,cast( '" + Crated_Date.Text + "' as datetime),112)=convert(varchar,Crated_Date,112) and left(Barocde,2)='" + int.Parse(SD_Barcode.Text.Substring(0, 2)).ToString("00") + "'");
            //string bb = dd.Rows[0][0].ToString();

            //DataTable dsp = dbFunctions.getTable(" insert into Formation_Production_Data ( Barocde,Part_No,Switch_Of,Remarks,S_No,Inpector,Skid_qty,Created_by,Crated_Date,Status ) values ( '" + bb + "', '" + Part_No.Text + "', '" + Switch_Of.Text + "','" + Remarks.Text + "', '" + Tag2_Serial_No.Text + "' ,'" + Inpector.Text + "', '" + Tag2.Text + "','" + dbFunctions.username + "' ,'" +DateTime.Parse(Crated_Date.Text).ToString("dd-MMM-yyyy hh:mm tt")+ "','A' )");


            //   DataTable dp = dbFunctions.getTable("select * from Scan_Details where SD_MOQ_Barcode='"+SD_Barcode.Text+"'");
            //   for (int i = int.Parse(Tag1.Text); i <dp.Rows.Count; i++)
            //   {

            //       DataTable di = dbFunctions.getTable("update Scan_Details set SD_MOQ_Barcode='" + bb + "' where  SD_ID=" + dp.Rows[i]["SD_ID"].ToString());

            //   }

            MessageBox.Show("Label Merge Success");
             print_Lable(New_Full_Barcode);
             this.Close();
            //   print_Lable(bb);
        }


        private void print_Lable(string Data)
        {

            DataTable dd = dbFunctions.getTable("select * from Formation_Production_Data where FULL_Barcode='" + Data+"'");
            if (dd.Rows.Count > 0)
            {

                string PrinterName = dataClass.printerName.ToString();
                string text = System.IO.File.ReadAllText(dbFunctions.Label_Path);



                string ReplaceText1 = text.Replace("@Date@", dd.Rows[0]["Crated_Date"].ToString());



                ReplaceText1 = ReplaceText1.Replace("@Desc@", dd.Rows[0]["Part_No"].ToString());


                string SNo = dd.Rows[0]["S_No"].ToString() + "                                                                                                                                                                                                                                                                                                                                                                                                                                            .";

                ReplaceText1 = ReplaceText1.Replace("@S_No@", SNo.Substring(0, 26));
                ReplaceText1 = ReplaceText1.Replace("@S1@", SNo.Substring(26, 52));
                ReplaceText1 = ReplaceText1.Replace("@S2@", SNo.Substring(52, 105));
                ReplaceText1 = ReplaceText1.Replace("@Qty@", dd.Rows[0]["Skid_Qty"].ToString());
                ReplaceText1 = ReplaceText1.Replace("@Lot@", "");
                ReplaceText1 = ReplaceText1.Replace("@Line@", "Finishing");
                ReplaceText1 = ReplaceText1.Replace("@Operator@", dd.Rows[0]["Inpector"].ToString());
                ReplaceText1 = ReplaceText1.Replace("@Bar@", dd.Rows[0]["Barocde"].ToString());
                ReplaceText1 = ReplaceText1.Replace("@Inspector@", dd.Rows[0]["Inpector"].ToString());
                ReplaceText1 = ReplaceText1.Replace("@Barcode@", dd.Rows[0]["Barocde"].ToString() + "~" + dd.Rows[0]["S_No"].ToString() + "~" + dd.Rows[0]["Part_No"].ToString() + "~" + dd.Rows[0]["Switch_of"].ToString() + "~" + dd.Rows[0]["Skid_Qty"].ToString() + "~" + dd.Rows[0]["Inpector"].ToString());
                ReplaceText1 = ReplaceText1.Replace("@Barcode1@", dd.Rows[0]["FULL_Barcode"].ToString());
                ReplaceText1 = ReplaceText1.Replace("@Switch@", dd.Rows[0]["Switch_of"].ToString());
                ReplaceText1 = ReplaceText1.Replace("@Remarks@", dd.Rows[0]["Remarks"].ToString());

                RawPrinterHelper.SendStringToPrinter(PrinterName, ReplaceText1);

            }
            
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                DataTable dd = dbFunctions.getTable("select * from Formation_Production_Data where  Barocde='" + Barcode2.Text + "'");
                if (dd.Rows.Count > 0)
                {
                    Part_No2.Text = dd.Rows[0]["Part_No"].ToString();
                    Switchoff_2.Text = dd.Rows[0]["Switch_Of"].ToString();
                    Remarks2.Text = dd.Rows[0]["Remarks"].ToString();
                    S_No2.Text = dd.Rows[0]["S_No"].ToString();
                    Inpector2.Text = dd.Rows[0]["Inpector"].ToString();
                    Skid_qty2.Text = dd.Rows[0]["Skid_qty"].ToString();
                    Crated_Date2.Text = dd.Rows[0]["Crated_Date"].ToString();
                    Full_Barcode2.Text = dd.Rows[0]["FULL_Barcode"].ToString();

                }
                else
                {
                    Part_No2.Text = "";
                    Switchoff_2.Text = "";
                    Remarks2.Text = "";
                    S_No2.Text = "";
                    Inpector2.Text = "";
                    Skid_qty2.Text = "";
                    Crated_Date2.Text = "";
                    Full_Barcode2.Text = "";
                    MessageBox.Show("Invalid Barcode Sacnned");
                    
                    Barcode2.Text = "";
                    Barcode2.Focus();
                }
            }
        }
    

      

    }
}
