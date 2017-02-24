namespace Caesar
{
    partial class Caesar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caesar));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCiphertext = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPlaintext = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxPlainCount = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxShift = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxCripherCount = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.textBoxFreqWord = new System.Windows.Forms.TextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.textBoxFreqCiph = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.textBoxFreqPlain = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.buttonWordFreq = new System.Windows.Forms.Button();
            this.buttonFreqCiph = new System.Windows.Forms.Button();
            this.buttonFreqPlain = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxCharacter = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBoxCountCharacter = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plainTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cipherTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1148, 554);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1140, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Caesar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCiphertext);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(465, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 522);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cipher Text";
            // 
            // textBoxCiphertext
            // 
            this.textBoxCiphertext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCiphertext.Location = new System.Drawing.Point(3, 16);
            this.textBoxCiphertext.Multiline = true;
            this.textBoxCiphertext.Name = "textBoxCiphertext";
            this.textBoxCiphertext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCiphertext.Size = new System.Drawing.Size(466, 503);
            this.textBoxCiphertext.TabIndex = 0;
            this.textBoxCiphertext.TextChanged += new System.EventHandler(this.textBoxCiphertext_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPlaintext);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 522);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plain Text";
            // 
            // textBoxPlaintext
            // 
            this.textBoxPlaintext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPlaintext.Location = new System.Drawing.Point(3, 16);
            this.textBoxPlaintext.Multiline = true;
            this.textBoxPlaintext.Name = "textBoxPlaintext";
            this.textBoxPlaintext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPlaintext.Size = new System.Drawing.Size(456, 503);
            this.textBoxPlaintext.TabIndex = 0;
            this.textBoxPlaintext.TextChanged += new System.EventHandler(this.textBoxPlaintext_TextChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox7);
            this.groupBox9.Controls.Add(this.groupBox4);
            this.groupBox9.Controls.Add(this.groupBox6);
            this.groupBox9.Controls.Add(this.groupBox5);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox9.Location = new System.Drawing.Point(937, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(200, 522);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button5);
            this.groupBox7.Controls.Add(this.button4);
            this.groupBox7.Controls.Add(this.button3);
            this.groupBox7.Controls.Add(this.buttonDecrypt);
            this.groupBox7.Controls.Add(this.buttonEncrypt);
            this.groupBox7.Location = new System.Drawing.Point(4, 93);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(196, 238);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Action";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(6, 195);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(184, 36);
            this.buttonDecrypt.TabIndex = 2;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(6, 151);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(184, 36);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxPlainCount);
            this.groupBox4.Location = new System.Drawing.Point(4, 392);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(196, 45);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Length Plain Text";
            // 
            // textBoxPlainCount
            // 
            this.textBoxPlainCount.Location = new System.Drawing.Point(6, 19);
            this.textBoxPlainCount.Name = "textBoxPlainCount";
            this.textBoxPlainCount.ReadOnly = true;
            this.textBoxPlainCount.Size = new System.Drawing.Size(184, 20);
            this.textBoxPlainCount.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxShift);
            this.groupBox6.Location = new System.Drawing.Point(4, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(196, 46);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Shift";
            // 
            // textBoxShift
            // 
            this.textBoxShift.Location = new System.Drawing.Point(6, 19);
            this.textBoxShift.Name = "textBoxShift";
            this.textBoxShift.Size = new System.Drawing.Size(184, 20);
            this.textBoxShift.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxCripherCount);
            this.groupBox5.Location = new System.Drawing.Point(4, 461);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(196, 46);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Length Cripher Text";
            // 
            // textBoxCripherCount
            // 
            this.textBoxCripherCount.Location = new System.Drawing.Point(6, 19);
            this.textBoxCripherCount.Name = "textBoxCripherCount";
            this.textBoxCripherCount.ReadOnly = true;
            this.textBoxCripherCount.Size = new System.Drawing.Size(184, 20);
            this.textBoxCripherCount.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox11);
            this.tabPage2.Controls.Add(this.groupBox10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1140, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Frequency";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.groupBox14);
            this.groupBox11.Controls.Add(this.groupBox13);
            this.groupBox11.Controls.Add(this.groupBox12);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(3, 3);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(934, 522);
            this.groupBox11.TabIndex = 4;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Frequency Table";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.textBoxFreqWord);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox14.Location = new System.Drawing.Point(611, 16);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(320, 503);
            this.groupBox14.TabIndex = 4;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Frequency Word Plain Text";
            // 
            // textBoxFreqWord
            // 
            this.textBoxFreqWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFreqWord.Location = new System.Drawing.Point(3, 16);
            this.textBoxFreqWord.Multiline = true;
            this.textBoxFreqWord.Name = "textBoxFreqWord";
            this.textBoxFreqWord.ReadOnly = true;
            this.textBoxFreqWord.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxFreqWord.Size = new System.Drawing.Size(314, 484);
            this.textBoxFreqWord.TabIndex = 0;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.textBoxFreqCiph);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox13.Location = new System.Drawing.Point(307, 16);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(304, 503);
            this.groupBox13.TabIndex = 3;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Frequency Character Cipher Text";
            // 
            // textBoxFreqCiph
            // 
            this.textBoxFreqCiph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFreqCiph.Location = new System.Drawing.Point(3, 16);
            this.textBoxFreqCiph.Multiline = true;
            this.textBoxFreqCiph.Name = "textBoxFreqCiph";
            this.textBoxFreqCiph.ReadOnly = true;
            this.textBoxFreqCiph.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFreqCiph.Size = new System.Drawing.Size(298, 484);
            this.textBoxFreqCiph.TabIndex = 1;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.textBoxFreqPlain);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox12.Location = new System.Drawing.Point(3, 16);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(304, 503);
            this.groupBox12.TabIndex = 2;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Frequency Character Plain Text";
            // 
            // textBoxFreqPlain
            // 
            this.textBoxFreqPlain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFreqPlain.Location = new System.Drawing.Point(3, 16);
            this.textBoxFreqPlain.Multiline = true;
            this.textBoxFreqPlain.Name = "textBoxFreqPlain";
            this.textBoxFreqPlain.ReadOnly = true;
            this.textBoxFreqPlain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFreqPlain.Size = new System.Drawing.Size(298, 484);
            this.textBoxFreqPlain.TabIndex = 1;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.buttonWordFreq);
            this.groupBox10.Controls.Add(this.buttonFreqCiph);
            this.groupBox10.Controls.Add(this.buttonFreqPlain);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox10.Location = new System.Drawing.Point(937, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 522);
            this.groupBox10.TabIndex = 3;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Function";
            // 
            // buttonWordFreq
            // 
            this.buttonWordFreq.Location = new System.Drawing.Point(7, 116);
            this.buttonWordFreq.Name = "buttonWordFreq";
            this.buttonWordFreq.Size = new System.Drawing.Size(187, 36);
            this.buttonWordFreq.TabIndex = 3;
            this.buttonWordFreq.Text = "Frequency Word Plain Text";
            this.buttonWordFreq.UseVisualStyleBackColor = true;
            this.buttonWordFreq.Click += new System.EventHandler(this.buttonWordFreq_Click);
            // 
            // buttonFreqCiph
            // 
            this.buttonFreqCiph.Location = new System.Drawing.Point(6, 65);
            this.buttonFreqCiph.Name = "buttonFreqCiph";
            this.buttonFreqCiph.Size = new System.Drawing.Size(188, 36);
            this.buttonFreqCiph.TabIndex = 2;
            this.buttonFreqCiph.Text = "Frequency Character Cipher Text";
            this.buttonFreqCiph.UseVisualStyleBackColor = true;
            this.buttonFreqCiph.Click += new System.EventHandler(this.buttonFreqCiph_Click);
            // 
            // buttonFreqPlain
            // 
            this.buttonFreqPlain.Location = new System.Drawing.Point(6, 20);
            this.buttonFreqPlain.Name = "buttonFreqPlain";
            this.buttonFreqPlain.Size = new System.Drawing.Size(188, 36);
            this.buttonFreqPlain.TabIndex = 0;
            this.buttonFreqPlain.Text = "Frequency Character Plain Text";
            this.buttonFreqPlain.UseVisualStyleBackColor = true;
            this.buttonFreqPlain.Click += new System.EventHandler(this.buttonFreqPlain_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1140, 528);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Convert";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxCharacter);
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 578);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1148, 111);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Character Table";
            // 
            // textBoxCharacter
            // 
            this.textBoxCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCharacter.Location = new System.Drawing.Point(3, 16);
            this.textBoxCharacter.Multiline = true;
            this.textBoxCharacter.Name = "textBoxCharacter";
            this.textBoxCharacter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCharacter.Size = new System.Drawing.Size(942, 92);
            this.textBoxCharacter.TabIndex = 0;
            this.textBoxCharacter.Text = resources.GetString("textBoxCharacter.Text");
            this.textBoxCharacter.TextChanged += new System.EventHandler(this.textBoxCharacter_TextChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBoxCountCharacter);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox8.Location = new System.Drawing.Point(945, 16);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 92);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Length Character";
            // 
            // textBoxCountCharacter
            // 
            this.textBoxCountCharacter.Location = new System.Drawing.Point(6, 37);
            this.textBoxCountCharacter.Name = "textBoxCountCharacter";
            this.textBoxCountCharacter.Size = new System.Drawing.Size(184, 20);
            this.textBoxCountCharacter.TabIndex = 1;
            this.textBoxCountCharacter.Text = "228";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1148, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.characterToolStripMenuItem,
            this.plainTextToolStripMenuItem,
            this.cipherTextToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // characterToolStripMenuItem
            // 
            this.characterToolStripMenuItem.Name = "characterToolStripMenuItem";
            this.characterToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.characterToolStripMenuItem.Text = "Character";
            this.characterToolStripMenuItem.Click += new System.EventHandler(this.characterToolStripMenuItem_Click);
            // 
            // plainTextToolStripMenuItem
            // 
            this.plainTextToolStripMenuItem.Name = "plainTextToolStripMenuItem";
            this.plainTextToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.plainTextToolStripMenuItem.Text = "Plain Text";
            this.plainTextToolStripMenuItem.Click += new System.EventHandler(this.plainTextToolStripMenuItem_Click_1);
            // 
            // cipherTextToolStripMenuItem
            // 
            this.cipherTextToolStripMenuItem.Name = "cipherTextToolStripMenuItem";
            this.cipherTextToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.cipherTextToolStripMenuItem.Text = "Cipher Text";
            this.cipherTextToolStripMenuItem.Click += new System.EventHandler(this.cipherTextToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Caesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 689);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBox3);
            this.Name = "Caesar";
            this.Text = "Caesar";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox textBoxShift;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCiphertext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPlaintext;
        private System.Windows.Forms.TextBox textBoxFreqCiph;
        private System.Windows.Forms.Button buttonFreqPlain;
        private System.Windows.Forms.TextBox textBoxCripherCount;
        private System.Windows.Forms.TextBox textBoxPlainCount;
        private System.Windows.Forms.Button buttonFreqCiph;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxCountCharacter;
        private System.Windows.Forms.TextBox textBoxCharacter;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem characterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plainTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cipherTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox textBoxFreqPlain;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox textBoxFreqWord;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button buttonWordFreq;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

