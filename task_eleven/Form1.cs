using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_eleven
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

        private void Integer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Integer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar.ToString() == "," && Integer.Text.IndexOf(',') == -1) && e.KeyChar != '\b')
                /*сообщение о нажатии клавиши не должно передаваться элементу управления*/
                e.Handled = true;
            if (e.KeyChar.Equals((char)13)) Integer.Focus(); //Enter
        }

        private void Integer_KeyUp(object sender, KeyEventArgs e)
        {
            if (Text.Text.Length > 0 && Integer.Text.Length > 0 && Integer.Text != "0") { Encrypt.Enabled = true; }
            else Encrypt.Enabled = false;
        }

        private void Text_KeyUp(object sender, KeyEventArgs e)
        {
            if (Text.Text.Length > 0 && Integer.Text.Length > 0 && Integer.Text != "0") { Encrypt.Enabled = true; }
            else Encrypt.Enabled = false;
        }

        static Random rand = new Random();

        private int[] Rearrange(int k) // перестановка чисел (1, ..., к) случайным образом
        {
            if (k == 2) return new int[2] { 2, 1 };

            List<int> list = new List<int>();
            for (int n = 1; n <= k; n++)
            {
                list.Add(n);
            }

            int[] array = new int[k];
            for (int i = 0; i < k; i++)
            {
                int index = rand.Next(0, list.Count - 1);
                array[i] = list[index];
                list.Remove(list[index]);
            }
            return array;
        }
        private void Encrypt_Click_1(object sender, EventArgs e)
        {
            Answer.Clear();
            if (Rearragement.Text != null)
            {
                int k = Int32.Parse(Integer.Text);
                int[] rearrangment = Rearrange(k);
                Rearragement.Text = "";
                foreach (int number in rearrangment) Rearragement.Text += number.ToString();

                // добавление пустых строк в изначальную строку в случае, если кол-во символов не кратно к
                int n = Text.Text.Length / k;
                if ((double)Text.Text.Length / k > n)
                {
                    n++;
                    while ((double)Text.Text.Length / k != n)
                    {
                        Text.Text += " ";
                    }
                }

                string[] encoded = new string[n]; // массив строк по к символов из текста
                int index = 0;
                for (int i = 0; i < Text.Text.Length; i += k)
                {
                    encoded[index] = Text.Text.Substring(i, k);
                    index++;
                }
                // перестановка
                for (int i = 0; i < encoded.Length; i++)
                {
                    string temp = encoded[i];
                    string add = "";
                    for (int j = 0; j < encoded[i].Length; j++)
                    {
                        add += encoded[i][rearrangment[j] - 1];
                    }
                    encoded[i] = add;
                }
                // вывод ответа
                foreach (string str in encoded)
                    Answer.Text += str;
            }
        }


        private void Decrypt_Click_1(object sender, EventArgs e)
        {
            Answer2.Clear();
            if (Rearragement2.Text != null)
            {
                int k = Int32.Parse(Integer2.Text);

                // добавление пустых строк в изначальную строку в случае, если кол-во символов не кратно к
                int n = textBox2.Text.Length / k;
                if ((double)textBox2.Text.Length / k > n)
                {
                    n++;
                    while ((double)textBox2.Text.Length / k != n)
                    {
                        textBox2.Text += " ";
                    }
                }

                int[] rearrangement = ToArray(Rearragement2.Text);

                string[] encoded = new string[n]; // массив строк по к символов из текста
                int index = 0;
                for (int i = 0; i < textBox2.Text.Length; i += k)
                {
                    encoded[index] = textBox2.Text.Substring(i, k);
                    index++;
                }

                for (int i = 0; i < encoded.Length; i++)
                {
                    char[] letters = new char[encoded[i].Length];
                    for (int j = 0; j < encoded[i].Length; j++)
                    {
                        letters[rearrangement[j] - 1] = encoded[i][j];
                    }
                    encoded[i] = ToString(letters);
                }

                // вывод ответа
                foreach (string str in encoded)
                    Answer2.Text += str;
            }
        }

        private string ToString(char[] letters)
        {
            string str = "";
            foreach (char l in letters)
                str += l;
            return str;
        }

        private int[] ToArray(string str)
        {
            int[] mas = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                mas[i] = (int)Char.GetNumericValue(str[i]);
            }
            return mas;
        }

        private void Answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox2.Text.Length > 0 && Integer2.Text.Length > 0 && Integer2.Text != "0" && Rearragement2.Text.Length> 0) { Decrypt.Enabled = true; }
            else Decrypt.Enabled = false;
        }

        private void Integer2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar.ToString() == "," && Integer2.Text.IndexOf(',') == -1) && e.KeyChar != '\b')
                /*сообщение о нажатии клавиши не должно передаваться элементу управления*/
                e.Handled = true;
            if (e.KeyChar.Equals((char)13)) Integer2.Focus(); //Enter
        }

        private void Integer2_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox2.Text.Length > 0 && Integer2.Text.Length > 0 && Integer2.Text != "0" && Rearragement2.Text.Length > 0) { Decrypt.Enabled = true; }
            else Decrypt.Enabled = false;
        }

        private void Rearragement2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar.ToString() == "," && Rearragement2.Text.IndexOf(',') == -1) && e.KeyChar != '\b')
                /*сообщение о нажатии клавиши не должно передаваться элементу управления*/
                e.Handled = true;
            if (e.KeyChar.Equals((char)13)) Rearragement2.Focus(); //Enter
        }

        private void Rearragement2_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox2.Text.Length > 0 && Integer2.Text.Length > 0 && Integer2.Text != "0" && Rearragement2.Text.Length > 0) { Decrypt.Enabled = true; }
            else Decrypt.Enabled = false;
        }

    }
}
