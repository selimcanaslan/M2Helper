using M2Helper.Models;
using M2Helper.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace M2Helper.Views
{
    public partial class LoginWindow : Form
    {
        UsersService usersService;
        public static bool developerMode = false;
        public LoginWindow()
        {
            usersService = new UsersService();
            InitializeComponent();
            if (developerMode)
            {
                GetAdminUser();
            }
        }

        private async void GetAdminUser()
        {
            Users admin = new Users();
            admin = await usersService.GetUserByIdAsync(1);
            mailTextBox.Text = admin.UserMailAddress;
            passwordTextBox.Text = "seloselo1";
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            userRegisterWindow userRegisterWindow = new userRegisterWindow();
            userRegisterWindow.ShowDialog();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            string userMail = mailTextBox.Text;
            Users user = await usersService.GetUserByEmailAsync(userMail);
            if (user != null)
            {
                if (user.UserPassword == HashPassword(passwordTextBox.Text))
                {
                    MainWindow mainWindow = new MainWindow(user);
                    this.Hide();
                    mainWindow.Closed += (s, args) => this.Close();
                    mainWindow.Show();
                }
                else
                {
                    MessageBox.Show("Password Incorrect!", "Info");
                }
            }
            else
            {
                MessageBox.Show("No Such User Found", "Info");
            }
        }

        public string HashPassword(string password)
        {
            // Use SHA256 to hash the password
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convert the input string to a byte array and compute the hash
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert the byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
