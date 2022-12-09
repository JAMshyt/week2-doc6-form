using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Форма_М3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static void fill(int n, ref double[,] arr)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = r.Next(-15, 15);
                }
            }
        }

        static void powM(int n, int b, ref double[,] arr)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] >= 0) arr[i, j] = Math.Pow(arr[i, j], b);
                    else if (b % 2 == 0) arr[i, j] = Math.Abs(Math.Pow(arr[i, j], b));
                    else arr[i, j] = Math.Pow(arr[i, j], b);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            int a, b;
            a = Convert.ToInt32(numericUpDown1.Value);
            b = Convert.ToInt32(numericUpDown2.Value);
            double[,] arr = new double[a, a];
            fill(a, ref arr);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    richTextBox1.Text += arr[i, j] + "   |   ";
                }
                richTextBox1.Text += "\n";
            }
            powM(a, b, ref arr);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    richTextBox2.Text += arr[i, j] + "   |   ";
                }
                richTextBox2.Text += "\n";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value < 1)
            {
                MessageBox.Show("Не меньше 1");
                numericUpDown1.Value = 1;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value < 1)
            {
                MessageBox.Show("Не меньше 1");
                numericUpDown2.Value = 1;
            }
        }
    }
}
