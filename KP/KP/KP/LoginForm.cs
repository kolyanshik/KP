using AuthorizationApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KP
{
    public partial class LoginForm : Form
    {
        private const string AccountsFilePath = "accounts.txt";
        private List<Account> accounts;
        public LoginForm()
        {
            InitializeComponent();
            accounts = AccountManager.LoadAccounts();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя и пароль.");
                return;
            }

            if (IsUsernameTaken(username))
            {
                MessageBox.Show("Это имя пользователя уже занято. Пожалуйста, выберите другое.");
                return;
            }

            // Регистрация нового аккаунта
            accounts.Add(new Account(username, password));
            AccountManager.SaveAccounts(accounts);
            MessageBox.Show("Аккаунт успешно зарегистрирован.");
        }
        private bool IsValidUser(string username, string password)
        {
            foreach (var account in accounts)
            {
                if (account.Username == username && account.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы успешно вошли.");
            MainForm newForm = new MainForm();
            newForm.Show();

            this.Hide();
        }
        private bool IsUsernameTaken(string username)
        {
            foreach (var account in accounts)
            {
                if (account.Username == username)
                {
                    return true;
                }
            }
            return false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
