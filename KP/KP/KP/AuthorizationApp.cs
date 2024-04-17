using System;
using System.Collections.Generic;
using System.IO;

namespace AuthorizationApp
{
    public class AccountManager
    {
        private const string AccountsFilePath = "accounts.txt";

        public static void SaveAccounts(List<Account> accounts)
        {
            using (StreamWriter writer = new StreamWriter(AccountsFilePath))
            {
                foreach (var account in accounts)
                {
                    writer.WriteLine($"{account.Username},{account.Password}");
                }
            }
        }

        public static List<Account> LoadAccounts()
        {
            List<Account> accounts = new List<Account>();
            if (File.Exists(AccountsFilePath))
            {
                using (StreamReader reader = new StreamReader(AccountsFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            string username = parts[0];
                            string password = parts[1];
                            accounts.Add(new Account(username, password));
                        }
                    }
                }
            }
            return accounts;
        }
    }

    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
