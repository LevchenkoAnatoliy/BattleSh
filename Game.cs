using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BattleShip
{
    public partial class Game : Form
    {
        ClassicSeaBattle collectionsAlias = new ClassicSeaBattle();//Коллекция обьектов союзных кораблей
        ClassicSeaBattle collectionsEnemy = new ClassicSeaBattle();//Коллекция объектов вражеских кораблей
        int[,] enemyField = new int[10, 10];//Массив для поля, где союзные корабли
        int[,] aliasField = new int[10, 10];//Массив для поля, где вражеские корабли
        int indexRow, indexColumn;//Переменные, для координаты выделенной ячейки с поля врага
        int countStep = 0;
        bool flag = true;
        //****************Поля класса************************

        public Game()
        {
            FileStream file = new FileStream("LogFile.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine("Курсовая работа  Левченка Анатолия и Петренко Дмитрия.");
            writer.Close();
            file.Close();

            InitializeComponent();         
            FillField(dataGridView1, ref collectionsAlias);
            aliasField = Ship.field;
            Ship.field = new int[10, 10];
            FillField(dataGridView2, ref collectionsEnemy);
            ShowField(dataGridView2, 1);
            enemyField = Ship.field;
            Ship.field = new int[10, 10];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        //Метод псевдослучайного заполнения указанного поля 
        private void FillField(DataGridView dgv, ref ClassicSeaBattle collections)
        {
            dgv.RowCount = 10;
            AddI(dgv);
            SingleDeckShip singleOne = new SingleDeckShip();
            collections.AddShip(singleOne);
            SingleDeckShip singleTwo = new SingleDeckShip();
            collections.AddShip(singleTwo);
            SingleDeckShip singleThree = new SingleDeckShip();
            collections.AddShip(singleThree);
            SingleDeckShip singleFour = new SingleDeckShip();
            collections.AddShip(singleFour);

            DoubleDeckShip doubleOne = new DoubleDeckShip();
            collections.AddShip(doubleOne);
            DoubleDeckShip doubleTwo = new DoubleDeckShip();
            collections.AddShip(doubleTwo);
            DoubleDeckShip doubleThree = new DoubleDeckShip();
            collections.AddShip(doubleThree);

            ThreeDeckShip threeOne = new ThreeDeckShip();
            collections.AddShip(threeOne);
            ThreeDeckShip threeTwo = new ThreeDeckShip();
            collections.AddShip(threeTwo);

            FourDeckShip fourOne = new FourDeckShip();
            collections.AddShip(fourOne);

            Random rand = new Random();
            foreach (Ship sh in collections.ListOfShips)
            {
                int x = rand.Next(0, 9);
                int y = rand.Next(0, 9);
                int count = 0;
                while (!sh.SetLocation(x + "," + y))
                {
                    count++;
                    x = rand.Next(0, 9);
                    y = rand.Next(0, 9);
                    if (count == 20)
                    {
                        Ship.field = new int[10, 10];
                        collections = new ClassicSeaBattle();
                        FillField(dgv, ref collections);
                        return;
                    }
                }
            }
            ShowField(dgv,0);
        }

        //Метод вывода на экран поля
        private void ShowField(DataGridView dgv, int x)
        {
            for(int i = 0; i< 10; i++)
            {
                for(int j =0; j < 10; j++)
                {
                    if (x == 1) dgv.Rows[i].Cells[j].Value = Properties.Resources.steam;
                    else
                    {
                        if (Ship.field[i, j] == 1)
                        {
                            dgv.Rows[i].Cells[j].Value = Properties.Resources.ship;
                        }
                        else
                        {
                            dgv.Rows[i].Cells[j].Value = Properties.Resources.sea;
                        }
                    }
                }
            }
        }

        //Метод добавления на поля счетчика
        void AddI(DataGridView dgv)
        {
            for(int i = 0; i < 10; i++)
            {
                dgv.Rows[i].HeaderCell.Value = (i + 1).ToString();
                dgv.Columns[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        //Событие нажатия на кнопку "Получить"
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)//Если включен отчет об союзных кораблях, то выдаем его, иначе об вражеских
                MessageBox.Show(collectionsAlias.ShowList(), "Отчет", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show(collectionsEnemy.ShowList(), "Отчет", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
        }

        //Событие нажатия на кнопку "Стрелять"
        private void button_fire_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (flag)
            {
                countStep++;
                listBoxHistory.Items.Add("Ход " + countStep);
            }
            if (Fire("Игрок", indexRow, indexColumn, enemyField, collectionsEnemy))
            {
                flag = false;
                if (enemyField[indexRow, indexColumn] == 1) dataGridView2.Rows[indexRow].Cells[indexColumn].Value = Properties.Resources.ship_dead;
                return;
            }
            else dataGridView2.Rows[indexRow].Cells[indexColumn].Value = Properties.Resources.sea_dead;
            x:
            indexRow = rand.Next(0, 9);
            indexColumn = rand.Next(0, 9);
            if (Fire("Компьютер", indexRow, indexColumn, aliasField, collectionsAlias))
            {
                dataGridView1.Rows[indexRow].Cells[indexColumn].Value = Properties.Resources.ship_dead;
                goto x;
            }
            else
            {
                dataGridView1.Rows[indexRow].Cells[indexColumn].Value = Properties.Resources.sea_dead;
            }
            flag = true;
        }
               
        //Метод выстрела либо пользователя, либо компьютера
        bool Fire(string name,int _indexRow, int _indexCol, int[,] field, ClassicSeaBattle collection)
        {
            string msg = "";
            if (field[_indexRow, _indexCol] == 1)
            {
                foreach (Ship ship in collection.ListOfShips)
                {
                    if (ship.Hit(_indexRow + "," + _indexCol))
                    {
                        if (ship.Injury(collection))
                        {
                            FileStream file1 = new FileStream("LogFile.txt", FileMode.Append);
                            StreamWriter writer1 = new StreamWriter(file1);
                            msg = "<<" + name + ">> сделал выстрел в точку [" + (_indexRow + 1)
                                                      + "," + (_indexCol + 1) + "]. Убил.";
                            MessageBox.Show(name + " убил: " + ship.ToString());
                            listBoxHistory.Items.Add(msg);
                            writer1.WriteLine(msg);
                            writer1.Close();
                            file1.Close();                         
                        }
                        break;
                    }
                }
                FileStream file = new FileStream("LogFile.txt", FileMode.Append);
                StreamWriter writer = new StreamWriter(file);
                msg = "<<" + name + ">> сделал выстрел в точку [" + (_indexRow + 1)
                + "," + (_indexCol + 1) + "]. Ранил.";
                listBoxHistory.Items.Add(msg);
                writer.WriteLine(msg);
                writer.Close();
                file.Close();
                if (collection.Count == 0) MessageBox.Show("Победа " + name);
                return true;
            }
            else
            {
                msg = "<<" + name + ">> сделал выстрел в точку [" + (_indexRow + 1)
                + "," + (_indexCol + 1) + "]. Мимо.";
                listBoxHistory.Items.Add(msg);
                FileStream file = new FileStream("LogFile.txt", FileMode.Append);
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine(msg);
                writer.Close();
                file.Close();
                return false;
            }
        }

        //Событие, при выделении ячейки с вражеского поля
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = dataGridView2.CurrentCell.RowIndex;
            indexColumn = dataGridView2.CurrentCell.ColumnIndex;
 
                button_fire.Enabled = true;
                labelCell.Text = "по координате [" + (indexRow + 1) + ", " + (indexColumn + 1) + "]";
            
        }
    }
}
