namespace Hospital_registration
{
    partial class DoctorForm
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
            panel1 = new Panel();
            ConsulionTextBox = new TextBox();
            MedicineText = new Label();
            ReferalText = new Label();
            ConclusionText = new Label();
            DescriptionText = new Label();
            dataGridView2 = new DataGridView();
            IID = new DataGridViewTextBoxColumn();
            Birth = new DataGridViewTextBoxColumn();
            INAME = new DataGridViewTextBoxColumn();
            ISURNAME = new DataGridViewTextBoxColumn();
            ITAME = new DataGridViewTextBoxColumn();
            IDAY = new DataGridViewTextBoxColumn();
            SaveButton = new Button();
            ReferalTextBox = new TextBox();
            MedecineTextBox = new TextBox();
            ConsultationTextBox = new TextBox();
            recordTypeComboBox = new ComboBox();
            dataGridView1 = new DataGridView();
            CofuId = new DataGridViewTextBoxColumn();
            TuName = new DataGridViewTextBoxColumn();
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
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 165, 190);
            panel1.Controls.Add(ConsulionTextBox);
            panel1.Controls.Add(MedicineText);
            panel1.Controls.Add(ReferalText);
            panel1.Controls.Add(ConclusionText);
            panel1.Controls.Add(DescriptionText);
            panel1.Controls.Add(dataGridView2);
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
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1165, 678);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // ConsulionTextBox
            // 
            ConsulionTextBox.Location = new Point(637, 389);
            ConsulionTextBox.Margin = new Padding(2);
            ConsulionTextBox.Multiline = true;
            ConsulionTextBox.Name = "ConsulionTextBox";
            ConsulionTextBox.Size = new Size(439, 42);
            ConsulionTextBox.TabIndex = 20;
            // 
            // MedicineText
            // 
            MedicineText.AutoSize = true;
            MedicineText.Location = new Point(749, 216);
            MedicineText.Margin = new Padding(2, 0, 2, 0);
            MedicineText.Name = "MedicineText";
            MedicineText.Size = new Size(70, 20);
            MedicineText.TabIndex = 19;
            MedicineText.Text = "Medicine";
            // 
            // ReferalText
            // 
            ReferalText.AutoSize = true;
            ReferalText.Location = new Point(749, 282);
            ReferalText.Margin = new Padding(2, 0, 2, 0);
            ReferalText.Name = "ReferalText";
            ReferalText.Size = new Size(56, 20);
            ReferalText.TabIndex = 18;
            ReferalText.Text = "Referal";
            // 
            // ConclusionText
            // 
            ConclusionText.AutoSize = true;
            ConclusionText.Location = new Point(749, 355);
            ConclusionText.Margin = new Padding(2, 0, 2, 0);
            ConclusionText.Name = "ConclusionText";
            ConclusionText.Size = new Size(81, 20);
            ConclusionText.TabIndex = 17;
            ConclusionText.Text = "Conclusion";
            // 
            // DescriptionText
            // 
            DescriptionText.AutoSize = true;
            DescriptionText.Location = new Point(749, 151);
            DescriptionText.Margin = new Padding(2, 0, 2, 0);
            DescriptionText.Name = "DescriptionText";
            DescriptionText.Size = new Size(85, 20);
            DescriptionText.TabIndex = 16;
            DescriptionText.Text = "Description";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { IID, Birth, INAME, ISURNAME, ITAME, IDAY });
            dataGridView2.Location = new Point(637, 515);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 72;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(399, 107);
            dataGridView2.TabIndex = 15;
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
            SaveButton.Location = new Point(727, 454);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(267, 56);
            SaveButton.TabIndex = 14;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // ReferalTextBox
            // 
            ReferalTextBox.Location = new Point(637, 312);
            ReferalTextBox.Margin = new Padding(2);
            ReferalTextBox.Multiline = true;
            ReferalTextBox.Name = "ReferalTextBox";
            ReferalTextBox.Size = new Size(439, 42);
            ReferalTextBox.TabIndex = 12;
            // 
            // MedecineTextBox
            // 
            MedecineTextBox.Location = new Point(637, 239);
            MedecineTextBox.Margin = new Padding(2);
            MedecineTextBox.Multiline = true;
            MedecineTextBox.Name = "MedecineTextBox";
            MedecineTextBox.Size = new Size(439, 42);
            MedecineTextBox.TabIndex = 11;
            // 
            // ConsultationTextBox
            // 
            ConsultationTextBox.Location = new Point(637, 173);
            ConsultationTextBox.Margin = new Padding(2);
            ConsultationTextBox.Multiline = true;
            ConsultationTextBox.Name = "ConsultationTextBox";
            ConsultationTextBox.Size = new Size(439, 42);
            ConsultationTextBox.TabIndex = 10;
            ConsultationTextBox.TextChanged += ConsultationTextBox_TextChanged;
            // 
            // recordTypeComboBox
            // 
            recordTypeComboBox.FormattingEnabled = true;
            recordTypeComboBox.Items.AddRange(new object[] { "Consultation", "Referal", "Medecine" });
            recordTypeComboBox.Location = new Point(749, 115);
            recordTypeComboBox.Margin = new Padding(2);
            recordTypeComboBox.Name = "recordTypeComboBox";
            recordTypeComboBox.Size = new Size(143, 28);
            recordTypeComboBox.TabIndex = 9;
            recordTypeComboBox.SelectedIndexChanged += recordTypeComboBox_SelectedIndexChanged_1;
            recordTypeComboBox.TabIndexChanged += recordTypeComboBox_TabIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CofuId, TuName, TuSurname, TuHour, TuDay, TuInformation });
            dataGridView1.Location = new Point(39, 466);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(399, 107);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CofuId
            // 
            CofuId.HeaderText = "CofuId";
            CofuId.MinimumWidth = 9;
            CofuId.Name = "CofuId";
            CofuId.Visible = false;
            CofuId.Width = 175;
            // 
            // TuName
            // 
            TuName.HeaderText = "Name";
            TuName.MinimumWidth = 9;
            TuName.Name = "TuName";
            TuName.Width = 175;
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
            dataGridViewAppointments.Location = new Point(39, 332);
            dataGridViewAppointments.Margin = new Padding(2);
            dataGridViewAppointments.MultiSelect = false;
            dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewAppointments.RowHeadersWidth = 72;
            dataGridViewAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAppointments.Size = new Size(399, 107);
            dataGridViewAppointments.TabIndex = 7;
            dataGridViewAppointments.CellContentClick += dataGridViewAppointments_CellContentClick_1;
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
            btnSaveWorkingHours.Location = new Point(274, 258);
            btnSaveWorkingHours.Name = "btnSaveWorkingHours";
            btnSaveWorkingHours.Size = new Size(330, 56);
            btnSaveWorkingHours.TabIndex = 6;
            btnSaveWorkingHours.Text = "SaveWorkingHours";
            btnSaveWorkingHours.UseVisualStyleBackColor = false;
            btnSaveWorkingHours.Click += btnSaveWorkingHours_Click;
            // 
            // WorkHListBox1
            // 
            WorkHListBox1.FormattingEnabled = true;
            WorkHListBox1.Location = new Point(364, 130);
            WorkHListBox1.Name = "WorkHListBox1";
            WorkHListBox1.Size = new Size(145, 92);
            WorkHListBox1.TabIndex = 2;
            WorkHListBox1.ItemCheck += WorkHListBox1_ItemCheck;
            WorkHListBox1.SelectedIndexChanged += WorkHListBox1_SelectedIndexChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(55, 115);
            monthCalendar1.Margin = new Padding(7);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowToday = false;
            monthCalendar1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 150, 190);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1165, 89);
            panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(1129, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(37, 34);
            closeButton.TabIndex = 1;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1165, 89);
            label1.TabIndex = 0;
            label1.Text = "Doctor office";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 678);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DoctorForm";
            Text = "DoctorForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MonthCalendar monthCalendar1;
        private Panel panel2;
        private Label closeButton;
        private Label label1;
        private CheckedListBox WorkHListBox1;
        private Button btnSaveWorkingHours;
        private DataGridView dataGridViewAppointments;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CofId;
        private DataGridViewTextBoxColumn TName;
        private DataGridViewTextBoxColumn TSurname;
        private DataGridViewTextBoxColumn THour;
        private DataGridViewTextBoxColumn TDay;
        private DataGridViewTextBoxColumn TInformation;
        private DataGridViewButtonColumn TAcceptStatus;
        private DataGridViewTextBoxColumn CofuId;
        private DataGridViewTextBoxColumn TuName;
        private DataGridViewTextBoxColumn TuSurname;
        private DataGridViewTextBoxColumn TuHour;
        private DataGridViewTextBoxColumn TuDay;
        private DataGridViewTextBoxColumn TuInformation;
        private ComboBox recordTypeComboBox;
        private Button SaveButton;
        private TextBox ReferalTextBox;
        private TextBox MedecineTextBox;
        private TextBox ConsultationTextBox;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn IID;
        private DataGridViewTextBoxColumn INAME;
        private DataGridViewTextBoxColumn ISURNAME;
        private DataGridViewTextBoxColumn ITAME;
        private DataGridViewTextBoxColumn IDAY;
        private DataGridViewTextBoxColumn Birth;
        private Label DescriptionText;
        private Label MedicineText;
        private Label ReferalText;
        private Label ConclusionText;
        private TextBox ConsulionTextBox;
    }
}