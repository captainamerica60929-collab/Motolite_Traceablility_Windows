using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABD2_Finishing
{
    public partial class Config_Data : Form
    {
        public Config_Data()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JObject ob = new JObject();
            ob["Server_Name"] = Server_Name.Text;
            ob["User_ID"] = User_Name.Text;
            ob["Password"] = Password.Text;
            ob["DB_Name"] = Databases.Text;

            ob["Line"] = Line_No.Text;
            ob["Pinter"] = Printer_Name.Text;
            ob["Port"] = Port.Text;
            ob["Label"] =Label_File.Text;




            string s = JsonConvert.SerializeObject(ob);
            System.IO.File.WriteAllText(dbFunctions.Con_path, s);
            this.Close();

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

        private void Config_Data_Load(object sender, EventArgs e)
        {

            PrintDocument prtdoc = new PrintDocument();
            string strDefaultPrinter = prtdoc.PrinterSettings.PrinterName;

            foreach (String strPrinter in PrinterSettings.InstalledPrinters)
            {
                Printer_Name.Items.Add(strPrinter);
                if (strPrinter == strDefaultPrinter)
                {
                    Printer_Name.SelectedIndex = Printer_Name.Items.IndexOf(strPrinter);
                }
            }



            try
            {
            string text = System.IO.File.ReadAllText(dbFunctions.Con_path);
            JObject jsonData = JObject.Parse(text);

            dynamic json = jsonData;

            
                Server_Name.Text=isnull(json.Server_Name,"");
                User_Name.Text= isnull(json.User_ID, "");
                Password.Text = isnull(json.Password, "");
                get_db();
                Databases.Text = isnull(json.DB_Name, "");
                 Line_No.Text= isnull(json.Line, "");
                Printer_Name.Text= isnull(json.Pinter, "");
                Port.Text = isnull(json.Port, "");
                Label_File.Text = isnull(json.Label, "");
                
            }
            catch { }




        }

        public List<string> GetDatabaseList()
        {
            
                List<string> list = new List<string>();
                try
                {
                // Open connection to the database
                    string conString = "Data Source="+Server_Name.Text+";Initial Catalog=master;Persist Security Info=True;User ID="+User_Name.Text+";Password="+Password.Text+"";

                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();

                    // Set up a command with the given query and associate
                    // this with the current connection.
                    using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases order by name", con))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                list.Add(dr[0].ToString());
                            }
                        }
                    }
                }
            }
            catch { }
            return list;

        }

  
        private void EM_Email_ID_Leave(object sender, EventArgs e)
        {
           
        }

        private void Server_Name_Leave(object sender, EventArgs e)
        {
            get_db();
        }

        public void get_db()
        {
            Databases.DataSource = GetDatabaseList();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
