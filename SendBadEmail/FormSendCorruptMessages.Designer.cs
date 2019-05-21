namespace SendBadEmail
{
    partial class FormSendCorruptMessages
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
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownStopMessageNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMessageNum = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxAttachSizeUnit = new System.Windows.Forms.ComboBox();
            this.numericUpDownAttachSize = new System.Windows.Forms.NumericUpDown();
            this.checkBoxAddAttachment = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownSendDelay = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxAuthenticate = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.checkBoxSSL = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownSMTPPort = new System.Windows.Forms.NumericUpDown();
            this.textBoxTargetSMTPServer = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timerSend = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonRandomSender = new System.Windows.Forms.RadioButton();
            this.textBoxSenderUserTemplate = new System.Windows.Forms.TextBox();
            this.textBoxSpecificSender = new System.Windows.Forms.TextBox();
            this.radioButtonSpecificSender = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSenderDomainTemplate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRemoveRecipient = new System.Windows.Forms.Button();
            this.buttonAddRecipient = new System.Windows.Forms.Button();
            this.textBoxAddRecipient = new System.Windows.Forms.TextBox();
            this.listBoxRecipients = new System.Windows.Forms.ListBox();
            this.radioButtonSendToAllRecipients = new System.Windows.Forms.RadioButton();
            this.radioButtonSendToEachRecipient = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBoxTooManyOpenTags = new System.Windows.Forms.CheckBox();
            this.buttonShowLog = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStopMessageNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMessageNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAttachSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSendDelay)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSMTPPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Subject:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(613, 427);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 15;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.numericUpDownStopMessageNumber);
            this.groupBox5.Controls.Add(this.numericUpDownMessageNum);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.comboBoxAttachSizeUnit);
            this.groupBox5.Controls.Add(this.numericUpDownAttachSize);
            this.groupBox5.Controls.Add(this.checkBoxAddAttachment);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.numericUpDownSendDelay);
            this.groupBox5.Location = new System.Drawing.Point(12, 350);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(590, 74);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sending Options";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Stop at message number:";
            // 
            // numericUpDownStopMessageNumber
            // 
            this.numericUpDownStopMessageNumber.Location = new System.Drawing.Point(456, 45);
            this.numericUpDownStopMessageNumber.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownStopMessageNumber.Name = "numericUpDownStopMessageNumber";
            this.numericUpDownStopMessageNumber.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownStopMessageNumber.TabIndex = 7;
            // 
            // numericUpDownMessageNum
            // 
            this.numericUpDownMessageNum.Location = new System.Drawing.Point(456, 19);
            this.numericUpDownMessageNum.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownMessageNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMessageNum.Name = "numericUpDownMessageNum";
            this.numericUpDownMessageNum.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMessageNum.TabIndex = 6;
            this.numericUpDownMessageNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Next message number (%N):";
            // 
            // comboBoxAttachSizeUnit
            // 
            this.comboBoxAttachSizeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAttachSizeUnit.FormattingEnabled = true;
            this.comboBoxAttachSizeUnit.Items.AddRange(new object[] {
            "bytes",
            "Kb",
            "Mb"});
            this.comboBoxAttachSizeUnit.Location = new System.Drawing.Point(231, 42);
            this.comboBoxAttachSizeUnit.Name = "comboBoxAttachSizeUnit";
            this.comboBoxAttachSizeUnit.Size = new System.Drawing.Size(63, 21);
            this.comboBoxAttachSizeUnit.TabIndex = 4;
            // 
            // numericUpDownAttachSize
            // 
            this.numericUpDownAttachSize.Location = new System.Drawing.Point(117, 42);
            this.numericUpDownAttachSize.Name = "numericUpDownAttachSize";
            this.numericUpDownAttachSize.Size = new System.Drawing.Size(109, 20);
            this.numericUpDownAttachSize.TabIndex = 3;
            // 
            // checkBoxAddAttachment
            // 
            this.checkBoxAddAttachment.AutoSize = true;
            this.checkBoxAddAttachment.Location = new System.Drawing.Point(9, 44);
            this.checkBoxAddAttachment.Name = "checkBoxAddAttachment";
            this.checkBoxAddAttachment.Size = new System.Drawing.Size(104, 17);
            this.checkBoxAddAttachment.TabIndex = 2;
            this.checkBoxAddAttachment.Text = "Add attachment:";
            this.checkBoxAddAttachment.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Delay between sending messages (seconds):";
            // 
            // numericUpDownSendDelay
            // 
            this.numericUpDownSendDelay.DecimalPlaces = 2;
            this.numericUpDownSendDelay.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownSendDelay.Location = new System.Drawing.Point(232, 19);
            this.numericUpDownSendDelay.Name = "numericUpDownSendDelay";
            this.numericUpDownSendDelay.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownSendDelay.TabIndex = 0;
            this.numericUpDownSendDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.checkBoxAuthenticate);
            this.groupBox4.Controls.Add(this.textBoxPassword);
            this.groupBox4.Controls.Add(this.textBoxUsername);
            this.groupBox4.Controls.Add(this.checkBoxSSL);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.numericUpDownSMTPPort);
            this.groupBox4.Controls.Add(this.textBoxTargetSMTPServer);
            this.groupBox4.Location = new System.Drawing.Point(355, 228);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 116);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Target SMTP Server";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Username:";
            // 
            // checkBoxAuthenticate
            // 
            this.checkBoxAuthenticate.AutoSize = true;
            this.checkBoxAuthenticate.Location = new System.Drawing.Point(6, 65);
            this.checkBoxAuthenticate.Name = "checkBoxAuthenticate";
            this.checkBoxAuthenticate.Size = new System.Drawing.Size(86, 17);
            this.checkBoxAuthenticate.TabIndex = 6;
            this.checkBoxAuthenticate.Text = "Authenticate";
            this.checkBoxAuthenticate.UseVisualStyleBackColor = true;
            this.checkBoxAuthenticate.CheckedChanged += new System.EventHandler(this.checkBoxAuthenticate_CheckedChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(238, 88);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(86, 20);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(70, 88);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 4;
            // 
            // checkBoxSSL
            // 
            this.checkBoxSSL.AutoSize = true;
            this.checkBoxSSL.Location = new System.Drawing.Point(278, 48);
            this.checkBoxSSL.Name = "checkBoxSSL";
            this.checkBoxSSL.Size = new System.Drawing.Size(46, 17);
            this.checkBoxSSL.TabIndex = 3;
            this.checkBoxSSL.Text = "SSL";
            this.checkBoxSSL.UseVisualStyleBackColor = true;
            this.checkBoxSSL.CheckedChanged += new System.EventHandler(this.checkBoxSSL_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Port:";
            // 
            // numericUpDownSMTPPort
            // 
            this.numericUpDownSMTPPort.Location = new System.Drawing.Point(201, 45);
            this.numericUpDownSMTPPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownSMTPPort.Name = "numericUpDownSMTPPort";
            this.numericUpDownSMTPPort.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownSMTPPort.TabIndex = 1;
            this.numericUpDownSMTPPort.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // textBoxTargetSMTPServer
            // 
            this.textBoxTargetSMTPServer.Location = new System.Drawing.Point(6, 19);
            this.textBoxTargetSMTPServer.Name = "textBoxTargetSMTPServer";
            this.textBoxTargetSMTPServer.Size = new System.Drawing.Size(318, 20);
            this.textBoxTargetSMTPServer.TabIndex = 0;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(58, 22);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(269, 20);
            this.textBoxSubject.TabIndex = 0;
            this.textBoxSubject.Text = "Test Message %N";
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(613, 390);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 14;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(613, 361);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 13;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timerSend
            // 
            this.timerSend.Tick += new System.EventHandler(this.timerSend_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonRandomSender);
            this.groupBox1.Controls.Add(this.textBoxSenderUserTemplate);
            this.groupBox1.Controls.Add(this.textBoxSpecificSender);
            this.groupBox1.Controls.Add(this.radioButtonSpecificSender);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSenderDomainTemplate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 134);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sender";
            // 
            // radioButtonRandomSender
            // 
            this.radioButtonRandomSender.AutoSize = true;
            this.radioButtonRandomSender.Checked = true;
            this.radioButtonRandomSender.Location = new System.Drawing.Point(14, 48);
            this.radioButtonRandomSender.Name = "radioButtonRandomSender";
            this.radioButtonRandomSender.Size = new System.Drawing.Size(122, 17);
            this.radioButtonRandomSender.TabIndex = 6;
            this.radioButtonRandomSender.TabStop = true;
            this.radioButtonRandomSender.Text = "Randomized sender:";
            this.radioButtonRandomSender.UseVisualStyleBackColor = true;
            // 
            // textBoxSenderUserTemplate
            // 
            this.textBoxSenderUserTemplate.Location = new System.Drawing.Point(126, 97);
            this.textBoxSenderUserTemplate.Name = "textBoxSenderUserTemplate";
            this.textBoxSenderUserTemplate.Size = new System.Drawing.Size(199, 20);
            this.textBoxSenderUserTemplate.TabIndex = 5;
            this.textBoxSenderUserTemplate.Text = "*.*";
            // 
            // textBoxSpecificSender
            // 
            this.textBoxSpecificSender.Location = new System.Drawing.Point(126, 22);
            this.textBoxSpecificSender.Name = "textBoxSpecificSender";
            this.textBoxSpecificSender.Size = new System.Drawing.Size(199, 20);
            this.textBoxSpecificSender.TabIndex = 4;
            // 
            // radioButtonSpecificSender
            // 
            this.radioButtonSpecificSender.AutoSize = true;
            this.radioButtonSpecificSender.Location = new System.Drawing.Point(14, 23);
            this.radioButtonSpecificSender.Name = "radioButtonSpecificSender";
            this.radioButtonSpecificSender.Size = new System.Drawing.Size(101, 17);
            this.radioButtonSpecificSender.TabIndex = 3;
            this.radioButtonSpecificSender.Text = "Specific sender:";
            this.radioButtonSpecificSender.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User:";
            // 
            // textBoxSenderDomainTemplate
            // 
            this.textBoxSenderDomainTemplate.Location = new System.Drawing.Point(126, 71);
            this.textBoxSenderDomainTemplate.Name = "textBoxSenderDomainTemplate";
            this.textBoxSenderDomainTemplate.Size = new System.Drawing.Size(199, 20);
            this.textBoxSenderDomainTemplate.TabIndex = 1;
            this.textBoxSenderDomainTemplate.Text = "*.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domain:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRemoveRecipient);
            this.groupBox2.Controls.Add(this.buttonAddRecipient);
            this.groupBox2.Controls.Add(this.textBoxAddRecipient);
            this.groupBox2.Controls.Add(this.listBoxRecipients);
            this.groupBox2.Controls.Add(this.radioButtonSendToAllRecipients);
            this.groupBox2.Controls.Add(this.radioButtonSendToEachRecipient);
            this.groupBox2.Location = new System.Drawing.Point(12, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 192);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recipients";
            // 
            // buttonRemoveRecipient
            // 
            this.buttonRemoveRecipient.Location = new System.Drawing.Point(275, 164);
            this.buttonRemoveRecipient.Name = "buttonRemoveRecipient";
            this.buttonRemoveRecipient.Size = new System.Drawing.Size(56, 23);
            this.buttonRemoveRecipient.TabIndex = 5;
            this.buttonRemoveRecipient.Text = "Remove";
            this.buttonRemoveRecipient.UseVisualStyleBackColor = true;
            this.buttonRemoveRecipient.Click += new System.EventHandler(this.buttonRemoveRecipient_Click);
            // 
            // buttonAddRecipient
            // 
            this.buttonAddRecipient.Location = new System.Drawing.Point(231, 164);
            this.buttonAddRecipient.Name = "buttonAddRecipient";
            this.buttonAddRecipient.Size = new System.Drawing.Size(38, 23);
            this.buttonAddRecipient.TabIndex = 4;
            this.buttonAddRecipient.Text = "Add";
            this.buttonAddRecipient.UseVisualStyleBackColor = true;
            this.buttonAddRecipient.Click += new System.EventHandler(this.buttonAddRecipient_Click);
            // 
            // textBoxAddRecipient
            // 
            this.textBoxAddRecipient.Location = new System.Drawing.Point(6, 166);
            this.textBoxAddRecipient.Name = "textBoxAddRecipient";
            this.textBoxAddRecipient.Size = new System.Drawing.Size(228, 20);
            this.textBoxAddRecipient.TabIndex = 3;
            this.textBoxAddRecipient.TextChanged += new System.EventHandler(this.textBoxAddRecipient_TextChanged);
            // 
            // listBoxRecipients
            // 
            this.listBoxRecipients.FormattingEnabled = true;
            this.listBoxRecipients.Location = new System.Drawing.Point(6, 67);
            this.listBoxRecipients.Name = "listBoxRecipients";
            this.listBoxRecipients.Size = new System.Drawing.Size(325, 95);
            this.listBoxRecipients.TabIndex = 2;
            this.listBoxRecipients.SelectedIndexChanged += new System.EventHandler(this.listBoxRecipients_SelectedIndexChanged);
            // 
            // radioButtonSendToAllRecipients
            // 
            this.radioButtonSendToAllRecipients.AutoSize = true;
            this.radioButtonSendToAllRecipients.Location = new System.Drawing.Point(12, 44);
            this.radioButtonSendToAllRecipients.Name = "radioButtonSendToAllRecipients";
            this.radioButtonSendToAllRecipients.Size = new System.Drawing.Size(105, 17);
            this.radioButtonSendToAllRecipients.TabIndex = 1;
            this.radioButtonSendToAllRecipients.Text = "Send to all on list";
            this.radioButtonSendToAllRecipients.UseVisualStyleBackColor = true;
            // 
            // radioButtonSendToEachRecipient
            // 
            this.radioButtonSendToEachRecipient.AutoSize = true;
            this.radioButtonSendToEachRecipient.Checked = true;
            this.radioButtonSendToEachRecipient.Location = new System.Drawing.Point(12, 21);
            this.radioButtonSendToEachRecipient.Name = "radioButtonSendToEachRecipient";
            this.radioButtonSendToEachRecipient.Size = new System.Drawing.Size(103, 17);
            this.radioButtonSendToEachRecipient.TabIndex = 0;
            this.radioButtonSendToEachRecipient.TabStop = true;
            this.radioButtonSendToEachRecipient.Text = "Loop through list";
            this.radioButtonSendToEachRecipient.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxSubject);
            this.groupBox3.Location = new System.Drawing.Point(355, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 51);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Message";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBoxTooManyOpenTags);
            this.groupBox6.Location = new System.Drawing.Point(355, 69);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(333, 153);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Type of Corruption";
            // 
            // checkBoxTooManyOpenTags
            // 
            this.checkBoxTooManyOpenTags.AutoSize = true;
            this.checkBoxTooManyOpenTags.Location = new System.Drawing.Point(6, 19);
            this.checkBoxTooManyOpenTags.Name = "checkBoxTooManyOpenTags";
            this.checkBoxTooManyOpenTags.Size = new System.Drawing.Size(254, 17);
            this.checkBoxTooManyOpenTags.TabIndex = 0;
            this.checkBoxTooManyOpenTags.Text = "MIME Conversion Failure (too many nested tags)";
            this.checkBoxTooManyOpenTags.UseVisualStyleBackColor = true;
            // 
            // buttonShowLog
            // 
            this.buttonShowLog.Location = new System.Drawing.Point(527, 427);
            this.buttonShowLog.Name = "buttonShowLog";
            this.buttonShowLog.Size = new System.Drawing.Size(75, 23);
            this.buttonShowLog.TabIndex = 17;
            this.buttonShowLog.Text = "Show log...";
            this.buttonShowLog.UseVisualStyleBackColor = true;
            this.buttonShowLog.Click += new System.EventHandler(this.ButtonShowLog_Click);
            // 
            // FormSendCorruptMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 458);
            this.Controls.Add(this.buttonShowLog);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormSendCorruptMessages";
            this.Text = "Form1";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStopMessageNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMessageNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAttachSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSendDelay)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSMTPPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownStopMessageNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownMessageNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxAttachSizeUnit;
        private System.Windows.Forms.NumericUpDown numericUpDownAttachSize;
        private System.Windows.Forms.CheckBox checkBoxAddAttachment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownSendDelay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxAuthenticate;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.CheckBox checkBoxSSL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownSMTPPort;
        private System.Windows.Forms.TextBox textBoxTargetSMTPServer;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timerSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonRandomSender;
        private System.Windows.Forms.TextBox textBoxSenderUserTemplate;
        private System.Windows.Forms.TextBox textBoxSpecificSender;
        private System.Windows.Forms.RadioButton radioButtonSpecificSender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSenderDomainTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRemoveRecipient;
        private System.Windows.Forms.Button buttonAddRecipient;
        private System.Windows.Forms.TextBox textBoxAddRecipient;
        private System.Windows.Forms.ListBox listBoxRecipients;
        private System.Windows.Forms.RadioButton radioButtonSendToAllRecipients;
        private System.Windows.Forms.RadioButton radioButtonSendToEachRecipient;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBoxTooManyOpenTags;
        private System.Windows.Forms.Button buttonShowLog;
    }
}

