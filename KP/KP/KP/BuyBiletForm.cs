using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KP
{
    public partial class BuyBiletForm : Form
    {
        public BuyBiletForm()
        {
            InitializeComponent();
        }

        private void BuyBiletForm_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            BuyForm buyForm = new BuyForm();
            buyForm.Show();

            this.Hide();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("data.txt"))
            {
                writer.WriteLine(textBox1.Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("data1.txt"))
            {
                writer.WriteLine(textBox2.Text);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("data2.txt"))
            {
                writer.WriteLine(textBox3.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Покупка была воспроизведена, спасибо!.");
            this.Close();
            BuyForm buyForm = new BuyForm();
            buyForm.Show();
        }
    }
}
