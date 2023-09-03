using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization; // Додали для CultureInfo
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_registration
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            PhoneRField.Text = "xxxxxxxxx";
            PhoneRField.ForeColor = Color.Gray;
            BirthRField.Text = "xx.xx.xxxx";
            BirthRField.ForeColor = Color.Gray;
            RoleRField.Text = "Patient/Doctor/Assistant/Administrator";
            RoleRField.ForeColor = Color.Gray;
            SpecialRField.Text = "Only for Doctor";
            SpecialRField.ForeColor = Color.Gray;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
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

        private void Registration_MouseEnter(object sender, EventArgs e)
        {
            Registration.ForeColor = Color.Green;
        }

        private void Registration_MouseLeave(object sender, EventArgs e)
        {
            Registration.ForeColor = Color.White;
        }

        private void HaveAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_in log_In = new Log_in();
            log_In.Show();
        }

        private void HaveAccountButton_MouseEnter(object sender, EventArgs e)
        {
            HaveAccountButton.ForeColor = Color.Green;
        }

        private void HaveAccountButton_MouseLeave(object sender, EventArgs e)
        {
            HaveAccountButton.ForeColor = Color.White;
        }

        private void PhoneRField_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneRField_Enter(object sender, EventArgs e)
        {
            if (PhoneRField.Text == "xxxxxxxxx")
            {
                PhoneRField.Text = "";
                PhoneRField.ForeColor = Color.Black;
            }
        }

        private void PhoneRField_Leave(object sender, EventArgs e)
        {
            if (PhoneRField.Text == "")
            {
                PhoneRField.Text = "xxxxxxxxx";
                PhoneRField.ForeColor = Color.Gray;
            }
        }

        private void BirthRField_Enter(object sender, EventArgs e)
        {
            if (BirthRField.Text == "xx.xx.xxxx")
            {
                BirthRField.Text = "";
                BirthRField.ForeColor = Color.Black;
            }
        }

        private void BirthRField_Leave(object sender, EventArgs e)
        {
            if (BirthRField.Text == "")
            {
                BirthRField.Text = "xx.xx.xxxx";
                BirthRField.ForeColor = Color.Gray;
            }
        }

        private void RoleRField_Enter(object sender, EventArgs e)
        {
            if (RoleRField.Text == "Patient/Doctor/Assistant/Administrator")
            {
                RoleRField.Text = "";
                RoleRField.ForeColor = Color.Black;
            }
        }

        private void RoleRField_Leave(object sender, EventArgs e)
        {
            if (RoleRField.Text == "")
            {
                RoleRField.Text = "Patient/Doctor/Assistant/Administrator";
                RoleRField.ForeColor = Color.Gray;
            }
        }




        private void Registration_Click(object sender, EventArgs e)
        {
            string phoneNumber = PhoneRField.Text.Replace("x", ""); // Видаляємо "x" з номеру
            if (phoneNumber.Length != 9 || !phoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Phone number should contain exactly 9 digits.");
                return;
            }
            if (NameRField.Text == "")
            {
                MessageBox.Show("Name error");
                return;
            }
            if (SurnameRField.Text == "")
            {
                MessageBox.Show("Surname error");
                return;
            }
            if (PassRField.Text == "")
            {
                MessageBox.Show("Password empty");
                return;
            }
            if (PassRField.Text == RePassRField.Text)
            {

            }
            else
            {
                MessageBox.Show("Passwords do not match");
                return;
            }
            if (RoleRField.Text == "Patient" || RoleRField.Text == "Doctor" || RoleRField.Text == "Assistant" || RoleRField.Text == "Administrator")
            {

            }
            else
            {
                MessageBox.Show("Invalid role. Please enter a valid role.");
            }
            if (AdressRField.Text == "")
            {
                MessageBox.Show("Addres error");
                return;
            }
            if (PostIndexRField.Text == "")
            {
                MessageBox.Show("Post Index error");
                return;
            }
            if (EmailRField.Text == "")
            {
                MessageBox.Show("Email error");
                return;
            }
            if (LoginRField.Text == "")
            {
                MessageBox.Show("Login error");
                return;
            }
            if (isUserExists())
                return;


            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`Name`, `Surname`, `Password`, `Role`, `Birth`, `Adress`, `IAdres`, `Email`, `Phone`, `Information`, `Specialization`, `Login`, `Activation`) VALUES (@name, @surname, @password, @role, @date, @Adress, @AdressIndex, @email, @phone, '', @specialization, @login, @activation)", db.GetConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameRField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = SurnameRField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = PassRField.Text;
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = RoleRField.Text;
            command.Parameters.Add("@specialization", MySqlDbType.VarChar).Value = SpecialRField.Text;
            string inputDate = BirthRField.Text;
            string dateFormat = "dd.MM.yyyy";
            DateTime birthDate;

            if (DateTime.TryParseExact(inputDate, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate))
            {
                command.Parameters.Add("@date", MySqlDbType.Date).Value = birthDate;
            }
            else
            {
                MessageBox.Show("Invalid date format. Please use dd.MM.yyyy format.");
                return;
            }

            command.Parameters.Add("@Adress", MySqlDbType.VarChar).Value = AdressRField.Text;
            command.Parameters.Add("@AdressIndex", MySqlDbType.VarChar).Value = PostIndexRField.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = EmailRField.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = PhoneRField.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginRField.Text;

            if (RoleRField.Text == "Patient")
            {
                command.Parameters.Add("@activation", MySqlDbType.VarChar).Value = "1";
            }
            else
            {
                command.Parameters.Add("@activation", MySqlDbType.VarChar).Value = "0";
            }

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Your account has been created");
            else
                MessageBox.Show("Error: Your account has not been created");

            db.closeConnection();
        }

        public Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginRField.Text;




            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("The login is already in use");
                return true;
            }

            else
                return false;
        }

        private void SpecialRField_TextChanged(object sender, EventArgs e)
        {

        }

        private void SpecialRField_MouseEnter(object sender, EventArgs e)
        {

        }

        private void SpecialRField_MouseLeave(object sender, EventArgs e)
        {

        }

        private void SpecialRField_Enter(object sender, EventArgs e)
        {
            if (SpecialRField.Text == "Only for Doctor")
            {
                SpecialRField.Text = "";
                SpecialRField.ForeColor = Color.Black;
            }
        }

        private void SpecialRField_Leave(object sender, EventArgs e)
        {
            if (SpecialRField.Text == "")
            {
                SpecialRField.Text = "Only for Doctor";
                SpecialRField.ForeColor = Color.Gray;
            }
        }

        private void NameRField_TextChanged(object sender, EventArgs e)
        {

        }
    }

}



