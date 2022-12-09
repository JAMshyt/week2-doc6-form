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

namespace Форма_М1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int A, B;
        public bool flag = true;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label5.Visible = true;
                numericUpDown4.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label5.Visible = false;
                numericUpDown4.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDown1.Value);
            int m = Convert.ToInt32(numericUpDown4.Value);
            do
            {
                A = Convert.ToInt32(numericUpDown2.Value);
                B = Convert.ToInt32(numericUpDown3.Value);
                if (A >= B) MessageBox.Show("Нчало диапазона должно быть меншьне конца");
                break;
            } while (true);
            string[] arr2 = null;
            string[] arr1 = null;
            string[] array1 = new string[n];
            string[,] array2 = new string[m, n];



            if (radioButton1.Checked)
            {
                arr2 = richTextBox2.Text.Split(' ', '\n');
                for (int i = 0; i < n; i++)
                {
                    array1[i] = arr2[i];
                }
            }
            else
            {
                for (int i = 0; i < m; i++)
                {
                    arr1 = richTextBox2.Text.Split('\n');
                    if(arr1.Length != m)
                    {
                        MessageBox.Show("Кол-во строк не совпадает");
                        flag = false;
                        break;
                    }
                    if (flag)
                    {
                        for (; i < n;)
                        {
                            arr2 = arr1[i].Split(' ');
                            if (arr2.Length != n)
                            {
                                MessageBox.Show("Кол-во ячеек не совпадает в строке " + (i + 1));
                                flag = false;
                            }
                            break;

                        }
                        if (flag)
                        {
                            
                            for (int j = 0; j < n; j++)
                            {
                                array2[i, j] = arr2[j];
                            }
                        }
                    }
                }

            }

            if (flag)
            {
                int cout = 0;
                if (radioButton1.Checked)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (Convert.ToInt32(array1[i]) >= A & Convert.ToInt32(array1[i]) <= B)
                        {
                            continue;
                        }
                        else
                        {
                            cout++;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (Convert.ToInt32(array2[i, j]) >= A & Convert.ToInt32(array2[i, j]) <= B)
                            {
                                continue;
                            }
                            else
                            {
                                cout++;
                            }
                        }
                    }
                }
                label4.Text = "Кол-во элементoв \r\nне входящих в диапазон:" + cout;
            }
        }
    }
}



