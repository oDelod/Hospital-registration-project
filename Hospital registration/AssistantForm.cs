﻿using MySql.Data.MySqlClient;
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
        private List<string> selectedHoursList = new List<string>();
        private string selectedPatientName;
        private string selectedPatientSurname;
        private int selectedPatientIds;
        private DateTime selectedPatientBirthDate;


        public AssistantForm(int loggedInUserIdOtherRoles)
        {
            InitializeComponent();
            LoadSpecialties();
            this.loggedInUserIdOtherRoles = loggedInUserIdOtherRoles;
            this.loggedInUserId = loggedInUserIdOtherRoles;
            MessageBox.Show(loggedInUserId.ToString());
            PathientList();
            DoctorList();
            InitializeHoursList(); // Виклик методу для заповнення годин
            recordTypeComboBox.SelectedItem = "Consultation";


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
                updateCommand.Parameters.AddWithValue("@assistantId", loggedInUserIdOtherRoles);

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
                LoadDoctorAvailability(selectedDoctorId);
                LoadApprovedAppointments();
                LoadUnapprovedAppointments();
                NowPathient();
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
            if (doctorsListBox.SelectedIndex >= 0 && Day.SelectedIndex >= 0 && !string.IsNullOrEmpty(Hours.Text) && !string.IsNullOrEmpty(Information.Text))
            {
                int selectedIndex = doctorsListBox.SelectedIndex;
                int selectedDoctorId = doctorIdDictionary[selectedIndex];
                string selectedDayStr = Day.SelectedItem.ToString();
                DateTime selectedDay = DateTime.ParseExact(selectedDayStr, "dd/MM/yyyy", null);
                string selectedTime = Hours.SelectedItem.ToString();
                string information = Information.Text;
                int assistantId = loggedInUserIdOtherRoles;

                // Використовуйте збережений selectedPatientId як ідентифікатор пацієнта
                int patientId = selectedPatientId;

                // Отримати ідентифікатор пацієнта, наприклад, із якось іншого джерела або зберегти його у змінній


                string message = $"Doctor ID: {selectedDoctorId}\nDay: {selectedDayStr}\nHours: {selectedTime}\nPatient ID: {patientId}\nInformation: {information}";
                MessageBox.Show(message);

                // Викликати метод для оновлення запису із відповідними даними
                UpdateAppointmentWithPatientId(selectedDoctorId, selectedDay, selectedTime, information, patientId, loggedInUserIdOtherRoles);

            }
            else
            {
                MessageBox.Show("Будь ласка, заповніть всі поля перед збереженням.");
            }
        }
        //DoctorPage
        private void InitializeHoursList()
        {
            for (int hour = 0; hour <= 24; hour++)
            {
                for (int minute = 0; minute < 60; minute += 30) // Додаємо півгодинний інтервал
                {
                    string time = $"{hour:D2}:{minute:D2}";
                    WorkHListBox1.Items.Add(time);
                }
            }
        }

        private void WorkHListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {

                string selectedHour = WorkHListBox1.Items[e.Index].ToString();
                selectedHoursList.Add(selectedHour);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {

                string selectedHour = WorkHListBox1.Items[e.Index].ToString();
                selectedHoursList.Remove(selectedHour);
            }
        }

        private void btnSaveWorkingHours_Click(object sender, EventArgs e)
        {
            using (DB db = new DB())
            {
                db.openConnection();

                foreach (string selectedHour in selectedHoursList)
                {
                    string[] hourParts = selectedHour.Split(':');
                    int hour = Convert.ToInt32(hourParts[0]);
                    int minute = Convert.ToInt32(hourParts[1]);

                    DateTime selectedDate = monthCalendar1.SelectionStart.Date.AddHours(hour).AddMinutes(minute);

                    // Перевірка, чи обрана дата не менше поточної дати
                    if (selectedDate.Date < DateTime.Today)
                    {
                        MessageBox.Show("Помилка: Неможливо зробити запис на заднє число.");
                        continue; // Пропустити цей запис і перейти до наступного
                    }

                    string insertQuery = "INSERT INTO `appointments` (`id`, `doctor_id`, `Day`, `Hour`, `patient_id`, `status` , `Assistant_id` ) VALUES (NULL, @doctorId, @day, @hour, NULL, 'available', @AssistantId)";

                    try
                    {
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, db.GetConnection());
                        insertCommand.Parameters.AddWithValue("@doctorId", selectedDoctorId);
                        insertCommand.Parameters.AddWithValue("@day", selectedDate.Date);
                        insertCommand.Parameters.AddWithValue("@hour", selectedDate.TimeOfDay);
                        insertCommand.Parameters.AddWithValue("@AssistantId", loggedInUserIdOtherRoles.ToString());

                        insertCommand.ExecuteNonQuery();

                        string dayAndTimeInfo = $"{selectedDate:dd/MM/yyyy HH:mm}-{selectedDate.AddMinutes(30):HH:mm}";
                        MessageBox.Show($"Робочі години збережено для дня: {selectedDate:dd/MM/yyyy}\nЧас: {dayAndTimeInfo}");
                    }
                    catch (MySqlException ex)
                    {
                        if (ex.Number == 1062)
                        {
                            string errorMessage = $"Помилка: Робочі години вже збережено для дня {selectedDate:dd/MM/yyyy HH:mm}";
                            MessageBox.Show(errorMessage);
                        }
                        else
                        {
                            MessageBox.Show("Помилка при збереженні робочих годин: " + ex.Message);
                        }
                    }
                }

                db.closeConnection();
            }

            MessageBox.Show("Робочі години збережено.");
        }
        //PathienList
        private void LoadUnapprovedAppointments()
        {
            using (DB db = new DB())
            {
                db.openConnection();

                string selectQuery = "SELECT u.UID, u.Name,a.Id, u.Surname, a.Day, a.Hour, a.status, a.information " +
                                     "FROM appointments AS a " +
                                     "INNER JOIN users AS u ON a.patient_id = u.UID " +
                                     "WHERE a.status = 'available' AND a.doctor_id = @doctorId AND a.patient_id IS NOT NULL";

                MySqlCommand command = new MySqlCommand(selectQuery, db.GetConnection());
                command.Parameters.AddWithValue("@doctorId", selectedDoctorId);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                // Встановити DataTable як DataSource для DataGridView
                dataGridViewAppointments.Rows.Clear(); // Очищаємо рядки перед додаванням нових даних
                foreach (DataRow row in dataTable.Rows)
                {
                    int rowIndex = dataGridViewAppointments.Rows.Add();
                    DataGridViewRow dataGridViewRow = dataGridViewAppointments.Rows[rowIndex];
                    dataGridViewRow.Cells["TName"].Value = row["Name"];
                    dataGridViewRow.Cells["TSurname"].Value = row["Surname"];
                    dataGridViewRow.Cells["TDay"].Value = row["Day"];
                    dataGridViewRow.Cells["THour"].Value = row["Hour"];
                    dataGridViewRow.Cells["TInformation"].Value = row["information"];
                    dataGridViewRow.Cells["CofId"].Value = row["id"]; // Приховане значення "ID"
                }
            }

            // Оновити DataGridView
            dataGridViewAppointments.Update();
            dataGridViewAppointments.Refresh();
        }
        private void ApproveAppointment(int appointmentId)
        {
            using (DB db = new DB())
            {
                db.openConnection();

                string updateQuery = "UPDATE appointments SET status = 'booked', Assistant_IdActiwation = @assistantId WHERE id = @appointmentId";

                MySqlCommand updateCommand = new MySqlCommand(updateQuery, db.GetConnection());
                updateCommand.Parameters.AddWithValue("@appointmentId", appointmentId);
                updateCommand.Parameters.AddWithValue("@assistantId", loggedInUserIdOtherRoles);

                int rowsAffected = updateCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Запис пацієнта затверджено.");
                    LoadUnapprovedAppointments();
                }
                else
                {
                    MessageBox.Show("Помилка під час затвердження запису.");
                }
            }
        }

        private void dataGridViewAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                MessageBox.Show("1");
                string appointmentIdText = dataGridViewAppointments.Rows[e.RowIndex].Cells["CofId"].Value.ToString();
                {
                    MessageBox.Show("2");
                    // Отримати значення ID з вибраного рядка
                    int appointmentId = Convert.ToInt32(dataGridViewAppointments.Rows[e.RowIndex].Cells["CofId"].Value);

                    // Викликати метод ApproveAppointment і передати appointmentId
                    ApproveAppointment(appointmentId);

                    // Відобразити appointmentId в MessageBox
                    MessageBox.Show(appointmentId.ToString());
                }
            }
        }
        //NextPatientList
        private void LoadApprovedAppointments()
        {
            using (DB db = new DB())
            {
                db.openConnection();

                string selectQuery = "SELECT u.UID, u.Name,a.Id, u.Surname, a.Day, a.Hour, a.status, a.information " +
                                     "FROM appointments AS a " +
                                     "INNER JOIN users AS u ON a.patient_id = u.UID " +
                                     "WHERE a.status = 'booked' AND a.doctor_id = @doctorId AND a.patient_id IS NOT NULL";

                MySqlCommand command = new MySqlCommand(selectQuery, db.GetConnection());
                command.Parameters.AddWithValue("@doctorId", selectedDoctorId);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                // Встановити DataTable як DataSource для DataGridView
                dataGridView1.Rows.Clear(); // Очищаємо рядки перед додаванням нових даних
                foreach (DataRow row in dataTable.Rows)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow dataGridViewRow = dataGridView1.Rows[rowIndex];
                    dataGridViewRow.Cells["TuName"].Value = row["Name"];
                    dataGridViewRow.Cells["TuSurname"].Value = row["Surname"];
                    dataGridViewRow.Cells["TuDay"].Value = row["Day"];
                    dataGridViewRow.Cells["TuHour"].Value = row["Hour"];
                    dataGridViewRow.Cells["TuInformation"].Value = row["information"];
                    dataGridViewRow.Cells["CofuId"].Value = row["id"]; // Приховане значення "ID"
                }
            }

            // Оновити DataGridView
            dataGridView1.Update();
            dataGridView1.Refresh();
        }


        //Consultation 
        private void recordTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                {
                    string selectedRecordType = recordTypeComboBox.SelectedItem.ToString();

                    // Перевірка вибору і встановлення видимості полів
                    if (selectedRecordType == "Consultation")
                    {
                        ConsultationTextBox.Visible = true;
                        MedecineTextBox.Visible = false;
                        ReferalTextBox.Visible = false;
                        ConsulionTextBox.Visible = true;
                        MedecineTextBox.Text = "";
                        ReferalTextBox.Text = "";
                    }
                    else if (selectedRecordType == "Medecine")
                    {
                        ConsultationTextBox.Visible = false;
                        MedecineTextBox.Visible = true;
                        ReferalTextBox.Visible = false;
                        ConsulionTextBox.Visible = false;
                        ConsultationTextBox.Text = "";
                        ReferalTextBox.Text = "";
                        ConsulionTextBox.Text = "";
                    }
                    else if (selectedRecordType == "Referal")
                    {
                        ConsultationTextBox.Visible = false;
                        MedecineTextBox.Visible = false;
                        ReferalTextBox.Visible = true;
                        ConsulionTextBox.Visible = false;
                        // Очищаємо текст на схованих полях
                        ConsultationTextBox.Text = "";
                        MedecineTextBox.Text = "";
                        ConsulionTextBox.Text = "";
                    }
                    else
                    {
                        // Обробка інших можливих типів записів
                    }
                }
            }
        }
        private void NowPathient()
        {
            int selectedDoctorIds = selectedDoctorId;
            DateTime today = DateTime.Today;

            using (DB db = new DB())
            {
                string query = "SELECT DISTINCT appointments.patient_id, users.Name, users.Birth, users.Surname, " +
                               "appointments.Day, appointments.Hour, appointments.information, appointments.id " +
                               "FROM appointments " +
                               "INNER JOIN users ON appointments.patient_id = users.UID " +
                               "WHERE appointments.Day = @today AND appointments.doctor_id = @doctorId";

                MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                command.Parameters.AddWithValue("@today", today);
                command.Parameters.AddWithValue("@doctorId", selectedDoctorIds);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                // Встановлюємо DataTable як DataSource для DataGridView
                dataGridView2.Rows.Clear(); // Очищаємо рядки перед додаванням нових даних
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    int rowIndex = dataGridView2.Rows.Add();
                    DataGridViewRow dataGridViewRow = dataGridView2.Rows[rowIndex];
                    dataGridViewRow.Cells["INAME"].Value = dataRow["Name"];
                    dataGridViewRow.Cells["ISURNAME"].Value = dataRow["Surname"];
                    dataGridViewRow.Cells["IDAY"].Value = dataRow["Day"];
                    dataGridViewRow.Cells["ITAME"].Value = dataRow["Hour"];
                    dataGridViewRow.Cells["Birth"].Value = dataRow["Birth"];

                    dataGridViewRow.Cells["IID"].Value = dataRow["patient_id"]; // Приховане значення "ID"
                }
            }

            // Оновити DataGridView
            dataGridView2.Update();
            dataGridView2.Refresh();
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                    // Отримайте інформацію про обраного пацієнта з вибраного рядка
                    selectedPatientName = row.Cells["INAME"].Value.ToString();
                    selectedPatientSurname = row.Cells["ISURNAME"].Value.ToString();
                    selectedPatientIds = Convert.ToInt32(row.Cells["IID"].Value);
                    // Передбачаємо, що дата народження знаходиться в стовпці "Birth" (замініть на відповідну назву стовпця)
                    selectedPatientBirthDate = Convert.ToDateTime(row.Cells["Birth"].Value);

                    // Виведіть MessageBox з інформацією про обраного пацієнта
                    string message = $"Ім'я: {selectedPatientName}\nПрізвище: {selectedPatientSurname}\n" +
                                     $"ID: {selectedPatientIds}\nДата народження: {selectedPatientBirthDate:dd/MM/yyyy}";
                    MessageBox.Show(message, "Інформація про пацієнта", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Тепер ви можете використовувати ці дані в інших частинах коду
                    // Наприклад, відобразити інформацію про пацієнта у текстових полях або іншому інтерфейсі
                    // Або виконати будь-які інші дії з цими даними
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            using (DB db = new DB())
            {
                // Отримайте значення з елементів інтерфейсу
                string meetingType = recordTypeComboBox.SelectedItem.ToString();

                string description = ConsultationTextBox.Text;
                string referral = ReferalTextBox.Text;
                string medications = MedecineTextBox.Text;
                string Conclusion = ConsulionTextBox.Text;

                string insertQuery = "INSERT INTO MedicalAppointments (DoctorID, AssistantID, PatientID, MeetingType, MeetingDate, BirthDate, Description, Referral, Medications, Conclusion) " +
                    "VALUES (@DoctorID, @AssistantID, @PatientID, @MeetingType, @MeetingDate, @BirthDate, @Description, @Referral, @Medications, @Conclusion)";

                MySqlCommand command = new MySqlCommand(insertQuery, db.GetConnection());
                command.Parameters.AddWithValue("@DoctorID", selectedDoctorId);
                command.Parameters.AddWithValue("@AssistantID", loggedInUserIdOtherRoles); // Додайте параметр для AssistantID
                command.Parameters.AddWithValue("@PatientID", selectedPatientIds);
                command.Parameters.AddWithValue("@MeetingType", meetingType);
                command.Parameters.AddWithValue("@MeetingDate", today);
                command.Parameters.AddWithValue("@BirthDate", selectedPatientBirthDate);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Referral", referral);
                command.Parameters.AddWithValue("@Medications", medications);
                command.Parameters.AddWithValue("@Conclusion", Conclusion);

                try
                {
                    db.openConnection();
                    int rowsAffected = command.ExecuteNonQuery();
                    db.closeConnection();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Запис медичного призначення збережено.");
                    }
                    else
                    {
                        MessageBox.Show("Помилка при збереженні запису медичного призначення.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при збереженні запису медичного призначення: " + ex.Message);
                }
            }
        }
    }
}


