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

namespace Hospital_registration
{
    public partial class DoctorForm : Form

    {
        public int LoggedInUserIdOtherRoles { get; set; }

        private List<string> selectedHoursList = new List<string>();

        private int loggedInUserId;  // Додайте цю змінну
        private int loggedInUserIdOtherRoles; // Додайте цю змінну

        public DoctorForm(int loggedInUserId, int loggedInUserIdOtherRoles)
        {
            InitializeComponent();
            InitializeHoursList(); // Виклик методу для заповнення годин
            this.loggedInUserId = loggedInUserId;
            this.loggedInUserIdOtherRoles = loggedInUserIdOtherRoles;
            LoadUnapprovedAppointments();
            LoadApprovedAppointments();
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
    }
}









