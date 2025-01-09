using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Array : Form
    {
        private int[] mas;
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckingInputValues.ArrayLen(textBox1.Text))
            {
                int N = int.Parse(textBox1.Text);
                mas = new int[N];
                ArrayDoing();
            }
            else
            {
                MessageBox.Show("exiptiop");
            }
        }
        private void button_make_arr_Click(object sender, EventArgs e)
        {
           mas = new int[10];
            ArrayDoing();
        }
        private void button_sort_Click(object sender, EventArgs e)
        {
            if (mas != null)
            {
                WriteArr();
                WorkingArray.BubbleSorting(mas);
                PrintArray();
            }
            else
            {
                MessageBox.Show("Для начала создайте массив");
            }
        }
        private void button_max_Click(object sender, EventArgs e)
        {
            if (mas != null)
            {
                WriteArr();
                int maxindex = WorkingArray.MaxElement(mas);
                int maxelement = mas[maxindex];
                dataGridView1.Rows[0].Cells[maxindex].Style.BackColor = Color.Green;
                label2.Text = "Максимальный элемет = " + maxelement.ToString();
                label2.Visible = true;
            }
            else
            {
                MessageBox.Show("Для начала создайте массив");
            }
        }
        private void button_min_Click(object sender, EventArgs e)
        {
            if (mas != null)
            {
                WriteArr();
                int minindex = WorkingArray.MinElement(mas);
                int minelement = mas[minindex];
                dataGridView1.Rows[0].Cells[minindex].Style.BackColor = Color.Blue;
                label2.Text = "Минимальный элемет = " + minelement.ToString();
                label2.Visible = true;
            }
            else
            {
                MessageBox.Show("Для начала создайте массив");
            }
        }
        private void button_average_Click(object sender, EventArgs e)
        {
            if (mas != null)
            {
                WriteArr();
                double averVal = WorkingArray.Average(mas);
                label2.Text = "Среднее значение = " + averVal.ToString();
                label2.Visible = true;
            }
            else
            {
                MessageBox.Show("Для начала создайте массив");
            }
        }
        public Array()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button_sort.Click += button_sort_Click;
            button_max.Click += button_max_Click;
            button_min.Click += button_min_Click;
            button_average.Click += button_average_Click;
            //dataGridView1.Rows.Add(record[0]);
        }
        private void ArrayDoing()
        {
            label2.Visible=false;
            WorkingArray.ArrayMake(mas);
            PrintArray();
        }
        private void PrintArray()
        {
            int arrayLen3 = mas.Length;
            dataGridView1.ColumnCount = arrayLen3;
            dataGridView1.RowCount = 1;
            for (int i = 0; i < arrayLen3; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = mas[i];
            }
        }
        private void WriteArr()
        {
            mas = new int[dataGridView1.ColumnCount];
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                mas[i] = int.Parse(dataGridView1.Rows[0].Cells[i].Value.ToString());
                dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.White;   
            }
            label2.Visible = false;
        }
    }
}
