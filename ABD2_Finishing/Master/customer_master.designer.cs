
namespace ABD2_Finishing.Master
{
    partial class customer_master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_master));
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.State = new VINCONTROL.VinTextBox();
            this.vinLabel3 = new VINCONTROL.VinLabel();
            this.vinLabel8 = new VINCONTROL.VinLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ArrowButton = new System.Windows.Forms.Button();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.city = new VINCONTROL.VinTextBox();
            this.Address = new VINCONTROL.VinTextBox();
            this.code = new VINCONTROL.VinTextBox();
            this.Phoneno = new VINCONTROL.VinTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel6 = new System.Windows.Forms.Panel();
            this.name = new VINCONTROL.VinTextBox();
            this.vinLabel4 = new VINCONTROL.VinLabel();
            this.pin = new VINCONTROL.VinTextBox();
            this.Type = new System.Windows.Forms.ComboBox();
            this.Email = new VINCONTROL.VinTextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.vinLabel15 = new VINCONTROL.VinLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.vinLabel10 = new VINCONTROL.VinLabel();
            this.vinLabel14 = new VINCONTROL.VinLabel();
            this.vinLabel1 = new VINCONTROL.VinLabel();
            this.vinLabel5 = new VINCONTROL.VinLabel();
            this.vinLabel2 = new VINCONTROL.VinLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(986, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // State
            // 
            this.State.BackColor = System.Drawing.Color.White;
            this.State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.State.CharacterInput = VINCONTROL.VinTextBox.Cinput.ALLKEYBOARDKEYS;
            this.State.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State.ForeColor = System.Drawing.Color.Black;
            this.State.InputValueYesNo = null;
            this.State.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.State.Location = new System.Drawing.Point(172, 209);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(298, 26);
            this.State.TabIndex = 5;
            this.State.Value = "0";
            // 
            // vinLabel3
            // 
            this.vinLabel3.AutoSize = true;
            this.vinLabel3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel3.Location = new System.Drawing.Point(504, 121);
            this.vinLabel3.Name = "vinLabel3";
            this.vinLabel3.Size = new System.Drawing.Size(74, 19);
            this.vinLabel3.TabIndex = 3528;
            this.vinLabel3.Text = "Address :";
            // 
            // vinLabel8
            // 
            this.vinLabel8.AutoSize = true;
            this.vinLabel8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel8.Location = new System.Drawing.Point(527, 82);
            this.vinLabel8.Name = "vinLabel8";
            this.vinLabel8.Size = new System.Drawing.Size(51, 19);
            this.vinLabel8.TabIndex = 3525;
            this.vinLabel8.Text = "Type :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
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
            this.panel3.Location = new System.Drawing.Point(0, 276);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 28);
            this.panel3.TabIndex = 0;
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
            this.ArrowButton.Location = new System.Drawing.Point(953, 0);
            this.ArrowButton.Name = "ArrowButton";
            this.ArrowButton.Size = new System.Drawing.Size(30, 27);
            this.ArrowButton.TabIndex = 4;
            this.ArrowButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ArrowButton.UseVisualStyleBackColor = true;
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
            this.btnClear.Location = new System.Drawing.Point(884, 0);
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
            this.btnDelete.Location = new System.Drawing.Point(804, 0);
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
            this.btnEdit.Location = new System.Drawing.Point(726, 0);
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
            this.btnsave.Location = new System.Drawing.Point(645, 0);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(81, 27);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "&Save    ";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // city
            // 
            this.city.BackColor = System.Drawing.Color.White;
            this.city.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.city.CharacterInput = VINCONTROL.VinTextBox.Cinput.ALLKEYBOARDKEYS;
            this.city.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.ForeColor = System.Drawing.Color.White;
            this.city.InputValueYesNo = null;
            this.city.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.city.Location = new System.Drawing.Point(172, 175);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(299, 26);
            this.city.TabIndex = 4;
            this.city.Value = "0";
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.Color.White;
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Address.CharacterInput = VINCONTROL.VinTextBox.Cinput.ALLKEYBOARDKEYS;
            this.Address.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.White;
            this.Address.InputValueYesNo = null;
            this.Address.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.Address.Location = new System.Drawing.Point(584, 121);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(371, 83);
            this.Address.TabIndex = 8;
            this.Address.Value = "0";
            this.Address.TextChanged += new System.EventHandler(this.Address_TextChanged);
            this.Address.HideSelection = false;

            // 
            // code
            // 
            this.code.BackColor = System.Drawing.Color.White;
            this.code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.code.CharacterInput = VINCONTROL.VinTextBox.Cinput.ALLKEYBOARDKEYS;
            this.code.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.ForeColor = System.Drawing.Color.White;
            this.code.InputValueYesNo = null;
            this.code.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.code.Location = new System.Drawing.Point(172, 40);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(299, 26);
            this.code.TabIndex = 0;
            this.code.Value = "0";
            this.code.TextChanged += new System.EventHandler(this.code_TextChanged);
            // 
            // Phoneno
            // 
            this.Phoneno.BackColor = System.Drawing.Color.White;
            this.Phoneno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Phoneno.CharacterInput = VINCONTROL.VinTextBox.Cinput.ALLKEYBOARDKEYS;
            this.Phoneno.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phoneno.ForeColor = System.Drawing.Color.White;
            this.Phoneno.InputValueYesNo = null;
            this.Phoneno.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.Phoneno.Location = new System.Drawing.Point(172, 105);
            this.Phoneno.MaxLength = 10;
            this.Phoneno.Name = "Phoneno";
            this.Phoneno.Size = new System.Drawing.Size(299, 26);
            this.Phoneno.TabIndex = 2;
            this.Phoneno.Value = "0";
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
            this.splitContainer1.Size = new System.Drawing.Size(986, 529);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.name);
            this.panel6.Controls.Add(this.vinLabel4);
            this.panel6.Controls.Add(this.pin);
            this.panel6.Controls.Add(this.Type);
            this.panel6.Controls.Add(this.State);
            this.panel6.Controls.Add(this.vinLabel3);
            this.panel6.Controls.Add(this.vinLabel8);
            this.panel6.Controls.Add(this.city);
            this.panel6.Controls.Add(this.Address);
            this.panel6.Controls.Add(this.Phoneno);
            this.panel6.Controls.Add(this.code);
            this.panel6.Controls.Add(this.Email);
            this.panel6.Controls.Add(this.button10);
            this.panel6.Controls.Add(this.vinLabel15);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.vinLabel10);
            this.panel6.Controls.Add(this.vinLabel14);
            this.panel6.Controls.Add(this.vinLabel1);
            this.panel6.Controls.Add(this.vinLabel5);
            this.panel6.Controls.Add(this.vinLabel2);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(986, 276);
            this.panel6.TabIndex = 0;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.CharacterInput = VINCONTROL.VinTextBox.Cinput.ALLKEYBOARDKEYS;
            this.name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.InputValueYesNo = null;
            this.name.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.name.Location = new System.Drawing.Point(172, 75);
            this.name.MaxLength = 100;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(299, 26);
            this.name.TabIndex = 1;
            this.name.Value = "0";
            // 
            // vinLabel4
            // 
            this.vinLabel4.AutoSize = true;
            this.vinLabel4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel4.Location = new System.Drawing.Point(506, 45);
            this.vinLabel4.Name = "vinLabel4";
            this.vinLabel4.Size = new System.Drawing.Size(72, 19);
            this.vinLabel4.TabIndex = 3533;
            this.vinLabel4.Text = "Pincode :";
            // 
            // pin
            // 
            this.pin.BackColor = System.Drawing.Color.White;
            this.pin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pin.CharacterInput = VINCONTROL.VinTextBox.Cinput.ALLKEYBOARDKEYS;
            this.pin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin.ForeColor = System.Drawing.Color.White;
            this.pin.InputValueYesNo = null;
            this.pin.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.pin.Location = new System.Drawing.Point(584, 44);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(298, 26);
            this.pin.TabIndex = 6;
            this.pin.Value = "0";
            // 
            // Type
            // 
            this.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type.Font = new System.Drawing.Font("Cambria", 12F);
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "Customer ",
            "Vendor"});
            this.Type.Location = new System.Drawing.Point(584, 79);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(298, 27);
            this.Type.TabIndex = 7;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.White;
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.CharacterInput = VINCONTROL.VinTextBox.Cinput.ALLKEYBOARDKEYS;
            this.Email.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.InputValueYesNo = null;
            this.Email.isMandatory = VINCONTROL.VinTextBox.Cinput2.NO;
            this.Email.Location = new System.Drawing.Point(172, 141);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(299, 26);
            this.Email.TabIndex = 3;
            this.Email.Value = "0";
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
            this.button10.Location = new System.Drawing.Point(899, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(81, 30);
            this.button10.TabIndex = 0;
            this.button10.Text = "Close";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // vinLabel15
            // 
            this.vinLabel15.AutoSize = true;
            this.vinLabel15.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel15.Location = new System.Drawing.Point(107, 211);
            this.vinLabel15.Name = "vinLabel15";
            this.vinLabel15.Size = new System.Drawing.Size(51, 19);
            this.vinLabel15.TabIndex = 3505;
            this.vinLabel15.Text = "State :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(30, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 19);
            this.label7.TabIndex = 3471;
            this.label7.Text = "Customer Master";
            // 
            // vinLabel10
            // 
            this.vinLabel10.AutoSize = true;
            this.vinLabel10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel10.Location = new System.Drawing.Point(34, 74);
            this.vinLabel10.Name = "vinLabel10";
            this.vinLabel10.Size = new System.Drawing.Size(128, 19);
            this.vinLabel10.TabIndex = 3477;
            this.vinLabel10.Text = "Customer Name :";
            // 
            // vinLabel14
            // 
            this.vinLabel14.AutoSize = true;
            this.vinLabel14.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel14.Location = new System.Drawing.Point(77, 107);
            this.vinLabel14.Name = "vinLabel14";
            this.vinLabel14.Size = new System.Drawing.Size(85, 19);
            this.vinLabel14.TabIndex = 3478;
            this.vinLabel14.Text = "Phone No :";
            // 
            // vinLabel1
            // 
            this.vinLabel1.AutoSize = true;
            this.vinLabel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel1.Location = new System.Drawing.Point(103, 141);
            this.vinLabel1.Name = "vinLabel1";
            this.vinLabel1.Size = new System.Drawing.Size(55, 19);
            this.vinLabel1.TabIndex = 3479;
            this.vinLabel1.Text = "Email :";
            // 
            // vinLabel5
            // 
            this.vinLabel5.AutoSize = true;
            this.vinLabel5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel5.Location = new System.Drawing.Point(119, 175);
            this.vinLabel5.Name = "vinLabel5";
            this.vinLabel5.Size = new System.Drawing.Size(43, 19);
            this.vinLabel5.TabIndex = 3481;
            this.vinLabel5.Text = "City :";
            // 
            // vinLabel2
            // 
            this.vinLabel2.AutoSize = true;
            this.vinLabel2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinLabel2.Location = new System.Drawing.Point(42, 42);
            this.vinLabel2.Name = "vinLabel2";
            this.vinLabel2.Size = new System.Drawing.Size(123, 19);
            this.vinLabel2.TabIndex = 3480;
            this.vinLabel2.Text = "Customer Code :";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Firebrick;
            this.panel7.Location = new System.Drawing.Point(9, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(12, 13);
            this.panel7.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel8.Location = new System.Drawing.Point(5, 31);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(975, 2);
            this.panel8.TabIndex = 1;
            // 
            // customer_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 529);
            this.Controls.Add(this.splitContainer1);
            this.Name = "customer_master";
            this.Text = "customer_master";
            this.Load += new System.EventHandler(this.customer_master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VINCONTROL.VinTextBox State;
        private VINCONTROL.VinLabel vinLabel3;
        private VINCONTROL.VinLabel vinLabel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ArrowButton;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnsave;
        private VINCONTROL.VinTextBox city;
        private VINCONTROL.VinTextBox Address;
        private VINCONTROL.VinTextBox code;
        private VINCONTROL.VinTextBox Phoneno;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel6;
        private VINCONTROL.VinTextBox Email;
        private System.Windows.Forms.Button button10;
        private VINCONTROL.VinLabel vinLabel15;
        private System.Windows.Forms.Label label7;
        private VINCONTROL.VinLabel vinLabel10;
        private VINCONTROL.VinLabel vinLabel14;
        private VINCONTROL.VinLabel vinLabel1;
        private VINCONTROL.VinLabel vinLabel5;
        private VINCONTROL.VinLabel vinLabel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox Type;
        private VINCONTROL.VinLabel vinLabel4;
        private VINCONTROL.VinTextBox pin;
        private VINCONTROL.VinTextBox name;
    }
}