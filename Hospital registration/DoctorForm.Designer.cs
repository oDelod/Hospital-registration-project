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
            dataGridViewAppointments = new DataGridView();
            btnSaveWorkingHours = new Button();
            WorkHListBox1 = new CheckedListBox();
            monthCalendar1 = new MonthCalendar();
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            Name = new DataGridViewTextBoxColumn();
            ColID = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            Day = new DataGridViewTextBoxColumn();
            Hour = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            TAcceptStatus = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 165, 190);
            panel1.Controls.Add(dataGridViewAppointments);
            panel1.Controls.Add(btnSaveWorkingHours);
            panel1.Controls.Add(WorkHListBox1);
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1747, 842);
            panel1.TabIndex = 2;
            // 
            // dataGridViewAppointments
            // 
            dataGridViewAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAppointments.Columns.AddRange(new DataGridViewColumn[] { Name, ColID, Surname, Day, Hour, status, TAcceptStatus });
            dataGridViewAppointments.Location = new Point(58, 498);
            dataGridViewAppointments.MultiSelect = false;
            dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewAppointments.RowHeadersWidth = 72;
            dataGridViewAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAppointments.Size = new Size(1604, 262);
            dataGridViewAppointments.TabIndex = 7;
            dataGridViewAppointments.CellClick += dataGridViewAppointments_CellClick;
            dataGridViewAppointments.CellContentClick += dataGridViewAppointments_CellContentClick_1;
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
            btnSaveWorkingHours.Font = new Font("Times New Roman", 26F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveWorkingHours.ForeColor = Color.White;
            btnSaveWorkingHours.Location = new Point(428, 389);
            btnSaveWorkingHours.Margin = new Padding(4);
            btnSaveWorkingHours.Name = "btnSaveWorkingHours";
            btnSaveWorkingHours.Size = new Size(401, 84);
            btnSaveWorkingHours.TabIndex = 6;
            btnSaveWorkingHours.Text = "Next";
            btnSaveWorkingHours.UseVisualStyleBackColor = false;
            btnSaveWorkingHours.Click += btnSaveWorkingHours_Click;
            // 
            // WorkHListBox1
            // 
            WorkHListBox1.FormattingEnabled = true;
            WorkHListBox1.Location = new Point(470, 182);
            WorkHListBox1.Margin = new Padding(4);
            WorkHListBox1.Name = "WorkHListBox1";
            WorkHListBox1.Size = new Size(215, 164);
            WorkHListBox1.TabIndex = 2;
            WorkHListBox1.ItemCheck += WorkHListBox1_ItemCheck;
            WorkHListBox1.SelectedIndexChanged += WorkHListBox1_SelectedIndexChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(83, 172);
            monthCalendar1.Margin = new Padding(11);
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
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1747, 134);
            panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(907, 0);
            closeButton.Margin = new Padding(4, 0, 4, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(50, 48);
            closeButton.TabIndex = 1;
            closeButton.Text = "X";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1747, 134);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Name
            // 
            Name.FillWeight = 1F;
            Name.HeaderText = "Name";
            Name.MinimumWidth = 9;
            Name.Name = "Name";
            Name.Width = 175;
            // 
            // ColID
            // 
            ColID.HeaderText = "iD";
            ColID.MinimumWidth = 9;
            ColID.Name = "ColID";
            ColID.Width = 175;
            // 
            // Surname
            // 
            Surname.FillWeight = 1F;
            Surname.HeaderText = "Surname";
            Surname.MinimumWidth = 9;
            Surname.Name = "Surname";
            Surname.Width = 142;
            // 
            // Day
            // 
            Day.FillWeight = 1F;
            Day.HeaderText = "Time";
            Day.MinimumWidth = 9;
            Day.Name = "Day";
            Day.Width = 175;
            // 
            // Hour
            // 
            Hour.FillWeight = 1F;
            Hour.HeaderText = "Hour";
            Hour.MinimumWidth = 9;
            Hour.Name = "Hour";
            Hour.Width = 175;
            // 
            // status
            // 
            status.FillWeight = 1F;
            status.HeaderText = "Status";
            status.MinimumWidth = 9;
            status.Name = "status";
            status.Width = 175;
            // 
            // TAcceptStatus
            // 
            TAcceptStatus.FillWeight = 1F;
            TAcceptStatus.HeaderText = "TAccept Status";
            TAcceptStatus.MinimumWidth = 9;
            TAcceptStatus.Name = "TAcceptStatus";
            TAcceptStatus.Width = 175;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1747, 842);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "DoctorForm";
            Text = "DoctorForm";
            panel1.ResumeLayout(false);
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
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewTextBoxColumn Hour;
        private DataGridViewTextBoxColumn status;
        private DataGridViewButtonColumn TAcceptStatus;
    }
}