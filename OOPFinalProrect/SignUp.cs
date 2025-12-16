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
using System.Security.Cryptography;
using System.Text;

namespace OOPFinalProrect
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;

            try
            {
                EnsureUsersTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to initialize user store: " + ex.Message);
            }
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            // "or sign in" - close this form to return to previous (login) form
            Close();
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            var fullName = textBox1.Text.Trim();
            var email = textBox2.Text.Trim();
            var password = textBox3.Text;
            var confirm = textBox4.Text;

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                using DbConnection conn = DbConfig.CreateConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();

                // check if email already exists
                cmd.CommandText = "SELECT COUNT(1) FROM users WHERE email = @email";
                var p = cmd.CreateParameter(); p.ParameterName = "@email"; p.Value = email; cmd.Parameters.Add(p);
                object? result = null;
                try { result = cmd.ExecuteScalar(); } catch { result = null; }

                if (result is not null && Convert.ToInt32(result) > 0)
                {
                    MessageBox.Show("An account with that email already exists.");
                    return;
                }

                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO users (fullname, email, passwordhash) VALUES (@fn, @email, @ph)";
                var pfn = cmd.CreateParameter(); pfn.ParameterName = "@fn"; pfn.Value = fullName; cmd.Parameters.Add(pfn);
                var pem = cmd.CreateParameter(); pem.ParameterName = "@email"; pem.Value = email; cmd.Parameters.Add(pem);
                var pph = cmd.CreateParameter(); pph.ParameterName = "@ph"; pph.Value = ComputeHash(password); cmd.Parameters.Add(pph);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Account created successfully.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create account: " + ex.Message);
            }
        }

        private static string ComputeHash(string input)
        {
            using var sha = SHA256.Create();
            var data = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sb = new StringBuilder();
            foreach (var b in data) sb.Append(b.ToString("x2"));
            return sb.ToString();
        }

        private void EnsureUsersTable()
        {
            using DbConnection conn = DbConfig.CreateConnection();
            conn.Open();
            using var cmd = conn.CreateCommand();

            if (DbConfig.ProviderName.IndexOf("MySql", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                cmd.CommandText = @"CREATE TABLE IF NOT EXISTS users (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    fullname VARCHAR(200),
                    email VARCHAR(200) UNIQUE,
                    passwordhash VARCHAR(200)
                );";
            }
            else if (DbConfig.ProviderName.IndexOf("Sqlite", StringComparison.OrdinalIgnoreCase) >= 0 || DbConfig.ProviderName.IndexOf("SQLite", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                cmd.CommandText = @"CREATE TABLE IF NOT EXISTS users (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    fullname TEXT,
                    email TEXT UNIQUE,
                    passwordhash TEXT
                );";
            }
            else // SQL Server
            {
                cmd.CommandText = @"IF OBJECT_ID('dbo.users', 'U') IS NULL
                    CREATE TABLE dbo.users (
                        id INT IDENTITY(1,1) PRIMARY KEY,
                        fullname NVARCHAR(200),
                        email NVARCHAR(200) UNIQUE,
                        passwordhash NVARCHAR(200)
                    );";
            }

            cmd.ExecuteNonQuery();
        }
    }
}
