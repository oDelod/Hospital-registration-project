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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Hospital_registration
{
    public partial class PatientForm : Form
    {
        private Dictionary<int, int> doctorIdDictionary = new Dictionary<int, int>();
        private int loggedInUserId;


        public PatientForm(int loggedInUserId)
        {
            InitializeComponent();
            LoadSpecialties();
            this.loggedInUserId = loggedInUserId;
            MessageBox.Show(loggedInUserId.ToString());

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

        private void Special_SelectedIndexChanged(object sender, EventArgs e)
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

        private void doctorsListBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Day_SelectedIndexChanged(object sender, EventArgs e)
        
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
    
        private void SaveInformation_Click(object sender, EventArgs e)
        {
            if (doctorsListBox.SelectedIndex >= 0 && Day.SelectedIndex >= 0 && !string.IsNullOrEmpty(Hours.Text) && !string.IsNullOrEmpty(Information.Text))
            {
                int selectedIndex = doctorsListBox.SelectedIndex;
                int selectedDoctorId = doctorIdDictionary[selectedIndex];
                string selectedDayStr = Day.SelectedItem.ToString();
                DateTime selectedDay = DateTime.ParseExact(selectedDayStr, "dd/MM/yyyy", null);
                string selectedTime = Hours.SelectedItem.ToString();
                string information = Information.Text;

                // Отримати ідентифікатор пацієнта, наприклад, із якось іншого джерела або зберегти його у змінній
                int patientId = loggedInUserId;  // Вам потрібно реалізувати цю функцію

                string message = $"Doctor ID: {selectedDoctorId}\nDay: {selectedDayStr}\nHours: {selectedTime}\nPatient ID: {patientId}\nInformation: {information}";
                MessageBox.Show(message);

                // Викликати метод для оновлення запису із відповідними даними
                UpdateAppointmentWithPatientId(selectedDoctorId, selectedDay, selectedTime, information, patientId);
            }
            else
            {
                MessageBox.Show("Будь ласка, заповніть всі поля перед збереженням.");
            }
        }
            private void UpdateAppointmentWithPatientId(int doctorId, DateTime selectedDay, string selectedTime, string information, int patientId)
            {
                using (DB db = new DB())
                {
                    db.openConnection();

                    string updateQuery = "UPDATE `appointments` " +
                                         "SET `patient_id` = @patientId, `status` = 'available', `information` = @information " +
                                         "WHERE `doctor_id` = @doctorId AND `Day` = @day AND `Hour` = @hour";

                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, db.GetConnection());
                    updateCommand.Parameters.AddWithValue("@doctorId", doctorId);
                    updateCommand.Parameters.AddWithValue("@day", selectedDay);
                    updateCommand.Parameters.AddWithValue("@hour", selectedTime);
                    updateCommand.Parameters.AddWithValue("@patientId", patientId);
                    updateCommand.Parameters.AddWithValue("@information", information);

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

    }

}


