using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void BuyForm_Click(object sender, EventArgs e)
        {
            BuyForm newForm = new BuyForm();
            newForm.Show();

            this.Hide();
        }

        private void History_Click(object sender, EventArgs e)
        {
            HistoryForm newForm = new HistoryForm();
            newForm.Show();

            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы вышли из аккаунта");
            LoginForm newForm = new LoginForm();
            newForm.Show();

            this.Hide();
        }
    }
}
