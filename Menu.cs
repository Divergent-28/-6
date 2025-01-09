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
    public partial class Menu : Form
    {
        private void button_guess_Click(object sender, EventArgs e)
        {
            Guess guess = new Guess();
            guess.Show();
        }
        private void button_arr_Click(object sender, EventArgs e)
        {
            Array arr = new Array();
            arr.Show();
        }
        private void button_play_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void button_info_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }
        public Menu()
        {
            InitializeComponent();
            button_guess.Click += button_guess_Click;
            button_arr.Click += button_arr_Click;
            button_play.Click += button_play_Click;
            button_info.Click += button_info_Click;
           
        }
        private void Menu_MenuClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите закрыть программу?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dr)
            {
                case DialogResult.Yes:
                    break;
                case DialogResult.No: 
                    e.Cancel = true;
                    break;
            }
        }
    }
}
