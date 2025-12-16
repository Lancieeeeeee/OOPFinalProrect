using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPFinalProrect
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentRegistration studentRegistrationForm = new StudentRegistration();
            studentRegistrationForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Attendance attendanceForm = new Attendance();
            attendanceForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GradeEntry gradeEntryForm = new GradeEntry();
            gradeEntryForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Open Fee Payment form
            FeeTrackingSys feeForm = new FeeTrackingSys();
            feeForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Open Timetable scheduling form
            Timetable timetableForm = new Timetable();
            timetableForm.ShowDialog();
        }
    }
}
