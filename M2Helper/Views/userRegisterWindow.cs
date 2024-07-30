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
    public partial class userRegisterWindow : Form
    {
        private UsersService usersService;
        public userRegisterWindow()
        {
            usersService = new UsersService();
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.UserMailAddress = mailTextBox.Text;
            user.UserPassword = HashPassword(passwordTextBox.Text);
            user.UserType = "User";
            user.ActiveKey = "No Key";
            await usersService.AddUserAsync(user);
            MessageBox.Show("Registration Successful", "Info");
        }

        private string HashPassword(string password)
        {
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
