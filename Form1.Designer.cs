namespace Elsa
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topMarginLabel = new System.Windows.Forms.Label();
            this.fontSettingStyleLabel = new System.Windows.Forms.Label();
            this.fontStyleSelect = new System.Windows.Forms.ComboBox();
            this.topAlign = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toPage = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.fromPage = new System.Windows.Forms.TextBox();
            this.evenPagesCheckBox = new System.Windows.Forms.RadioButton();
            this.oddPagesCheckBox = new System.Windows.Forms.RadioButton();
            this.allPagesCheckBox = new System.Windows.Forms.RadioButton();
            this.rightAlign = new System.Windows.Forms.RadioButton();
            this.centerAlign = new System.Windows.Forms.RadioButton();
            this.leftAlign = new System.Windows.Forms.RadioButton();
            this.customPagesCheckBox = new System.Windows.Forms.RadioButton();
            this.pdfView = new System.Windows.Forms.PictureBox();
            this.margin = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.rightMargin = new System.Windows.Forms.NumericUpDown();
            this.leftMargin = new System.Windows.Forms.NumericUpDown();
            this.bottomMargin = new System.Windows.Forms.NumericUpDown();
            this.topMargin = new System.Windows.Forms.NumericUpDown();
            this.rightMarginLabel = new System.Windows.Forms.Label();
            this.leftMarginLabel = new System.Windows.Forms.Label();
            this.bottomMarginLabel = new System.Windows.Forms.Label();
            this.bottomAlign = new System.Windows.Forms.RadioButton();
            this.fontSize = new System.Windows.Forms.NumericUpDown();
            this.fontSettingColorLabel = new System.Windows.Forms.Label();
            this.fontSettingSizeLabel = new System.Windows.Forms.Label();
            this.fontSettingFontLabel = new System.Windows.Forms.Label();
            this.fontColorSelect = new System.Windows.Forms.ComboBox();
            this.fontFamilySelect = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.customTextInput = new System.Windows.Forms.TextBox();
            this.useCustomText = new System.Windows.Forms.CheckBox();
            this.showStamp = new System.Windows.Forms.CheckBox();
            this.fontSetting = new System.Windows.Forms.GroupBox();
            this.showPageNo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.alignText = new System.Windows.Forms.GroupBox();
            this.prevPageBtn = new System.Windows.Forms.Button();
            this.pageCountTextBox = new System.Windows.Forms.TextBox();
            this.nextPageBtn = new System.Windows.Forms.Button();
            this.gravity = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pdfView)).BeginInit();
            this.margin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            this.fontSetting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.alignText.SuspendLayout();
            this.gravity.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMarginLabel
            // 
            this.topMarginLabel.AutoSize = true;
            this.topMarginLabel.Enabled = false;
            this.topMarginLabel.Location = new System.Drawing.Point(8, 22);
            this.topMarginLabel.Name = "topMarginLabel";
            this.topMarginLabel.Size = new System.Drawing.Size(26, 13);
            this.topMarginLabel.TabIndex = 0;
            this.topMarginLabel.Text = "Top";
            // 
            // fontSettingStyleLabel
            // 
            this.fontSettingStyleLabel.AutoSize = true;
            this.fontSettingStyleLabel.Enabled = false;
            this.fontSettingStyleLabel.Location = new System.Drawing.Point(98, 68);
            this.fontSettingStyleLabel.Name = "fontSettingStyleLabel";
            this.fontSettingStyleLabel.Size = new System.Drawing.Size(30, 13);
            this.fontSettingStyleLabel.TabIndex = 8;
            this.fontSettingStyleLabel.Text = "Style";
            // 
            // fontStyleSelect
            // 
            this.fontStyleSelect.Enabled = false;
            this.fontStyleSelect.FormattingEnabled = true;
            this.fontStyleSelect.Items.AddRange(new object[] {
            "Regular",
            "Bold",
            "Italic",
            "BoldItalic",
            "Underline",
            "Strikeout"});
            this.fontStyleSelect.Location = new System.Drawing.Point(128, 65);
            this.fontStyleSelect.Name = "fontStyleSelect";
            this.fontStyleSelect.Size = new System.Drawing.Size(72, 21);
            this.fontStyleSelect.TabIndex = 7;
            // 
            // topAlign
            // 
            this.topAlign.AutoSize = true;
            this.topAlign.Checked = true;
            this.topAlign.Location = new System.Drawing.Point(16, 24);
            this.topAlign.Name = "topAlign";
            this.topAlign.Size = new System.Drawing.Size(44, 17);
            this.topAlign.TabIndex = 0;
            this.topAlign.TabStop = true;
            this.topAlign.Text = "Top";
            this.topAlign.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "To: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "From: ";
            // 
            // toPage
            // 
            this.toPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toPage.Enabled = false;
            this.toPage.Location = new System.Drawing.Point(77, 170);
            this.toPage.Name = "toPage";
            this.toPage.Size = new System.Drawing.Size(30, 20);
            this.toPage.TabIndex = 6;
            this.toPage.Text = "0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(208, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Default";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // fromPage
            // 
            this.fromPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fromPage.Enabled = false;
            this.fromPage.Location = new System.Drawing.Point(77, 144);
            this.fromPage.Name = "fromPage";
            this.fromPage.Size = new System.Drawing.Size(30, 20);
            this.fromPage.TabIndex = 5;
            this.fromPage.Text = "0";
            // 
            // evenPagesCheckBox
            // 
            this.evenPagesCheckBox.AutoSize = true;
            this.evenPagesCheckBox.Location = new System.Drawing.Point(16, 80);
            this.evenPagesCheckBox.Name = "evenPagesCheckBox";
            this.evenPagesCheckBox.Size = new System.Drawing.Size(83, 17);
            this.evenPagesCheckBox.TabIndex = 2;
            this.evenPagesCheckBox.Text = "Even Pages";
            this.evenPagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // oddPagesCheckBox
            // 
            this.oddPagesCheckBox.AutoSize = true;
            this.oddPagesCheckBox.Location = new System.Drawing.Point(16, 53);
            this.oddPagesCheckBox.Name = "oddPagesCheckBox";
            this.oddPagesCheckBox.Size = new System.Drawing.Size(78, 17);
            this.oddPagesCheckBox.TabIndex = 1;
            this.oddPagesCheckBox.Text = "Odd Pages";
            this.oddPagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // allPagesCheckBox
            // 
            this.allPagesCheckBox.AutoSize = true;
            this.allPagesCheckBox.Checked = true;
            this.allPagesCheckBox.Location = new System.Drawing.Point(16, 24);
            this.allPagesCheckBox.Name = "allPagesCheckBox";
            this.allPagesCheckBox.Size = new System.Drawing.Size(69, 17);
            this.allPagesCheckBox.TabIndex = 0;
            this.allPagesCheckBox.TabStop = true;
            this.allPagesCheckBox.Text = "All Pages";
            this.allPagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // rightAlign
            // 
            this.rightAlign.AutoSize = true;
            this.rightAlign.Location = new System.Drawing.Point(16, 70);
            this.rightAlign.Name = "rightAlign";
            this.rightAlign.Size = new System.Drawing.Size(50, 17);
            this.rightAlign.TabIndex = 2;
            this.rightAlign.Text = "Right";
            this.rightAlign.UseVisualStyleBackColor = true;
            // 
            // centerAlign
            // 
            this.centerAlign.AutoSize = true;
            this.centerAlign.Location = new System.Drawing.Point(16, 47);
            this.centerAlign.Name = "centerAlign";
            this.centerAlign.Size = new System.Drawing.Size(56, 17);
            this.centerAlign.TabIndex = 1;
            this.centerAlign.Text = "Center";
            this.centerAlign.UseVisualStyleBackColor = true;
            // 
            // leftAlign
            // 
            this.leftAlign.AutoSize = true;
            this.leftAlign.Checked = true;
            this.leftAlign.Location = new System.Drawing.Point(16, 24);
            this.leftAlign.Name = "leftAlign";
            this.leftAlign.Size = new System.Drawing.Size(43, 17);
            this.leftAlign.TabIndex = 0;
            this.leftAlign.TabStop = true;
            this.leftAlign.Text = "Left";
            this.leftAlign.UseVisualStyleBackColor = true;
            // 
            // customPagesCheckBox
            // 
            this.customPagesCheckBox.AutoSize = true;
            this.customPagesCheckBox.Location = new System.Drawing.Point(16, 110);
            this.customPagesCheckBox.Name = "customPagesCheckBox";
            this.customPagesCheckBox.Size = new System.Drawing.Size(60, 17);
            this.customPagesCheckBox.TabIndex = 4;
            this.customPagesCheckBox.Text = "Custom";
            this.customPagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // pdfView
            // 
            this.pdfView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pdfView.Location = new System.Drawing.Point(375, 12);
            this.pdfView.Name = "pdfView";
            this.pdfView.Size = new System.Drawing.Size(320, 420);
            this.pdfView.TabIndex = 48;
            this.pdfView.TabStop = false;
            // 
            // margin
            // 
            this.margin.Controls.Add(this.checkBox2);
            this.margin.Controls.Add(this.rightMargin);
            this.margin.Controls.Add(this.leftMargin);
            this.margin.Controls.Add(this.bottomMargin);
            this.margin.Controls.Add(this.topMargin);
            this.margin.Controls.Add(this.rightMarginLabel);
            this.margin.Controls.Add(this.leftMarginLabel);
            this.margin.Controls.Add(this.bottomMarginLabel);
            this.margin.Controls.Add(this.topMarginLabel);
            this.margin.Location = new System.Drawing.Point(99, 319);
            this.margin.Name = "margin";
            this.margin.Size = new System.Drawing.Size(270, 78);
            this.margin.TabIndex = 41;
            this.margin.TabStop = false;
            this.margin.Text = "Margin";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(194, 34);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Default";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // rightMargin
            // 
            this.rightMargin.Enabled = false;
            this.rightMargin.Location = new System.Drawing.Point(133, 49);
            this.rightMargin.Name = "rightMargin";
            this.rightMargin.Size = new System.Drawing.Size(42, 20);
            this.rightMargin.TabIndex = 7;
            this.rightMargin.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // leftMargin
            // 
            this.leftMargin.Enabled = false;
            this.leftMargin.Location = new System.Drawing.Point(38, 49);
            this.leftMargin.Name = "leftMargin";
            this.leftMargin.Size = new System.Drawing.Size(42, 20);
            this.leftMargin.TabIndex = 6;
            this.leftMargin.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // bottomMargin
            // 
            this.bottomMargin.Enabled = false;
            this.bottomMargin.Location = new System.Drawing.Point(133, 18);
            this.bottomMargin.Name = "bottomMargin";
            this.bottomMargin.Size = new System.Drawing.Size(42, 20);
            this.bottomMargin.TabIndex = 5;
            this.bottomMargin.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // topMargin
            // 
            this.topMargin.Enabled = false;
            this.topMargin.Location = new System.Drawing.Point(38, 18);
            this.topMargin.Name = "topMargin";
            this.topMargin.Size = new System.Drawing.Size(42, 20);
            this.topMargin.TabIndex = 4;
            this.topMargin.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // rightMarginLabel
            // 
            this.rightMarginLabel.AutoSize = true;
            this.rightMarginLabel.Enabled = false;
            this.rightMarginLabel.Location = new System.Drawing.Point(90, 53);
            this.rightMarginLabel.Name = "rightMarginLabel";
            this.rightMarginLabel.Size = new System.Drawing.Size(32, 13);
            this.rightMarginLabel.TabIndex = 3;
            this.rightMarginLabel.Text = "Right";
            // 
            // leftMarginLabel
            // 
            this.leftMarginLabel.AutoSize = true;
            this.leftMarginLabel.Enabled = false;
            this.leftMarginLabel.Location = new System.Drawing.Point(8, 52);
            this.leftMarginLabel.Name = "leftMarginLabel";
            this.leftMarginLabel.Size = new System.Drawing.Size(25, 13);
            this.leftMarginLabel.TabIndex = 2;
            this.leftMarginLabel.Text = "Left";
            // 
            // bottomMarginLabel
            // 
            this.bottomMarginLabel.AutoSize = true;
            this.bottomMarginLabel.Enabled = false;
            this.bottomMarginLabel.Location = new System.Drawing.Point(90, 22);
            this.bottomMarginLabel.Name = "bottomMarginLabel";
            this.bottomMarginLabel.Size = new System.Drawing.Size(40, 13);
            this.bottomMarginLabel.TabIndex = 1;
            this.bottomMarginLabel.Text = "Bottom";
            // 
            // bottomAlign
            // 
            this.bottomAlign.AutoSize = true;
            this.bottomAlign.Location = new System.Drawing.Point(16, 47);
            this.bottomAlign.Name = "bottomAlign";
            this.bottomAlign.Size = new System.Drawing.Size(58, 17);
            this.bottomAlign.TabIndex = 1;
            this.bottomAlign.Text = "Bottom";
            this.bottomAlign.UseVisualStyleBackColor = true;
            // 
            // fontSize
            // 
            this.fontSize.Enabled = false;
            this.fontSize.Location = new System.Drawing.Point(219, 26);
            this.fontSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.fontSize.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(35, 20);
            this.fontSize.TabIndex = 6;
            this.fontSize.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // fontSettingColorLabel
            // 
            this.fontSettingColorLabel.AutoSize = true;
            this.fontSettingColorLabel.Enabled = false;
            this.fontSettingColorLabel.Location = new System.Drawing.Point(11, 68);
            this.fontSettingColorLabel.Name = "fontSettingColorLabel";
            this.fontSettingColorLabel.Size = new System.Drawing.Size(31, 13);
            this.fontSettingColorLabel.TabIndex = 5;
            this.fontSettingColorLabel.Text = "Color";
            // 
            // fontSettingSizeLabel
            // 
            this.fontSettingSizeLabel.AutoSize = true;
            this.fontSettingSizeLabel.Enabled = false;
            this.fontSettingSizeLabel.Location = new System.Drawing.Point(186, 29);
            this.fontSettingSizeLabel.Name = "fontSettingSizeLabel";
            this.fontSettingSizeLabel.Size = new System.Drawing.Size(27, 13);
            this.fontSettingSizeLabel.TabIndex = 4;
            this.fontSettingSizeLabel.Text = "Size";
            // 
            // fontSettingFontLabel
            // 
            this.fontSettingFontLabel.AutoSize = true;
            this.fontSettingFontLabel.Enabled = false;
            this.fontSettingFontLabel.Location = new System.Drawing.Point(10, 29);
            this.fontSettingFontLabel.Name = "fontSettingFontLabel";
            this.fontSettingFontLabel.Size = new System.Drawing.Size(28, 13);
            this.fontSettingFontLabel.TabIndex = 3;
            this.fontSettingFontLabel.Text = "Font";
            // 
            // fontColorSelect
            // 
            this.fontColorSelect.Enabled = false;
            this.fontColorSelect.FormattingEnabled = true;
            this.fontColorSelect.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue",
            "Green",
            "White"});
            this.fontColorSelect.Location = new System.Drawing.Point(42, 65);
            this.fontColorSelect.Name = "fontColorSelect";
            this.fontColorSelect.Size = new System.Drawing.Size(52, 21);
            this.fontColorSelect.TabIndex = 2;
            // 
            // fontFamilySelect
            // 
            this.fontFamilySelect.Enabled = false;
            this.fontFamilySelect.FormattingEnabled = true;
            this.fontFamilySelect.Location = new System.Drawing.Point(42, 26);
            this.fontFamilySelect.Name = "fontFamilySelect";
            this.fontFamilySelect.Size = new System.Drawing.Size(140, 21);
            this.fontFamilySelect.TabIndex = 0;
            this.fontFamilySelect.Text = "Select Font Family";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Drag a file or click this box!";
            // 
            // customTextInput
            // 
            this.customTextInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customTextInput.Enabled = false;
            this.customTextInput.Location = new System.Drawing.Point(131, 423);
            this.customTextInput.Name = "customTextInput";
            this.customTextInput.Size = new System.Drawing.Size(233, 20);
            this.customTextInput.TabIndex = 46;
            this.customTextInput.Text = "PSIG";
            // 
            // useCustomText
            // 
            this.useCustomText.AutoSize = true;
            this.useCustomText.Location = new System.Drawing.Point(20, 425);
            this.useCustomText.Name = "useCustomText";
            this.useCustomText.Size = new System.Drawing.Size(105, 17);
            this.useCustomText.TabIndex = 45;
            this.useCustomText.Text = "Custom Header :";
            this.useCustomText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.useCustomText.UseVisualStyleBackColor = true;
            this.useCustomText.CheckedChanged += new System.EventHandler(this.useCustomText_CheckedChanged);
            // 
            // showStamp
            // 
            this.showStamp.AutoSize = true;
            this.showStamp.Checked = true;
            this.showStamp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showStamp.Enabled = false;
            this.showStamp.Location = new System.Drawing.Point(131, 401);
            this.showStamp.Name = "showStamp";
            this.showStamp.Size = new System.Drawing.Size(119, 17);
            this.showStamp.TabIndex = 44;
            this.showStamp.Text = "Show Page Header";
            this.showStamp.UseVisualStyleBackColor = true;
            // 
            // fontSetting
            // 
            this.fontSetting.Controls.Add(this.checkBox1);
            this.fontSetting.Controls.Add(this.fontSettingStyleLabel);
            this.fontSetting.Controls.Add(this.fontStyleSelect);
            this.fontSetting.Controls.Add(this.fontSize);
            this.fontSetting.Controls.Add(this.fontSettingColorLabel);
            this.fontSetting.Controls.Add(this.fontSettingSizeLabel);
            this.fontSetting.Controls.Add(this.fontSettingFontLabel);
            this.fontSetting.Controls.Add(this.fontColorSelect);
            this.fontSetting.Controls.Add(this.fontFamilySelect);
            this.fontSetting.Location = new System.Drawing.Point(99, 216);
            this.fontSetting.Name = "fontSetting";
            this.fontSetting.Size = new System.Drawing.Size(270, 101);
            this.fontSetting.TabIndex = 42;
            this.fontSetting.TabStop = false;
            this.fontSetting.Text = "Font Setting";
            // 
            // showPageNo
            // 
            this.showPageNo.AutoSize = true;
            this.showPageNo.Checked = true;
            this.showPageNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPageNo.Enabled = false;
            this.showPageNo.Location = new System.Drawing.Point(20, 401);
            this.showPageNo.Name = "showPageNo";
            this.showPageNo.Size = new System.Drawing.Size(98, 17);
            this.showPageNo.TabIndex = 43;
            this.showPageNo.Text = "Show Page No";
            this.showPageNo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.toPage);
            this.groupBox1.Controls.Add(this.fromPage);
            this.groupBox1.Controls.Add(this.customPagesCheckBox);
            this.groupBox1.Controls.Add(this.evenPagesCheckBox);
            this.groupBox1.Controls.Add(this.oddPagesCheckBox);
            this.groupBox1.Controls.Add(this.allPagesCheckBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(231, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 199);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pages";
            // 
            // pictureBox
            // 
            this.pictureBox.AllowDrop = true;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(20, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(191, 197);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 35;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            this.pictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragEnter);
            // 
            // alignText
            // 
            this.alignText.Controls.Add(this.rightAlign);
            this.alignText.Controls.Add(this.centerAlign);
            this.alignText.Controls.Add(this.leftAlign);
            this.alignText.Enabled = false;
            this.alignText.Location = new System.Drawing.Point(19, 216);
            this.alignText.Name = "alignText";
            this.alignText.Size = new System.Drawing.Size(74, 102);
            this.alignText.TabIndex = 39;
            this.alignText.TabStop = false;
            this.alignText.Text = "Align Text";
            // 
            // prevPageBtn
            // 
            this.prevPageBtn.Enabled = false;
            this.prevPageBtn.Location = new System.Drawing.Point(461, 440);
            this.prevPageBtn.Name = "prevPageBtn";
            this.prevPageBtn.Size = new System.Drawing.Size(52, 23);
            this.prevPageBtn.TabIndex = 34;
            this.prevPageBtn.Text = "Prev";
            this.prevPageBtn.UseVisualStyleBackColor = true;
            this.prevPageBtn.Click += new System.EventHandler(this.prevPageBtn_Click);
            // 
            // pageCountTextBox
            // 
            this.pageCountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageCountTextBox.Enabled = false;
            this.pageCountTextBox.Location = new System.Drawing.Point(519, 442);
            this.pageCountTextBox.Name = "pageCountTextBox";
            this.pageCountTextBox.Size = new System.Drawing.Size(53, 20);
            this.pageCountTextBox.TabIndex = 38;
            this.pageCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pageCountTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pageCountTextBox_KeyDown_1);
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.Enabled = false;
            this.nextPageBtn.Location = new System.Drawing.Point(578, 440);
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Size = new System.Drawing.Size(52, 23);
            this.nextPageBtn.TabIndex = 37;
            this.nextPageBtn.Text = "Next";
            this.nextPageBtn.UseVisualStyleBackColor = true;
            this.nextPageBtn.Click += new System.EventHandler(this.nextPageBtn_Click);
            // 
            // gravity
            // 
            this.gravity.Controls.Add(this.bottomAlign);
            this.gravity.Controls.Add(this.topAlign);
            this.gravity.Enabled = false;
            this.gravity.Location = new System.Drawing.Point(19, 319);
            this.gravity.Name = "gravity";
            this.gravity.Size = new System.Drawing.Size(74, 78);
            this.gravity.TabIndex = 40;
            this.gravity.TabStop = false;
            this.gravity.Text = "Gravity";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(274, 401);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(73, 17);
            this.checkBox3.TabIndex = 50;
            this.checkBox3.Text = "AutoSave";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(8, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "@Alhareth Aboud";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 468);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.pdfView);
            this.Controls.Add(this.margin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.customTextInput);
            this.Controls.Add(this.useCustomText);
            this.Controls.Add(this.showStamp);
            this.Controls.Add(this.fontSetting);
            this.Controls.Add(this.showPageNo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.alignText);
            this.Controls.Add(this.prevPageBtn);
            this.Controls.Add(this.pageCountTextBox);
            this.Controls.Add(this.nextPageBtn);
            this.Controls.Add(this.gravity);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(723, 507);
            this.MinimumSize = new System.Drawing.Size(723, 507);
            this.Name = "Form1";
            this.Text = "Elsa";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pdfView)).EndInit();
            this.margin.ResumeLayout(false);
            this.margin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            this.fontSetting.ResumeLayout(false);
            this.fontSetting.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.alignText.ResumeLayout(false);
            this.alignText.PerformLayout();
            this.gravity.ResumeLayout(false);
            this.gravity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topMarginLabel;
        private System.Windows.Forms.Label fontSettingStyleLabel;
        private System.Windows.Forms.ComboBox fontStyleSelect;
        private System.Windows.Forms.RadioButton topAlign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox toPage;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox fromPage;
        private System.Windows.Forms.RadioButton evenPagesCheckBox;
        private System.Windows.Forms.RadioButton oddPagesCheckBox;
        private System.Windows.Forms.RadioButton allPagesCheckBox;
        private System.Windows.Forms.RadioButton rightAlign;
        private System.Windows.Forms.RadioButton centerAlign;
        private System.Windows.Forms.RadioButton leftAlign;
        private System.Windows.Forms.RadioButton customPagesCheckBox;
        private System.Windows.Forms.PictureBox pdfView;
        private System.Windows.Forms.GroupBox margin;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.NumericUpDown rightMargin;
        private System.Windows.Forms.NumericUpDown leftMargin;
        private System.Windows.Forms.NumericUpDown bottomMargin;
        private System.Windows.Forms.NumericUpDown topMargin;
        private System.Windows.Forms.Label rightMarginLabel;
        private System.Windows.Forms.Label leftMarginLabel;
        private System.Windows.Forms.Label bottomMarginLabel;
        private System.Windows.Forms.RadioButton bottomAlign;
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.Label fontSettingColorLabel;
        private System.Windows.Forms.Label fontSettingSizeLabel;
        private System.Windows.Forms.Label fontSettingFontLabel;
        private System.Windows.Forms.ComboBox fontColorSelect;
        private System.Windows.Forms.ComboBox fontFamilySelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox customTextInput;
        private System.Windows.Forms.CheckBox useCustomText;
        private System.Windows.Forms.CheckBox showStamp;
        private System.Windows.Forms.GroupBox fontSetting;
        private System.Windows.Forms.CheckBox showPageNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox alignText;
        private System.Windows.Forms.Button prevPageBtn;
        private System.Windows.Forms.TextBox pageCountTextBox;
        private System.Windows.Forms.Button nextPageBtn;
        private System.Windows.Forms.GroupBox gravity;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label3;
    }
}

