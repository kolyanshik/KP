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
    public partial class BuyForm : Form
    {
        public BuyForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();

            this.Hide();

        }

        private void BuyForm_Load(object sender, EventArgs e)
        {

        }

        private void Mars_Click(object sender, EventArgs e)
        {
            BuyBiletForm buyBiletForm = new BuyBiletForm();
            buyBiletForm.Show();

            this.Hide();
        }

        private void Yopiter_Click(object sender, EventArgs e)
        {
            BuyBiletForm buyBiletForm = new BuyBiletForm();
            buyBiletForm.Show();

            this.Hide();
        }

        private void Satyrn_Click(object sender, EventArgs e)
        {
            BuyBiletForm buyBiletForm = new BuyBiletForm();
            buyBiletForm.Show();

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }      
    }
}
