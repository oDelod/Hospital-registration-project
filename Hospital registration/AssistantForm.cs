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
    public partial class AssistantForm : Form
    {
        private DataTable patientDataTable = new DataTable();
        private Dictionary<int, int> doctorIdDictionary = new Dictionary<int, int>();
        private int loggedInUserId;
        private int loggedInUserIdOtherRoles;
        private int selectedPatientId;
        private int selectedDoctorId;


        public AssistantForm(int loggedInUserIdOtherRoles)
        {
            InitializeComponent();
            LoadSpecialties();
            this.loggedInUserIdOtherRoles = loggedInUserIdOtherRoles;
            this.loggedInUserId = loggedInUserId;
            MessageBox.Show(loggedInUserId.ToString());
            PathientList();
            DoctorList();

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadSpecialties()
        {
            using (DB db = new DB())
            {
                string query = "SELECT DISTINCT Specialization FROM users WHERE Activation = 1 AND Role = 'Doctor'";

                MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                db.openConnection();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        specialListBox.Items.Add(reader["Specialization"].ToString());
                    }
                }

                db.closeConnection();
            }
        }

        private void specialListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSpecialty = specialListBox.SelectedItem.ToString();
            LoadDoctorsBySpecialty(selectedSpecialty);
        }


        private void LoadDoctorsBySpecialty(string specialty)
        {
            doctorsListBox.Items.Clear();
            doctorIdDictionary.Clear();

            using (DB db = new DB())
            {
                string query = "SELECT UID, Name, Surname FROM users WHERE Activation = 1 AND Role = 'Doctor' AND Specialization = @specialty";

                MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                command.Parameters.AddWithValue("@specialty", specialty);

                db.openConnection();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int doctorId = Convert.ToInt32(reader["UID"]);
                        string doctorName = reader["Name"].ToString();
                        string doctorSurname = reader["Surname"].ToString();
                        string doctorFullName = $"{doctorName} {doctorSurname}";

                        doctorsListBox.Items.Add(doctorFullName);
                        int index = doctorsListBox.Items.Count - 1;
                        doctorIdDictionary[index] = doctorId;
                    }
                }

                db.closeConnection();
            }
        }
        private void doctorsListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            {
                if (doctorsListBox.SelectedIndex >= 0)
                {
                    int selectedIndex = doctorsListBox.SelectedIndex;
                    int selectedDoctorId = doctorIdDictionary[selectedIndex];
                    // MessageBox.Show($"Selected Doctor ID: {selectedDoctorId}");
                    LoadDoctorAvailability(selectedDoctorId);
                    // Викликати метод чи робити інші дії зі знайденим ID лікаря
                    // Наприклад: LoadDoctorAvailability(selectedDoctorId);
                }
            }
        }

        private void Day_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            {
                if (Day.SelectedIndex >= 0)
                {
                    int selectedIndex = doctorsListBox.SelectedIndex;
                    int selectedDoctorId = doctorIdDictionary[selectedIndex];
                    string selectedDayStr = Day.SelectedItem.ToString();
                    DateTime selectedDay = DateTime.ParseExact(selectedDayStr, "dd/MM/yyyy", null);

                    // Викликати метод для завантаження доступних годин для обраного дня і лікаря
                    LoadAvailableHours(selectedDoctorId, selectedDay);
                }
            }
        }





        private void LoadDoctorAvailability(int doctorId)
        {

            Day.Items.Clear();

            using (DB db = new DB())
            {
                string query = "SELECT DISTINCT Day FROM appointments WHERE doctor_id = @doctorId AND status = 'available'";

                MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                command.Parameters.AddWithValue("@doctorId", doctorId);

                db.openConnection();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime availableDay = Convert.ToDateTime(reader["Day"]);
                        Day.Items.Add(availableDay.ToString("dd/MM/yyyy"));
                    }
                }

                db.closeConnection();
            }
        }





        private void UpdateAppointmentWithPatientId(int doctorId, DateTime selectedDay, string selectedTime, string information, int patientId, int assistantId)
        {
            using (DB db = new DB())
            {
                db.openConnection();

                string updateQuery = "UPDATE `appointments` " +
                                     "SET `patient_id` = @patientId, `status` = 'available', `information` = @information, `Assistant_id` = @assistantId " +
                                     "WHERE `doctor_id` = @doctorId AND `Day` = @day AND `Hour` = @hour";

                MySqlCommand updateCommand = new MySqlCommand(updateQuery, db.GetConnection());
                updateCommand.Parameters.AddWithValue("@doctorId", doctorId);
                updateCommand.Parameters.AddWithValue("@day", selectedDay);
                updateCommand.Parameters.AddWithValue("@hour", selectedTime);
                updateCommand.Parameters.AddWithValue("@patientId", patientId);
                updateCommand.Parameters.AddWithValue("@information", information);
                updateCommand.Parameters.AddWithValue("@assistantId", assistantId);

                try
                {
                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Запис пацієнта збережено.");
                        // Додайте оновлення списку доступних записів лікаря
                    }
                    else
                    {
                        MessageBox.Show("Помилка при оновленні запису.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Помилка при оновленні запису: " + ex.Message);
                }

                db.closeConnection();
            }
        }

        private void LoadAvailableHours(int doctorId, DateTime selectedDay)
        {
            Hours.Items.Clear();

            using (DB db = new DB())
            {
                string query = "SELECT DISTINCT Hour FROM appointments WHERE doctor_id = @doctorId AND Day = @day AND status = 'available' AND patient_id IS NULL";

                MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                command.Parameters.AddWithValue("@doctorId", doctorId);
                command.Parameters.AddWithValue("@day", selectedDay);

                db.openConnection();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string availableHour = reader["Hour"].ToString();
                        Hours.Items.Add(availableHour);
                    }
                }

                db.closeConnection();
            }
        }

        private void Consultation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void textBoxSearchpathient_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearchpathient.Text.ToLower();

            foreach (DataGridViewRow row in dataGridViewPatients.Rows)
            {
                var cell = row.Cells["Login1"];
                if (cell != null && cell.Value != null)
                {
                    string loginValue = cell.Value.ToString().ToLower();
                    row.Visible = loginValue.Contains(searchText);
                }
            }
        }








        private void PathientList()
        {
            using (DB db = new DB())
            {
                db.openConnection();

                string query = "SELECT UID, Name, Surname, Login FROM users WHERE Role = 'Patient'";

                MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(patientDataTable); // Заповнити DataTable

                // Очищаємо дані в DataGridView перед заповненням
                dataGridViewPatients.Rows.Clear();

                foreach (DataRow dataRow in patientDataTable.Rows)
                {
                    int rowIndex = dataGridViewPatients.Rows.Add();
                    DataGridViewRow dataGridViewRow = dataGridViewPatients.Rows[rowIndex];
                    dataGridViewRow.Cells["UID1"].Value = dataRow["UID"];
                    dataGridViewRow.Cells["Name1"].Value = dataRow["Name"];
                    dataGridViewRow.Cells["Surname1"].Value = dataRow["Surname"];
                    dataGridViewRow.Cells["Login1"].Value = dataRow["Login"];
                }

                // Оновити DataGridView
                dataGridViewPatients.Update();
                dataGridViewPatients.Refresh();
            }
        }


        private void dataGridViewPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Отримуємо ідентифікатор пацієнта з виділеного рядка
                DataGridViewRow selectedRow = dataGridViewPatients.Rows[e.RowIndex];
                int patientId = Convert.ToInt32(selectedRow.Cells["UID1"].Value);
                string patientLogin = selectedRow.Cells["Login1"].Value.ToString();

                // Зберігаємо ідентифікатор пацієнта
                selectedPatientId = patientId;

                // Виводимо повідомлення MessageBox
                string message = $"Ідентифікатор пацієнта: {patientId}\nЛогін пацієнта: {patientLogin}";
                MessageBox.Show(message, "Інформація про пацієнта");
            }

        }

        private void textBoxSearchdoctor_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearchdoctor.Text.ToLower();

            foreach (DataGridViewRow row in dataGridViewDoctor.Rows)
            {
                var cell = row.Cells["PLogin"];
                if (cell != null && cell.Value != null)
                {
                    string loginValue = cell.Value.ToString().ToLower();
                    row.Visible = loginValue.Contains(searchText);
                }
            }
        }

        private void dataGridViewDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Отримуємо ідентифікатор пацієнта з виділеного рядка
                DataGridViewRow selectedRow = dataGridViewDoctor.Rows[e.RowIndex];
                int doctorId = Convert.ToInt32(selectedRow.Cells["PUID"].Value);
                string doctorLogin = selectedRow.Cells["PLogin"].Value.ToString();

                // Зберігаємо ідентифікатор пацієнта
                selectedDoctorId = doctorId;

                // Виводимо повідомлення MessageBox
                string message = $"Ідентифікатор лікаря: {doctorId}\nЛогін пацієнта: {doctorLogin}";
                MessageBox.Show(message, "Інформація про пацієнта");
            }

        }
        private void DoctorList()
        {
            using (DB db = new DB())
            {
                db.openConnection();

                string query = "SELECT UID, Name, Surname, Login FROM users WHERE Role = 'Doctor'";

                MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(patientDataTable); // Заповнити DataTable

                // Очищаємо дані в DataGridView перед заповненням
                dataGridViewDoctor.Rows.Clear();

                foreach (DataRow dataRow in patientDataTable.Rows)
                {
                    int rowIndex = dataGridViewDoctor.Rows.Add();
                    DataGridViewRow dataGridViewRow = dataGridViewDoctor.Rows[rowIndex];
                    dataGridViewRow.Cells["PUID"].Value = dataRow["UID"];
                    dataGridViewRow.Cells["PName"].Value = dataRow["Name"];
                    dataGridViewRow.Cells["PSurname"].Value = dataRow["Surname"];
                    dataGridViewRow.Cells["PLogin"].Value = dataRow["Login"];
                }

                // Оновити DataGridView
                dataGridViewDoctor.Update();
                dataGridViewDoctor.Refresh();
            }
        }

        private void SaveInformation_Click_1(object sender, EventArgs e)
        {
            {
                if (doctorsListBox.SelectedIndex >= 0 && Day.SelectedIndex >= 0 && !string.IsNullOrEmpty(Hours.Text) && !string.IsNullOrEmpty(Information.Text))
                {
                    int selectedIndex = doctorsListBox.SelectedIndex;
                    int selectedDoctorId = doctorIdDictionary[selectedIndex];
                    string selectedDayStr = Day.SelectedItem.ToString();
                    DateTime selectedDay = DateTime.ParseExact(selectedDayStr, "dd/MM/yyyy", null);
                    string selectedTime = Hours.SelectedItem.ToString();
                    string information = Information.Text;
                    int assistantId = loggedInUserIdOtherRoles; // Змінено на integer

                    // Отримати ідентифікатор пацієнта, наприклад, із якось іншого джерела або зберегти його у змінній
                    int patientId = selectedPatientId;  // Вам потрібно реалізувати цю функцію

                    string message = $"Doctor ID: {selectedDoctorId}\nDay: {selectedDayStr}\nHours: {selectedTime}\nPatient ID: {patientId}\nInformation: {information}";
                    MessageBox.Show(message);

                    // Викликати метод для оновлення запису із відповідними даними
                    UpdateAppointmentWithPatientId(selectedDoctorId, selectedDay, selectedTime, information, patientId, assistantId);
                }
                else
                {
                    MessageBox.Show("Будь ласка, заповніть всі поля перед збереженням.");
                }
            }
        }
        //DoctorPage

    }
}

