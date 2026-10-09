using Maintanence_Printing_Tool;
using Shasun_Printing_Toll.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABD2_Finishing.Transaction
{
    public partial class Barcode_Print : Form
    {
        string Label = System.Configuration.ConfigurationSettings.AppSettings["Barcode"];
        public Barcode_Print()
        {
            InitializeComponent();
        }

        private void SD_Item_Code_Leave(object sender, EventArgs e)
        {
           
        }

        private void Barcode_KeyDown(object sender, KeyEventArgs e)
        {
        
        }
        private void PrintBarcode()
        {

            //if (Barcode_Scan.Text.Length <= 1)
            //{
            //    MessageBox.Show("Barcode value too short");
            //    return;
            //}

            int printCount = int.Parse(Count.Text);

            if (printCount <= 0)
            {
                MessageBox.Show("Invalid print count");
                return;
            }

            //if (string.IsNullOrWhiteSpace(Barcode_Scan.Text))
            //{
            //    //MessageBox.Show("Please scan barcode");
            //    //Barcode_Scan.Focus();
            //    //return;
            //}

            string printerName = dataClass.printerName;
            string prnPath = @"C:\Barcode.prn";

            if (!File.Exists(prnPath))
            {
                MessageBox.Show("PRN file not found");
                return;
            }

            string prnText = File.ReadAllText(prnPath);

            for (int i = 1; i <= printCount; i++)
            {
                string printData = prnText.Replace("@N600011@", Barcode_Scan.Text.Trim());
                RawPrinterHelper.SendStringToPrinter(printerName, printData);
            }

            Barcode_Scan.Clear();   // clear AFTER all prints
            Barcode_Scan.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Barcode_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Stop beep
                PrintBarcode();
            }

            // Clear textbox after print
            Barcode_Scan.Text = string.Empty;
        }

        private void Barcode_Scan_TextChanged(object sender, EventArgs e)
        {

        }

        private void Barcode_Print_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            PrintBarcode();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //if (Barcode_Scan.Text.Length <= 1)
            //{
            //    MessageBox.Show("Barcode value too short");
            //    return;
            //}

            int printCount = int.Parse(Count.Text);

            if (printCount <= 0)
            {
                MessageBox.Show("Invalid print count");
                return;
            }

            //if (string.IsNullOrWhiteSpace(Barcode_Scan.Text))
            //{
            //    //MessageBox.Show("Please scan barcode");
            //    //Barcode_Scan.Focus();
            //    //return;
            //}

            string printerName = dataClass.printerName;
            string prnPath = @"C:\Barcode.prn";

            if (!File.Exists(prnPath))
            {
                MessageBox.Show("PRN file not found");
                return;
            }

            string prnText = File.ReadAllText(prnPath);

            for (int i = 1; i <= printCount; i++)
            {
                string printData = prnText.Replace("@N600011@", Barcode_Scan.Text.Trim());
                RawPrinterHelper.SendStringToPrinter(printerName, printData);
            }

            Barcode_Scan.Clear();   // clear AFTER all prints
            Barcode_Scan.Focus();
        }

        private void Barcode_Scan_TextChanged_1(object sender, EventArgs e)
        {
            //PrintBarcode();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //if (Barcode_Scan.Text.Length <= 1)
            //{
            //    MessageBox.Show("Barcode value too short");
            //    return;
            //}

            int printCount = int.Parse(Count1.Text);

            if (printCount <= 0)
            {
                MessageBox.Show("Invalid print count");
                return;
            }

            //if (string.IsNullOrWhiteSpace(Barcode_Scan2.Text))
            //{
            //    //MessageBox.Show("Please scan barcode");
            //    //Barcode_Scan.Focus();
            //    //return;
            //}

            string printerName = dataClass.printerName;
            string prnPath = @"C:\Barcode2.prn";

            if (!File.Exists(prnPath))
            {
                MessageBox.Show("PRN file not found");
                return;
            }

            string prnText = File.ReadAllText(prnPath);

            for (int i = 1; i <= printCount; i++)
            {
                string printData = prnText
                    .Replace("@38B20R0126IN600013@", Barcode_Scan2.Text.Trim())
                    .Replace("@Model@", Model.Text.Trim())
                    .Replace("@DATE@", DateTime.Now.ToString("MM'/'yy"))
                    .Replace("@DATE1@", DateTime.Now.ToString("MMyy"))
                    .Replace("@Type@", Type.Text.Trim());


                RawPrinterHelper.SendStringToPrinter(printerName, printData);

            }

            Barcode_Scan2.Clear();   // clear AFTER all prints
            Barcode_Scan2.Focus();
            Model.Text = "";
            Type.Text = "";
        }

        private void Barcode_Scan2_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = dbFunctions.getTable("pr_get_Serial_No_Details '" + Barcode_Scan2.Text.Trim() + "'");

            if (dt != null && dt.Rows.Count > 0)
            {
                Model.Text = dt.Rows[0]["PM_Mold"].ToString();
                Type.Text = dt.Rows[0]["Type"].ToString();

            }
            else
            {
                Model.Text = string.Empty;   
                                            
            }
        }

        private void Barcode_Scan_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Barcode_Scan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PrintBarcode();
            }
        }
        private void PrintBarcode1()
        {

            int printCount = int.Parse(Count1.Text);

            if (printCount <= 0)
            {
                MessageBox.Show("Invalid print count");
                return;
            }



            string printerName = dataClass.printerName;
            string prnPath = @"C:\Barcode2.prn";

            if (!File.Exists(prnPath))
            {
                MessageBox.Show("PRN file not found");
                return;
            }

            string prnText = File.ReadAllText(prnPath);

            for (int i = 1; i <= printCount; i++)
            {
                string printData = prnText
                    .Replace("@38B20R0126IN600013@", Barcode_Scan2.Text.Trim())
                    .Replace("@Model@", Model.Text.Trim())
                    .Replace("@DATE@", DateTime.Now.ToString("MM'/'yy"))
                    .Replace("@DATE1@", DateTime.Now.ToString("MMyy"))
                    .Replace("@Type@", Type.Text.Trim());


                RawPrinterHelper.SendStringToPrinter(printerName, printData);

            }

            Barcode_Scan2.Clear();   // clear AFTER all prints
            Barcode_Scan2.Focus();
            Model.Text = "";
            Type.Text = "";

        }
        private void Barcode_Scan2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PrintBarcode1();
            }

        }
    }
    }
