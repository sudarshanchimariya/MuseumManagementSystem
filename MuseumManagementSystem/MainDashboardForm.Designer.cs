namespace MuseumManagementSystem
{
    partial class MainDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboardForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmailAdd = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEmailAddr = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCsvInput = new System.Windows.Forms.Button();
            this.errFirstName = new System.Windows.Forms.Label();
            this.errContactNo = new System.Windows.Forms.Label();
            this.errOccupation = new System.Windows.Forms.Label();
            this.errEmailAddress = new System.Windows.Forms.Label();
            this.newVisitorEntryPanel = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.TxtInputPanel = new System.Windows.Forms.GroupBox();
            this.lblTxtImport = new System.Windows.Forms.Label();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.DispInputGridView = new System.Windows.Forms.DataGridView();
            this.tempVisitorID = new System.Windows.Forms.Label();
            this.visitorID = new System.Windows.Forms.Label();
            this.CheckOutTimepicker = new System.Windows.Forms.DateTimePicker();
            this.lblOutTime = new System.Windows.Forms.Label();
            this.CheckInTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.errLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.dateToday = new System.Windows.Forms.Label();
            this.lblInTime = new System.Windows.Forms.Label();
            this.lblMnlInput = new System.Windows.Forms.Label();
            this.dispReportPanel = new System.Windows.Forms.Panel();
            this.dispReportGridView = new System.Windows.Forms.DataGridView();
            this.dailyDatePicker = new System.Windows.Forms.DateTimePicker();
            this.weeklyDatePicker = new System.Windows.Forms.DateTimePicker();
            this.reportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDailyReport = new System.Windows.Forms.Button();
            this.fromLabel = new System.Windows.Forms.Label();
            this.reportDatePicker = new System.Windows.Forms.DateTimePicker();
            this.btnWeeklyReport = new System.Windows.Forms.Button();
            this.btnDailyList = new System.Windows.Forms.Button();
            this.csvOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnNewVisitor = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.VisitorBtnBox = new System.Windows.Forms.GroupBox();
            this.MainGrpBox = new System.Windows.Forms.GroupBox();
            this.lblMainMsg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblMms = new System.Windows.Forms.Label();
            this.lblMuMaSy = new System.Windows.Forms.Label();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.newVisitorEntryPanel.SuspendLayout();
            this.TxtInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DispInputGridView)).BeginInit();
            this.dispReportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dispReportGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).BeginInit();
            this.VisitorBtnBox.SuspendLayout();
            this.MainGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(19, 106);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(102, 20);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First Name";
            // 
            // lblEmailAdd
            // 
            this.lblEmailAdd.AutoSize = true;
            this.lblEmailAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAdd.Location = new System.Drawing.Point(19, 314);
            this.lblEmailAdd.Name = "lblEmailAdd";
            this.lblEmailAdd.Size = new System.Drawing.Size(131, 20);
            this.lblEmailAdd.TabIndex = 10;
            this.lblEmailAdd.Text = "Email Address";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(19, 261);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(108, 20);
            this.lblContact.TabIndex = 12;
            this.lblContact.Text = "Contact No.";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupation.Location = new System.Drawing.Point(19, 379);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(104, 20);
            this.lblOccupation.TabIndex = 13;
            this.lblOccupation.Text = "Occupation";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(161, 103);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(202, 23);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtEmailAddr
            // 
            this.txtEmailAddr.Location = new System.Drawing.Point(161, 314);
            this.txtEmailAddr.Name = "txtEmailAddr";
            this.txtEmailAddr.Size = new System.Drawing.Size(202, 23);
            this.txtEmailAddr.TabIndex = 5;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(161, 258);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(202, 23);
            this.txtContactNo.TabIndex = 4;
            // 
            // txtOccupation
            // 
            this.txtOccupation.Location = new System.Drawing.Point(161, 379);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(202, 23);
            this.txtOccupation.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Location = new System.Drawing.Point(1170, 499);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 34);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCsvInput
            // 
            this.btnCsvInput.Image = ((System.Drawing.Image)(resources.GetObject("btnCsvInput.Image")));
            this.btnCsvInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCsvInput.Location = new System.Drawing.Point(182, 38);
            this.btnCsvInput.Name = "btnCsvInput";
            this.btnCsvInput.Size = new System.Drawing.Size(123, 32);
            this.btnCsvInput.TabIndex = 10;
            this.btnCsvInput.Text = "CSV Import";
            this.btnCsvInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCsvInput.UseVisualStyleBackColor = true;
            this.btnCsvInput.Click += new System.EventHandler(this.BtnCsvInput_Click);
            // 
            // errFirstName
            // 
            this.errFirstName.AutoSize = true;
            this.errFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errFirstName.ForeColor = System.Drawing.Color.Red;
            this.errFirstName.Location = new System.Drawing.Point(369, 106);
            this.errFirstName.Name = "errFirstName";
            this.errFirstName.Size = new System.Drawing.Size(15, 20);
            this.errFirstName.TabIndex = 18;
            this.errFirstName.Text = "*";
            this.errFirstName.Visible = false;
            // 
            // errContactNo
            // 
            this.errContactNo.AutoSize = true;
            this.errContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errContactNo.ForeColor = System.Drawing.Color.Red;
            this.errContactNo.Location = new System.Drawing.Point(158, 284);
            this.errContactNo.Name = "errContactNo";
            this.errContactNo.Size = new System.Drawing.Size(136, 18);
            this.errContactNo.TabIndex = 16;
            this.errContactNo.Text = "Enter only numbers";
            this.errContactNo.Visible = false;
            // 
            // errOccupation
            // 
            this.errOccupation.AutoSize = true;
            this.errOccupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errOccupation.ForeColor = System.Drawing.Color.Red;
            this.errOccupation.Location = new System.Drawing.Point(368, 379);
            this.errOccupation.Name = "errOccupation";
            this.errOccupation.Size = new System.Drawing.Size(15, 20);
            this.errOccupation.TabIndex = 14;
            this.errOccupation.Text = "*";
            this.errOccupation.Visible = false;
            this.errOccupation.Click += new System.EventHandler(this.errOccuptn_Click);
            // 
            // errEmailAddress
            // 
            this.errEmailAddress.AutoSize = true;
            this.errEmailAddress.ForeColor = System.Drawing.Color.Red;
            this.errEmailAddress.Location = new System.Drawing.Point(157, 342);
            this.errEmailAddress.Name = "errEmailAddress";
            this.errEmailAddress.Size = new System.Drawing.Size(208, 17);
            this.errEmailAddress.TabIndex = 19;
            this.errEmailAddress.Text = "Must be in format abc@xyz.com";
            this.errEmailAddress.Visible = false;
            // 
            // newVisitorEntryPanel
            // 
            this.newVisitorEntryPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.newVisitorEntryPanel.Controls.Add(this.btnClear);
            this.newVisitorEntryPanel.Controls.Add(this.TxtInputPanel);
            this.newVisitorEntryPanel.Controls.Add(this.lblCardNo);
            this.newVisitorEntryPanel.Controls.Add(this.DispInputGridView);
            this.newVisitorEntryPanel.Controls.Add(this.tempVisitorID);
            this.newVisitorEntryPanel.Controls.Add(this.visitorID);
            this.newVisitorEntryPanel.Controls.Add(this.CheckOutTimepicker);
            this.newVisitorEntryPanel.Controls.Add(this.lblOutTime);
            this.newVisitorEntryPanel.Controls.Add(this.CheckInTimePicker);
            this.newVisitorEntryPanel.Controls.Add(this.errAddress);
            this.newVisitorEntryPanel.Controls.Add(this.btnSave);
            this.newVisitorEntryPanel.Controls.Add(this.txtAddress);
            this.newVisitorEntryPanel.Controls.Add(this.lblAddress);
            this.newVisitorEntryPanel.Controls.Add(this.errLastName);
            this.newVisitorEntryPanel.Controls.Add(this.txtLastName);
            this.newVisitorEntryPanel.Controls.Add(this.lblLastName);
            this.newVisitorEntryPanel.Controls.Add(this.dateToday);
            this.newVisitorEntryPanel.Controls.Add(this.lblInTime);
            this.newVisitorEntryPanel.Controls.Add(this.lblFirstName);
            this.newVisitorEntryPanel.Controls.Add(this.lblMnlInput);
            this.newVisitorEntryPanel.Controls.Add(this.errEmailAddress);
            this.newVisitorEntryPanel.Controls.Add(this.txtFirstName);
            this.newVisitorEntryPanel.Controls.Add(this.errContactNo);
            this.newVisitorEntryPanel.Controls.Add(this.errOccupation);
            this.newVisitorEntryPanel.Controls.Add(this.errFirstName);
            this.newVisitorEntryPanel.Controls.Add(this.lblEmailAdd);
            this.newVisitorEntryPanel.Controls.Add(this.txtEmailAddr);
            this.newVisitorEntryPanel.Controls.Add(this.lblOccupation);
            this.newVisitorEntryPanel.Controls.Add(this.txtOccupation);
            this.newVisitorEntryPanel.Controls.Add(this.txtContactNo);
            this.newVisitorEntryPanel.Controls.Add(this.lblContact);
            this.newVisitorEntryPanel.Location = new System.Drawing.Point(6, 19);
            this.newVisitorEntryPanel.Name = "newVisitorEntryPanel";
            this.newVisitorEntryPanel.Size = new System.Drawing.Size(1355, 594);
            this.newVisitorEntryPanel.TabIndex = 15;
            this.newVisitorEntryPanel.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(1011, 499);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 34);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // TxtInputPanel
            // 
            this.TxtInputPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TxtInputPanel.Controls.Add(this.lblTxtImport);
            this.TxtInputPanel.Controls.Add(this.btnCsvInput);
            this.TxtInputPanel.Location = new System.Drawing.Point(23, 486);
            this.TxtInputPanel.Name = "TxtInputPanel";
            this.TxtInputPanel.Size = new System.Drawing.Size(340, 94);
            this.TxtInputPanel.TabIndex = 29;
            this.TxtInputPanel.TabStop = false;
            this.TxtInputPanel.Text = "Import CSV File";
            // 
            // lblTxtImport
            // 
            this.lblTxtImport.AutoSize = true;
            this.lblTxtImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtImport.Location = new System.Drawing.Point(7, 44);
            this.lblTxtImport.Name = "lblTxtImport";
            this.lblTxtImport.Size = new System.Drawing.Size(129, 20);
            this.lblTxtImport.TabIndex = 17;
            this.lblTxtImport.Text = "Text File Input";
            this.lblTxtImport.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNo.Location = new System.Drawing.Point(19, 54);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(83, 20);
            this.lblCardNo.TabIndex = 27;
            this.lblCardNo.Text = "Card No.";
            // 
            // DispInputGridView
            // 
            this.DispInputGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DispInputGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DispInputGridView.Location = new System.Drawing.Point(390, 103);
            this.DispInputGridView.Name = "DispInputGridView";
            this.DispInputGridView.ReadOnly = true;
            this.DispInputGridView.RowTemplate.Height = 24;
            this.DispInputGridView.Size = new System.Drawing.Size(947, 296);
            this.DispInputGridView.TabIndex = 26;
            this.DispInputGridView.Visible = false;
            // 
            // tempVisitorID
            // 
            this.tempVisitorID.AutoSize = true;
            this.tempVisitorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempVisitorID.Location = new System.Drawing.Point(275, 57);
            this.tempVisitorID.Name = "tempVisitorID";
            this.tempVisitorID.Size = new System.Drawing.Size(35, 17);
            this.tempVisitorID.TabIndex = 25;
            this.tempVisitorID.Text = "001";
            this.tempVisitorID.Visible = false;
            // 
            // visitorID
            // 
            this.visitorID.AutoSize = true;
            this.visitorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorID.Location = new System.Drawing.Point(161, 54);
            this.visitorID.Name = "visitorID";
            this.visitorID.Size = new System.Drawing.Size(39, 20);
            this.visitorID.TabIndex = 24;
            this.visitorID.Text = "001";
            // 
            // CheckOutTimepicker
            // 
            this.CheckOutTimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.CheckOutTimepicker.Location = new System.Drawing.Point(518, 441);
            this.CheckOutTimepicker.MinDate = new System.DateTime(2019, 1, 19, 0, 0, 0, 0);
            this.CheckOutTimepicker.Name = "CheckOutTimepicker";
            this.CheckOutTimepicker.ShowUpDown = true;
            this.CheckOutTimepicker.Size = new System.Drawing.Size(202, 23);
            this.CheckOutTimepicker.TabIndex = 8;
            this.CheckOutTimepicker.Visible = false;
            // 
            // lblOutTime
            // 
            this.lblOutTime.AutoSize = true;
            this.lblOutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutTime.Location = new System.Drawing.Point(409, 441);
            this.lblOutTime.Name = "lblOutTime";
            this.lblOutTime.Size = new System.Drawing.Size(86, 20);
            this.lblOutTime.TabIndex = 22;
            this.lblOutTime.Text = "Out Time";
            this.lblOutTime.Visible = false;
            // 
            // CheckInTimePicker
            // 
            this.CheckInTimePicker.Enabled = false;
            this.CheckInTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.CheckInTimePicker.Location = new System.Drawing.Point(161, 441);
            this.CheckInTimePicker.MinDate = new System.DateTime(2019, 1, 19, 0, 0, 0, 0);
            this.CheckInTimePicker.Name = "CheckInTimePicker";
            this.CheckInTimePicker.ShowUpDown = true;
            this.CheckInTimePicker.Size = new System.Drawing.Size(202, 23);
            this.CheckInTimePicker.TabIndex = 7;
            // 
            // errAddress
            // 
            this.errAddress.AutoSize = true;
            this.errAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errAddress.ForeColor = System.Drawing.Color.Red;
            this.errAddress.Location = new System.Drawing.Point(368, 209);
            this.errAddress.Name = "errAddress";
            this.errAddress.Size = new System.Drawing.Size(15, 20);
            this.errAddress.TabIndex = 17;
            this.errAddress.Text = "*";
            this.errAddress.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(161, 209);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(202, 23);
            this.txtAddress.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(19, 208);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(78, 20);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address";
            // 
            // errLastName
            // 
            this.errLastName.AutoSize = true;
            this.errLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLastName.ForeColor = System.Drawing.Color.Red;
            this.errLastName.Location = new System.Drawing.Point(369, 153);
            this.errLastName.Name = "errLastName";
            this.errLastName.Size = new System.Drawing.Size(15, 20);
            this.errLastName.TabIndex = 15;
            this.errLastName.Text = "*";
            this.errLastName.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(161, 153);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(202, 23);
            this.txtLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(19, 156);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 20);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name";
            // 
            // dateToday
            // 
            this.dateToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToday.Location = new System.Drawing.Point(385, 14);
            this.dateToday.Name = "dateToday";
            this.dateToday.Size = new System.Drawing.Size(301, 31);
            this.dateToday.TabIndex = 18;
            this.dateToday.Text = "Today date";
            // 
            // lblInTime
            // 
            this.lblInTime.AutoSize = true;
            this.lblInTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInTime.Location = new System.Drawing.Point(24, 441);
            this.lblInTime.Name = "lblInTime";
            this.lblInTime.Size = new System.Drawing.Size(71, 20);
            this.lblInTime.TabIndex = 6;
            this.lblInTime.Text = "In Time";
            // 
            // lblMnlInput
            // 
            this.lblMnlInput.AutoSize = true;
            this.lblMnlInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMnlInput.Location = new System.Drawing.Point(17, 18);
            this.lblMnlInput.Name = "lblMnlInput";
            this.lblMnlInput.Size = new System.Drawing.Size(116, 20);
            this.lblMnlInput.TabIndex = 20;
            this.lblMnlInput.Text = "Manual Input";
            // 
            // dispReportPanel
            // 
            this.dispReportPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dispReportPanel.Controls.Add(this.dispReportGridView);
            this.dispReportPanel.Controls.Add(this.dailyDatePicker);
            this.dispReportPanel.Controls.Add(this.weeklyDatePicker);
            this.dispReportPanel.Controls.Add(this.reportChart);
            this.dispReportPanel.Controls.Add(this.label8);
            this.dispReportPanel.Controls.Add(this.btnDailyReport);
            this.dispReportPanel.Controls.Add(this.fromLabel);
            this.dispReportPanel.Controls.Add(this.reportDatePicker);
            this.dispReportPanel.Controls.Add(this.btnWeeklyReport);
            this.dispReportPanel.Controls.Add(this.btnDailyList);
            this.dispReportPanel.Location = new System.Drawing.Point(9, 19);
            this.dispReportPanel.Name = "dispReportPanel";
            this.dispReportPanel.Size = new System.Drawing.Size(1368, 668);
            this.dispReportPanel.TabIndex = 16;
            this.dispReportPanel.Visible = false;
            // 
            // dispReportGridView
            // 
            this.dispReportGridView.AllowUserToAddRows = false;
            this.dispReportGridView.AllowUserToDeleteRows = false;
            this.dispReportGridView.AllowUserToResizeColumns = false;
            this.dispReportGridView.AllowUserToResizeRows = false;
            this.dispReportGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dispReportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dispReportGridView.Location = new System.Drawing.Point(100, 109);
            this.dispReportGridView.Name = "dispReportGridView";
            this.dispReportGridView.Size = new System.Drawing.Size(1148, 250);
            this.dispReportGridView.TabIndex = 22;
            this.dispReportGridView.Visible = false;
            // 
            // dailyDatePicker
            // 
            this.dailyDatePicker.Location = new System.Drawing.Point(388, 73);
            this.dailyDatePicker.Name = "dailyDatePicker";
            this.dailyDatePicker.Size = new System.Drawing.Size(200, 23);
            this.dailyDatePicker.TabIndex = 30;
            // 
            // weeklyDatePicker
            // 
            this.weeklyDatePicker.Location = new System.Drawing.Point(814, 23);
            this.weeklyDatePicker.Name = "weeklyDatePicker";
            this.weeklyDatePicker.Size = new System.Drawing.Size(200, 23);
            this.weeklyDatePicker.TabIndex = 29;
            // 
            // reportChart
            // 
            chartArea2.Name = "ChartArea1";
            this.reportChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.reportChart.Legends.Add(legend2);
            this.reportChart.Location = new System.Drawing.Point(98, 379);
            this.reportChart.Name = "reportChart";
            this.reportChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Number of Visitor";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.reportChart.Series.Add(series2);
            this.reportChart.Size = new System.Drawing.Size(1150, 274);
            this.reportChart.TabIndex = 23;
            this.reportChart.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title1";
            title2.Text = "Time Spent Per Day";
            this.reportChart.Titles.Add(title2);
            this.reportChart.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(351, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Of";
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDailyReport.BackgroundImage")));
            this.btnDailyReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDailyReport.Location = new System.Drawing.Point(203, 67);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(136, 32);
            this.btnDailyReport.TabIndex = 27;
            this.btnDailyReport.Text = "Daily Report";
            this.btnDailyReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDailyReport.UseVisualStyleBackColor = true;
            this.btnDailyReport.Click += new System.EventHandler(this.BtnDailyReport_Click);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(760, 23);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(48, 20);
            this.fromLabel.TabIndex = 26;
            this.fromLabel.Text = "From";
            // 
            // reportDatePicker
            // 
            this.reportDatePicker.Location = new System.Drawing.Point(388, 17);
            this.reportDatePicker.Name = "reportDatePicker";
            this.reportDatePicker.Size = new System.Drawing.Size(200, 23);
            this.reportDatePicker.TabIndex = 25;
            // 
            // btnWeeklyReport
            // 
            this.btnWeeklyReport.Image = ((System.Drawing.Image)(resources.GetObject("btnWeeklyReport.Image")));
            this.btnWeeklyReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeeklyReport.Location = new System.Drawing.Point(611, 16);
            this.btnWeeklyReport.Name = "btnWeeklyReport";
            this.btnWeeklyReport.Size = new System.Drawing.Size(143, 35);
            this.btnWeeklyReport.TabIndex = 24;
            this.btnWeeklyReport.Text = "Weekly Report";
            this.btnWeeklyReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWeeklyReport.UseVisualStyleBackColor = true;
            this.btnWeeklyReport.Click += new System.EventHandler(this.BtnWeeklyReport_Click);
            // 
            // btnDailyList
            // 
            this.btnDailyList.Image = ((System.Drawing.Image)(resources.GetObject("btnDailyList.Image")));
            this.btnDailyList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDailyList.Location = new System.Drawing.Point(202, 14);
            this.btnDailyList.Name = "btnDailyList";
            this.btnDailyList.Size = new System.Drawing.Size(137, 37);
            this.btnDailyList.TabIndex = 23;
            this.btnDailyList.Text = "List of Visitors";
            this.btnDailyList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDailyList.UseVisualStyleBackColor = true;
            this.btnDailyList.Click += new System.EventHandler(this.BtnDailyList_Click);
            // 
            // csvOpenFileDialog
            // 
            this.csvOpenFileDialog.Filter = "\"CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt\"";
            this.csvOpenFileDialog.RestoreDirectory = true;
            this.csvOpenFileDialog.Title = "Browse Text and CSV Files";
            this.csvOpenFileDialog.ValidateNames = false;
            // 
            // btnNewVisitor
            // 
            this.btnNewVisitor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewVisitor.BackgroundImage")));
            this.btnNewVisitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewVisitor.Location = new System.Drawing.Point(20, 35);
            this.btnNewVisitor.Name = "btnNewVisitor";
            this.btnNewVisitor.Size = new System.Drawing.Size(154, 133);
            this.btnNewVisitor.TabIndex = 0;
            this.btnNewVisitor.Text = "New Entry";
            this.btnNewVisitor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewVisitor.UseVisualStyleBackColor = true;
            this.btnNewVisitor.Click += new System.EventHandler(this.NewEntryBtn_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(21, 36);
            this.txtSearchBox.Multiline = true;
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(271, 34);
            this.txtSearchBox.TabIndex = 1;
            this.txtSearchBox.Tag = "Search By Email";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(337, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerateReport.BackgroundImage")));
            this.btnGenerateReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGenerateReport.Location = new System.Drawing.Point(20, 196);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(154, 133);
            this.btnGenerateReport.TabIndex = 3;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.BtnReportGenerate_Click);
            // 
            // VisitorBtnBox
            // 
            this.VisitorBtnBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.VisitorBtnBox.Controls.Add(this.btnNewVisitor);
            this.VisitorBtnBox.Controls.Add(this.btnGenerateReport);
            this.VisitorBtnBox.Location = new System.Drawing.Point(51, 219);
            this.VisitorBtnBox.Name = "VisitorBtnBox";
            this.VisitorBtnBox.Size = new System.Drawing.Size(193, 360);
            this.VisitorBtnBox.TabIndex = 20;
            this.VisitorBtnBox.TabStop = false;
            this.VisitorBtnBox.Text = "Visitor Management";
            // 
            // MainGrpBox
            // 
            this.MainGrpBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MainGrpBox.Controls.Add(this.lblMainMsg);
            this.MainGrpBox.Controls.Add(this.newVisitorEntryPanel);
            this.MainGrpBox.Controls.Add(this.dispReportPanel);
            this.MainGrpBox.Location = new System.Drawing.Point(281, 282);
            this.MainGrpBox.Name = "MainGrpBox";
            this.MainGrpBox.Size = new System.Drawing.Size(1383, 702);
            this.MainGrpBox.TabIndex = 22;
            this.MainGrpBox.TabStop = false;
            this.MainGrpBox.Text = "New Entry";
            // 
            // lblMainMsg
            // 
            this.lblMainMsg.AutoSize = true;
            this.lblMainMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMsg.Location = new System.Drawing.Point(221, 122);
            this.lblMainMsg.Name = "lblMainMsg";
            this.lblMainMsg.Size = new System.Drawing.Size(403, 31);
            this.lblMainMsg.TabIndex = 22;
            this.lblMainMsg.Text = "Museum Management System";
            this.lblMainMsg.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(51, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 150);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // LblMms
            // 
            this.LblMms.AutoSize = true;
            this.LblMms.Font = new System.Drawing.Font("Bradley Hand ITC", 36.30252F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMms.Location = new System.Drawing.Point(444, 43);
            this.LblMms.Name = "LblMms";
            this.LblMms.Size = new System.Drawing.Size(844, 75);
            this.LblMms.TabIndex = 25;
            this.LblMms.Text = "Museum Management System";
            // 
            // lblMuMaSy
            // 
            this.lblMuMaSy.AutoSize = true;
            this.lblMuMaSy.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.20168F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuMaSy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMuMaSy.Location = new System.Drawing.Point(89, 167);
            this.lblMuMaSy.Name = "lblMuMaSy";
            this.lblMuMaSy.Size = new System.Drawing.Size(116, 46);
            this.lblMuMaSy.TabIndex = 26;
            this.lblMuMaSy.Text = "MMS";
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SearchGroupBox.Controls.Add(this.btnSearch);
            this.SearchGroupBox.Controls.Add(this.txtSearchBox);
            this.SearchGroupBox.Location = new System.Drawing.Point(634, 144);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(516, 100);
            this.SearchGroupBox.TabIndex = 27;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Check Out";
            // 
            // MainDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1705, 1027);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.lblMuMaSy);
            this.Controls.Add(this.VisitorBtnBox);
            this.Controls.Add(this.MainGrpBox);
            this.Controls.Add(this.LblMms);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MainDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Museum Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MuseumForm_Closed);
            this.Load += new System.EventHandler(this.MuseumForm_Load);
            this.newVisitorEntryPanel.ResumeLayout(false);
            this.newVisitorEntryPanel.PerformLayout();
            this.TxtInputPanel.ResumeLayout(false);
            this.TxtInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DispInputGridView)).EndInit();
            this.dispReportPanel.ResumeLayout(false);
            this.dispReportPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dispReportGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).EndInit();
            this.VisitorBtnBox.ResumeLayout(false);
            this.MainGrpBox.ResumeLayout(false);
            this.MainGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmailAdd;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtEmailAddr;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCsvInput;
        private System.Windows.Forms.Label errFirstName;
        private System.Windows.Forms.Label errContactNo;
        private System.Windows.Forms.Label errOccupation;
        private System.Windows.Forms.Label errEmailAddress;
        private System.Windows.Forms.Panel newVisitorEntryPanel;
        private System.Windows.Forms.Label lblTxtImport;
        private System.Windows.Forms.Label lblInTime;
        private System.Windows.Forms.Label dateToday;
        private System.Windows.Forms.Label errAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label errLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMnlInput;
        private System.Windows.Forms.DateTimePicker CheckInTimePicker;
        private System.Windows.Forms.OpenFileDialog csvOpenFileDialog;
        private System.Windows.Forms.Button btnNewVisitor;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.GroupBox VisitorBtnBox;
        private System.Windows.Forms.GroupBox MainGrpBox;
        private System.Windows.Forms.DataGridView dispReportGridView;
        private System.Windows.Forms.Panel dispReportPanel;
        private System.Windows.Forms.Button btnDailyList;
        private System.Windows.Forms.Button btnWeeklyReport;
        private System.Windows.Forms.Label lblMainMsg;
        private System.Windows.Forms.DateTimePicker CheckOutTimepicker;
        private System.Windows.Forms.Label lblOutTime;
        private System.Windows.Forms.Label visitorID;
        private System.Windows.Forms.Label tempVisitorID;
        private System.Windows.Forms.DateTimePicker reportDatePicker;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker dailyDatePicker;
        private System.Windows.Forms.DateTimePicker weeklyDatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDailyReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart reportChart;
        private System.Windows.Forms.DataGridView DispInputGridView;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblMms;
        private System.Windows.Forms.Label lblMuMaSy;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.GroupBox TxtInputPanel;
        private System.Windows.Forms.Button btnClear;
    }
}

