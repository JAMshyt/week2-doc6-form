using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Форма_М2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                var arr2 = textBox1.Text.Split(' ');
                double[] arr = new double[arr2.Length];
                for (int i = 0; i < arr2.Length; i++)
                {
                    arr[i] = Convert.ToDouble(arr2[i]);
                }

                int lastMin = 0;
                double min = 16;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (Math.Min(arr[i], min) == arr[i])
                    {
                        min = arr[i];
                        lastMin = i + 1;
                    }
                }

                label2.Text = "Номер последнего минимального элемента: " + lastMin;
            }
            catch { MessageBox.Show("Вводить только цифры"); }
        }

    }
}
