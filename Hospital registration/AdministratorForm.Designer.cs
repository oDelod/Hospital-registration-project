namespace Hospital_registration
{
    partial class AdministratorForm
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
            Surname1 = new DataGridViewTextBoxColumn();
            TuSurname = new DataGridViewTextBoxColumn();
            TuHour = new DataGridViewTextBoxColumn();
            TuDay = new DataGridViewTextBoxColumn();
            TuInformation = new DataGridViewTextBoxColumn();
            dataGridViewAppointments = new DataGridView();
            CofId = new DataGridViewTextBoxColumn();
            TName = new DataGridViewTextBoxColumn();
            TSurname = new DataGridViewTextBoxColumn();
            THour = new DataGridViewTextBoxColumn();
            TDay = new DataGridViewTextBoxColumn();
            TInformation = new DataGridViewTextBoxColumn();
            TAcceptStatus = new DataGridViewButtonColumn();
            btnSaveWorkingHours = new Button();
            WorkHListBox1 = new CheckedListBox();
            monthCalendar1 = new MonthCalendar();
            textBoxSearchdoctor = new TextBox();
            dataGridViewDoctor = new DataGridView();
            PUID = new DataGridViewTextBoxColumn();
            PName = new DataGridViewTextBoxColumn();
            PSurname = new DataGridViewTextBoxColumn();
            PLogin = new DataGridViewTextBoxColumn();
            textBoxSearchpathient = new TextBox();
            dataGridViewPatients = new DataGridView();
            UID1 = new DataGridViewTextBoxColumn();
            Name1 = new DataGridViewTextBoxColumn();
            Login1 = new DataGridViewTextBoxColumn();
            TuName = new DataGridViewTextBoxColumn();
            CofuId = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            IID = new DataGridViewTextBoxColumn();
            Birth = new DataGridViewTextBoxColumn();
            INAME = new DataGridViewTextBoxColumn();
            ISURNAME = new DataGridViewTextBoxColumn();
            ITAME = new DataGridViewTextBoxColumn();
            IDAY = new DataGridViewTextBoxColumn();
            ConsulionTextBox = new TextBox();
            MedicineText = new Label();
            ReferalText = new Label();
            ConclusionText = new Label();
            DescriptionText = new Label();
            SaveButton = new Button();
            ReferalTextBox = new TextBox();
            MedecineTextBox = new TextBox();
            ConsultationTextBox = new TextBox();
            recordTypeComboBox = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            SaveInformation = new Button();
            Information = new TextBox();
            Day = new ListBox();
            doctorsListBox = new ListBox();
            specialListBox = new ListBox();
            panel2 = new Panel();
            closeButton = new Label();
            panel1 = new Panel();
            ActivationButton = new Button();
            Ban = new Button();
            ACTIVATIONADMIN = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            Specialization = new Label();
            SPECIALIZATIONADMIN = new TextBox();
            SURNAMEADMIN = new TextBox();
            NAMEADMIN = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ROLEADMIN = new ComboBox();
            LoadUserData = new DataGridView();
            AdminID = new DataGridViewTextBoxColumn();
            AdminName = new DataGridViewTextBoxColumn();
            AdminSurname = new DataGridViewTextBoxColumn();
            AdminRole = new DataGridViewTextBoxColumn();
            AdministratorActivation = new DataGridViewTextBoxColumn();
            AdminSpecialization = new DataGridViewTextBoxColumn();
            SelectedUsers = new DataGridViewCheckBoxColumn();
            Hours = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoadUserData).BeginInit();
            SuspendLayout();
            // 
            // Surname1
            // 
            Surname1.HeaderText = "Surname";
            Surname1.MinimumWidth = 9;
            Surname1.Name = "Surname1";
            Surname1.Width = 175;
            // 
            // TuSurname
            // 
            TuSurname.HeaderText = "Surname";
            TuSurname.MinimumWidth = 9;
            TuSurname.Name = "TuSurname";
            TuSurname.Width = 175;
            // 
            // TuHour
            // 
            TuHour.FillWeight = 1F;
            TuHour.HeaderText = "Time";
            TuHour.MinimumWidth = 9;
            TuHour.Name = "TuHour";
            TuHour.Width = 175;
            // 
            // TuDay
            // 
            TuDay.HeaderText = "Day";
            TuDay.MinimumWidth = 9;
            TuDay.Name = "TuDay";
            TuDay.Width = 175;
            // 
            // TuInformation
            // 
            TuInformation.HeaderText = "Information";
            TuInformation.MinimumWidth = 9;
            TuInformation.Name = "TuInformation";
            TuInformation.Width = 175;
            // 
            // dataGridViewAppointments
            // 
            dataGridViewAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAppointments.Columns.AddRange(new DataGridViewColumn[] { CofId, TName, TSurname, THour, TDay, TInformation, TAcceptStatus });
            dataGridViewAppointments.Location = new Point(70, 671);
            dataGridViewAppointments.Margin = new Padding(2);
            dataGridViewAppointments.MultiSelect = false;
            dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewAppointments.RowHeadersWidth = 72;
            dataGridViewAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAppointments.Size = new Size(399, 107);
            dataGridViewAppointments.TabIndex = 44;
            dataGridViewAppointments.CellContentClick += dataGridViewAppointments_CellContentClick;
            // 
            // CofId
            // 
            CofId.HeaderText = "CofId";
            CofId.MinimumWidth = 9;
            CofId.Name = "CofId";
            CofId.Visible = false;
            CofId.Width = 175;
            // 
            // TName
            // 
            TName.HeaderText = "Name";
            TName.MinimumWidth = 9;
            TName.Name = "TName";
            TName.Width = 175;
            // 
            // TSurname
            // 
            TSurname.HeaderText = "Surname";
            TSurname.MinimumWidth = 9;
            TSurname.Name = "TSurname";
            TSurname.Width = 175;
            // 
            // THour
            // 
            THour.FillWeight = 1F;
            THour.HeaderText = "Time";
            THour.MinimumWidth = 9;
            THour.Name = "THour";
            THour.Width = 175;
            // 
            // TDay
            // 
            TDay.HeaderText = "Day";
            TDay.MinimumWidth = 9;
            TDay.Name = "TDay";
            TDay.Width = 175;
            // 
            // TInformation
            // 
            TInformation.HeaderText = "Information";
            TInformation.MinimumWidth = 9;
            TInformation.Name = "TInformation";
            TInformation.Width = 175;
            // 
            // TAcceptStatus
            // 
            TAcceptStatus.FillWeight = 1F;
            TAcceptStatus.HeaderText = "TAccept Status";
            TAcceptStatus.MinimumWidth = 9;
            TAcceptStatus.Name = "TAcceptStatus";
            TAcceptStatus.Width = 175;
            // 
            // btnSaveWorkingHours
            // 
            btnSaveWorkingHours.BackColor = Color.FromArgb(37, 150, 190);
            btnSaveWorkingHours.Cursor = Cursors.Hand;
            btnSaveWorkingHours.FlatAppearance.BorderColor = Color.FromArgb(37, 150, 190);
            btnSaveWorkingHours.FlatAppearance.BorderSize = 0;
            btnSaveWorkingHours.FlatAppearance.MouseDownBackColor = Color.FromArgb(37, 150, 190);
            btnSaveWorkingHours.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 150, 190);
            btnSaveWorkingHours.FlatStyle = FlatStyle.Flat;
            btnSaveWorkingHours.Font = new Font("Times New Roman", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveWorkingHours.ForeColor = Color.White;
            btnSaveWorkingHours.Location = new Point(271, 551);
            btnSaveWorkingHours.Name = "btnSaveWorkingHours";
            btnSaveWorkingHours.Size = new Size(315, 56);
            btnSaveWorkingHours.TabIndex = 43;
            btnSaveWorkingHours.Text = "SaveWorkingHours";
            btnSaveWorkingHours.UseVisualStyleBackColor = false;
            btnSaveWorkingHours.Click += btnSaveWorkingHours_Click;
            // 
            // WorkHListBox1
            // 
            WorkHListBox1.FormattingEnabled = true;
            WorkHListBox1.Location = new Point(281, 414);
            WorkHListBox1.Name = "WorkHListBox1";
            WorkHListBox1.Size = new Size(145, 92);
            WorkHListBox1.TabIndex = 42;
            WorkHListBox1.ItemCheck += WorkHListBox1_ItemCheck;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(69, 411);
            monthCalendar1.Margin = new Padding(7);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowToday = false;
            monthCalendar1.TabIndex = 41;
            // 
            // textBoxSearchdoctor
            // 
            textBoxSearchdoctor.Location = new Point(507, 110);
            textBoxSearchdoctor.Margin = new Padding(2);
            textBoxSearchdoctor.Name = "textBoxSearchdoctor";
            textBoxSearchdoctor.Size = new Size(118, 27);
            textBoxSearchdoctor.TabIndex = 40;
            textBoxSearchdoctor.TextChanged += textBoxSearchdoctor_TextChanged;
            // 
            // dataGridViewDoctor
            // 
            dataGridViewDoctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDoctor.Columns.AddRange(new DataGridViewColumn[] { PUID, PName, PSurname, PLogin });
            dataGridViewDoctor.Location = new Point(434, 137);
            dataGridViewDoctor.Margin = new Padding(2);
            dataGridViewDoctor.Name = "dataGridViewDoctor";
            dataGridViewDoctor.RowHeadersWidth = 72;
            dataGridViewDoctor.Size = new Size(280, 175);
            dataGridViewDoctor.TabIndex = 39;
            dataGridViewDoctor.CellContentClick += dataGridViewDoctor_CellContentClick;
            // 
            // PUID
            // 
            PUID.HeaderText = "UID1";
            PUID.MinimumWidth = 9;
            PUID.Name = "PUID";
            PUID.Width = 175;
            // 
            // PName
            // 
            PName.HeaderText = "Name";
            PName.MinimumWidth = 9;
            PName.Name = "PName";
            PName.Width = 175;
            // 
            // PSurname
            // 
            PSurname.HeaderText = "Surname";
            PSurname.MinimumWidth = 9;
            PSurname.Name = "PSurname";
            PSurname.Width = 175;
            // 
            // PLogin
            // 
            PLogin.HeaderText = "Login";
            PLogin.MinimumWidth = 9;
            PLogin.Name = "PLogin";
            PLogin.Width = 175;
            // 
            // textBoxSearchpathient
            // 
            textBoxSearchpathient.Location = new Point(500, 316);
            textBoxSearchpathient.Margin = new Padding(2);
            textBoxSearchpathient.Name = "textBoxSearchpathient";
            textBoxSearchpathient.Size = new Size(118, 27);
            textBoxSearchpathient.TabIndex = 38;
            textBoxSearchpathient.TextChanged += textBoxSearchpathient_TextChanged;
            // 
            // dataGridViewPatients
            // 
            dataGridViewPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPatients.Columns.AddRange(new DataGridViewColumn[] { UID1, Name1, Surname1, Login1 });
            dataGridViewPatients.Location = new Point(427, 345);
            dataGridViewPatients.Margin = new Padding(2);
            dataGridViewPatients.Name = "dataGridViewPatients";
            dataGridViewPatients.RowHeadersWidth = 72;
            dataGridViewPatients.Size = new Size(280, 175);
            dataGridViewPatients.TabIndex = 37;
            dataGridViewPatients.CellContentClick += dataGridViewPatients_CellContentClick;
            // 
            // UID1
            // 
            UID1.HeaderText = "UID1";
            UID1.MinimumWidth = 9;
            UID1.Name = "UID1";
            UID1.Width = 175;
            // 
            // Name1
            // 
            Name1.HeaderText = "Name";
            Name1.MinimumWidth = 9;
            Name1.Name = "Name1";
            Name1.Width = 175;
            // 
            // Login1
            // 
            Login1.HeaderText = "Login";
            Login1.MinimumWidth = 9;
            Login1.Name = "Login1";
            Login1.Width = 175;
            // 
            // TuName
            // 
            TuName.HeaderText = "Name";
            TuName.MinimumWidth = 9;
            TuName.Name = "TuName";
            TuName.Width = 175;
            // 
            // CofuId
            // 
            CofuId.HeaderText = "CofuId";
            CofuId.MinimumWidth = 9;
            CofuId.Name = "CofuId";
            CofuId.Visible = false;
            CofuId.Width = 175;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { IID, Birth, INAME, ISURNAME, ITAME, IDAY });
            dataGridView2.Location = new Point(887, 498);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 72;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(399, 107);
            dataGridView2.TabIndex = 57;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // IID
            // 
            IID.HeaderText = "CofuId";
            IID.MinimumWidth = 9;
            IID.Name = "IID";
            IID.Visible = false;
            IID.Width = 175;
            // 
            // Birth
            // 
            Birth.HeaderText = "Birth";
            Birth.MinimumWidth = 9;
            Birth.Name = "Birth";
            Birth.Width = 175;
            // 
            // INAME
            // 
            INAME.HeaderText = "Name";
            INAME.MinimumWidth = 9;
            INAME.Name = "INAME";
            INAME.Width = 175;
            // 
            // ISURNAME
            // 
            ISURNAME.HeaderText = "Surname";
            ISURNAME.MinimumWidth = 9;
            ISURNAME.Name = "ISURNAME";
            ISURNAME.Width = 175;
            // 
            // ITAME
            // 
            ITAME.FillWeight = 1F;
            ITAME.HeaderText = "Time";
            ITAME.MinimumWidth = 9;
            ITAME.Name = "ITAME";
            ITAME.Width = 175;
            // 
            // IDAY
            // 
            IDAY.HeaderText = "Day";
            IDAY.MinimumWidth = 9;
            IDAY.Name = "IDAY";
            IDAY.Width = 175;
            // 
            // ConsulionTextBox
            // 
            ConsulionTextBox.Location = new Point(868, 390);
            ConsulionTextBox.Margin = new Padding(2);
            ConsulionTextBox.Multiline = true;
            ConsulionTextBox.Name = "ConsulionTextBox";
            ConsulionTextBox.Size = new Size(439, 42);
            ConsulionTextBox.TabIndex = 56;
            // 
            // MedicineText
            // 
            MedicineText.AutoSize = true;
            MedicineText.ForeColor = SystemColors.ButtonHighlight;
            MedicineText.Location = new Point(980, 217);
            MedicineText.Margin = new Padding(2, 0, 2, 0);
            MedicineText.Name = "MedicineText";
            MedicineText.Size = new Size(70, 20);
            MedicineText.TabIndex = 55;
            MedicineText.Text = "Medicine";
            // 
            // ReferalText
            // 
            ReferalText.AutoSize = true;
            ReferalText.ForeColor = SystemColors.ButtonHighlight;
            ReferalText.Location = new Point(980, 283);
            ReferalText.Margin = new Padding(2, 0, 2, 0);
            ReferalText.Name = "ReferalText";
            ReferalText.Size = new Size(56, 20);
            ReferalText.TabIndex = 54;
            ReferalText.Text = "Referal";
            // 
            // ConclusionText
            // 
            ConclusionText.AutoSize = true;
            ConclusionText.ForeColor = SystemColors.ButtonHighlight;
            ConclusionText.Location = new Point(980, 356);
            ConclusionText.Margin = new Padding(2, 0, 2, 0);
            ConclusionText.Name = "ConclusionText";
            ConclusionText.Size = new Size(81, 20);
            ConclusionText.TabIndex = 53;
            ConclusionText.Text = "Conclusion";
            // 
            // DescriptionText
            // 
            DescriptionText.AutoSize = true;
            DescriptionText.ForeColor = SystemColors.ButtonHighlight;
            DescriptionText.Location = new Point(980, 153);
            DescriptionText.Margin = new Padding(2, 0, 2, 0);
            DescriptionText.Name = "DescriptionText";
            DescriptionText.Size = new Size(85, 20);
            DescriptionText.TabIndex = 52;
            DescriptionText.Text = "Description";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(37, 150, 190);
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.FlatAppearance.BorderColor = Color.FromArgb(37, 150, 190);
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(37, 150, 190);
            SaveButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 150, 190);
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Times New Roman", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(955, 437);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(267, 56);
            SaveButton.TabIndex = 50;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // ReferalTextBox
            // 
            ReferalTextBox.Location = new Point(868, 313);
            ReferalTextBox.Margin = new Padding(2);
            ReferalTextBox.Multiline = true;
            ReferalTextBox.Name = "ReferalTextBox";
            ReferalTextBox.Size = new Size(439, 42);
            ReferalTextBox.TabIndex = 49;
            // 
            // MedecineTextBox
            // 
            MedecineTextBox.Location = new Point(868, 241);
            MedecineTextBox.Margin = new Padding(2);
            MedecineTextBox.Multiline = true;
            MedecineTextBox.Name = "MedecineTextBox";
            MedecineTextBox.Size = new Size(439, 42);
            MedecineTextBox.TabIndex = 48;
            // 
            // ConsultationTextBox
            // 
            ConsultationTextBox.Location = new Point(868, 175);
            ConsultationTextBox.Margin = new Padding(2);
            ConsultationTextBox.Multiline = true;
            ConsultationTextBox.Name = "ConsultationTextBox";
            ConsultationTextBox.Size = new Size(439, 42);
            ConsultationTextBox.TabIndex = 47;
            // 
            // recordTypeComboBox
            // 
            recordTypeComboBox.FormattingEnabled = true;
            recordTypeComboBox.Items.AddRange(new object[] { "Consultation", "Referal", "Medecine" });
            recordTypeComboBox.Location = new Point(980, 116);
            recordTypeComboBox.Margin = new Padding(2);
            recordTypeComboBox.Name = "recordTypeComboBox";
            recordTypeComboBox.Size = new Size(143, 28);
            recordTypeComboBox.TabIndex = 46;
            recordTypeComboBox.SelectedIndexChanged += recordTypeComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1980, 89);
            label1.TabIndex = 0;
            label1.Text = "Administrator office";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CofuId, TuName, TuSurname, TuHour, TuDay, TuInformation });
            dataGridView1.Location = new Point(472, 671);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(399, 107);
            dataGridView1.TabIndex = 45;
            // 
            // SaveInformation
            // 
            SaveInformation.Location = new Point(156, 365);
            SaveInformation.Margin = new Padding(2);
            SaveInformation.Name = "SaveInformation";
            SaveInformation.Size = new Size(181, 27);
            SaveInformation.TabIndex = 35;
            SaveInformation.Text = "Save Information";
            SaveInformation.UseVisualStyleBackColor = true;
            SaveInformation.Click += SaveInformation_Click;
            // 
            // Information
            // 
            Information.Location = new Point(181, 334);
            Information.Margin = new Padding(2);
            Information.Name = "Information";
            Information.Size = new Size(118, 27);
            Information.TabIndex = 34;
            // 
            // Day
            // 
            Day.FormattingEnabled = true;
            Day.ItemHeight = 20;
            Day.Location = new Point(83, 225);
            Day.Name = "Day";
            Day.Size = new Size(145, 104);
            Day.TabIndex = 32;
            Day.SelectedIndexChanged += Day_SelectedIndexChanged;
            // 
            // doctorsListBox
            // 
            doctorsListBox.FormattingEnabled = true;
            doctorsListBox.ItemHeight = 20;
            doctorsListBox.Location = new Point(253, 117);
            doctorsListBox.Name = "doctorsListBox";
            doctorsListBox.Size = new Size(145, 104);
            doctorsListBox.TabIndex = 31;
            doctorsListBox.SelectedIndexChanged += doctorsListBox_SelectedIndexChanged;
            // 
            // specialListBox
            // 
            specialListBox.FormattingEnabled = true;
            specialListBox.ItemHeight = 20;
            specialListBox.Location = new Point(83, 117);
            specialListBox.Name = "specialListBox";
            specialListBox.Size = new Size(145, 104);
            specialListBox.TabIndex = 36;
            specialListBox.SelectedIndexChanged += specialListBox_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 150, 190);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1980, 89);
            panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(1943, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(37, 34);
            closeButton.TabIndex = 1;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 165, 190);
            panel1.Controls.Add(ActivationButton);
            panel1.Controls.Add(Ban);
            panel1.Controls.Add(ACTIVATIONADMIN);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Specialization);
            panel1.Controls.Add(SPECIALIZATIONADMIN);
            panel1.Controls.Add(SURNAMEADMIN);
            panel1.Controls.Add(NAMEADMIN);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ROLEADMIN);
            panel1.Controls.Add(LoadUserData);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(ConsulionTextBox);
            panel1.Controls.Add(MedicineText);
            panel1.Controls.Add(ReferalText);
            panel1.Controls.Add(ConclusionText);
            panel1.Controls.Add(DescriptionText);
            panel1.Controls.Add(SaveButton);
            panel1.Controls.Add(ReferalTextBox);
            panel1.Controls.Add(MedecineTextBox);
            panel1.Controls.Add(ConsultationTextBox);
            panel1.Controls.Add(recordTypeComboBox);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(dataGridViewAppointments);
            panel1.Controls.Add(btnSaveWorkingHours);
            panel1.Controls.Add(WorkHListBox1);
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(textBoxSearchdoctor);
            panel1.Controls.Add(dataGridViewDoctor);
            panel1.Controls.Add(textBoxSearchpathient);
            panel1.Controls.Add(dataGridViewPatients);
            panel1.Controls.Add(SaveInformation);
            panel1.Controls.Add(Information);
            panel1.Controls.Add(Hours);
            panel1.Controls.Add(Day);
            panel1.Controls.Add(doctorsListBox);
            panel1.Controls.Add(specialListBox);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1980, 857);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // ActivationButton
            // 
            ActivationButton.Location = new Point(1716, 457);
            ActivationButton.Name = "ActivationButton";
            ActivationButton.Size = new Size(94, 29);
            ActivationButton.TabIndex = 73;
            ActivationButton.Text = "Activation";
            ActivationButton.UseVisualStyleBackColor = true;
            ActivationButton.Click += ActivationButton_Click;
            // 
            // Ban
            // 
            Ban.Location = new Point(1437, 457);
            Ban.Name = "Ban";
            Ban.Size = new Size(94, 29);
            Ban.TabIndex = 72;
            Ban.Text = "Ban";
            Ban.UseVisualStyleBackColor = true;
            Ban.Click += Ban_Click;
            // 
            // ACTIVATIONADMIN
            // 
            ACTIVATIONADMIN.FormattingEnabled = true;
            ACTIVATIONADMIN.Items.AddRange(new object[] { "Activated", "Not activated" });
            ACTIVATIONADMIN.Location = new Point(1549, 414);
            ACTIVATIONADMIN.Name = "ACTIVATIONADMIN";
            ACTIVATIONADMIN.Size = new Size(151, 28);
            ACTIVATIONADMIN.TabIndex = 71;
            ACTIVATIONADMIN.TextChanged += ACTIVATIONADMIN_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(1585, 388);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 70;
            label5.Text = "Activation";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(1699, 355);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 68;
            label7.Text = "Surname";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(1437, 354);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 67;
            label6.Text = "Name";
            // 
            // Specialization
            // 
            Specialization.AutoSize = true;
            Specialization.ForeColor = SystemColors.Control;
            Specialization.Location = new Point(1699, 292);
            Specialization.Name = "Specialization";
            Specialization.Size = new Size(102, 20);
            Specialization.TabIndex = 66;
            Specialization.Text = "Specialization";
            // 
            // SPECIALIZATIONADMIN
            // 
            SPECIALIZATIONADMIN.Location = new Point(1699, 312);
            SPECIALIZATIONADMIN.Name = "SPECIALIZATIONADMIN";
            SPECIALIZATIONADMIN.Size = new Size(125, 27);
            SPECIALIZATIONADMIN.TabIndex = 65;
            SPECIALIZATIONADMIN.TextChanged += SPECIALIZATIONADMIN_TextChanged;
            // 
            // SURNAMEADMIN
            // 
            SURNAMEADMIN.Location = new Point(1699, 381);
            SURNAMEADMIN.Name = "SURNAMEADMIN";
            SURNAMEADMIN.Size = new Size(125, 27);
            SURNAMEADMIN.TabIndex = 64;
            SURNAMEADMIN.TextChanged += SURNAMEADMIN_TextChanged;
            // 
            // NAMEADMIN
            // 
            NAMEADMIN.Location = new Point(1437, 377);
            NAMEADMIN.Name = "NAMEADMIN";
            NAMEADMIN.Size = new Size(125, 27);
            NAMEADMIN.TabIndex = 63;
            NAMEADMIN.TextChanged += NAMEADMIN_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(1437, 292);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 62;
            label4.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(121, 390);
            label3.Name = "label3";
            label3.Size = new Size(247, 20);
            label3.TabIndex = 61;
            label3.Text = "Make an appointment with a doctor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(97, 94);
            label2.Name = "label2";
            label2.Size = new Size(285, 20);
            label2.TabIndex = 60;
            label2.Text = "Sign up for available hours for the patient";
            // 
            // ROLEADMIN
            // 
            ROLEADMIN.FormattingEnabled = true;
            ROLEADMIN.Items.AddRange(new object[] { "Administrator", "Patient", "Doctor", "Assistant" });
            ROLEADMIN.Location = new Point(1437, 312);
            ROLEADMIN.Name = "ROLEADMIN";
            ROLEADMIN.Size = new Size(151, 28);
            ROLEADMIN.TabIndex = 59;
            ROLEADMIN.TextChanged += ROLEADMIN_TextChanged;
            // 
            // LoadUserData
            // 
            LoadUserData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LoadUserData.Columns.AddRange(new DataGridViewColumn[] { AdminID, AdminName, AdminSurname, AdminRole, AdministratorActivation, AdminSpecialization, SelectedUsers });
            LoadUserData.Location = new Point(1437, 175);
            LoadUserData.Margin = new Padding(2);
            LoadUserData.MultiSelect = false;
            LoadUserData.Name = "LoadUserData";
            LoadUserData.RowHeadersWidth = 72;
            LoadUserData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadUserData.ShowCellErrors = false;
            LoadUserData.Size = new Size(399, 107);
            LoadUserData.TabIndex = 58;
            // 
            // AdminID
            // 
            AdminID.HeaderText = "ID";
            AdminID.MinimumWidth = 9;
            AdminID.Name = "AdminID";
            AdminID.Visible = false;
            AdminID.Width = 175;
            // 
            // AdminName
            // 
            AdminName.HeaderText = "Name";
            AdminName.MinimumWidth = 9;
            AdminName.Name = "AdminName";
            AdminName.Width = 175;
            // 
            // AdminSurname
            // 
            AdminSurname.HeaderText = "Surname";
            AdminSurname.MinimumWidth = 9;
            AdminSurname.Name = "AdminSurname";
            AdminSurname.Width = 175;
            // 
            // AdminRole
            // 
            AdminRole.HeaderText = "Role";
            AdminRole.MinimumWidth = 6;
            AdminRole.Name = "AdminRole";
            AdminRole.Width = 125;
            // 
            // AdministratorActivation
            // 
            AdministratorActivation.HeaderText = "Activation";
            AdministratorActivation.MinimumWidth = 6;
            AdministratorActivation.Name = "AdministratorActivation";
            AdministratorActivation.Width = 125;
            // 
            // AdminSpecialization
            // 
            AdminSpecialization.HeaderText = "Specialization";
            AdminSpecialization.MinimumWidth = 6;
            AdminSpecialization.Name = "AdminSpecialization";
            AdminSpecialization.Width = 125;
            // 
            // SelectedUsers
            // 
            SelectedUsers.HeaderText = "Selected";
            SelectedUsers.MinimumWidth = 6;
            SelectedUsers.Name = "SelectedUsers";
            SelectedUsers.Width = 125;
            // 
            // Hours
            // 
            Hours.FormattingEnabled = true;
            Hours.ItemHeight = 20;
            Hours.Location = new Point(253, 225);
            Hours.Name = "Hours";
            Hours.Size = new Size(145, 104);
            Hours.TabIndex = 33;
            // 
            // AdministratorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1980, 857);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "AdministratorForm";
            Text = "AdministratorForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LoadUserData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn Surname1;
        private DataGridViewTextBoxColumn TuSurname;
        private DataGridViewTextBoxColumn TuHour;
        private DataGridViewTextBoxColumn TuDay;
        private DataGridViewTextBoxColumn TuInformation;
        private DataGridView dataGridViewAppointments;
        private DataGridViewTextBoxColumn CofId;
        private DataGridViewTextBoxColumn TName;
        private DataGridViewTextBoxColumn TSurname;
        private DataGridViewTextBoxColumn THour;
        private DataGridViewTextBoxColumn TDay;
        private DataGridViewTextBoxColumn TInformation;
        private DataGridViewButtonColumn TAcceptStatus;
        private Button btnSaveWorkingHours;
        private CheckedListBox WorkHListBox1;
        private MonthCalendar monthCalendar1;
        private TextBox textBoxSearchdoctor;
        private DataGridView dataGridViewDoctor;
        private DataGridViewTextBoxColumn PUID;
        private DataGridViewTextBoxColumn PName;
        private DataGridViewTextBoxColumn PSurname;
        private DataGridViewTextBoxColumn PLogin;
        private TextBox textBoxSearchpathient;
        private DataGridView dataGridViewPatients;
        private DataGridViewTextBoxColumn UID1;
        private DataGridViewTextBoxColumn Name1;
        private DataGridViewTextBoxColumn Login1;
        private DataGridViewTextBoxColumn TuName;
        private DataGridViewTextBoxColumn CofuId;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn IID;
        private DataGridViewTextBoxColumn Birth;
        private DataGridViewTextBoxColumn INAME;
        private DataGridViewTextBoxColumn ISURNAME;
        private DataGridViewTextBoxColumn ITAME;
        private DataGridViewTextBoxColumn IDAY;
        private TextBox ConsulionTextBox;
        private Label MedicineText;
        private Label ReferalText;
        private Label ConclusionText;
        private Label DescriptionText;
        private Button SaveButton;
        private TextBox ReferalTextBox;
        private TextBox MedecineTextBox;
        private TextBox ConsultationTextBox;
        private ComboBox recordTypeComboBox;
        private Label label1;
        private DataGridView dataGridView1;
        private Button SaveInformation;
        private TextBox Information;
        private ListBox Day;
        private ListBox doctorsListBox;
        private ListBox specialListBox;
        private Panel panel2;
        private Label closeButton;
        private Panel panel1;
        private ListBox Hours;
        private DataGridView LoadUserData;
        private ComboBox ROLEADMIN;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox SPECIALIZATIONADMIN;
        private TextBox SURNAMEADMIN;
        private TextBox NAMEADMIN;
        private Label label7;
        private Label label6;
        private Label Specialization;
        private ComboBox ACTIVATIONADMIN;
        private Label label5;
        private DataGridViewTextBoxColumn AdminID;
        private DataGridViewTextBoxColumn AdminName;
        private DataGridViewTextBoxColumn AdminSurname;
        private DataGridViewTextBoxColumn AdminRole;
        private DataGridViewTextBoxColumn AdministratorActivation;
        private DataGridViewTextBoxColumn AdminSpecialization;
        private DataGridViewCheckBoxColumn SelectedUsers;
        private Button Ban;
        private Button ActivationButton;
    }
}