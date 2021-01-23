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
             
            if (game == "GTA V")
            {
                label1.Text = "GTA V";
                label5.Text = "1498,50 руб.";
                GamePicture.Load("../../Маркет плэйс/GTA V.jpg");
            }
            if (game == "CS: GO")
            {
                label1.Text = "CS: GO";
                label5.Text = "Бесплатно";
                GamePicture.Load("../../Маркет плэйс/CS GO.jpg");
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
    }
}
