namespace myfform
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.labSurname = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.labBdate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labCard = new System.Windows.Forms.Label();
            this.chkDebitCard = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtDebitCard = new System.Windows.Forms.TextBox();
            this.txtCreditCard = new System.Windows.Forms.TextBox();
            this.labDebitCard = new System.Windows.Forms.Label();
            this.labCredit = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.toolTipSubmit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipClear = new System.Windows.Forms.ToolTip(this.components);
            this.labPlace = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.labFshow = new System.Windows.Forms.Label();
            this.labFrequency = new System.Windows.Forms.Label();
            this.trackFrequency = new System.Windows.Forms.TrackBar();
            this.menuStrip1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labName.Location = new System.Drawing.Point(17, 26);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(35, 13);
            this.labName.TabIndex = 0;
            this.labName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(378, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(100, 68);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(378, 20);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // labSurname
            // 
            this.labSurname.AutoSize = true;
            this.labSurname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labSurname.Location = new System.Drawing.Point(17, 68);
            this.labSurname.Name = "labSurname";
            this.labSurname.Size = new System.Drawing.Size(49, 13);
            this.labSurname.TabIndex = 2;
            this.labSurname.Text = "Surname";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labGender.Location = new System.Drawing.Point(17, 107);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(42, 13);
            this.labGender.TabIndex = 4;
            this.labGender.Text = "Gender";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Location = new System.Drawing.Point(118, 103);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 5;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            this.radMale.CheckedChanged += new System.EventHandler(this.radMale_CheckedChanged);
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(201, 105);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(59, 17);
            this.radFemale.TabIndex = 6;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            this.radFemale.CheckedChanged += new System.EventHandler(this.radFemale_CheckedChanged);
            // 
            // labBdate
            // 
            this.labBdate.AutoSize = true;
            this.labBdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labBdate.Location = new System.Drawing.Point(17, 146);
            this.labBdate.Name = "labBdate";
            this.labBdate.Size = new System.Drawing.Size(66, 13);
            this.labBdate.TabIndex = 7;
            this.labBdate.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // labCard
            // 
            this.labCard.AutoSize = true;
            this.labCard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labCard.Location = new System.Drawing.Point(17, 188);
            this.labCard.Name = "labCard";
            this.labCard.Size = new System.Drawing.Size(64, 13);
            this.labCard.TabIndex = 9;
            this.labCard.Text = "Card Details";
            // 
            // chkDebitCard
            // 
            this.chkDebitCard.AutoSize = true;
            this.chkDebitCard.Location = new System.Drawing.Point(100, 187);
            this.chkDebitCard.Name = "chkDebitCard";
            this.chkDebitCard.Size = new System.Drawing.Size(76, 17);
            this.chkDebitCard.TabIndex = 10;
            this.chkDebitCard.Text = "Debit Card";
            this.chkDebitCard.UseVisualStyleBackColor = true;
            this.chkDebitCard.CheckedChanged += new System.EventHandler(this.chkDebitCard_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(100, 231);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Credit Card";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // txtDebitCard
            // 
            this.txtDebitCard.Location = new System.Drawing.Point(309, 185);
            this.txtDebitCard.Name = "txtDebitCard";
            this.txtDebitCard.Size = new System.Drawing.Size(100, 20);
            this.txtDebitCard.TabIndex = 12;
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.Location = new System.Drawing.Point(309, 228);
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Size = new System.Drawing.Size(100, 20);
            this.txtCreditCard.TabIndex = 13;
            // 
            // labDebitCard
            // 
            this.labDebitCard.AutoSize = true;
            this.labDebitCard.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labDebitCard.Location = new System.Drawing.Point(223, 188);
            this.labDebitCard.Name = "labDebitCard";
            this.labDebitCard.Size = new System.Drawing.Size(49, 13);
            this.labDebitCard.TabIndex = 14;
            this.labDebitCard.Text = "Card No.";
            // 
            // labCredit
            // 
            this.labCredit.AutoSize = true;
            this.labCredit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labCredit.Location = new System.Drawing.Point(223, 235);
            this.labCredit.Name = "labCredit";
            this.labCredit.Size = new System.Drawing.Size(49, 13);
            this.labCredit.TabIndex = 16;
            this.labCredit.Text = "Card No.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Lime;
            this.btnSubmit.Location = new System.Drawing.Point(241, 311);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.toolTipSubmit.SetToolTip(this.btnSubmit, "Click For Submit");
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.Enter += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClear.Location = new System.Drawing.Point(356, 311);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.toolTipClear.SetToolTip(this.btnClear, "Click to Clear");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // toolTipSubmit
            // 
            this.toolTipSubmit.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipSubmit.ToolTipTitle = "Info";
            this.toolTipSubmit.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipSubmit_Popup);
            // 
            // toolTipClear
            // 
            this.toolTipClear.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipClear.ToolTipTitle = "Info";
            // 
            // labPlace
            // 
            this.labPlace.AutoSize = true;
            this.labPlace.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labPlace.Location = new System.Drawing.Point(25, 270);
            this.labPlace.Name = "labPlace";
            this.labPlace.Size = new System.Drawing.Size(34, 13);
            this.labPlace.TabIndex = 20;
            this.labPlace.Text = "Place";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ahmedabad",
            "Baroda",
            "Rajkot",
            "Surat"});
            this.comboBox1.Location = new System.Drawing.Point(100, 267);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tab2);
            this.tab1.Location = new System.Drawing.Point(14, 28);
            this.tab1.Multiline = true;
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(704, 366);
            this.tab1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.IndianRed;
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.labName);
            this.tabPage1.Controls.Add(this.labSurname);
            this.tabPage1.Controls.Add(this.btnSubmit);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.labGender);
            this.tabPage1.Controls.Add(this.labPlace);
            this.tabPage1.Controls.Add(this.labCredit);
            this.tabPage1.Controls.Add(this.labBdate);
            this.tabPage1.Controls.Add(this.labDebitCard);
            this.tabPage1.Controls.Add(this.labCard);
            this.tabPage1.Controls.Add(this.txtCreditCard);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.txtDebitCard);
            this.tabPage1.Controls.Add(this.txtSurname);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.radMale);
            this.tabPage1.Controls.Add(this.chkDebitCard);
            this.tabPage1.Controls.Add(this.radFemale);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // tab2
            // 
            this.tab2.BackColor = System.Drawing.Color.IndianRed;
            this.tab2.Controls.Add(this.labFshow);
            this.tab2.Controls.Add(this.labFrequency);
            this.tab2.Controls.Add(this.trackFrequency);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(696, 340);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Second";
            // 
            // labFshow
            // 
            this.labFshow.AutoSize = true;
            this.labFshow.Location = new System.Drawing.Point(180, 34);
            this.labFshow.Name = "labFshow";
            this.labFshow.Size = new System.Drawing.Size(13, 13);
            this.labFshow.TabIndex = 2;
            this.labFshow.Text = "0";
            // 
            // labFrequency
            // 
            this.labFrequency.AutoSize = true;
            this.labFrequency.Location = new System.Drawing.Point(110, 34);
            this.labFrequency.Name = "labFrequency";
            this.labFrequency.Size = new System.Drawing.Size(60, 13);
            this.labFrequency.TabIndex = 1;
            this.labFrequency.Text = "Frequency:";
            // 
            // trackFrequency
            // 
            this.trackFrequency.Location = new System.Drawing.Point(69, 64);
            this.trackFrequency.Maximum = 100;
            this.trackFrequency.Name = "trackFrequency";
            this.trackFrequency.Size = new System.Drawing.Size(213, 45);
            this.trackFrequency.TabIndex = 0;
            this.trackFrequency.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Main Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackFrequency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label labSurname;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.Label labBdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labCard;
        private System.Windows.Forms.CheckBox chkDebitCard;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox txtDebitCard;
        private System.Windows.Forms.TextBox txtCreditCard;
        private System.Windows.Forms.Label labDebitCard;
        private System.Windows.Forms.Label labCredit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolTip toolTipSubmit;
        private System.Windows.Forms.ToolTip toolTipClear;
        private System.Windows.Forms.Label labPlace;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Label labFrequency;
        private System.Windows.Forms.TrackBar trackFrequency;
        private System.Windows.Forms.Label labFshow;
    }
}