namespace Hospital_registration
{
    partial class PatientForm
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
            dataGridView2 = new DataGridView();
            DoctorName2 = new DataGridViewTextBoxColumn();
            DoctorSurname2 = new DataGridViewTextBoxColumn();
            DSpecialization2 = new DataGridViewTextBoxColumn();
            MeetingDate2 = new DataGridViewTextBoxColumn();
            Referal = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            DoctorName1 = new DataGridViewTextBoxColumn();
            DoctorSurname1 = new DataGridViewTextBoxColumn();
            DSpecialization1 = new DataGridViewTextBoxColumn();
            MeetingDate1 = new DataGridViewTextBoxColumn();
            Medications = new DataGridViewTextBoxColumn();
            ConsultationGridView = new DataGridView();
            DoctorName = new DataGridViewTextBoxColumn();
            DoctorSurname = new DataGridViewTextBoxColumn();
            DSpecialization = new DataGridViewTextBoxColumn();
            MeetingDate = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Conclusion = new DataGridViewTextBoxColumn();
            SaveInformation = new Button();
            Information = new TextBox();
            Hours = new ListBox();
            Day = new ListBox();
            doctorsListBox = new ListBox();
            specialListBox = new ListBox();
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ConsultationGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 165, 190);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(ConsultationGridView);
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
            panel1.Size = new Size(1502, 533);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { DoctorName2, DoctorSurname2, DSpecialization2, MeetingDate2, Referal });
            dataGridView2.Location = new Point(1175, 109);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 72;
            dataGridView2.Size = new Size(280, 175);
            dataGridView2.TabIndex = 38;
            // 
            // DoctorName2
            // 
            DoctorName2.HeaderText = "Dname";
            DoctorName2.MinimumWidth = 9;
            DoctorName2.Name = "DoctorName2";
            DoctorName2.Width = 175;
            // 
            // DoctorSurname2
            // 
            DoctorSurname2.HeaderText = "DSurname";
            DoctorSurname2.MinimumWidth = 9;
            DoctorSurname2.Name = "DoctorSurname2";
            DoctorSurname2.Width = 175;
            // 
            // DSpecialization2
            // 
            DSpecialization2.HeaderText = "DSpecialization";
            DSpecialization2.MinimumWidth = 9;
            DSpecialization2.Name = "DSpecialization2";
            DSpecialization2.Width = 175;
            // 
            // MeetingDate2
            // 
            MeetingDate2.HeaderText = "MeetingDate ";
            MeetingDate2.MinimumWidth = 9;
            MeetingDate2.Name = "MeetingDate2";
            MeetingDate2.Width = 175;
            // 
            // Referal
            // 
            Referal.HeaderText = "Referal";
            Referal.MinimumWidth = 9;
            Referal.Name = "Referal";
            Referal.Width = 175;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DoctorName1, DoctorSurname1, DSpecialization1, MeetingDate1, Medications });
            dataGridView1.Location = new Point(877, 109);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(280, 175);
            dataGridView1.TabIndex = 37;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // DoctorName1
            // 
            DoctorName1.HeaderText = "Dname";
            DoctorName1.MinimumWidth = 9;
            DoctorName1.Name = "DoctorName1";
            DoctorName1.Width = 175;
            // 
            // DoctorSurname1
            // 
            DoctorSurname1.HeaderText = "DSurname";
            DoctorSurname1.MinimumWidth = 9;
            DoctorSurname1.Name = "DoctorSurname1";
            DoctorSurname1.Width = 175;
            // 
            // DSpecialization1
            // 
            DSpecialization1.HeaderText = "DSpecialization";
            DSpecialization1.MinimumWidth = 9;
            DSpecialization1.Name = "DSpecialization1";
            DSpecialization1.Width = 175;
            // 
            // MeetingDate1
            // 
            MeetingDate1.HeaderText = "MeetingDate ";
            MeetingDate1.MinimumWidth = 9;
            MeetingDate1.Name = "MeetingDate1";
            MeetingDate1.Width = 175;
            // 
            // Medications
            // 
            Medications.HeaderText = "Medications";
            Medications.MinimumWidth = 9;
            Medications.Name = "Medications";
            Medications.Width = 175;
            // 
            // ConsultationGridView
            // 
            ConsultationGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ConsultationGridView.Columns.AddRange(new DataGridViewColumn[] { DoctorName, DoctorSurname, DSpecialization, MeetingDate, Description, Conclusion });
            ConsultationGridView.Location = new Point(586, 109);
            ConsultationGridView.Margin = new Padding(2);
            ConsultationGridView.Name = "ConsultationGridView";
            ConsultationGridView.RowHeadersWidth = 72;
            ConsultationGridView.Size = new Size(280, 175);
            ConsultationGridView.TabIndex = 36;
            ConsultationGridView.CellContentClick += Consultation_CellContentClick;
            // 
            // DoctorName
            // 
            DoctorName.HeaderText = "Dname";
            DoctorName.MinimumWidth = 9;
            DoctorName.Name = "DoctorName";
            DoctorName.Width = 175;
            // 
            // DoctorSurname
            // 
            DoctorSurname.HeaderText = "DSurname";
            DoctorSurname.MinimumWidth = 9;
            DoctorSurname.Name = "DoctorSurname";
            DoctorSurname.Width = 175;
            // 
            // DSpecialization
            // 
            DSpecialization.HeaderText = "DSpecialization";
            DSpecialization.MinimumWidth = 9;
            DSpecialization.Name = "DSpecialization";
            DSpecialization.Width = 175;
            // 
            // MeetingDate
            // 
            MeetingDate.HeaderText = "MeetingDate ";
            MeetingDate.MinimumWidth = 9;
            MeetingDate.Name = "MeetingDate";
            MeetingDate.Width = 175;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 9;
            Description.Name = "Description";
            Description.Width = 175;
            // 
            // Conclusion
            // 
            Conclusion.HeaderText = "Conclusion";
            Conclusion.MinimumWidth = 9;
            Conclusion.Name = "Conclusion";
            Conclusion.Width = 175;
            // 
            // SaveInformation
            // 
            SaveInformation.Location = new Point(156, 355);
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
            Information.Location = new Point(451, 141);
            Information.Margin = new Padding(2);
            Information.Name = "Information";
            Information.Size = new Size(118, 27);
            Information.TabIndex = 34;
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
            specialListBox.TabIndex = 30;
            specialListBox.SelectedIndexChanged += Special_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 150, 190);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1502, 89);
            panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(1469, 0);
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
            label1.Size = new Size(1502, 89);
            label1.TabIndex = 0;
            label1.Text = "Pathient office";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1502, 533);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PatientForm";
            Text = "PatientForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ConsultationGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label closeButton;
        private Label label1;
        private ListBox specialListBox;
        private ListBox Hours;
        private ListBox Day;
        private ListBox doctorsListBox;
        private DataGridView ConsultationGridView;
        private Button SaveInformation;
        private TextBox Information;
        private DataGridViewTextBoxColumn DoctorName;
        private DataGridViewTextBoxColumn DoctorSurname;
        private DataGridViewTextBoxColumn DSpecialization;
        private DataGridViewTextBoxColumn MeetingDate;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Conclusion;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn DoctorName1;
        private DataGridViewTextBoxColumn DoctorSurname1;
        private DataGridViewTextBoxColumn DSpecialization1;
        private DataGridViewTextBoxColumn MeetingDate1;
        private DataGridViewTextBoxColumn Medications;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn DoctorName2;
        private DataGridViewTextBoxColumn DoctorSurname2;
        private DataGridViewTextBoxColumn DSpecialization2;
        private DataGridViewTextBoxColumn MeetingDate2;
        private DataGridViewTextBoxColumn Referal;
    }
}