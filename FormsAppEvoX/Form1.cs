using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAppEvoX
{
    public struct Game
    {
        public PictureBox picture;
        public Label label;
        public string name;
        public string genre;
        public int price;
        public int rating;
        public Game(string name1, int price1, string genre1, int rating1)
        {
            picture = new PictureBox();
            label = new Label();
            name = name1;
            price = price1;
            genre = genre1;
            rating = rating1;
        }
    }

    
    public partial class Form1 : Form
    {
        /// <summary>
        /// Все игры
        /// </summary>
        public static List<Game> games_list = new List<Game>();
        /// <summary>
        /// корзины
        /// </summary>
        public static List<Game> korzina = new List<Game>();

        public Form1()
        {
            InitializeComponent();


            string[] lines = File.ReadAllLines("../../../Маркет плэйс.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { ", " }, StringSplitOptions.None);
                games_list.Add(
                    new Game(parts[0],          //Название
                    Convert.ToInt32(parts[1]),  //Цена
                    parts[2], 
                    Convert.ToInt32(parts[3])));//Рейтинг
            }


            int x = 1;
            int y = 80;
            for (int i = 0; i < games_list.Count; i++)
            {
                # region Формируем картинку
                games_list[i].picture.Location = new Point(x, y);
                games_list[i].picture.Size = new Size(150, 200);
                games_list[i].picture.SizeMode = PictureBoxSizeMode.StretchImage;
                try
                {
                    games_list[i].picture.Load("../../Маркет плэйс/" + games_list[i].name + ".png");
                }
                catch (Exception)
                {
                    try
                    {
                        games_list[i].picture.Load("../../Маркет плэйс/" + games_list[i].name + ".jpg");
                    }
                    catch (Exception) { }
                }

                games_list[i].picture.Tag = games_list[i].name;
                games_list[i].picture.Click += new EventHandler(OpenGame);
                panel2.Controls.Add(games_list[i].picture);
                #endregion

                #region Подпись к картинке
                games_list[i].label.AutoSize = true;
                games_list[i].label.BackColor = Color.Transparent;
                games_list[i].label.ForeColor = Color.Brown;
                games_list[i].label.Font = new Font("Microsoft Sans Serif", 15);
                games_list[i].label.Location = new Point(x + 10, y + 200);
                games_list[i].label.Size = new Size(150, 20);
                games_list[i].label.Text = games_list[i].name;
                panel2.Controls.Add(games_list[i].label);
                #endregion

                //Координаты
                x = x + 160;
                if (x + 160 > Width)
                {
                    x = 15;
                    y = y + 225;
                }
            }
        }
        public static void OpenGame(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            GameForm form = new GameForm(pb.Tag.ToString());
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        

        private void SearchClick(object sender, EventArgs e)
        {
            int x = 10;
            int y = 80;
            for (int i = 0; i < games_list.Count; i++)
            {
                games_list[i].picture.Visible = true;
                games_list[i].label.Visible = true;

                if (textBox1.Text != "" &&
                    games_list[i].name != textBox1.Text)
                {
                    games_list[i].picture.Visible = false;
                    games_list[i].label.Visible = false;
                }

                //Скрываем игры с неподходящей ценой
                if (cenaTB.Text != "" &&
                   games_list[i].price > Convert.ToInt32(cenaTB.Text))
                {
                    games_list[i].picture.Visible = false;
                    games_list[i].label.Visible = false;
                }

                //Меняем координаты у видимых игр
                if (games_list[i].picture.Visible)
                {
                    games_list[i].picture.Location = new Point(x, y);
                    games_list[i].label.Location = new Point(x + 10, y + 200);
                    //Координаты
                    x = x + 160;
                    if (x + 160 > Width)
                    {
                        x = 15;
                        y = y + 225;
                    }
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Корзина_Click(object sender, EventArgs e)
        {
            KorzinaForm form = new KorzinaForm();
            form.Show();
        }

        private void AddGameButton_Click(object sender, EventArgs e)
        {
            AddGame form = new AddGame();
            form.Show();
        }
    }
}