namespace OOPFinalProrect
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> users = new Dictionary<string, string>()
        {
            { "Admin", "Admin" },
        };
        string username;
        string password;
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            username = usernameTextBox.Text;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            password = passwordTextBox.Text;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (users.ContainsKey(username))
            {
                if (users[username] == password)
                {
                    DashBoard dashBoard = new DashBoard();
                    dashBoard.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid password.");
                }
            }
            else
            {
                MessageBox.Show("Invalid username.");
            }
        }

        private void signupLabel_Click(object sender, EventArgs e)
        {
           SignUp signUpForm = new SignUp();
            signUpForm.ShowDialog();
        }
    }
}
