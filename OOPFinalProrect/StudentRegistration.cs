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

    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();
            // Ensure DB and table exist, then wire additional button handlers
            try
            {
                EnsureDatabaseAndTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database initialization failed: " + ex.Message);
            }

            button2.Click += button2_Click; // Clear
            button4.Click += button4_Click; // Cancel/Close
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                InsertStudent();
                MessageBox.Show("Student saved successfully.");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving: " + ex.Message);
            }
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            ClearFields();
        }

        private void button4_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void EnsureDatabaseAndTable()
        {
            // Use provider-agnostic factory
            using DbConnection conn = DbConfig.CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();

            if (DbConfig.ProviderName == "MySql.Data.MySqlClient")
            {
                // MySQL: create database if not exists and table
                cmd.CommandText = "CREATE DATABASE IF NOT EXISTS studentreg_db;";
                cmd.ExecuteNonQuery();

                // switch to DB-specific connection
                conn.ConnectionString = DbConfig.MySqlConnectionString;
                cmd.CommandText = @"CREATE TABLE IF NOT EXISTS students (
                        id INT AUTO_INCREMENT PRIMARY KEY,
                        firstname VARCHAR(100),
                        lastname VARCHAR(100),
                        address VARCHAR(255),
                        contact VARCHAR(50),
                        email VARCHAR(150),
                        studentid VARCHAR(50)
                    );";
                cmd.ExecuteNonQuery();
            }
            else if (DbConfig.ProviderName == "System.Data.SqlClient" || DbConfig.ProviderName == "Microsoft.Data.SqlClient")
            {
                // SQL Server: ensure database exists by connecting to master first
                var factory = DbProviderFactories.GetFactory(DbConfig.ProviderName);
                using (var masterConn = factory.CreateConnection())
                {
                    // build a master connection string by replacing Database/Initial Catalog to master
                    var masterConnStr = DbConfig.SqlServerConnectionString;
                    if (masterConnStr.IndexOf("Database=", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        var parts = masterConnStr.Split(';').Select(p => p).ToList();
                        for (int i = 0; i < parts.Count; i++)
                        {
                            if (parts[i].StartsWith("Database=", StringComparison.OrdinalIgnoreCase) || parts[i].StartsWith("Initial Catalog=", StringComparison.OrdinalIgnoreCase))
                            {
                                parts[i] = "Database=master";
                                break;
                            }
                        }
                        masterConn.ConnectionString = string.Join(";", parts.Where(s => !string.IsNullOrWhiteSpace(s))) + ";";
                    }
                    else if (masterConnStr.IndexOf("Initial Catalog=", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        masterConn.ConnectionString = masterConnStr.Replace("Initial Catalog=studentreg_db", "Initial Catalog=master");
                    }
                    else
                    {
                        masterConn.ConnectionString = masterConnStr + ";Initial Catalog=master";
                    }

                    masterConn.Open();
                    using var masterCmd = masterConn.CreateCommand();
                    masterCmd.CommandText = "IF DB_ID('studentreg_db') IS NULL CREATE DATABASE studentreg_db;";
                    masterCmd.ExecuteNonQuery();
                }

                // now create the table in the target database
                conn.ConnectionString = DbConfig.SqlServerConnectionString;
                cmd.CommandText = @"IF OBJECT_ID('dbo.students', 'U') IS NULL
                    CREATE TABLE dbo.students (
                        id INT IDENTITY(1,1) PRIMARY KEY,
                        firstname NVARCHAR(100),
                        lastname NVARCHAR(100),
                        address NVARCHAR(255),
                        contact NVARCHAR(50),
                        email NVARCHAR(150),
                        studentid NVARCHAR(50)
                    );";
                cmd.ExecuteNonQuery();
            }
            else if (DbConfig.ProviderName == "Microsoft.Data.Sqlite" || DbConfig.ProviderName == "System.Data.SQLite")
            {
                // SQLite: just create table in file
                cmd.CommandText = @"CREATE TABLE IF NOT EXISTS students (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        firstname TEXT,
                        lastname TEXT,
                        address TEXT,
                        contact TEXT,
                        email TEXT,
                        studentid TEXT
                    );";
                cmd.ExecuteNonQuery();
            }
            else
            {
                throw new NotSupportedException("Provider not supported: " + DbConfig.ProviderName);
            }
        }

        private void InsertStudent()
        {
            using DbConnection conn = DbConfig.CreateConnection();
            conn.Open();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO students (firstname, lastname, address, contact, email, studentid) VALUES (@fn,@ln,@addr,@contact,@email,@sid);";

            var p1 = cmd.CreateParameter(); p1.ParameterName = "@fn"; p1.Value = textBox1.Text.Trim(); cmd.Parameters.Add(p1);
            var p2 = cmd.CreateParameter(); p2.ParameterName = "@ln"; p2.Value = textBox2.Text.Trim(); cmd.Parameters.Add(p2);
            var p3 = cmd.CreateParameter(); p3.ParameterName = "@addr"; p3.Value = textBox3.Text.Trim(); cmd.Parameters.Add(p3);
            var p4 = cmd.CreateParameter(); p4.ParameterName = "@contact"; p4.Value = textBox4.Text.Trim(); cmd.Parameters.Add(p4);
            var p5 = cmd.CreateParameter(); p5.ParameterName = "@email"; p5.Value = textBox5.Text.Trim(); cmd.Parameters.Add(p5);
            var p6 = cmd.CreateParameter(); p6.ParameterName = "@sid"; p6.Value = textBox6.Text.Trim(); cmd.Parameters.Add(p6);

            cmd.ExecuteNonQuery();
        }

        private void ClearFields()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
