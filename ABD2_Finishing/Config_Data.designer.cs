namespace ABD2_Finishing
{
    partial class Config_Data
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config_Data));
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.User_Name = new System.Windows.Forms.TextBox();
            this.Server_Name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.vinLabel1 = new VINCONTROL.VinLabel();
            this.Databases = new VINCONTROL.VinComboBox();
            this.vinLabel12 = new VINCONTROL.VinLabel();
            this.vinLabel11 = new VINCONTROL.VinLabel();
            this.vinLabel7 = new VINCONTROL.VinLabel();
            this.button10 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.vinLabel2 = new VINCONTROL.VinLabel();
            this.Port = new System.Windows.Forms.TextBox();
            this.vinLabel3 = new VINCONTROL.VinLabel();
            this.Label_File = new System.Windows.Forms.TextBox();
            this.vinLabel4 = new VINCONTROL.VinLabel();
            this.Printer_Name = new VINCONTROL.VinComboBox();
            this.Line_No = new System.Windows.Forms.TextBox();
            this.vinLabel5 = new VINCONTROL.VinLabel();
            this.panel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Controls.Add(this.button10);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(632, 422);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Line_No);
            this.groupBox1.Controls.Add(this.vinLabel5);
            this.groupBox1.Controls.Add(this.Printer_Name);
            this.groupBox1.Controls.Add(this.Label_File);
            this.groupBox1.Controls.Add(this.vinLabel4);
            this.groupBox1.Controls.Add(this.Port);
            this.groupBox1.Controls.Add(this.vinLabel3);
            this.groupBox1.Controls.Add(this.vinLabel2);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.User_Name);
            this.groupBox1.Controls.Add(this.Server_Name);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.vinLabel1);
            this.groupBox1.Controls.Add(this.Databases);
            this.groupBox1.Controls.Add(this.vinLabel12);
            this.groupBox1.Controls.Add(this.vinLabel11);
            this.groupBox1.Controls.Add(this.vinLabel7);
            this.groupBox1.Location = new System.Drawing.Point(27, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 350);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Config";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(179, 103);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(312, 26);
            this.Password.TabIndex = 101;
            this.Password.Leave += new System.EventHandler(this.Server_Name_Leave);
            // 
            // User_Name
            // 
            this.User_Name.Location = new System.Drawing.Point(179, 73);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(312, 26);
            this.User_Name.TabIndex = 100;
            this.User_Name.Leave += new System.EventHandler(this.Server_Name_Leave);
            // 
            // Server_Name
            // 
            this.Server_Name.Location = new System.Drawing.Point(179, 41);
            this.Server_Name.Name = "Server_Name";
            this.Server_Name.Size = new System.Drawing.Size(312, 26);
            this.Server_Name.TabIndex = 99;
            this.Server_Name.Leave += new System.EventHandler(this.Server_Name_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 38);
            this.button1.TabIndex = 97;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vinLabel1
            // 
            this.vinLabel1.AutoSize = true;
            this.vinLabel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel1.Location = new System.Drawing.Point(78, 74);
            this.vinLabel1.Name = "vinLabel1";
            this.vinLabel1.Size = new System.Drawing.Size(93, 19);
            this.vinLabel1.TabIndex = 96;
            this.vinLabel1.Text = "User Name :";
            // 
            // Databases
            // 
            this.Databases.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Databases.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Databases.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Databases.FormattingEnabled = true;
            this.Databases.ID = "0";
            this.Databases.Location = new System.Drawing.Point(179, 135);
            this.Databases.Name = "Databases";
            this.Databases.ResetOnClear = false;
            this.Databases.Size = new System.Drawing.Size(312, 27);
            this.Databases.TabIndex = 4;
            // 
            // vinLabel12
            // 
            this.vinLabel12.AutoSize = true;
            this.vinLabel12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel12.Location = new System.Drawing.Point(86, 104);
            this.vinLabel12.Name = "vinLabel12";
            this.vinLabel12.Size = new System.Drawing.Size(85, 19);
            this.vinLabel12.TabIndex = 94;
            this.vinLabel12.Text = "Password :";
            // 
            // vinLabel11
            // 
            this.vinLabel11.AutoSize = true;
            this.vinLabel11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel11.Location = new System.Drawing.Point(46, 138);
            this.vinLabel11.Name = "vinLabel11";
            this.vinLabel11.Size = new System.Drawing.Size(125, 19);
            this.vinLabel11.TabIndex = 91;
            this.vinLabel11.Text = "Database Name :";
            // 
            // vinLabel7
            // 
            this.vinLabel7.AutoSize = true;
            this.vinLabel7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel7.Location = new System.Drawing.Point(33, 41);
            this.vinLabel7.Name = "vinLabel7";
            this.vinLabel7.Size = new System.Drawing.Size(138, 19);
            this.vinLabel7.TabIndex = 86;
            this.vinLabel7.Text = "SQL Server Name :";
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(547, -1);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(81, 30);
            this.button10.TabIndex = 0;
            this.button10.Text = "Close";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Firebrick;
            this.panel7.Location = new System.Drawing.Point(9, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(12, 13);
            this.panel7.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cofiguration";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(5, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 2);
            this.panel1.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel8.Location = new System.Drawing.Point(5, 31);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(623, 2);
            this.panel8.TabIndex = 1;
            // 
            // vinLabel2
            // 
            this.vinLabel2.AutoSize = true;
            this.vinLabel2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel2.Location = new System.Drawing.Point(61, 171);
            this.vinLabel2.Name = "vinLabel2";
            this.vinLabel2.Size = new System.Drawing.Size(110, 19);
            this.vinLabel2.TabIndex = 102;
            this.vinLabel2.Text = "Printer Name :";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(179, 200);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(312, 26);
            this.Port.TabIndex = 105;
            // 
            // vinLabel3
            // 
            this.vinLabel3.AutoSize = true;
            this.vinLabel3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel3.Location = new System.Drawing.Point(93, 201);
            this.vinLabel3.Name = "vinLabel3";
            this.vinLabel3.Size = new System.Drawing.Size(78, 19);
            this.vinLabel3.TabIndex = 104;
            this.vinLabel3.Text = "Comport :";
            // 
            // Label_File
            // 
            this.Label_File.Location = new System.Drawing.Point(179, 262);
            this.Label_File.Name = "Label_File";
            this.Label_File.Size = new System.Drawing.Size(312, 26);
            this.Label_File.TabIndex = 107;
            // 
            // vinLabel4
            // 
            this.vinLabel4.AutoSize = true;
            this.vinLabel4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel4.Location = new System.Drawing.Point(87, 263);
            this.vinLabel4.Name = "vinLabel4";
            this.vinLabel4.Size = new System.Drawing.Size(84, 19);
            this.vinLabel4.TabIndex = 106;
            this.vinLabel4.Text = "Label File :";
            // 
            // Printer_Name
            // 
            this.Printer_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Printer_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Printer_Name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Printer_Name.FormattingEnabled = true;
            this.Printer_Name.ID = "0";
            this.Printer_Name.Location = new System.Drawing.Point(179, 167);
            this.Printer_Name.Name = "Printer_Name";
            this.Printer_Name.ResetOnClear = false;
            this.Printer_Name.Size = new System.Drawing.Size(312, 27);
            this.Printer_Name.TabIndex = 108;
            // 
            // Line_No
            // 
            this.Line_No.Location = new System.Drawing.Point(179, 231);
            this.Line_No.Name = "Line_No";
            this.Line_No.Size = new System.Drawing.Size(312, 26);
            this.Line_No.TabIndex = 110;
            // 
            // vinLabel5
            // 
            this.vinLabel5.AutoSize = true;
            this.vinLabel5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel5.Location = new System.Drawing.Point(100, 233);
            this.vinLabel5.Name = "vinLabel5";
            this.vinLabel5.Size = new System.Drawing.Size(71, 19);
            this.vinLabel5.TabIndex = 109;
            this.vinLabel5.Text = "Line No :";
            // 
            // Config_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 422);
            this.ControlBox = false;
            this.Controls.Add(this.panel6);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Config_Data";
            this.Load += new System.EventHandler(this.Config_Data_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private VINCONTROL.VinLabel vinLabel1;
        private VINCONTROL.VinComboBox Databases;
        private VINCONTROL.VinLabel vinLabel12;
        private VINCONTROL.VinLabel vinLabel11;
        private VINCONTROL.VinLabel vinLabel7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox User_Name;
        private System.Windows.Forms.TextBox Server_Name;
        private VINCONTROL.VinComboBox Printer_Name;
        private System.Windows.Forms.TextBox Label_File;
        private VINCONTROL.VinLabel vinLabel4;
        private System.Windows.Forms.TextBox Port;
        private VINCONTROL.VinLabel vinLabel3;
        private VINCONTROL.VinLabel vinLabel2;
        private System.Windows.Forms.TextBox Line_No;
        private VINCONTROL.VinLabel vinLabel5;
    }
}