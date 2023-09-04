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
            dataGridView1 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 165, 190);
            panel1.Controls.Add(dataGridView1);
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
            panel1.Size = new Size(960, 673);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(591, 408);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(420, 262);
            dataGridView1.TabIndex = 36;
            // 
            // SaveInformation
            // 
            SaveInformation.Location = new Point(234, 532);
            SaveInformation.Name = "SaveInformation";
            SaveInformation.Size = new Size(271, 40);
            SaveInformation.TabIndex = 35;
            SaveInformation.Text = "Save Information";
            SaveInformation.UseVisualStyleBackColor = true;
            SaveInformation.Click += SaveInformation_Click;
            // 
            // Information
            // 
            Information.Location = new Point(676, 212);
            Information.Name = "Information";
            Information.Size = new Size(175, 35);
            Information.TabIndex = 34;
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
            // Day
            // 
            Day.FormattingEnabled = true;
            Day.ItemHeight = 30;
            Day.Location = new Point(125, 337);
            Day.Margin = new Padding(4);
            Day.Name = "Day";
            Day.Size = new Size(215, 154);
            Day.TabIndex = 32;
            Day.SelectedIndexChanged += Day_SelectedIndexChanged;
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
            doctorsListBox.SelectedIndexChanged += doctorsListBox_SelectedIndexChanged;
            // 
            // specialListBox
            // 
            specialListBox.FormattingEnabled = true;
            specialListBox.ItemHeight = 30;
            specialListBox.Location = new Point(125, 175);
            specialListBox.Margin = new Padding(4);
            specialListBox.Name = "specialListBox";
            specialListBox.Size = new Size(215, 154);
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
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(960, 134);
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
            closeButton.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(960, 134);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 673);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "PatientForm";
            Text = "PatientForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Button SaveInformation;
        private TextBox Information;
    }
}