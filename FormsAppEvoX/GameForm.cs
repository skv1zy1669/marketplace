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
    public partial class GameForm : Form
    {

        public GameForm(string game)
        {
            InitializeComponent();

            label1.Text = game;

            if (game == "GTA V")
            {
                labelPrice.Text = "1498.50 руб.";
                labelDeveloper.Text = "РАЗРАБОТЧИК: Rockstar North";
                labelPromoter.Text = "ИЗДАТЕЛЬ: Rockstar Games";
                label2.Text = "Дата выхода 14 апр. 2015";
                GamePicture.Load("../../Маркет плэйс/GTA V.jpg");
            }

            if (game == "Destiny")
            {
                labelPrice.Text = "5591 руб.";
                labelDeveloper.Text = "Разработчик: Bungel";
                labelPromoter.Text = "Издатель: Activision";
                label2.Text = "Дата выхода: 10 ноя. 2020";
                GamePicture.Load("../../Маркет плэйс/GTA V.jpg");
            }

            if (game == "CS GO")
            {
                labelPrice.Text = "Бесплатно";
                labelDeveloper.Text = "ДАТА ВЫХОДА: 21 авг. 2012";
                labelPromoter.Text = "РАЗРАБОТЧИК:Valve, Hidden Path Entertainment";
                label2.Text = "ИЗДАТЕЛЬ:Valve";
                GamePicture.Load("../../Маркет плэйс/CS GO.jpg");
            }
            if (game == "Mortal Kombat")
            {
                labelPrice.Text = "690 руб.";
                labelDeveloper.Text = "РАЗРАБОТЧИК:  NetherRealm Studios, QLOC, Shiver";
                labelPromoter.Text = "ИЗДАТЕЛЬ:  Warner Bros Interactive Entertainment";
                label2.Text = "Дата выхода 23 апр. 2019";
                GamePicture.Load("../../Маркет плэйс/Mortal Kombat.jpg");
            }
            if (game == "Forza")
            {
                labelPrice.Text = "800 руб";
                labelDeveloper.Text = "РАЗРАБОТЧИК:  Playground Games, Turn 10 Studios";
                labelPromoter.Text = "ИЗДАТЕЛЬ:  Playground Games, Turn 10 Studios";
                label2.Text = "Дата выхода 2018 г.";
                GamePicture.Load("../../Маркет плэйс/Forza.jpg");
            }
            if (game == "Mirror's Edge")
            {
                labelPrice.Text = "999 руб.";
                labelDeveloper.Text = "РАЗРАБОТЧИК: EA DICE";
                labelPromoter.Text = "ИЗДАТЕЛЬ: EA DICE";
                label2.Text = "Дата выхода 2008 г.";
                GamePicture.Load("../../Маркет плэйс/Mirros edge.jpg");

                
            }

            if (game == "WITCHER")
            { 
                labelPrice.Text = "1354 руб";
                labelDeveloper.Text = "РАЗРАБОТЧИК; CD PROJEKT RED";
                labelPromoter.Text = "ИЗДАТЕЛЬ:  CD PROJEKT RED";
                label2.Text = "Дата выхода 2018 г.";
                GamePicture.Load("../../Маркет плэйс/WITCHER.jpg");

            }


            if (game == "CALL of DUTY WTR")
            {
                labelPrice.Text = "899 руб";
                labelDeveloper.Text = "РАЗРАБОТЧИК; CD PROJEKT RED";
                labelPromoter.Text = "ИЗДАТЕЛЬ:  CD PROJEKT RED";
                label2.Text = "Дата выхода 2008 г.";
                GamePicture.Load("../../Маркет плэйс/CALL of DUTY WTR.jpg");
            }

            if (game == "CALL of DUTY")
            {
                labelPrice.Text = "1999 руб";
                labelDeveloper.Text = "РАЗРАБОТЧИК; CD PROJEKT RED";
                labelPromoter.Text = "ИЗДАТЕЛЬ:  CD PROJEKT RED";
                label2.Text = "Дата выхода 2018 г.";
                GamePicture.Load("../../Маркет плэйс/CALL of DUTY.jpg");
            }
            if (game == "L.A Noire")
                {
                    labelPrice.Text = "699 руб";
                    labelDeveloper.Text = "РАЗРАБОТЧИК; Team Bondi";
                    labelPromoter.Text = "ИЗДАТЕЛЬ:  Rockstar games";
                    label2.Text = "Дата выхода 8 ноя.2011 г.";
                    GamePicture.Load("../../Маркет плэйс/L.A.NOIRE.jpg");


                }

        }









        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
