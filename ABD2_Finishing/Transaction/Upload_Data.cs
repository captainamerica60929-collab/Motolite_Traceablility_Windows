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

namespace ABD2_Finishing.Transaction
{
    public partial class Upload_Data : Form
    {
        public Upload_Data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            openFileDialog1.Filter = "xls File|*.xls";
            openFileDialog1.FilterIndex = 2;
            DialogResult dlgResult = dlg.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                txtFile.Text = dlg.FileName;
            }

            string xslPath = txtFile.Text.Trim();
            string query = "SELECT * from [" + "Sheet1" + "$A01:Z9000]";
            DataTable dt = getFromExcel(xslPath, query);

            // dataGridView1.Columns.Remove("Select");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
        }

        private DataTable getFromExcel(string ExcelPath, string query)
        {
            DataTable dt = new DataTable();

            DataColumn col = dt.Columns.Add("RowNumber", typeof(int));
            col.AutoIncrementSeed = 1;
            col.AutoIncrement = true;

            string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ExcelPath + ";Extended Properties=Excel 12.0;";
            //string cs = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + ExcelPath + @"; Extended Properties=""Excel 8.0;IMEX=0; HDR=YES""";

            OleDbConnection con = new OleDbConnection(cs);

            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            
            
            insert();
        }

        public void insert()
        {

            DataTable dd = dbFunctions.getTable("delete from   Production_Plan where convert(varchar,Plan_Date,112)='"+Plan_Date.Value.ToString("yyyyMMdd")+"'");
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                SqlConnection con = new SqlConnection(dbFunctions.connectionstring);
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    com.Connection = con;
                    com.CommandType = CommandType.Text;
                    com.CommandText = "insert into Production_Plan (MIS_Qty,Switch_off_Qty,Plan_Date,Part_No,Plan_Qty,Created_by,Created_Date,Status) Values (@MIS_Qty,@Switch_off_Qty,@Plan_Date,@Part_No,@Plan_Qty,@Created_by,getdate(),'A')";
                    com.Parameters.Add("@Plan_Date", SqlDbType.VarChar).Value = Plan_Date.Value.ToString("dd-MMM-yyyy");
                    com.Parameters.Add("@Part_No", SqlDbType.VarChar).Value = dataGridView1.Rows[i].Cells["Part No"].Value.ToString();
                    com.Parameters.Add("@Plan_Qty", SqlDbType.VarChar).Value = dataGridView1.Rows[i].Cells["Plan Qty"].Value.ToString();

                    com.Parameters.Add("@MIS_Qty", SqlDbType.VarChar).Value = "0";

                    com.Parameters.Add("@Switch_off_Qty", SqlDbType.VarChar).Value = "0";
                    com.Parameters.Add("@Created_by", SqlDbType.VarChar).Value = dbFunctions.username;

                    com.ExecuteNonQuery();
                    com.Connection.Close();
                  
                }
                catch (Exception Ex)
                {
                    dbFunctions.Logs(Ex.Message, dbFunctions.username);
                    MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            MessageBox.Show("Recode Saved Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Supply_Invoice_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataTable dt = dbFunctions.getTable("select '' as [Part No],'' as [Plan Qty]");
            dataGridView2.DataSource = dt;
            Cursor.Current = Cursors.WaitCursor;
            dbFunctions.ExportExcel(dataGridView2);
            Cursor.Current = Cursors.Default;
           
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

    }
}
