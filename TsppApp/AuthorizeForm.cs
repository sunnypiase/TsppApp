using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TsppApp.Services.Abstract;
using TsppApp.Services;
using TsppApp.Models;

namespace TsppApp
{
    public partial class AuthorizeForm : Form
    {
        private readonly IHttpClientService _httpClient = new HttpClientService();
        public AuthorizeForm()
        {
            InitializeComponent();
        }

        private async void buttonAuthorize_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            try
            {

                if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter both login and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Replace this section with your own authentication logic.
                if (await _httpClient.AuthorizeUser(new AuthorizationDto() { Login = login, Password = password }))
                {
                    MessageBox.Show("Authorization successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainForm mainForm = new();
                    mainForm.Show();
                    this.Hide();

                    mainForm.FormClosing += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid login or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
