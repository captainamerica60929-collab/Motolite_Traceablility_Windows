namespace ABD2_Finishing.Setting
{
    partial class Rights_Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rights_Master));
            this.panel6 = new System.Windows.Forms.Panel();
            this.RA_Rights_ID = new VINCONTROL.VinComboBox();
            this.vinLabel7 = new VINCONTROL.VinLabel();
            this.button10 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Module = new VINCONTROL.VinComboBox();
            this.vinLabel1 = new VINCONTROL.VinLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Save = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Display = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Menu_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MM_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.checkBox4);
            this.panel6.Controls.Add(this.checkBox3);
            this.panel6.Controls.Add(this.checkBox2);
            this.panel6.Controls.Add(this.checkBox1);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.Module);
            this.panel6.Controls.Add(this.vinLabel1);
            this.panel6.Controls.Add(this.RA_Rights_ID);
            this.panel6.Controls.Add(this.vinLabel7);
            this.panel6.Controls.Add(this.button10);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(963, 387);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // RA_Rights_ID
            // 
            this.RA_Rights_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.RA_Rights_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.RA_Rights_ID.Font = new System.Drawing.Font("Verdana", 10F);
            this.RA_Rights_ID.FormattingEnabled = true;
            this.RA_Rights_ID.Location = new System.Drawing.Point(101, 50);
            this.RA_Rights_ID.Name = "RA_Rights_ID";
            this.RA_Rights_ID.Size = new System.Drawing.Size(183, 24);
            this.RA_Rights_ID.TabIndex = 1;
            this.RA_Rights_ID.SelectedIndexChanged += new System.EventHandler(this.MM_Module_SelectedIndexChanged);
            // 
            // vinLabel7
            // 
            this.vinLabel7.AutoSize = true;
            this.vinLabel7.Font = new System.Drawing.Font("Verdana", 10F);
            this.vinLabel7.Location = new System.Drawing.Point(15, 53);
            this.vinLabel7.Name = "vinLabel7";
            this.vinLabel7.Size = new System.Drawing.Size(86, 17);
            this.vinLabel7.TabIndex = 86;
            this.vinLabel7.Text = "User Role :";
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
            this.button10.Location = new System.Drawing.Point(876, -1);
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
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Menu Master";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(5, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 2);
            this.panel1.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel8.Location = new System.Drawing.Point(5, 31);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(952, 2);
            this.panel8.TabIndex = 1;
            // 
            // Module
            // 
            this.Module.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Module.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Module.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Module.Font = new System.Drawing.Font("Verdana", 10F);
            this.Module.FormattingEnabled = true;
            this.Module.Items.AddRange(new object[] {
            "1",
            "2"});
            this.Module.Location = new System.Drawing.Point(358, 50);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(211, 24);
            this.Module.TabIndex = 108;
            this.Module.SelectedIndexChanged += new System.EventHandler(this.vinComboBox1_SelectedIndexChanged);
            // 
            // vinLabel1
            // 
            this.vinLabel1.AutoSize = true;
            this.vinLabel1.Font = new System.Drawing.Font("Verdana", 9F);
            this.vinLabel1.Location = new System.Drawing.Point(293, 55);
            this.vinLabel1.Name = "vinLabel1";
            this.vinLabel1.Size = new System.Drawing.Size(61, 14);
            this.vinLabel1.TabIndex = 109;
            this.vinLabel1.Text = "Module :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 110;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MM_ID,
            this.Parent,
            this.Menu_Name,
            this.Display,
            this.Save,
            this.Edit,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(4, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(953, 255);
            this.dataGridView1.TabIndex = 111;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(687, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 112;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Delete
            // 
            this.Delete.FalseValue = "0";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.TrueValue = "1";
            // 
            // Edit
            // 
            this.Edit.FalseValue = "0";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.TrueValue = "1";
            // 
            // Save
            // 
            this.Save.FalseValue = "0";
            this.Save.HeaderText = "Save";
            this.Save.Name = "Save";
            this.Save.TrueValue = "1";
            // 
            // Display
            // 
            this.Display.FalseValue = "0";
            this.Display.HeaderText = "Display";
            this.Display.Name = "Display";
            this.Display.TrueValue = "1";
            // 
            // Menu_Name
            // 
            this.Menu_Name.HeaderText = "Menu_Name";
            this.Menu_Name.Name = "Menu_Name";
            // 
            // Parent
            // 
            this.Parent.HeaderText = "Parent";
            this.Parent.Name = "Parent";
            // 
            // MM_ID
            // 
            this.MM_ID.HeaderText = "MM_ID";
            this.MM_ID.Name = "MM_ID";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.Location = new System.Drawing.Point(554, 95);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 30);
            this.checkBox1.TabIndex = 113;
            this.checkBox1.Text = "Display";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.Location = new System.Drawing.Point(654, 95);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(100, 30);
            this.checkBox2.TabIndex = 114;
            this.checkBox2.Text = "Save";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox3.Location = new System.Drawing.Point(754, 95);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(100, 30);
            this.checkBox3.TabIndex = 115;
            this.checkBox3.Text = "Edit";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox4.Location = new System.Drawing.Point(854, 95);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(100, 30);
            this.checkBox4.TabIndex = 116;
            this.checkBox4.Text = "Delete";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // Rights_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 387);
            this.Controls.Add(this.panel6);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Rights_Master";
            this.Text = "Rights_Master";
            this.Load += new System.EventHandler(this.Rights_Master_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private VINCONTROL.VinComboBox Module;
        private VINCONTROL.VinLabel vinLabel1;
        private VINCONTROL.VinComboBox RA_Rights_ID;
        private VINCONTROL.VinLabel vinLabel7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MM_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu_Name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Display;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Save;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Edit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Delete;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}