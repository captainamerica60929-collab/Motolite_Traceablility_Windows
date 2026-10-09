using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Maintanence_Printing_Tool;


namespace ABD2_Finishing.Transaction
{
    public partial class Transaction_Menu : Form
    {
        //string Rights = "";
        public Transaction_Menu()
        {
            InitializeComponent();
        }

        private void Master_Menu_Load(object sender, EventArgs e)
        {

            LodMenu();
        }


        public void LodMenu()
        {
            DataTable dt = dbFunctions.getTable("Pr_get_ParentMenu 'Dcoument'," + dbFunctions.rights);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                FlowLayoutPanel L1 = new FlowLayoutPanel();
                L1.Location = new System.Drawing.Point(0, 0);
                L1.Margin = new System.Windows.Forms.Padding(0);
                L1.Name = "FL" + i;
                // L1.Size = new System.Drawing.Size(197, 166);
                L1.TabIndex = 0;
                this.MenuPanel.Controls.Add(L1);

                DataTable ds = dbFunctions.getTable("pr_get_Menus_by_Parent_ID  " + dt.Rows[i][0].ToString() + "," + dbFunctions.rights);

                int x = 0;
                for (int j = 0; j < ds.Rows.Count; j++)
                {
                    Button B = new System.Windows.Forms.Button();

                    B.BackColor = System.Drawing.SystemColors.ButtonFace;
                    B.FlatAppearance.BorderSize = 0;
                    B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    B.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    B.ForeColor = System.Drawing.SystemColors.ControlText;
                    B.Image = global::ABD2_Finishing.Properties.Resources.RightArrow;
                    // B.Image = ((System.Drawing.Image)(resources.GetObject("SupplierMaster.Image")));
                    B.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    B.Location = new System.Drawing.Point(-1, 77);
                    B.Size = new System.Drawing.Size(201, 36);
                    B.TabIndex = 25;
                    B.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    B.UseVisualStyleBackColor = false;



                    B.Location = new System.Drawing.Point(0, 0);
                    B.Margin = new System.Windows.Forms.Padding(0);
                    B.Name = "_" + ds.Rows[j]["MM_Menu_Name"].ToString();
                    B.Text = "    " + ds.Rows[j]["MM_Display_Name"].ToString();

                    B.Click += new System.EventHandler(this.B_Click);
                    L1.Controls.Add(B);



                    Button Bar = new System.Windows.Forms.Button();

                    Bar.BackColor = System.Drawing.SystemColors.ButtonFace;
                    Bar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    Bar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    Bar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
                    Bar.Location = new System.Drawing.Point(0, 36);
                    Bar.Size = new System.Drawing.Size(202, 2);
                    Bar.TabIndex = 28;
                    Bar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    Bar.UseVisualStyleBackColor = false;

                    Bar.Location = new System.Drawing.Point(0, 0);
                    Bar.Margin = new System.Windows.Forms.Padding(0);
                    L1.Controls.Add(Bar);

                    x += 38;
                }

                L1.Size = new System.Drawing.Size(197, x);
            }


        }


        void Clear_Buttons()
        {
            foreach (Control ctrl in this.MenuPanel.Controls)
            {
                foreach (Control ctrls in ctrl.Controls)
                {
                    if (ctrls.GetType() == typeof(Button))
                    {
                        // ctrl.ForeColor = System.Drawing.Color.ControlText;
                        if (ctrls.Height == 2)
                        {
                            ctrls.ForeColor = System.Drawing.SystemColors.ButtonShadow;
                            ctrls.BackColor = System.Drawing.SystemColors.ButtonFace;//ButtonFace
                        }
                        else
                        {

                            ctrls.ForeColor = System.Drawing.SystemColors.ControlText;
                            ctrls.BackColor = System.Drawing.SystemColors.ButtonFace;//ButtonFace
                        }
                    }
                }
            }
        }

        public void change_Color(object sender)
        {
            Clear_Buttons();
            Button B = (Button)sender;
            B.ForeColor = System.Drawing.Color.Maroon;
            B.BackColor = System.Drawing.Color.Moccasin;//ButtonFace
            // B.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));


        }


        private void B_Click(object sender, EventArgs e)
        {
            try
            {
                change_Color(sender);

                var button = (Button)sender;

                string Menu_Name = button.Name.ToString().Substring(1, button.Name.ToString().Length - 1);
                Type CAType = Type.GetType("Agri." + Menu_Name);
                Form nextForm2 = (Form)Activator.CreateInstance(CAType);
                // nextForm2.ShowDialog();
                //Ledger_Master ObjContributor_Master = new Ledger_Master();

                BodyPanel.Controls.Clear();

                nextForm2.TopLevel = false;
                nextForm2.FormBorderStyle = FormBorderStyle.None;
                nextForm2.Dock = DockStyle.Fill;
                BodyPanel.Controls.Add(nextForm2);
                nextForm2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        

        public void LoadMaster()
        {
            

          
        }


       
       
    }
}
