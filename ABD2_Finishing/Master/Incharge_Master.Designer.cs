namespace ABD2_Finishing.Master
{
    partial class Incharge_Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incharge_Master));
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.CM_CustomerName = new VINCONTROL.VinTextBox();
            this.vinLabel14 = new VINCONTROL.VinLabel();
            this.CM_State = new VINCONTROL.VinTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ArrowButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CM_PAN_No = new VINCONTROL.VinTextBox();
            this.vinLabel7 = new VINCONTROL.VinLabel();
            this.vinLabel6 = new VINCONTROL.VinLabel();
            this.CM_GSTNo = new VINCONTROL.VinTextBox();
            this.vinLabel5 = new VINCONTROL.VinLabel();
            this.CM_Email = new VINCONTROL.VinTextBox();
            this.CM_Phone2 = new VINCONTROL.VinTextBox();
            this.vinLabel8 = new VINCONTROL.VinLabel();
            this.CM_Phone1 = new VINCONTROL.VinTextBox();
            this.vinLabel9 = new VINCONTROL.VinLabel();
            this.CM_Pincode = new VINCONTROL.VinTextBox();
            this.vinLabel11 = new VINCONTROL.VinLabel();
            this.CM_Website = new VINCONTROL.VinTextBox();
            this.vinLabel13 = new VINCONTROL.VinLabel();
            this.CM_Country = new VINCONTROL.VinTextBox();
            this.vinLabel4 = new VINCONTROL.VinLabel();
            this.CM_StateCode = new VINCONTROL.VinTextBox();
            this.vinLabel3 = new VINCONTROL.VinLabel();
            this.CM_City = new VINCONTROL.VinTextBox();
            this.vinLabel2 = new VINCONTROL.VinLabel();
            this.CM_Address = new VINCONTROL.VinTextBox();
            this.vinLabel1 = new VINCONTROL.VinLabel();
            this.vinLabel12 = new VINCONTROL.VinLabel();
            this.CM_Code = new VINCONTROL.VinTextBox();
            this.vinLabel10 = new VINCONTROL.VinLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(65, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 19);
            this.label3.TabIndex = 3433;
            this.label3.Text = "*";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX1.Location = new System.Drawing.Point(82, 2);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(276, 24);
            this.textBoxX1.TabIndex = 5;
            this.textBoxX1.WatermarkColor = System.Drawing.Color.Gray;
            this.textBoxX1.WatermarkText = "Search";
            this.textBoxX1.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CM_CustomerName
            // 
            this.CM_CustomerName.BackColor = System.Drawing.Color.White;
            this.CM_CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CM_CustomerName.CharacterInput = VINCONTROL.VinTextBox.Cinput.ALLKEYBOARDKEYS;
            this.CM_CustomerName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CM_CustomerName.ForeColor = System.Drawing.Color.Black;
            this.CM_CustomerName.InputValueYesNo = null;
            this.CM_CustomerName.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.CM_CustomerName.Location = new System.Drawing.Point(160, 79);
            this.CM_CustomerName.Name = "CM_CustomerName";
            this.CM_CustomerName.Size = new System.Drawing.Size(316, 26);
            this.CM_CustomerName.TabIndex = 2;
            this.CM_CustomerName.Value = "0";
            this.CM_CustomerName.TextChanged += new System.EventHandler(this.CM_CustomerName_TextChanged);
            // 
            // vinLabel14
            // 
            this.vinLabel14.AutoSize = true;
            this.vinLabel14.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel14.Location = new System.Drawing.Point(27, 82);
            this.vinLabel14.Name = "vinLabel14";
            this.vinLabel14.Size = new System.Drawing.Size(128, 19);
            this.vinLabel14.TabIndex = 101;
            this.vinLabel14.Text = "Customer Name :";
            this.vinLabel14.Click += new System.EventHandler(this.vinLabel14_Click);
            // 
            // CM_State
            // 
            this.CM_State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CM_State.CharacterInput = VINCONTROL.VinTextBox.Cinput.ALLKEYBOARDKEYS;
            this.CM_State.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CM_State.InputValueYesNo = null;
            this.CM_State.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.CM_State.Location = new System.Drawing.Point(160, 209);
            this.CM_State.Name = "CM_State";
            this.CM_State.Size = new System.Drawing.Size(316, 26);
            this.CM_State.TabIndex = 6;
            this.CM_State.Value = "0";
            this.CM_State.TextChanged += new System.EventHandler(this.CM_State_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.panel3.Controls.Add(this.ArrowButton);
            this.panel3.Controls.Add(this.textBoxX1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnsave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 287);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 28);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // ArrowButton
            // 
            this.ArrowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ArrowButton.FlatAppearance.BorderSize = 0;
            this.ArrowButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.ArrowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ArrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArrowButton.ForeColor = System.Drawing.Color.White;
            this.ArrowButton.Image = ((System.Drawing.Image)(resources.GetObject("ArrowButton.Image")));
            this.ArrowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ArrowButton.Location = new System.Drawing.Point(957, 0);
            this.ArrowButton.Name = "ArrowButton";
            this.ArrowButton.Size = new System.Drawing.Size(30, 27);
            this.ArrowButton.TabIndex = 4;
            this.ArrowButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ArrowButton.UseVisualStyleBackColor = true;
            this.ArrowButton.Click += new System.EventHandler(this.ArrowButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(7, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(17, 13);
            this.panel5.TabIndex = 16;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(361, 1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(26, 27);
            this.button7.TabIndex = 6;
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(888, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 27);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(808, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 27);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(730, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(64, 27);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(649, 0);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(81, 27);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "&Save    ";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel6);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(990, 377);
            this.splitContainer1.SplitterDistance = 315;
            this.splitContainer1.TabIndex = 8;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.button8);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.CM_PAN_No);
            this.panel6.Controls.Add(this.vinLabel7);
            this.panel6.Controls.Add(this.vinLabel6);
            this.panel6.Controls.Add(this.CM_GSTNo);
            this.panel6.Controls.Add(this.vinLabel5);
            this.panel6.Controls.Add(this.CM_Email);
            this.panel6.Controls.Add(this.CM_Phone2);
            this.panel6.Controls.Add(this.vinLabel8);
            this.panel6.Controls.Add(this.CM_Phone1);
            this.panel6.Controls.Add(this.vinLabel9);
            this.panel6.Controls.Add(this.CM_Pincode);
            this.panel6.Controls.Add(this.vinLabel11);
            this.panel6.Controls.Add(this.CM_Website);
            this.panel6.Controls.Add(this.vinLabel13);
            this.panel6.Controls.Add(this.CM_Country);
            this.panel6.Controls.Add(this.vinLabel4);
            this.panel6.Controls.Add(this.CM_StateCode);
            this.panel6.Controls.Add(this.vinLabel3);
            this.panel6.Controls.Add(this.CM_City);
            this.panel6.Controls.Add(this.vinLabel2);
            this.panel6.Controls.Add(this.CM_Address);
            this.panel6.Controls.Add(this.vinLabel1);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.CM_CustomerName);
            this.panel6.Controls.Add(this.vinLabel14);
            this.panel6.Controls.Add(this.CM_State);
            this.panel6.Controls.Add(this.vinLabel12);
            this.panel6.Controls.Add(this.CM_Code);
            this.panel6.Controls.Add(this.vinLabel10);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.button10);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(990, 287);
            this.panel6.TabIndex = 0;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(832, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 27);
            this.button8.TabIndex = 1;
            this.button8.Text = "E&xcel";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(531, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 18);
            this.label1.TabIndex = 3459;
            this.label1.Text = "*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CM_PAN_No
            // 
            this.CM_PAN_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CM_PAN_No.CharacterInput = VINCONTROL.VinTextBox.Cinput.ALLKEYBOARDKEYS;
            this.CM_PAN_No.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CM_PAN_No.InputValueYesNo = null;
            this.CM_PAN_No.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.CM_PAN_No.Location = new System.Drawing.Point(631, 242);
            this.CM_PAN_No.Name = "CM_PAN_No";
            this.CM_PAN_No.Size = new System.Drawing.Size(316, 26);
            this.CM_PAN_No.TabIndex = 14;
            this.CM_PAN_No.Value = "0";
            this.CM_PAN_No.TextChanged += new System.EventHandler(this.CM_PAN_No_TextChanged);
            // 
            // vinLabel7
            // 
            this.vinLabel7.AutoSize = true;
            this.vinLabel7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel7.Location = new System.Drawing.Point(555, 244);
            this.vinLabel7.Name = "vinLabel7";
            this.vinLabel7.Size = new System.Drawing.Size(70, 19);
            this.vinLabel7.TabIndex = 3458;
            this.vinLabel7.Text = "PAN No :";
            this.vinLabel7.Click += new System.EventHandler(this.vinLabel7_Click);
            // 
            // vinLabel6
            // 
            this.vinLabel6.AutoSize = true;
            this.vinLabel6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel6.Location = new System.Drawing.Point(549, 147);
            this.vinLabel6.Name = "vinLabel6";
            this.vinLabel6.Size = new System.Drawing.Size(76, 19);
            this.vinLabel6.TabIndex = 3456;
            this.vinLabel6.Text = "Email-ID :";
            this.vinLabel6.Click += new System.EventHandler(this.vinLabel6_Click);
            // 
            // CM_GSTNo
            // 
            this.CM_GSTNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CM_GSTNo.CharacterInput = VINCONTROL.VinTextBox.Cinput.ALLKEYBOARDKEYS;
            this.CM_GSTNo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CM_GSTNo.InputValueYesNo = null;
            this.CM_GSTNo.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.CM_GSTNo.Location = new System.Drawing.Point(631, 209);
            this.CM_GSTNo.Name = "CM_GSTNo";
            this.CM_GSTNo.Size = new System.Drawing.Size(316, 26);
            this.CM_GSTNo.TabIndex = 13;
            this.CM_GSTNo.Value = "0";
            this.CM_GSTNo.TextChanged += new System.EventHandler(this.CM_GSTNo_TextChanged);
            // 
            // vinLabel5
            // 
            this.vinLabel5.AutoSize = true;
            this.vinLabel5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel5.Location = new System.Drawing.Point(561, 211);
            this.vinLabel5.Name = "vinLabel5";
            this.vinLabel5.Size = new System.Drawing.Size(64, 19);
            this.vinLabel5.TabIndex = 3455;
            this.vinLabel5.Text = "GSTNo :";
            this.vinLabel5.Click += new System.EventHandler(this.vinLabel5_Click);
            // 
            // CM_Email
            // 
            this.CM_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CM_Email.CharacterInput = VINCONTROL.VinTextBox.Cinput.ALLKEYBOARDKEYS;
            this.CM_Email.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CM_Email.InputValueYesNo = null;
            this.CM_Email.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.CM_Email.Location = new System.Drawing.Point(631, 145);
            this.CM_Email.Name = "CM_Email";
            this.CM_Email.Size = new System.Drawing.Size(316, 26);
            this.CM_Email.TabIndex = 11;
            this.CM_Email.Value = "0";
            this.CM_Email.TextChanged += new System.EventHandler(this.CM_Email_TextChanged);
            // 
            // CM_Phone2
            // 
            this.CM_Phone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CM_Phone2.CharacterInput = VINCONTROL.VinTextBox.Cinput.IntegerOnly;
            this.CM_Phone2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CM_Phone2.InputValueYesNo = null;
            this.CM_Phone2.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.CM_Phone2.Location = new System.Drawing.Point(631, 112);
            this.CM_Phone2.Name = "CM_Phone2";
            this.CM_Phone2.Size = new System.Drawing.Size(316, 26);
            this.CM_Phone2.TabIndex = 10;
            this.CM_Phone2.Value = "0";
            this.CM_Phone2.TextChanged += new System.EventHandler(this.CM_Phone2_TextChanged);
            // 
            // vinLabel8
            // 
            this.vinLabel8.AutoSize = true;
            this.vinLabel8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel8.Location = new System.Drawing.Point(555, 114);
            this.vinLabel8.Name = "vinLabel8";
            this.vinLabel8.Size = new System.Drawing.Size(70, 19);
            this.vinLabel8.TabIndex = 3451;
            this.vinLabel8.Text = "Phone2 :";
            this.vinLabel8.Click += new System.EventHandler(this.vinLabel8_Click);
            // 
            // CM_Phone1
            // 
            this.CM_Phone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CM_Phone1.CharacterInput = VINCONTROL.VinTextBox.Cinput.IntegerOnly;
            this.CM_Phone1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CM_Phone1.InputValueYesNo = null;
            this.CM_Phone1.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.CM_Phone1.Location = new System.Drawing.Point(631, 79);
            this.CM_Phone1.Name = "CM_Phone1";
            this.CM_Phone1.Size = new System.Drawing.Size(316, 26);
            this.CM_Phone1.TabIndex = 9;
            this.CM_Phone1.Value = "0";
            this.CM_Phone1.TextChanged += new System.EventHandler(this.CM_Phone1_TextChanged);
            // 
            // vinLabel9
            // 
            this.vinLabel9.AutoSize = true;
            this.vinLabel9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel9.Location = new System.Drawing.Point(555, 81);
            this.vinLabel9.Name = "vinLabel9";
            this.vinLabel9.Size = new System.Drawing.Size(70, 19);
            this.vinLabel9.TabIndex = 3449;
            this.vinLabel9.Text = "Phone1 :";
            this.vinLabel9.Click += new System.EventHandler(this.vinLabel9_Click);
            // 
            // CM_Pincode
            // 
            this.CM_Pincode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CM_Pincode.CharacterInput = VINCONTROL.VinTextBox.Cinput.IntegerOnly;
            this.CM_Pincode.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CM_Pincode.InputValueYesNo = null;
            this.CM_Pincode.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.CM_Pincode.Location = new System.Drawing.Point(631, 46);
            this.CM_Pincode.Name = "CM_Pincode";
            this.CM_Pincode.Size = new System.Drawing.Size(316, 26);
            this.CM_Pincode.TabIndex = 8;
            this.CM_Pincode.Value = "0";
            this.CM_Pincode.TextChanged += new System.EventHandler(this.CM_Pincode_TextChanged);
            // 
            // vinLabel11
            // 
            this.vinLabel11.AutoSize = true;
            this.vinLabel11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel11.Location = new System.Drawing.Point(553, 48);
            this.vinLabel11.Name = "vinLabel11";
            this.vinLabel11.Size = new System.Drawing.Size(72, 19);
            this.vinLabel11.TabIndex = 3445;
            this.vinLabel11.Text = "Pincode :";
            this.vinLabel11.Click += new System.EventHandler(this.vinLabel11_Click);
            // 
            // CM_Website
            // 
            this.CM_Website.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CM_Website.CharacterInput = VINCONTROL.VinTextBox.Cinput.ALLKEYBOARDKEYS;
            this.CM_Website.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CM_Website.InputValueYesNo = null;
            this.CM_Website.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.CM_Website.Location = new System.Drawing.Point(631, 177);
            this.CM_Website.Name = "CM_Website";
            this.CM_Website.Size = new System.Drawing.Size(316, 26);
            this.CM_Website.TabIndex = 12;
            this.CM_Website.Value = "0";
            this.CM_Website.TextChanged += new System.EventHandler(this.CM_Website_TextChanged);
            // 
            // vinLabel13
            // 
            this.vinLabel13.AutoSize = true;
            this.vinLabel13.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel13.Location = new System.Drawing.Point(553, 179);
            this.vinLabel13.Name = "vinLabel13";
            this.vinLabel13.Size = new System.Drawing.Size(72, 19);
            this.vinLabel13.TabIndex = 3444;
            this.vinLabel13.Text = "Website :";
            this.vinLabel13.Click += new System.EventHandler(this.vinLabel13_Click);
            // 
            // CM_Country
            // 
            this.CM_Country.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CM_Country.CharacterInput = VINCONTROL.VinTextBox.Cinput.ALLKEYBOARDKEYS;
            this.CM_Country.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CM_Country.InputValueYesNo = null;
            this.CM_Country.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.CM_Country.Location = new System.Drawing.Point(160, 242);
            this.CM_Country.Name = "CM_Country";
            this.CM_Country.Size = new System.Drawing.Size(316, 26);
            this.CM_Country.TabIndex = 7;
            this.CM_Country.Value = "0";
            this.CM_Country.TextChanged += new System.EventHandler(this.CM_Country_TextChanged);
            // 
            // vinLabel4
            // 
            this.vinLabel4.AutoSize = true;
            this.vinLabel4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel4.Location = new System.Drawing.Point(82, 245);
            this.vinLabel4.Name = "vinLabel4";
            this.vinLabel4.Size = new System.Drawing.Size(73, 19);
            this.vinLabel4.TabIndex = 3441;
            this.vinLabel4.Text = "Country :";
            this.vinLabel4.Click += new System.EventHandler(this.vinLabel4_Click);
            // 
            // CM_StateCode
            // 
            this.CM_StateCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CM_StateCode.CharacterInput = VINCONTROL.VinTextBox.Cinput.ALLKEYBOARDKEYS;
            this.CM_StateCode.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CM_StateCode.InputValueYesNo = null;
            this.CM_StateCode.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.CM_StateCode.Location = new System.Drawing.Point(160, 177);
            this.CM_StateCode.Name = "CM_StateCode";
            this.CM_StateCode.Size = new System.Drawing.Size(316, 26);
            this.CM_StateCode.TabIndex = 5;
            this.CM_StateCode.Value = "0";
            this.CM_StateCode.TextChanged += new System.EventHandler(this.CM_StateCode_TextChanged);
            // 
            // vinLabel3
            // 
            this.vinLabel3.AutoSize = true;
            this.vinLabel3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel3.Location = new System.Drawing.Point(65, 180);
            this.vinLabel3.Name = "vinLabel3";
            this.vinLabel3.Size = new System.Drawing.Size(90, 19);
            this.vinLabel3.TabIndex = 3439;
            this.vinLabel3.Text = "State Code :";
            this.vinLabel3.Click += new System.EventHandler(this.vinLabel3_Click);
            // 
            // CM_City
            // 
            this.CM_City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CM_City.CharacterInput = VINCONTROL.VinTextBox.Cinput.ALLKEYBOARDKEYS;
            this.CM_City.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CM_City.InputValueYesNo = null;
            this.CM_City.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.CM_City.Location = new System.Drawing.Point(160, 145);
            this.CM_City.Name = "CM_City";
            this.CM_City.Size = new System.Drawing.Size(316, 26);
            this.CM_City.TabIndex = 4;
            this.CM_City.Value = "0";
            this.CM_City.TextChanged += new System.EventHandler(this.CM_City_TextChanged);
            // 
            // vinLabel2
            // 
            this.vinLabel2.AutoSize = true;
            this.vinLabel2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel2.Location = new System.Drawing.Point(112, 148);
            this.vinLabel2.Name = "vinLabel2";
            this.vinLabel2.Size = new System.Drawing.Size(43, 19);
            this.vinLabel2.TabIndex = 3437;
            this.vinLabel2.Text = "City :";
            this.vinLabel2.Click += new System.EventHandler(this.vinLabel2_Click);
            // 
            // CM_Address
            // 
            this.CM_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CM_Address.CharacterInput = VINCONTROL.VinTextBox.Cinput.ALLKEYBOARDKEYS;
            this.CM_Address.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CM_Address.InputValueYesNo = null;
            this.CM_Address.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.CM_Address.Location = new System.Drawing.Point(160, 112);
            this.CM_Address.Name = "CM_Address";
            this.CM_Address.Size = new System.Drawing.Size(316, 26);
            this.CM_Address.TabIndex = 3;
            this.CM_Address.Value = "0";
            this.CM_Address.TextChanged += new System.EventHandler(this.CM_Address_TextChanged);
            // 
            // vinLabel1
            // 
            this.vinLabel1.AutoSize = true;
            this.vinLabel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel1.Location = new System.Drawing.Point(81, 115);
            this.vinLabel1.Name = "vinLabel1";
            this.vinLabel1.Size = new System.Drawing.Size(74, 19);
            this.vinLabel1.TabIndex = 3435;
            this.vinLabel1.Text = "Address :";
            this.vinLabel1.Click += new System.EventHandler(this.vinLabel1_Click);
            // 
            // vinLabel12
            // 
            this.vinLabel12.AutoSize = true;
            this.vinLabel12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel12.Location = new System.Drawing.Point(104, 212);
            this.vinLabel12.Name = "vinLabel12";
            this.vinLabel12.Size = new System.Drawing.Size(51, 19);
            this.vinLabel12.TabIndex = 94;
            this.vinLabel12.Text = "State :";
            this.vinLabel12.Click += new System.EventHandler(this.vinLabel12_Click);
            // 
            // CM_Code
            // 
            this.CM_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CM_Code.CharacterInput = VINCONTROL.VinTextBox.Cinput.ALLKEYBOARDKEYS;
            this.CM_Code.Enabled = false;
            this.CM_Code.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CM_Code.InputValueYesNo = null;
            this.CM_Code.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.CM_Code.Location = new System.Drawing.Point(160, 46);
            this.CM_Code.Name = "CM_Code";
            this.CM_Code.ReadOnly = true;
            this.CM_Code.Size = new System.Drawing.Size(316, 26);
            this.CM_Code.TabIndex = 1;
            this.CM_Code.Value = "0";
            this.CM_Code.TextChanged += new System.EventHandler(this.CM_Code_TextChanged);
            // 
            // vinLabel10
            // 
            this.vinLabel10.AutoSize = true;
            this.vinLabel10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel10.Location = new System.Drawing.Point(103, 48);
            this.vinLabel10.Name = "vinLabel10";
            this.vinLabel10.Size = new System.Drawing.Size(52, 19);
            this.vinLabel10.TabIndex = 89;
            this.vinLabel10.Text = "Code :";
            this.vinLabel10.Click += new System.EventHandler(this.vinLabel10_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 18);
            this.label4.TabIndex = 105;
            this.label4.Text = "*";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(903, -1);
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
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Customer Master";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(5, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 2);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel8.Location = new System.Drawing.Point(5, 31);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(979, 2);
            this.panel8.TabIndex = 1;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(990, 58);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Incharge_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 377);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Incharge_Master";
            this.Text = "Customer_Master";
            this.Load += new System.EventHandler(this.Customer_Master_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsave;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private System.Windows.Forms.Button ArrowButton;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private VINCONTROL.VinTextBox CM_CustomerName;
        private VINCONTROL.VinLabel vinLabel14;
        private System.Windows.Forms.Button btnEdit;
        private VINCONTROL.VinTextBox CM_State;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel6;
        private VINCONTROL.VinLabel vinLabel12;
        private VINCONTROL.VinTextBox CM_Code;
        private VINCONTROL.VinLabel vinLabel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VINCONTROL.VinTextBox CM_GSTNo;
        private VINCONTROL.VinLabel vinLabel5;
        private VINCONTROL.VinTextBox CM_Email;
        private VINCONTROL.VinTextBox CM_Phone2;
        private VINCONTROL.VinLabel vinLabel8;
        private VINCONTROL.VinTextBox CM_Phone1;
        private VINCONTROL.VinLabel vinLabel9;
        private VINCONTROL.VinTextBox CM_Pincode;
        private VINCONTROL.VinLabel vinLabel11;
        private VINCONTROL.VinTextBox CM_Website;
        private VINCONTROL.VinLabel vinLabel13;
        private VINCONTROL.VinTextBox CM_Country;
        private VINCONTROL.VinLabel vinLabel4;
        private VINCONTROL.VinTextBox CM_StateCode;
        private VINCONTROL.VinLabel vinLabel3;
        private VINCONTROL.VinTextBox CM_City;
        private VINCONTROL.VinLabel vinLabel2;
        private VINCONTROL.VinTextBox CM_Address;
        private VINCONTROL.VinLabel vinLabel1;
        private VINCONTROL.VinLabel vinLabel6;
        private VINCONTROL.VinTextBox CM_PAN_No;
        private VINCONTROL.VinLabel vinLabel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
    }
}