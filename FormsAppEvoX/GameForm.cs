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
        Game game1;

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
                picture.Location = new Point(460 + 40 * i, 65);
                picture.Size = new Size(40, 40);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Load("../../Маркет плэйс/звездочка.jpeg");
                Controls.Add(picture);
            }


            if (game ==  "Dirt 2.0")
            {
                //labelPrice.Text = " руб.";
                labelDeveloper.Text = "РАЗРАБОТЧИК: Codemasters";
                labelPromoter.Text = "ИЗДАТЕЛЬ: Codemasters";
                label2.Text = "Дата выхода: 2019";
            }

            if (game == "")
            {
                //labelPrice.Text = "руб.";
                labelDeveloper.Text = "РАЗРАБОТЧИК: ";
                labelPromoter.Text = "ИЗДАТЕЛЬ: ";
                label2.Text = "Дата выхода ";
            }

            if (game == "")
            {
                //labelPrice.Text = " руб.";
                labelDeveloper.Text = "РАЗРАБОТЧИК: ";
                labelPromoter.Text = "ИЗДАТЕЛЬ: ";
                label2.Text = "Дата выхода ";
            }

            if (game == "")
            {
                //labelPrice.Text = "руб.";
                labelDeveloper.Text = "РАЗРАБОТЧИК: ";
                labelPromoter.Text = "ИЗДАТЕЛЬ: ";
                label2.Text = "Дата выхода ";
            }










            if (game == "Red Dead Redemption 2")
            {
                //labelPrice.Text = "2499 руб.";
                labelDeveloper.Text = "РАЗРАБОТЧИК: Rockstar Games";
                labelPromoter.Text = "ИЗДАТЕЛЬ: Rockstar Games";
                label2.Text = "Дата выхода 5 Дек. 2019";
            }

            if (game == "Rust")
            {
                //labelPrice.Text = "725 руб.";
                labelDeveloper.Text = "РАЗРАБОТЧИК: Facepunch Studios";
                labelPromoter.Text = "ИЗДАТЕЛЬ: Facepunch Studios";
                label2.Text = "Дата выходa 8 фев. 2018";
            }

            if (game == "GTA V")
            {
                //labelPrice.Text = "1499 руб.";
                labelDeveloper.Text = "РАЗРАБОТЧИК: Rockstar North";
                labelPromoter.Text = "ИЗДАТЕЛЬ: Rockstar Games";
                label2.Text = "Дата выхода 14 апр. 2015";
            }

            if (game == "Destiny")
            {
                // labelPrice.Text = "5591 руб.";
                labelDeveloper.Text = "Разработчик: Bungel";
                labelPromoter.Text = "Издатель: Activision";
                label2.Text = "Дата выхода: 10 ноя. 2020";
            }

            if (game == "CS GO")
            {
                //  labelPrice.Text = "Бесплатно";
                labelDeveloper.Text = "ДАТА ВЫХОДА: 21 авг. 2012";
                labelPromoter.Text = "РАЗРАБОТЧИК:Valve, Hidden Path Entertainment";
                label2.Text = "ИЗДАТЕЛЬ:Valve";
            }
            if (game == "Mortal Kombat")
            {
                //   labelPrice.Text = "690 руб.";
                labelDeveloper.Text = "РАЗРАБОТЧИК:  NetherRealm Studios, QLOC, Shiver";
                labelPromoter.Text = "ИЗДАТЕЛЬ:  Warner Bros Interactive Entertainment";
                label2.Text = "Дата выхода 23 апр. 2019";
            }
            if (game == "Forza")
            {
                //   labelPrice.Text = "800 руб";
                labelDeveloper.Text = "РАЗРАБОТЧИК:  Playground Games, Turn 10 Studios";
                labelPromoter.Text = "ИЗДАТЕЛЬ:  Playground Games, Turn 10 Studios";
                label2.Text = "Дата выхода 2018 г.";
            }
            if (game == "Mirrors Edge")
            {
                //  labelPrice.Text = "999 руб.";
                labelDeveloper.Text = "РАЗРАБОТЧИК: EA DICE";
                labelPromoter.Text = "ИЗДАТЕЛЬ: EA DICE";
                label2.Text = "Дата выхода 2008 г.";
            }

            if (game == "WITCHER")
            {
                //labelPrice.Text = "1354 руб";
                labelDeveloper.Text = "РАЗРАБОТЧИК; CD PROJEKT RED";
                labelPromoter.Text = "ИЗДАТЕЛЬ:  CD PROJEKT RED";
                label2.Text = "Дата выхода 2018 г.";
            }


            if (game == "CALL of DUTY WTR")
            {
                //labelPrice.Text = "899 руб";
                labelDeveloper.Text = "РАЗРАБОТЧИК; CD PROJEKT RED";
                labelPromoter.Text = "ИЗДАТЕЛЬ:  CD PROJEKT RED";
                label2.Text = "Дата выхода 2008 г.";
            }

            if (game == "CALL of DUTY")
            {
               // labelPrice.Text = "1999 руб";
                labelDeveloper.Text = "РАЗРАБОТЧИК; CD PROJEKT RED";
                labelPromoter.Text = "ИЗДАТЕЛЬ:  CD PROJEKT RED";
                label2.Text = "Дата выхода 2018 г.";
            }
            if (game == "L.A Noire")
            {
             //   labelPrice.Text = "699 руб";
                labelDeveloper.Text = "РАЗРАБОТЧИК; Team Bondi";
                labelPromoter.Text = "ИЗДАТЕЛЬ:  Rockstar games";
                label2.Text = "Дата выхода 8 ноя.2011 г.";
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!Form1.korzina.Contains(game1)) 
                Form1.korzina.Add(game1);
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
