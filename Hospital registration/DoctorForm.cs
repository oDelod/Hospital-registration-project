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
            // Цей метод може залишити пустим, або ви можете додати додатковий код,
            // який виконується при виборі елемента, якщо потрібно.
        }

        private void WorkHListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                // Код, який виконується, коли вибраний новий елемент
                // Наприклад, можна додати вибраний час роботи до списку годин
                string selectedHour = WorkHListBox1.Items[e.Index].ToString();
                selectedHoursList.Add(selectedHour);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                // Код, який виконується, коли елемент скасований вибір
                // Наприклад, можна видалити скасований час роботи зі списку годин
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
    }

}



