using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace OOPFinalProrect
{

    public partial class StudentRegistration : Form
    {
        // Fix: Move the MySqlConnection declaration inside the class and use correct syntax.
        public MySqlConnection con = new MySqlConnection("server=localhost; user=root; password=root; database=studentreg_db");

        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Console.WriteLine("Connection Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
