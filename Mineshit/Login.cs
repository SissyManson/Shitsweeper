using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mineshit
{
    public partial class Login : Form
    {
        List<string> Usernames = new List<string>();
        List<string> Passwords = new List<string>();
        readonly string filepath = "users.csv";

        public Login()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string inputUsername = tbUsername.Text.Trim();
            string inputPassword = tbPassword.Text.Trim();

            if (inputUsername == "")
            {
                MessageBox.Show("Input Username!");
                return;
            }
            else if (inputPassword == "")
            {
                MessageBox.Show("Input Password!");
                return;
            }

            if(Usernames.Contains(inputUsername))
            {
                MessageBox.Show("Username exists!");
                return;
            }

            using (StreamWriter sw = new StreamWriter(filepath, true))
            {
                sw.WriteLine(inputUsername + ", " + inputPassword);
                sw.Close();
            }

            Usernames.Add(inputUsername);
            Passwords.Add(inputPassword);
            MessageBox.Show("You're done!");
            tbPassword.Text = "";
            tbUsername.Text = "";
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            string inputUsername = tbUsername.Text.Trim();
            string inputPassword = tbPassword.Text.Trim();

            for (int i = 0; i < Usernames.Count; i++)
            {
                if (Usernames[i] == inputUsername && Passwords[i] == inputPassword)
                {
                    isFound = true;
                    MessageBox.Show("Log in successfull!");
                    this.Hide();
                    DaGAYme f2 = new DaGAYme();
                    f2.Show();
                }
            }
            if (!isFound)
                MessageBox.Show("Invalid Username or Password!");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream) //chete dokato ne stigne kraq na faila
                    {
                        string line = sr.ReadLine();
                        string[] splitted = line.Split(',');

                        Usernames.Add(splitted[0]);
                        Passwords.Add(splitted[1]);
                    }
                    sr.Close();
                }
            }
        }

        private void tbUsername_Validated(object sender, EventArgs e)
        {
            ValidateInput(tbUsername, errorProvider1);
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(tbUsername, errorProvider1);
        }

        private void tbPassword_Validated(object sender, EventArgs e)
        {
            ValidateInput(tbPassword, errorProvider2);
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(tbPassword, errorProvider2);
        }

        private void ValidateInput(TextBox tb, ErrorProvider er)
        {
            if (tb.Text.Length == 0)
            {
                er.Icon = Mineshit.Properties.Resources.iconfinder_shield_error_299056;
                er.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                er.SetError(tb, "Empty field");
            }
            else
            {
                er.Icon = Mineshit.Properties.Resources.iconfinder_success_1646004;
                er.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                er.SetError(tb, "Success");
            }
            if (tbUsername.Text != "" && tbPassword.Text != "")
            {
                btnLogIn.Enabled = true;
                btnRegister.Enabled = true;
            }
            else
            {
                btnLogIn.Enabled = false;
                btnRegister.Enabled = false;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Gave up?", "Leaving...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
