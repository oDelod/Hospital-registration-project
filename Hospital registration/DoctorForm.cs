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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Hospital_registration
{
    public partial class DoctorForm : Form

    {
        public int LoggedInUserIdOtherRoles { get; set; }

        private List<string> selectedHoursList = new List<string>();

        private int loggedInUserId;  // Додайте цю змінну
        private int loggedInUserIdOtherRoles; // Додайте цю змінну
        private string selectedPatientName;
        private string selectedPatientSurname;
        private int selectedPatientId;
        private DateTime selectedPatientBirthDate;

        public DoctorForm(int loggedInUserId, int loggedInUserIdOtherRoles)
        {
            InitializeComponent();
            InitializeHoursList(); // Виклик методу для заповнення годин
            this.loggedInUserId = loggedInUserId;
            this.loggedInUserIdOtherRoles = loggedInUserIdOtherRoles;
            LoadUnapprovedAppointments();
            LoadApprovedAppointments();
            NowPathient();
            recordTypeComboBox.SelectedItem = "Consultation";
            System.Windows.Forms.TextBox decisionTextBox = new System.Windows.Forms.TextBox();


        }

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

        private void WorkHListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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

                    string insertQuery = "INSERT INTO `appointments` (`id`, `doctor_id`, `Day`, `Hour`, `patient_id`, `status`) VALUES (NULL, @doctorId, @day, @hour, NULL, 'available')";

                    try
                    {
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, db.GetConnection());
                        insertCommand.Parameters.AddWithValue("@doctorId", loggedInUserIdOtherRoles);
                        insertCommand.Parameters.AddWithValue("@day", selectedDate.Date);
                        insertCommand.Parameters.AddWithValue("@hour", selectedDate.TimeOfDay);
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
                command.Parameters.AddWithValue("@doctorId", loggedInUserIdOtherRoles);

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

                string updateQuery = "UPDATE appointments SET status = 'booked' WHERE id = @appointmentId";

                MySqlCommand updateCommand = new MySqlCommand(updateQuery, db.GetConnection());
                updateCommand.Parameters.AddWithValue("@appointmentId", appointmentId);

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
        private void dataGridViewAppointments_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
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
                command.Parameters.AddWithValue("@doctorId", loggedInUserIdOtherRoles);

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




        private void recordTypeComboBox_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void recordTypeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void NowPathient()
        {
            int doctorId = loggedInUserIdOtherRoles;
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
                command.Parameters.AddWithValue("@doctorId", doctorId);

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

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                // Отримайте інформацію про обраного пацієнта з вибраного рядка
                selectedPatientName = row.Cells["INAME"].Value.ToString();
                selectedPatientSurname = row.Cells["ISURNAME"].Value.ToString();
                selectedPatientId = Convert.ToInt32(row.Cells["IID"].Value);
                // Передбачаємо, що дата народження знаходиться в стовпці "Birth" (замініть на відповідну назву стовпця)
                selectedPatientBirthDate = Convert.ToDateTime(row.Cells["Birth"].Value);

                // Виведіть MessageBox з інформацією про обраного пацієнта
                string message = $"Ім'я: {selectedPatientName}\nПрізвище: {selectedPatientSurname}\n" +
                                 $"ID: {selectedPatientId}\nДата народження: {selectedPatientBirthDate:dd/MM/yyyy}";
                MessageBox.Show(message, "Інформація про пацієнта", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Тепер ви можете використовувати ці дані в інших частинах коду
                // Наприклад, відобразити інформацію про пацієнта у текстових полях або іншому інтерфейсі
                // Або виконати будь-які інші дії з цими даними
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

                string insertQuery = "INSERT INTO MedicalAppointments (DoctorID, PatientID, MeetingType, MeetingDate, BirthDate, Description, Referral, Medications , Conclusion ) " +
            "VALUES (@DoctorID, @PatientID, @MeetingType, @MeetingDate, @BirthDate, @Description, @Referral, @Medications , @Conclusion )";


                MySqlCommand command = new MySqlCommand(insertQuery, db.GetConnection());
                command.Parameters.AddWithValue("@DoctorID", loggedInUserIdOtherRoles);

                command.Parameters.AddWithValue("@PatientID", selectedPatientId);
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






















