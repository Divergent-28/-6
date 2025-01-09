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
    public partial class Form2 : Form
    {
        private int countClick = 0;
        int[,] mapHum = new int[5, 5];
        int[,] pole = new int[5, 5];
        int countSheepEnemy = 6;
        int countSheepYou = 6;
        int doubleShotBot = 0;
        int doubleShotYou = 0;
        private void Inic() //инициализация поля
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.RowCount = 5;
            for (int i = 0; i != 5; i++)
            {
                for (int j = 0; j != 5; j++)
                {
                    dataGridView1.Columns[i].Width = 75;
                    dataGridView1.Rows[i].Height = 75;
                }
            }
        }
        public Form2()
        {
            InitializeComponent();
            Inic();
            button1.Click += button1_Click;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            dataGridView2.MouseClick += dataGridView2_MouseClick;
            dataGridView2.CellValueChanged += dataGridView2_CurrentCellValueChanged;

        }


        private void button1_Click(object sender, EventArgs e) //Нажатие на кнопку играть, если корабли расталены верно, то
        {                                                        // он начнет игру, иначе обнулит поле
            WriteArr();
            if (Game.Check1(mapHum))
            {
                MessageBox.Show("УРААААААААААААААААААААААА, ЗАРАБОТАЛООО!!!!!!!!");
                button1.Visible = false;
                pole = Game.MakeMap();
                dataGridView2.ColumnCount = 5;
                dataGridView2.RowCount = 5;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        dataGridView2.Columns[i].Width = 75;
                        dataGridView2.Rows[i].Height = 75;
                        //if (pole[i, j] == 1)
                        //{
                        //    dataGridView2.Rows[i].Cells[j].Value = 1;
                        //}
                        //if (pole[i, j] == 2)
                        //{
                        //    dataGridView2.Rows[i].Cells[j].Value = 2;
                        //}
                        //if (pole[i, j] == 3)
                        //{
                        //    dataGridView2.Rows[i].Cells[j].Value = 3;
                        //}
                    }
                }
            }
            else
            {
                MessageBox.Show("Возникла ошибка при создании поля");
                StartNewGame();
            }
        }
        private void WriteArr() //создает массив mapHum, в котором будет храниться и изменяться игровое поле
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        mapHum[i, j] = 0;
                    }
                    else
                    {
                        mapHum[i, j] = int.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    }
                }
            }
        }
        private void dataGridView2_MouseClick(object sender, MouseEventArgs e) //стрельба по клеткам противника
        {
            DataGridView.HitTestInfo hit = dataGridView2.HitTest(e.X, e.Y);
            if (pole[hit.RowIndex, hit.ColumnIndex] == 5)
            {
                MessageBox.Show("Вы уже стреляли в эту клетку");
            }
            else
            {
                if (pole[hit.RowIndex, hit.ColumnIndex] == 0)
                {
                    dataGridView2.SelectedCells[0].Style.BackColor = Color.Gray;
                    doubleShotYou = 0;
                    pole[hit.RowIndex, hit.ColumnIndex] = 5;
                }
                else
                {
                    dataGridView2.SelectedCells[0].Style.BackColor = Color.Red;
                    dataGridView2.SelectedCells[0].Value = "X";
                    doubleShotYou = 1;
                    countSheepEnemy--;
                    pole[hit.RowIndex, hit.ColumnIndex] = 5;
                }
                if (doubleShotYou == 0)
                {
                    bootShoot();
                    while (doubleShotBot != 0)
                    {
                        bootShoot();
                    }
                }
            }
        }
        private void dataGridView2_CurrentCellValueChanged(object sender, DataGridViewCellEventArgs e) //контроль изменеия поля противника
        {
            if (countSheepEnemy == 1)
            {
                MessageBox.Show("Вы победили");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e) //размещение корабликов щелчком мыши
        {
            if (countClick < 3)
            {
                DataGridView.HitTestInfo hit = dataGridView1.HitTest(e.X, e.Y);
                if (dataGridView1.Rows[hit.RowIndex].Cells[hit.ColumnIndex].Value == null)
                {

                    dataGridView1.Rows[hit.RowIndex].Cells[hit.ColumnIndex].Value = 3;
                    countClick++;
                    WriteArr();

                }
                else
                {
                    MessageBox.Show("Здесь нельзя разместить корабль");
                }

            }
            else if (countClick < 5)
            {
                DataGridView.HitTestInfo hit = dataGridView1.HitTest(e.X, e.Y);
                if (dataGridView1.Rows[hit.RowIndex].Cells[hit.ColumnIndex].Value == null)
                {
                    dataGridView1.Rows[hit.RowIndex].Cells[hit.ColumnIndex].Value = 2;
                    countClick++;
                    WriteArr();
                }
                else
                {
                    MessageBox.Show("Здесь нельзя разместить корабль");
                }
            }
            else if (countClick < 6)
            {
                DataGridView.HitTestInfo hit = dataGridView1.HitTest(e.X, e.Y);
                if (dataGridView1.Rows[hit.RowIndex].Cells[hit.ColumnIndex].Value == null)
                {
                    dataGridView1.Rows[hit.RowIndex].Cells[hit.ColumnIndex].Value = 1;
                    countClick++;
                }
                else
                {
                    MessageBox.Show("Здесь нельзя разместить корабль");
                }
            }
            else
            {
                MessageBox.Show("Поле заполнено");
            }
        }
        private void StartNewGame() //метод, который чистит поле
        {
            countClick = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = null;
                }
            }
        }
        private void bootShoot() //метод отвечающий за стрельбу бота
        {
            if (countSheepYou == 0)
            {
                MessageBox.Show("Вы проиграли");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            Random rnd = new Random();
            int x = rnd.Next(0, 5);
            int y = rnd.Next(0, 5);
            while (mapHum[x, y] == 5)
            {
                x = rnd.Next(0, 5);
                y = rnd.Next(0, 5);
            }
            if (mapHum[x, y] == 0)
            {
                dataGridView1.Rows[x].Cells[y].Style.BackColor = Color.Gray;
                mapHum[x, y] = 5;
                doubleShotBot = 0;
            }
            else
            {
                dataGridView1.Rows[x].Cells[y].Style.BackColor = Color.Red;
                mapHum[x, y] = 5;
                countSheepYou--;
                doubleShotBot = 1;
            }
        }
    }
}

