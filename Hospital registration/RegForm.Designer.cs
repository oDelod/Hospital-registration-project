﻿namespace Hospital_registration
{
    partial class RegForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            panel1 = new Panel();
            HaveAccountButton = new Button();
            label10 = new Label();
            label11 = new Label();
            PostIndexRField = new TextBox();
            AdressRField = new TextBox();
            label12 = new Label();
            label13 = new Label();
            PhoneRField = new TextBox();
            EmailRField = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SpecialRField = new TextBox();
            BirthRField = new TextBox();
            label8 = new Label();
            label9 = new Label();
            SurnameRField = new TextBox();
            NameRField = new TextBox();
            label4 = new Label();
            label5 = new Label();
            RoleRField = new TextBox();
            RePassRField = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Registration = new Button();
            PassRField = new TextBox();
            LoginRField = new TextBox();
            panel2 = new Panel();
            closeButton = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1059, 112);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 165, 190);
            panel1.Controls.Add(HaveAccountButton);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(PostIndexRField);
            panel1.Controls.Add(AdressRField);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(PhoneRField);
            panel1.Controls.Add(EmailRField);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(SpecialRField);
            panel1.Controls.Add(BirthRField);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(SurnameRField);
            panel1.Controls.Add(NameRField);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(RoleRField);
            panel1.Controls.Add(RePassRField);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Registration);
            panel1.Controls.Add(PassRField);
            panel1.Controls.Add(LoginRField);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1059, 896);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // HaveAccountButton
            // 
            HaveAccountButton.BackColor = Color.FromArgb(37, 150, 190);
            HaveAccountButton.Cursor = Cursors.Hand;
            HaveAccountButton.FlatAppearance.BorderColor = Color.FromArgb(37, 150, 190);
            HaveAccountButton.FlatAppearance.BorderSize = 0;
            HaveAccountButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(37, 150, 190);
            HaveAccountButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 150, 190);
            HaveAccountButton.FlatStyle = FlatStyle.Flat;
            HaveAccountButton.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            HaveAccountButton.ForeColor = Color.White;
            HaveAccountButton.Location = new Point(391, 798);
            HaveAccountButton.Name = "HaveAccountButton";
            HaveAccountButton.Size = new Size(260, 60);
            HaveAccountButton.TabIndex = 28;
            HaveAccountButton.Text = "Have account";
            HaveAccountButton.UseVisualStyleBackColor = false;
            HaveAccountButton.Click += HaveAccountButton_Click;
            HaveAccountButton.MouseEnter += HaveAccountButton_MouseEnter;
            HaveAccountButton.MouseLeave += HaveAccountButton_MouseLeave;
            // 
            // label10
            // 
            label10.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(566, 464);
            label10.Name = "label10";
            label10.Size = new Size(427, 38);
            label10.TabIndex = 27;
            label10.Text = "Post index";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(729, 357);
            label11.Name = "label11";
            label11.Size = new Size(264, 38);
            label11.TabIndex = 26;
            label11.Text = "Adress";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PostIndexRField
            // 
            PostIndexRField.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            PostIndexRField.Location = new Point(566, 505);
            PostIndexRField.Name = "PostIndexRField";
            PostIndexRField.Size = new Size(427, 63);
            PostIndexRField.TabIndex = 25;
            // 
            // AdressRField
            // 
            AdressRField.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            AdressRField.Location = new Point(729, 397);
            AdressRField.Multiline = true;
            AdressRField.Name = "AdressRField";
            AdressRField.Size = new Size(264, 64);
            AdressRField.TabIndex = 24;
            // 
            // label12
            // 
            label12.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(729, 248);
            label12.Name = "label12";
            label12.Size = new Size(264, 38);
            label12.TabIndex = 23;
            label12.Text = "Phone";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(729, 140);
            label13.Name = "label13";
            label13.Size = new Size(264, 38);
            label13.TabIndex = 22;
            label13.Text = "Email";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PhoneRField
            // 
            PhoneRField.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneRField.Location = new Point(729, 288);
            PhoneRField.Name = "PhoneRField";
            PhoneRField.Size = new Size(264, 63);
            PhoneRField.TabIndex = 21;
            PhoneRField.TextChanged += PhoneRField_TextChanged;
            PhoneRField.Enter += PhoneRField_Enter;
            PhoneRField.Leave += PhoneRField_Leave;
            // 
            // EmailRField
            // 
            EmailRField.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            EmailRField.Location = new Point(729, 182);
            EmailRField.Multiline = true;
            EmailRField.Name = "EmailRField";
            EmailRField.Size = new Size(264, 64);
            EmailRField.TabIndex = 20;
            // 
            // label6
            // 
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(50, 463);
            label6.Name = "label6";
            label6.Size = new Size(442, 38);
            label6.TabIndex = 19;
            label6.Text = "Specialization";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(391, 357);
            label7.Name = "label7";
            label7.Size = new Size(264, 38);
            label7.TabIndex = 18;
            label7.Text = "Birth day";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SpecialRField
            // 
            SpecialRField.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            SpecialRField.Location = new Point(50, 505);
            SpecialRField.Name = "SpecialRField";
            SpecialRField.Size = new Size(442, 63);
            SpecialRField.TabIndex = 17;
            SpecialRField.TextChanged += SpecialRField_TextChanged;
            SpecialRField.Enter += SpecialRField_Enter;
            SpecialRField.Leave += SpecialRField_Leave;
            SpecialRField.MouseEnter += SpecialRField_MouseEnter;
            SpecialRField.MouseLeave += SpecialRField_MouseLeave;
            // 
            // BirthRField
            // 
            BirthRField.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            BirthRField.Location = new Point(391, 397);
            BirthRField.Multiline = true;
            BirthRField.Name = "BirthRField";
            BirthRField.Size = new Size(264, 64);
            BirthRField.TabIndex = 16;
            BirthRField.Enter += BirthRField_Enter;
            BirthRField.Leave += BirthRField_Leave;
            // 
            // label8
            // 
            label8.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(391, 248);
            label8.Name = "label8";
            label8.Size = new Size(264, 38);
            label8.TabIndex = 15;
            label8.Text = "Surname";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(391, 140);
            label9.Name = "label9";
            label9.Size = new Size(264, 38);
            label9.TabIndex = 14;
            label9.Text = "Name";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SurnameRField
            // 
            SurnameRField.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            SurnameRField.Location = new Point(391, 288);
            SurnameRField.Name = "SurnameRField";
            SurnameRField.Size = new Size(264, 63);
            SurnameRField.TabIndex = 13;
            // 
            // NameRField
            // 
            NameRField.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            NameRField.Location = new Point(391, 182);
            NameRField.Multiline = true;
            NameRField.Name = "NameRField";
            NameRField.Size = new Size(264, 64);
            NameRField.TabIndex = 12;
            NameRField.TextChanged += NameRField_TextChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(387, 570);
            label4.Name = "label4";
            label4.Size = new Size(264, 38);
            label4.TabIndex = 11;
            label4.Text = "Role";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(50, 357);
            label5.Name = "label5";
            label5.Size = new Size(264, 38);
            label5.TabIndex = 10;
            label5.Text = "Repit Password";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RoleRField
            // 
            RoleRField.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            RoleRField.Location = new Point(150, 618);
            RoleRField.Name = "RoleRField";
            RoleRField.Size = new Size(770, 63);
            RoleRField.TabIndex = 9;
            RoleRField.Enter += RoleRField_Enter;
            RoleRField.Leave += RoleRField_Leave;
            // 
            // RePassRField
            // 
            RePassRField.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            RePassRField.Location = new Point(50, 397);
            RePassRField.Name = "RePassRField";
            RePassRField.Size = new Size(264, 63);
            RePassRField.TabIndex = 8;
            RePassRField.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(50, 248);
            label3.Name = "label3";
            label3.Size = new Size(264, 38);
            label3.TabIndex = 7;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(50, 140);
            label2.Name = "label2";
            label2.Size = new Size(264, 38);
            label2.TabIndex = 6;
            label2.Text = "Login";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Registration
            // 
            Registration.BackColor = Color.FromArgb(37, 150, 190);
            Registration.Cursor = Cursors.Hand;
            Registration.FlatAppearance.BorderColor = Color.FromArgb(37, 150, 190);
            Registration.FlatAppearance.BorderSize = 0;
            Registration.FlatAppearance.MouseDownBackColor = Color.FromArgb(37, 150, 190);
            Registration.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 150, 190);
            Registration.FlatStyle = FlatStyle.Flat;
            Registration.Font = new Font("Times New Roman", 26F, FontStyle.Regular, GraphicsUnit.Point);
            Registration.ForeColor = Color.White;
            Registration.Location = new Point(356, 710);
            Registration.Name = "Registration";
            Registration.Size = new Size(334, 82);
            Registration.TabIndex = 5;
            Registration.Text = "Regestration";
            Registration.UseVisualStyleBackColor = false;
            Registration.Click += Registration_Click;
            Registration.MouseEnter += Registration_MouseEnter;
            Registration.MouseLeave += Registration_MouseLeave;
            // 
            // PassRField
            // 
            PassRField.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            PassRField.Location = new Point(50, 288);
            PassRField.Name = "PassRField";
            PassRField.Size = new Size(264, 63);
            PassRField.TabIndex = 3;
            PassRField.UseSystemPasswordChar = true;
            // 
            // LoginRField
            // 
            LoginRField.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            LoginRField.Location = new Point(50, 182);
            LoginRField.Multiline = true;
            LoginRField.Name = "LoginRField";
            LoginRField.Size = new Size(264, 64);
            LoginRField.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 150, 190);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1059, 112);
            panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(1001, 8);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(44, 41);
            closeButton.TabIndex = 1;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            closeButton.DragEnter += closeButton_DragEnter;
            closeButton.MouseEnter += closeButton_MouseEnter;
            closeButton.MouseLeave += closeButton_MouseLeave;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 896);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegForm";
            Text = "RegForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button Registration;
        private TextBox PassRField;
        private TextBox LoginRField;
        private Panel panel2;
        private Label closeButton;
        private Label label2;
        private Button HaveAccountButton;
        private Label label10;
        private Label label11;
        private TextBox PostIndexRField;
        private TextBox AdressRField;
        private Label label12;
        private Label label13;
        private TextBox PhoneRField;
        private TextBox EmailRField;
        private Label label6;
        private Label label7;
        private TextBox SpecialRField;
        private TextBox BirthRField;
        private Label label8;
        private Label label9;
        private TextBox SurnameRField;
        private TextBox NameRField;
        private Label label4;
        private Label label5;
        private TextBox RoleRField;
        private TextBox RePassRField;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
    }
}