using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public Game(string name1, int price1, string genre1)
        {
            picture = new PictureBox();
            label = new Label();
            name = name1;
            price = price1;
            genre = genre1;
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

            games_list.Add(new Game("L.A.Noire", 2000, "Приключения"));
            games_list.Add(new Game("CALL of DUTY", 2000, "Приключения"));
            games_list.Add(new Game("CS GO", 0, ""));
            games_list.Add(new Game("Mortal Kombat", 700, ""));
            games_list.Add(new Game("Forza", 800, ""));
            games_list.Add(new Game("WITCHER", 1500, ""));
            games_list.Add(new Game("Mirrors Edge", 1000, ""));
            games_list.Add(new Game("CALL of DUTY WTR", 900, "Приключения"));
            games_list.Add(new Game("GTA V", 1499, "Приключения"));
            games_list.Add(new Game("Destiny", 5600, "Приключения"));


            int x = 10;
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
                Controls.Add(games_list[i].picture);
                #endregion

                #region Подпись к картинке
                games_list[i].label.AutoSize = true;
                games_list[i].label.BackColor = Color.Transparent;
                games_list[i].label.ForeColor = Color.Brown;
                games_list[i].label.Font = new Font("Microsoft Sans Serif", 15);
                games_list[i].label.Location = new Point(x + 10, y + 200);
                games_list[i].label.Size = new Size(150, 20);
                games_list[i].label.Text = games_list[i].name;
                Controls.Add(games_list[i].label);
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
        private void OpenGame(object sender, EventArgs e)
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

        

        

        private void button1_Click_1(object sender, EventArgs e)
        {
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

                if (cenaTB.Text != "" &&
                   games_list[i].price > Convert.ToInt32(cenaTB.Text))
                {
                    games_list[i].picture.Visible = false;
                    games_list[i].label.Visible = false;
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}