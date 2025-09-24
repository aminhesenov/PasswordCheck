using System.Text.RegularExpressions;

namespace PasswordCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text;
            if(validPassword(password) == false)
            {
                MessageBox.Show("Password is invalid", "Information");
            }
            else
            {
                MessageBox.Show("Password is valid","Information");
            }
        }
        private bool validPassword(string password)
        {
            if(password.Length < 8)
            {
                return false;
            }
            if (!password.Any(char.IsUpper)){
                return false;
            }
            if(!password.Any(char.IsLower))
            {
                return false;
            }
            if (!password.Any(char.IsDigit))
            {
                return false;
            }
            if(!Regex.IsMatch(password, @"[@#$%!*]")){
                return false;
            }
            string[] check = { "123", "abc", "qwerty" };
            foreach (string s in check)
            {
                if (password.ToLower().Contains(s))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
