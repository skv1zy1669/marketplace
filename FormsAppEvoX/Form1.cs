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
        public Game[] games = new Game[600];
        public Form1()
        {
            InitializeComponent();

            games[0] = new Game("L.A. Noire", 2000, "Приключения");

            games[0] = new Game("CALL of DUTY", 2000, "Приключения");
          //  games[0].picture = pictureBox9;

            games[1] = new Game("CS GO", 0, "");
         //   games[1].picture = pictureBox1;


            games[2] = new Game("Mortal Kombat", 700, "");
           // games[2].picture = pictureBox8;


            games[3] = new Game("Forza", 800, "");
           // games[3].picture = pictureBox2;


            games[4] = new Game("WITCHER", 1500, "");
         //   games[4].picture = pictureBox6;


            games[5] = new Game("Mirrors Edge", 1000, "");
          //  games[5].picture = pictureBox10;

            games[6] = new Game("CALL of DUTY", 900, "Приключения");
          //  games[6].picture = pictureBox5;

            games[7] = new Game("GTA V", 900, "Приключения");
          //  games[7].picture = pictureBox3;

            games[8] = new Game("Destiny", 5600, "Приключения");
           // games[8].picture = pictureBox4;


            int x = 10;
            int y = 80;
            for (int i = 0; i < 9; i++)
            {
                PictureBox pb1 = new PictureBox(); 
                pb1.Location = new Point(x, y);
                pb1.Size = new Size(150, 200);
                pb1.SizeMode = PictureBoxSizeMode.Zoom;
                try
                {
                    pb1.Load("../../Маркет плэйс/" + games[i].name + ".png");
                }
                catch (Exception)
                {
                    try
                    {
                        pb1.Load("../../Маркет плэйс/" + games[i].name + ".jpg");
                    }
                    catch (Exception) { }
                }
                games[i].picture = pb1; 
                games[i].picture.Tag = games[i].name;
                games[i].picture.Click += new EventHandler(OpenGame);
                Controls.Add(pb1);

                Label Lb1 = new Label();
                Lb1.AutoSize = true;
                Lb1.BackColor = Color.Transparent;
                Lb1.ForeColor = Color.Brown;
                Lb1.Font = new Font("Microsoft Sans Serif", 15F);
                Lb1.Location = new Point(x + 10, y + 200);
                Lb1.Size = new Size(150, 20);
                Lb1.Text = games[i].name;
                games[i].label = Lb1;
                Controls.Add(Lb1);

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
            for (int i = 0; i < 9; i++)
            {
                games[i].picture.Visible = true;

                if (textBox1.Text != "" &&
                    games[i].name != textBox1.Text)
                {
                    games[i].picture.Visible = false;
                }

                if (cenaTB.Text != "" &&
                   games[i].price > Convert.ToInt32(cenaTB.Text))
                {
                   games[i].picture.Visible = false;
                
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}