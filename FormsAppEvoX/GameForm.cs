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
    public partial class GameForm : Form
    {
        /// <summary>
        /// Выбранная игра
        /// </summary>
        public Game game1; 
        void translate(Dictionary<string, string> words)
        {
            labelDeveloper.Text = words["Разработчик"];
            labelPromoter.Text = words["Издатель"];
            label5.Text = words["Описание"];
            label2.Text = words["Дата выхода"];
            label3.Text = words["Платформы"];
        }

        public GameForm(string game)
        {
            //Form1.games_list;
            InitializeComponent();

            label1.Text = game;
            try
            {
                label6.Text = File.ReadAllText("../../Маркет плэйс/" + game + ".txt");
            }
            catch (Exception) { }

            try
            {               
                GamePicture.Load("../../Маркет плэйс/" + game + ".png");
            }
            catch (Exception)
            {
                try
                {
                    GamePicture.Load("../../Маркет плэйс/" + game + ".jpg");
                }
                catch (Exception) { }
            }


            for (int i = 0; i < Form1.games_list.Count; i++)
            {
                if (Form1.games_list[i].name == game)
                {
                    game1 = Form1.games_list[i];
                    labelPrice.Text = game1.price.ToString() + " руб.";
                }
            }

            //Рейтинг
            for (int i = 0; i < game1.rating; i++)
            {
                PictureBox picture = new PictureBox();
                picture.Location = new Point(460 + 40 * i, 158);
                picture.Size = new Size(40, 40);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Load("../../Маркет плэйс/звездочка.jpeg");
                Controls.Add(picture);
            }



            labelDeveloper.Text = "РАЗРАБОТЧИК: " + game1.developer;
            labelPromoter.Text = "ИЗДАТЕЛЬ: " + game1.promoter;

            if (Form1.Language == "En")
            {
                labelDeveloper.Text = Form1.EngWords["Разработчик"] + ": " + game1.developer; ;
                labelPromoter.Text = Form1.EngWords["Издатель"] + ": " + game1.promoter;
            }


            if (game ==  "Dirt 2.0")
            {
                //labelPromoter.Text = "ИЗДАТЕЛЬ: Codemasters";
                label2.Text = "Дата выхода: 2019";
            }

           
           



            if (game == "Red Dead Redemption 2")
            {
                //labelPromoter.Text = "ИЗДАТЕЛЬ: Rockstar Games";
                label2.Text = "Дата выхода 5 Дек. 2019";
            }

            if (game == "Rust")
            {
                
                //labelPromoter.Text = "ИЗДАТЕЛЬ: Facepunch Studios";
                label2.Text = "Дата выходa 8 фев. 2018";
            }

            if (game == "GTA V")
            {
               
                //labelDeveloper.Text = "РАЗРАБОТЧИК: Rockstar North";
                //labelPromoter.Text = "ИЗДАТЕЛЬ: Rockstar Games";
                label2.Text = "Дата выхода 14 апр. 2015";
            }

            if (game == "Destiny")
            {
                //labelPromoter.Text = "Издатель: Activision";
                label2.Text = "Дата выхода: 10 ноя. 2020";
            }

            if (game == "CS GO")
            {
                //labelPromoter.Text = "ИЗДАТЕЛЬ:Valve";
                label2.Text = "ДАТА ВЫХОДА: 21 авг. 2012";
            }
            if (game == "Mortal Kombat")
            {
                //labelPromoter.Text = "ИЗДАТЕЛЬ:  Warner Bros Interactive Entertainment";
                label2.Text = "Дата выхода 23 апр. 2019";
            }
            if (game == "Forza")
            {
                //labelPromoter.Text = "ИЗДАТЕЛЬ:  Playground Games, Turn 10 Studios";
                label2.Text = "Дата выхода 2018 г.";
            }
            if (game == "Mirrors Edge")
            {
                //labelPromoter.Text = "ИЗДАТЕЛЬ: EA DICE";
                label2.Text = "Дата выхода 2008 г.";
            }

            if (game == "WITCHER")
            {
                //labelPromoter.Text = "ИЗДАТЕЛЬ:  CD PROJEKT RED";
                label2.Text = "Дата выхода 2018 г.";
            }


            if (game == "CALL of DUTY WTR")
            {
                //labelPromoter.Text = "ИЗДАТЕЛЬ:  CD PROJEKT RED";
                label2.Text = "Дата выхода 2008 г.";
            }

            if (game == "CALL of DUTY")
            {
                //labelPromoter.Text = "ИЗДАТЕЛЬ:  CD PROJEKT RED";
                label2.Text = "Дата выхода 2018 г.";
            }
            if (game == "L.A Noire")
            {
                //labelPromoter.Text = "ИЗДАТЕЛЬ:  Rockstar games";
                label2.Text = "Дата выхода 8 ноя.2011 г.";
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!Form1.korzina.Contains(game1))
            {

                Form1.korzina.Add(game1);
                MessageBox.Show("Вы добавили игру в карзину");
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {


            if (game1.name == "CS GO")
            {
                System.Diagnostics.Process.Start("https://store.steampowered.com/app/730/CounterStrike_Global_Offensive/");
            }
   
            if (game1.name == "L.A.Noire")
            {
                System.Diagnostics.Process.Start("http://store.steampowered.com/app/110800/LA_Noire/");
            }

            if (game1.name == "GTA V")
            {
                System.Diagnostics.Process.Start("https://store.steampowered.com/app/271590/Grand_Theft_Auto_V/");
            }

            if (game1.name == "Destiny")
            {
                System.Diagnostics.Process.Start("https://store.steampowered.com/app/1085660/Destiny_2/");
            }

            if (game1.name == "WITCHER")
            {
                System.Diagnostics.Process.Start("https://store.steampowered.com/app/292030/_3/");
            }

            if (game1.name == "CALL of DUTY")
            {
                System.Diagnostics.Process.Start("https://store.steampowered.com/app/10180/Call_of_Duty_Modern_Warfare_2/");
            }

            if (game1.name == "CALL of DUTY WTR")
            {
                System.Diagnostics.Process.Start("https://store.steampowered.com/app/10090/Call_of_Duty_World_at_War/");
            }

            if (game1.name == "Mirrors Edge")
            {
                System.Diagnostics.Process.Start("https://store.steampowered.com/app/1233570/Mirrors_Edge_Catalyst/");
            }

            if (game1.name == "Forza")
            {
                System.Diagnostics.Process.Start("https://store.steampowered.com/app/1293830/Forza_Horizon_4/");
            }
        }
    }
}
