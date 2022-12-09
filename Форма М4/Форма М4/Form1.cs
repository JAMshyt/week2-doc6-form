using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Форма_М4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int b, i = 0, ii = 1;
        int[][] arr;

        static void fill(ref int[][] arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[i][j] = r.Next(-15, 15);
                }
            }
        }

        static int[] newArr(int b, ref int[][] arr)
        {
            int[] arr2 = new int[b];
            for (int i = 0; i < arr.Length; i++)
            {
                int num = 111;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i][j]) % 2 == 0 | arr[i][j] == 0)
                    {
                        num = arr[i][j];
                    }
                }

                arr2[i] = num;
            }
            return arr2;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            ii = 1;
            label3.Text = "Кол-во строк";
            numericUpDown1.Visible = true;
            numericUpDown1.Value = 1;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            button2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Чтобы сделать новый массив нажмите\"Очистить\"";
            numericUpDown1.Visible = false;

            fill(ref arr);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    richTextBox1.Text += arr[i][j] + " ";
                }
                richTextBox1.Text += "\n";
            }
            int co = 1;
            foreach (int yes in newArr(b, ref arr))
            {
                if (yes == 111)
                {
                    richTextBox2.Text += "Строка " + co + " не имеет четные элементы \n";
                    co++;
                }
                else
                {
                    richTextBox2.Text += "Строка " + co + " : " + yes + "\n";
                    co++;
                }
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 1)
            {
                MessageBox.Show("Не меньше 1");
                numericUpDown1.Value = 1;
            }
            b = Convert.ToInt32(numericUpDown1.Value);
            button2.Visible = true;
            arr = new int[b][];
            for(int i = 0; i < b; i++)
            {
                arr[i] = new int[b];
            }
        }

    }
}
