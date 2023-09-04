using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_registration
{
    public partial class Log_in : Form
    {
        private int loggedInUserId = -1;
        private int loggedInUserIdOtherRoles = -1;
        public Log_in()
        {
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 64);
        }



        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private void NextButt_MouseEnter(object sender, EventArgs e)
        {
            LoginButton.ForeColor = Color.Green;
        }

        private void NextButt_MouseLeave(object sender, EventArgs e)
        {
            LoginButton.ForeColor = Color.White;
        }
        Point LastpPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastpPoint.X;
                this.Top += e.Y - LastpPoint.Y;

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastpPoint = new Point(e.X, e.Y);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string PassUser = passField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @uL AND  `Password` = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PassUser;



            adapter.SelectCommand = command;
            adapter.Fill(table);

            int userId = -1;


            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                string userRole = row["Role"].ToString(); 

                string activationStatus = row["Activation"].ToString(); 

                if (activationStatus == "1")
                {
                    if (userRole == "Patient")
                    {
                        loggedInUserId = Convert.ToInt32(row["UID"]); // Зберігаємо UID пацієнта
                    }
                    else
                    {
                        loggedInUserIdOtherRoles = Convert.ToInt32(row["UID"]); // Зберігаємо UID користувачів інших ролей
                    }
                    switch (userRole)
                    {
                        case "Patient":
                            PatientForm patientForm = new PatientForm(loggedInUserId);
                            patientForm.Show();
                            break;
                        case "Doctor":
                            DoctorForm doctorForm = new DoctorForm(loggedInUserId, loggedInUserIdOtherRoles);
                            doctorForm.LoggedInUserIdOtherRoles = loggedInUserIdOtherRoles;
                            doctorForm.Show();
                            break;
                        case "Assistant":
                            AssistantForm assistantForm = new AssistantForm();
                            assistantForm.Show();
                            break;
                        case "Administrator":
                            AdministratorForm adminForm = new AdministratorForm();
                            adminForm.Show();
                            break;
                        default:
                            MessageBox.Show("Invalid role.");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Your account is not activated yet.");
                }

            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials.");
            }
        }
            private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void NoHaveAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            RegForm regForm = new RegForm();
            regForm.Show();
        }

        private void NoHaveAccountButton_MouseEnter(object sender, EventArgs e)
        {
            NoHaveAccountButton.ForeColor = Color.Green;
        }

        private void NoHaveAccountButton_MouseLeave(object sender, EventArgs e)
        {
            NoHaveAccountButton.ForeColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void passField_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
