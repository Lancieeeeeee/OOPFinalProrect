using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace OOPFinalProrect
{
    public partial class Timetable : Form
    {
        public Timetable()
        {
            InitializeComponent();
            button1.Click += button1_Click; // Save
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Clear inputs
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // View / load timetable entries
            try
            {
                using DbConnection conn = DbConfig.CreateConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT id, course, day, classroom, starttime, endtime FROM timetable";

                var factory = DbProviderFactories.GetFactory(DbConfig.ProviderName);
                var da = factory.CreateDataAdapter();
                if (da is DbDataAdapter typed)
                {
                    typed.SelectCommand = (DbCommand)cmd;
                    var dt = new DataTable();
                    typed.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No suitable data adapter found for provider: " + DbConfig.ProviderName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load timetable: " + ex.Message);
            }
        }

        private void Timetable_Load(object sender, EventArgs e)
        {
            // populate example combo boxes
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[] { "Math", "English", "Biology", "Chemistry", "Physics" });

            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" });

            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "Room 101", "Room 102", "Lab A", "Lab B" });

            try
            {
                EnsureTableExists();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to ensure timetable table: " + ex.Message);
            }
        }

        private void EnsureTableExists()
        {
            using DbConnection conn = DbConfig.CreateConnection();
            conn.Open();
            using var cmd = conn.CreateCommand();

            if (DbConfig.ProviderName == "MySql.Data.MySqlClient")
            {
                cmd.CommandText = @"CREATE TABLE IF NOT EXISTS timetable (
                id INT AUTO_INCREMENT PRIMARY KEY,
                course VARCHAR(200),
                day VARCHAR(50),
                classroom VARCHAR(100),
                starttime TIME,
                endtime TIME
            );";
            }
            else if (DbConfig.ProviderName == "System.Data.SqlClient" || DbConfig.ProviderName == "Microsoft.Data.SqlClient")
            {
                cmd.CommandText = @"IF OBJECT_ID('dbo.timetable', 'U') IS NULL
                    CREATE TABLE dbo.timetable (
                        id INT IDENTITY(1,1) PRIMARY KEY,
                        course NVARCHAR(200),
                        day NVARCHAR(50),
                        classroom NVARCHAR(100),
                        starttime TIME,
                        endtime TIME
                    );";
            }
            else if (DbConfig.ProviderName == "Microsoft.Data.Sqlite" || DbConfig.ProviderName == "System.Data.SQLite")
            {
                cmd.CommandText = @"CREATE TABLE IF NOT EXISTS timetable (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                course TEXT,
                day TEXT,
                classroom TEXT,
                starttime TEXT,
                endtime TEXT
            );";
            }
            else
            {
                throw new NotSupportedException("Provider not supported: " + DbConfig.ProviderName);
            }

            cmd.ExecuteNonQuery();
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            // Save entry
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Please select course, day and classroom before saving.");
                return;
            }

            try
            {
                using DbConnection conn = DbConfig.CreateConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO timetable (course, day, classroom, starttime, endtime) VALUES (@course,@day,@classroom,@start,@end);";

                var cp1 = cmd.CreateParameter(); cp1.ParameterName = "@course"; cp1.Value = comboBox1.SelectedItem.ToString(); cmd.Parameters.Add(cp1);
                var cp2 = cmd.CreateParameter(); cp2.ParameterName = "@day"; cp2.Value = comboBox2.SelectedItem.ToString(); cmd.Parameters.Add(cp2);
                var cp3 = cmd.CreateParameter(); cp3.ParameterName = "@classroom"; cp3.Value = comboBox3.SelectedItem.ToString(); cmd.Parameters.Add(cp3);
                var cp4 = cmd.CreateParameter(); cp4.ParameterName = "@start"; cp4.Value = dateTimePicker1.Value.TimeOfDay; cmd.Parameters.Add(cp4);
                var cp5 = cmd.CreateParameter(); cp5.ParameterName = "@end"; cp5.Value = dateTimePicker2.Value.TimeOfDay; cmd.Parameters.Add(cp5);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Timetable entry saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save timetable: " + ex.Message);
            }
        }
    }
}
