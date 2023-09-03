namespace Hospital_registration
{
    partial class Log_in
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
            NoHaveAccountButton = new Button();
            LoginButton = new Button();
            pictureBox2 = new PictureBox();
            passField = new TextBox();
            pictureBox1 = new PictureBox();
            loginField = new TextBox();
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 165, 190);
            panel1.Controls.Add(NoHaveAccountButton);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 527);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // NoHaveAccountButton
            // 
            NoHaveAccountButton.BackColor = Color.FromArgb(37, 150, 190);
            NoHaveAccountButton.Cursor = Cursors.Hand;
            NoHaveAccountButton.FlatAppearance.BorderColor = Color.FromArgb(37, 150, 190);
            NoHaveAccountButton.FlatAppearance.BorderSize = 0;
            NoHaveAccountButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(37, 150, 190);
            NoHaveAccountButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 150, 190);
            NoHaveAccountButton.FlatStyle = FlatStyle.Flat;
            NoHaveAccountButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NoHaveAccountButton.ForeColor = Color.White;
            NoHaveAccountButton.Location = new Point(92, 434);
            NoHaveAccountButton.Name = "NoHaveAccountButton";
            NoHaveAccountButton.Size = new Size(260, 60);
            NoHaveAccountButton.TabIndex = 29;
            NoHaveAccountButton.Text = "I don't have an account";
            NoHaveAccountButton.UseVisualStyleBackColor = false;
            NoHaveAccountButton.Click += NoHaveAccountButton_Click;
            NoHaveAccountButton.MouseEnter += NoHaveAccountButton_MouseEnter;
            NoHaveAccountButton.MouseLeave += NoHaveAccountButton_MouseLeave;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(37, 150, 190);
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.FlatAppearance.BorderColor = Color.FromArgb(37, 150, 190);
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(37, 150, 190);
            LoginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 150, 190);
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Times New Roman", 26F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(53, 358);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(334, 70);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Next";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            LoginButton.MouseEnter += NextButt_MouseEnter;
            LoginButton.MouseLeave += NextButt_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(53, 262);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // passField
            // 
            passField.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            passField.Location = new Point(123, 262);
            passField.Name = "passField";
            passField.PasswordChar = '*';
            passField.Size = new Size(264, 63);
            passField.TabIndex = 3;
            passField.UseSystemPasswordChar = true;
            passField.TextChanged += passField_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(53, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // loginField
            // 
            loginField.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            loginField.Location = new Point(123, 153);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new Size(264, 64);
            loginField.TabIndex = 1;
            loginField.TextChanged += loginField_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 150, 190);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(461, 112);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(419, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(44, 41);
            closeButton.TabIndex = 1;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            closeButton.MouseEnter += closeButton_MouseEnter;
            closeButton.MouseLeave += closeButton_MouseLeave;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(461, 112);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Log_in
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 527);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Log_in";
            Text = "Log_in";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox loginField;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox passField;
        private Button LoginButton;
        private Label closeButton;
        private Button NoHaveAccountButton;
    }
}