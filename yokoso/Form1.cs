using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yokoso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, toplam = 0;
            sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i <= sayi; i++)
            {
                toplam = toplam + i;
            }
            label2.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1, s2, toplam = 0;
            s1 = Convert.ToInt32(textBox2.Text);
            s2 = Convert.ToInt32(textBox3.Text);
            for (int i = s1; i <= s2; i++)
            {
                toplam = toplam + i;
            }
            label3.Text = toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int s1, x;
            s1 = int.Parse(textBox5.Text);
            for (int i = 0; i <= 10; i++)
            {
                x = s1 * i;
                listBox1.Items.Add(i + " x " + s1 + " = " + x);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            int s1;
            s1 = int.Parse(textBox4.Text);
            for (int i = 0; i <= s1; i++)
            {
                if (i % 2 == 0)
                {
                    listBox2.Items.Add(i);
                }
                else
                {
                    listBox3.Items.Add(i);
                }
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int rastgeleSayi;
            Random rand = new Random();
            rastgeleSayi = rand.Next(100);
            label8.Text = rastgeleSayi.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            int s1,rs;
            s1 = int.Parse(textBox4.Text);
            Random rnd = new Random();
            for (int i = 0; i <= 20; i++)
            {
                rs = rnd.Next(s1);
                if (rs % 2 == 0)
                {
                    listBox2.Items.Add(rs);
                }
                else
                {
                    listBox3.Items.Add(rs);
                }
            }
        }
    }
}
