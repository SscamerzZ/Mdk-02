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


namespace TextRedactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы
                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.
                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBox
}
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
            {
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //Записываем в файл содержимое textBox с кодировкой 1251
            }
            richTextBox.Clear();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выравниваниеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            richTextBox.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            richTextBox.Cut();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            richTextBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            richTextBox.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void слеваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void справаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            string Hello = "Hello World!";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
