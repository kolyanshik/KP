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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("data.txt"))
            {
                label1.Text = reader.ReadLine();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("data1.txt"))
            {
                label2.Text = reader.ReadLine();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("data2.txt"))
            {
                label3.Text = reader.ReadLine();

            }
        }
    }
}
