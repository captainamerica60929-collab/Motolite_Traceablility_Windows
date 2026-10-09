using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using  ABD2_Finishing.Properties;
using ABD2_Finishing;
using ABD2_Finishing.Transaction;

namespace ABD2_Finishing
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        string Layour_Color = "#2C3B41";
        string Hedaer_BgColor = "#1E282C";
        string Hedaer_foreColor = "#8aa4af";

        string Button_Color = "#8aa4af";
        string Button_focusColor = "#FFFFFF";
        string Button_LossColor = "#8aa4af";

        private void Main_Load(object sender, EventArgs e)
        {
            this.Height = (Screen.PrimaryScreen.WorkingArea.Height);
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            dbFunctions.objPrint_Lable = new Print_Lable();
            panel2.Tag = "Inactinve";

            

            Side_Panel.BackColor = ColorTranslator.FromHtml(Hedaer_BgColor);

            DataTable dt = dbFunctions.getTable("Pr_get_ParentMenu ''," + dbFunctions.rights);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
               

                PictureBox Pic1 = new PictureBox();
                Pic1.Cursor = System.Windows.Forms.Cursors.Hand;

                string ico=dt.Rows[i]["MM_Icon"].ToString();

                object O = Resources.ResourceManager.GetObject("" + ico); 
                Pic1.Image = (Image)O;
             //   Pic1.Image = global::ABD2_Finishing.Properties.Resources.+"RightArrow";
                Pic1.Location = new System.Drawing.Point(7, 7);

                Pic1.Name = "_Picture" + i;
                Pic1.Size = new  System.Drawing.Size(21, 20);
                Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                Pic1.TabIndex = 2;
                Pic1.TabStop = false;

                PictureBox Pic2 = new PictureBox();
                Pic2.Cursor = System.Windows.Forms.Cursors.Hand;
                Pic2.Image = global::ABD2_Finishing.Properties.Resources.Left_Arrow_;
                Pic2.Location = new System.Drawing.Point(185, 8);
                Pic2.Name = "_Pic" + i;
                Pic2.Tag = "Left";
                Pic2.Size = new System.Drawing.Size(23, 19);
                Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                Pic2.TabIndex = 2;
                Pic2.TabStop = false;
                Pic2.Click += new System.EventHandler(this.P_Click); Label L = new Label();

                L.AutoSize = true;
                L.Cursor = System.Windows.Forms.Cursors.Hand;
                L.ForeColor = ColorTranslator.FromHtml(Hedaer_foreColor);
                L.Location = new System.Drawing.Point(33, 8);
                L.Name = "_label"+i;
                L.Size = new System.Drawing.Size(63, 18);
                L.TabIndex = 1;
                L.Click += new System.EventHandler(this.LB_Click);
                L.Text = "" + dt.Rows[i]["MM_Module"].ToString();
                


                Panel Pan = new Panel();
                Pan.Controls.Add(Pic1);
                Pan.Controls.Add(L);
                Pan.Controls.Add(Pic2);
                Pan.Margin = new System.Windows.Forms.Padding(0);
                Pan.Cursor = System.Windows.Forms.Cursors.Hand;
                Pan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Pan.Location = new System.Drawing.Point(0, 0);
                Pan.BackColor = ColorTranslator.FromHtml(Hedaer_BgColor);
                Pan.Name = "_panel" + i;
                Pan.Size = new System.Drawing.Size(230, 40);

                Pan.Click += new System.EventHandler(this.PN_Click);
                Pan.TabIndex = 1;
                Pan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));

                FlowLayoutPanel L1 = new FlowLayoutPanel();
                L1.Location = new System.Drawing.Point(0, 0);
                L1.Margin = new System.Windows.Forms.Padding(0);
                L1.Name = "_FL" + i;
                L1.AutoSize = true;
                L1.TabIndex = 0;
                L1.BackColor = ColorTranslator.FromHtml(Layour_Color);
                L1.Controls.Add(Pan);

              
                this.Side_Panel.Controls.Add(L1);
                
                DataTable ds = dbFunctions.getTable("pr_get_Menus_by_Parent_ID  " + dt.Rows[i][0].ToString() + "," + dbFunctions.rights);

                int x = 0;
                for (int j = 0; j < ds.Rows.Count; j++)
                {
                    Button B = new System.Windows.Forms.Button();

                    B.FlatAppearance.BorderSize = 0;
                    B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    B.Font = new System.Drawing.Font("Verdana", 10F);
                    B.ForeColor = ColorTranslator.FromHtml(Hedaer_foreColor);
                    B.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    B.Location = new System.Drawing.Point(10, 38);
                    B.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
                    B.Image = global::ABD2_Finishing.Properties.Resources.Round1;         
                    B.Size = new System.Drawing.Size(217, 31);
                    B.TabIndex = 0;
                    B.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    B.UseVisualStyleBackColor = true;
                    B.Tag = "Inactive";
                    B.Name = "_" + ds.Rows[j]["MM_Menu_Name"].ToString();
                    B.Text = "    " + ds.Rows[j]["MM_Display_Name"].ToString();
                    
                    B.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));

                    B.Click += new System.EventHandler(this.B_Click);
                    B.MouseEnter += new EventHandler(this.B_MouseEnter);
                    B.MouseLeave += new EventHandler(this.B_MouseLeave);


                    L1.Controls.Add(B);
                }

                
            }

            hide_Button();
        }

        public void hide_Button()
        {
            foreach (Control ctrl in this.Side_Panel.Controls)
            {

              

                foreach (Control ctrls in ctrl.Controls)
                {
                    if (ctrls.GetType() == typeof(Button))
                    {
                        // ctrl.ForeColor = System.Drawing.Color.ControlText;
                        if (ctrls.Height == 31)
                        {
                            ctrls.Visible = false;
                            ctrls.ForeColor = ColorTranslator.FromHtml(Button_LossColor);
                            ctrls.Tag = "Inactive";
                        }
                    }


                }
            }

        }

        public void Inactive_Tag()
       {
           foreach (Control ctrl in this.Side_Panel.Controls)
           {



               foreach (Control ctrls in ctrl.Controls)
               {
                   if (ctrls.GetType() == typeof(Button))
                   {
                       // ctrl.ForeColor = System.Drawing.Color.ControlText;
                       if (ctrls.Height == 31)
                       {
                           ctrls.ForeColor = ColorTranslator.FromHtml(Button_LossColor);
                           ctrls.Tag = "Inactive";
                       }
                   }


               }
           }

       }

        private void B_MouseEnter(object sender, EventArgs e)
       {
           Button b = sender as Button;
           b.ForeColor = ColorTranslator.FromHtml(Button_focusColor);
       }
       
        private void B_MouseLeave(object sender, EventArgs e)
       {

           Button b = sender as Button;
           if (b.Tag.ToString() != "Active")
           {
               b.ForeColor = ColorTranslator.FromHtml(Button_LossColor);
           }
       }
       
        private void P_Click(object sender, EventArgs e)
       {
           hide_Button();

           var button = sender as PictureBox;

           
           string data = button.Name;

           foreach (Control ctrl in this.Side_Panel.Controls)
           {
               if (ctrl.Name == data.Replace("_Pic", "_FL") )
               {
                 Image img= global::ABD2_Finishing.Properties.Resources.Down_Arrow;

                 if (button.Tag.ToString().Equals("Down"))
                 {
                     button.Image = global::ABD2_Finishing.Properties.Resources.Left_Arrow_;
                     button.Tag = "Left";

                     foreach (Control ctrls in ctrl.Controls)
                     {
                         if (ctrls.GetType() == typeof(Button))
                         {
                             // ctrl.ForeColor = System.Drawing.Color.ControlText;
                             if (ctrls.Height == 31)
                             {
                                 ctrls.Visible = false;
                             }
                         }
                     }
                 }
                 else
                 {
                     button.Tag = "Down";
                     button.Image = global::ABD2_Finishing.Properties.Resources.Down_Arrow;

                     foreach (Control ctrls in ctrl.Controls)
                     {
                         if (ctrls.GetType() == typeof(Button))
                         {
                             // ctrl.ForeColor = System.Drawing.Color.ControlText;
                             if (ctrls.Height == 31)
                             {
                                 ctrls.Visible = true;
                             }
                         }
                     }
                 }

                  
               }


           }

           
       }

        private void PN_Click(object sender, EventArgs e)
       {
           hide_Button();

           Panel p=sender as Panel;

           var button = this.Controls.Find(p.Name.ToString().Replace("_panel", "_Pic"), true).FirstOrDefault() as PictureBox;


           string data = button.Name;

           foreach (Control ctrl in this.Side_Panel.Controls)
           {
               if (ctrl.Name == data.Replace("_Pic", "_FL"))
               {
                   Image img = global::ABD2_Finishing.Properties.Resources.Down_Arrow;

                   if (button.Tag.ToString().Equals("Down"))
                   {
                       button.Image = global::ABD2_Finishing.Properties.Resources.Left_Arrow_;
                       button.Tag = "Left";

                       foreach (Control ctrls in ctrl.Controls)
                       {
                           if (ctrls.GetType() == typeof(Button))
                           {
                               // ctrl.ForeColor = System.Drawing.Color.ControlText;
                               if (ctrls.Height == 31)
                               {
                                   ctrls.Visible = false;
                               }
                           }
                       }
                   }
                   else
                   {
                       button.Tag = "Down";
                       button.Image = global::ABD2_Finishing.Properties.Resources.Down_Arrow;

                       foreach (Control ctrls in ctrl.Controls)
                       {
                           if (ctrls.GetType() == typeof(Button))
                           {
                               // ctrl.ForeColor = System.Drawing.Color.ControlText;
                               if (ctrls.Height == 31)
                               {
                                   ctrls.Visible = true;
                               }
                           }
                       }
                   }


               }


           }


       }

       private void LB_Click(object sender, EventArgs e)
       {
           hide_Button();

           Label p = sender as Label;
           //string s = p.Name;

           var button = this.Controls.Find(p.Name.ToString().Replace("_label", "_Pic"), true).FirstOrDefault() as PictureBox;


           string data = button.Name;

           foreach (Control ctrl in this.Side_Panel.Controls)
           {
               if (ctrl.Name == data.Replace("_Pic", "_FL"))
               {
                   Image img = global::ABD2_Finishing.Properties.Resources.Down_Arrow;

                   if (button.Tag.ToString().Equals("Down"))
                   {
                       button.Image = global::ABD2_Finishing.Properties.Resources.Left_Arrow_;
                       button.Tag = "Left";

                       foreach (Control ctrls in ctrl.Controls)
                       {
                           if (ctrls.GetType() == typeof(Button))
                           {
                               // ctrl.ForeColor = System.Drawing.Color.ControlText;
                               if (ctrls.Height == 31)
                               {
                                   ctrls.Visible = false;
                               }
                           }
                       }
                   }
                   else
                   {
                       button.Tag = "Down";
                       button.Image = global::ABD2_Finishing.Properties.Resources.Down_Arrow;

                       foreach (Control ctrls in ctrl.Controls)
                       {
                           if (ctrls.GetType() == typeof(Button))
                           {
                               // ctrl.ForeColor = System.Drawing.Color.ControlText;
                               if (ctrls.Height == 31)
                               {
                                   ctrls.Visible = true;
                               }
                           }
                       }
                   }


               }


           }


       }




        private void B_Click(object sender, EventArgs e)
        {
            try
            {
              //  change_Color(sender);
                Inactive_Tag();
                var button = (Button)sender;
                button.Tag = "Active";
                button.ForeColor = ColorTranslator.FromHtml(Button_focusColor);
                string Menu_Name = button.Name.ToString().Substring(1, button.Name.ToString().Length - 1);
                Type CAType = Type.GetType("ABD2_Finishing." + Menu_Name);

                Form nextForm2 = null;
                if (Menu_Name.ToLower().Equals("transaction.print_lable"))
                {
                    nextForm2 = dbFunctions.objPrint_Lable;
                }
                else
                {
                     nextForm2 = (Form)Activator.CreateInstance(CAType);
                }
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


       

        

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.BringToFront();
            panel2.Tag = "Active";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login objlogin = new Login();
            objlogin.Show();

        }

        
      

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                panel2.Visible = false;
                Side_Panel.Focus();
                
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void label3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            panel2.Visible = false;
        }

     
    }
}
