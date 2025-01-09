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
    public partial class Guess : Form
    {
        private int count;
        private double res;
        private void button_checkAns_Click(object sender, EventArgs e)
        {
            string inputAns=textBoxAns.Text;
            if (CheckingInputValues.ReadNumber(inputAns))
            {
                if (count > 1)
                {
                    if (double.Parse(inputAns) == res)
                    {
                        MessageBox.Show("Вы победили, правильный ответ"+ res.ToString());
                        AfterGame();
                    }
                    else
                    {
                        count--;
                        MessageBox.Show("Неверно, осталось " + count.ToString() + " попыток");
                    }
                }
                else 
                {
                    string mess = res.ToString();
                    MessageBox.Show("Вы проиграли, правильный ответ" + mess);
                    AfterGame();
                }
            }
            else
            { MessageBox.Show("Ошибка ввода"); }
        }
        private void button_start_Click(object sender, EventArgs e)
        {
            string inputA = textBoxA.Text;
            string inputB = textBoxB.Text;
            string inputP = textBoxP.Text;
            if (CheckingInputValues.ReadNumberA(inputA) && CheckingInputValues.ReadNumberB(inputB) && CheckingInputValues.ReadNumberP(inputP))
            {
                textBoxAns.Visible = true;
                label4.Visible = true;
                button_checkAns.Visible = true;
                count = int.Parse(inputP);
                res = Calc.Calculating(double.Parse(inputA), double.Parse(inputB));
                button_start.Visible = false;
            }
            else { MessageBox.Show("Ошибка ввода"); }
        }
        private void AfterGame()
        {
            textBoxAns.Visible = false;
            label4.Visible = false;
            button_checkAns.Visible = false;
            button_start.Visible = true;
            textBoxAns.Clear();
        }
        public Guess()
        {
            InitializeComponent();
            button_start.Click += button_start_Click;
            button_checkAns.Click += button_checkAns_Click;
        }
    }
}
