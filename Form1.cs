using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Emit;

namespace Practice15
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
            try
            {
                if (textBox1.Text != String.Empty || textBox2.Text != String.Empty || textBox3.Text != String.Empty)
                {
                    Class1 ykaz = new Class1();
                    int num_of_page = Convert.ToInt32(textBox3.Text);                    
                    if (num_of_page <= 10 && num_of_page >= 1)
                    {
                        string text = textBox1.Text + " " + textBox2.Text;
                        StreamWriter sw = File.AppendText("file.txt");
                        sw.WriteLine(text);
                        MessageBox.Show("Записано в файл", "Успешно", MessageBoxButtons.OK);                      
                        listBox1.Items.Add(text);
                        sw.Close();

                    }
                    else
                    {
                        MessageBox.Show("Номер страницы должен быть от одного до десяти", "Ошибка", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("У вас есть незаполненные поля", "Ошибка", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка!Данные введены неверно!");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
