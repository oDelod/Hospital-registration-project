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
            Hours = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            dataGridViewAppointments.Location = new Point(103, 918);
            dataGridViewAppointments.MultiSelect = false;
            dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewAppointments.RowHeadersWidth = 72;
            dataGridViewAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAppointments.Size = new Size(598, 161);
            dataGridViewAppointments.TabIndex = 44;
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
            btnSaveWorkingHours.Location = new Point(380, 814);
            btnSaveWorkingHours.Margin = new Padding(4);
            btnSaveWorkingHours.Name = "btnSaveWorkingHours";
            btnSaveWorkingHours.Size = new Size(401, 84);
            btnSaveWorkingHours.TabIndex = 43;
            btnSaveWorkingHours.Text = "SaveWorkingHours";
            btnSaveWorkingHours.UseVisualStyleBackColor = false;
            // 
            // WorkHListBox1
            // 
            WorkHListBox1.FormattingEnabled = true;
            WorkHListBox1.Location = new Point(422, 621);
            WorkHListBox1.Margin = new Padding(4);
            WorkHListBox1.Name = "WorkHListBox1";
            WorkHListBox1.Size = new Size(215, 164);
            WorkHListBox1.TabIndex = 42;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(103, 597);
            monthCalendar1.Margin = new Padding(11);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowToday = false;
            monthCalendar1.TabIndex = 41;
            // 
            // textBoxSearchdoctor
            // 
            textBoxSearchdoctor.Location = new Point(760, 165);
            textBoxSearchdoctor.Name = "textBoxSearchdoctor";
            textBoxSearchdoctor.Size = new Size(175, 35);
            textBoxSearchdoctor.TabIndex = 40;
            // 
            // dataGridViewDoctor
            // 
            dataGridViewDoctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDoctor.Columns.AddRange(new DataGridViewColumn[] { PUID, PName, PSurname, PLogin });
            dataGridViewDoctor.Location = new Point(651, 206);
            dataGridViewDoctor.Name = "dataGridViewDoctor";
            dataGridViewDoctor.RowHeadersWidth = 72;
            dataGridViewDoctor.Size = new Size(420, 262);
            dataGridViewDoctor.TabIndex = 39;
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
            textBoxSearchpathient.Location = new Point(750, 474);
            textBoxSearchpathient.Name = "textBoxSearchpathient";
            textBoxSearchpathient.Size = new Size(175, 35);
            textBoxSearchpathient.TabIndex = 38;
            // 
            // dataGridViewPatients
            // 
            dataGridViewPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPatients.Columns.AddRange(new DataGridViewColumn[] { UID1, Name1, Surname1, Login1 });
            dataGridViewPatients.Location = new Point(641, 518);
            dataGridViewPatients.Name = "dataGridViewPatients";
            dataGridViewPatients.RowHeadersWidth = 72;
            dataGridViewPatients.Size = new Size(420, 262);
            dataGridViewPatients.TabIndex = 37;
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
            dataGridView2.Location = new Point(1330, 774);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 72;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(598, 161);
            dataGridView2.TabIndex = 57;
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
            ConsulionTextBox.Location = new Point(1302, 585);
            ConsulionTextBox.Multiline = true;
            ConsulionTextBox.Name = "ConsulionTextBox";
            ConsulionTextBox.Size = new Size(656, 61);
            ConsulionTextBox.TabIndex = 56;
            // 
            // MedicineText
            // 
            MedicineText.AutoSize = true;
            MedicineText.Location = new Point(1470, 326);
            MedicineText.Name = "MedicineText";
            MedicineText.Size = new Size(98, 30);
            MedicineText.TabIndex = 55;
            MedicineText.Text = "Medicine";
            // 
            // ReferalText
            // 
            ReferalText.AutoSize = true;
            ReferalText.Location = new Point(1470, 425);
            ReferalText.Name = "ReferalText";
            ReferalText.Size = new Size(77, 30);
            ReferalText.TabIndex = 54;
            ReferalText.Text = "Referal";
            // 
            // ConclusionText
            // 
            ConclusionText.AutoSize = true;
            ConclusionText.Location = new Point(1470, 534);
            ConclusionText.Name = "ConclusionText";
            ConclusionText.Size = new Size(115, 30);
            ConclusionText.TabIndex = 53;
            ConclusionText.Text = "Conclusion";
            // 
            // DescriptionText
            // 
            DescriptionText.AutoSize = true;
            DescriptionText.Location = new Point(1467, 215);
            DescriptionText.Name = "DescriptionText";
            DescriptionText.Size = new Size(118, 30);
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
            SaveButton.Location = new Point(1437, 683);
            SaveButton.Margin = new Padding(4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(401, 84);
            SaveButton.TabIndex = 50;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // ReferalTextBox
            // 
            ReferalTextBox.Location = new Point(1302, 470);
            ReferalTextBox.Multiline = true;
            ReferalTextBox.Name = "ReferalTextBox";
            ReferalTextBox.Size = new Size(656, 61);
            ReferalTextBox.TabIndex = 49;
            // 
            // MedecineTextBox
            // 
            MedecineTextBox.Location = new Point(1302, 361);
            MedecineTextBox.Multiline = true;
            MedecineTextBox.Name = "MedecineTextBox";
            MedecineTextBox.Size = new Size(656, 61);
            MedecineTextBox.TabIndex = 48;
            // 
            // ConsultationTextBox
            // 
            ConsultationTextBox.Location = new Point(1302, 262);
            ConsultationTextBox.Multiline = true;
            ConsultationTextBox.Name = "ConsultationTextBox";
            ConsultationTextBox.Size = new Size(656, 61);
            ConsultationTextBox.TabIndex = 47;
            // 
            // recordTypeComboBox
            // 
            recordTypeComboBox.FormattingEnabled = true;
            recordTypeComboBox.Items.AddRange(new object[] { "Consultation", "Referal", "Medecine" });
            recordTypeComboBox.Location = new Point(1470, 174);
            recordTypeComboBox.Name = "recordTypeComboBox";
            recordTypeComboBox.Size = new Size(212, 38);
            recordTypeComboBox.TabIndex = 46;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(2087, 134);
            label1.TabIndex = 0;
            label1.Text = "Assistant office";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CofuId, TuName, TuSurname, TuHour, TuDay, TuInformation });
            dataGridView1.Location = new Point(707, 918);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(598, 161);
            dataGridView1.TabIndex = 45;
            // 
            // SaveInformation
            // 
            SaveInformation.Location = new Point(234, 532);
            SaveInformation.Name = "SaveInformation";
            SaveInformation.Size = new Size(271, 40);
            SaveInformation.TabIndex = 35;
            SaveInformation.Text = "Save Information";
            SaveInformation.UseVisualStyleBackColor = true;
            // 
            // Information
            // 
            Information.Location = new Point(271, 491);
            Information.Name = "Information";
            Information.Size = new Size(175, 35);
            Information.TabIndex = 34;
            // 
            // Day
            // 
            Day.FormattingEnabled = true;
            Day.ItemHeight = 30;
            Day.Location = new Point(125, 337);
            Day.Margin = new Padding(4);
            Day.Name = "Day";
            Day.Size = new Size(215, 154);
            Day.TabIndex = 32;
            // 
            // doctorsListBox
            // 
            doctorsListBox.FormattingEnabled = true;
            doctorsListBox.ItemHeight = 30;
            doctorsListBox.Location = new Point(380, 175);
            doctorsListBox.Margin = new Padding(4);
            doctorsListBox.Name = "doctorsListBox";
            doctorsListBox.Size = new Size(215, 154);
            doctorsListBox.TabIndex = 31;
            // 
            // specialListBox
            // 
            specialListBox.FormattingEnabled = true;
            specialListBox.ItemHeight = 30;
            specialListBox.Location = new Point(125, 175);
            specialListBox.Margin = new Padding(4);
            specialListBox.Name = "specialListBox";
            specialListBox.Size = new Size(215, 154);
            specialListBox.TabIndex = 36;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 150, 190);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(2087, 134);
            panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(2185, 0);
            closeButton.Margin = new Padding(4, 0, 4, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(50, 48);
            closeButton.TabIndex = 1;
            closeButton.Text = "X";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 165, 190);
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
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(2087, 1286);
            panel1.TabIndex = 3;
            // 
            // Hours
            // 
            Hours.FormattingEnabled = true;
            Hours.ItemHeight = 30;
            Hours.Location = new Point(380, 337);
            Hours.Margin = new Padding(4);
            Hours.Name = "Hours";
            Hours.Size = new Size(215, 154);
            Hours.TabIndex = 33;
            // 
            // AdministratorForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2087, 1286);
            Controls.Add(panel1);
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
    }
}