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
    public partial class KorzinaForm : Form
    {
        public KorzinaForm()
        {
            InitializeComponent();
        }

        private void KorzinaForm_Load(object sender, EventArgs e)
        {
            int x = 10;
            int y = 80;
            foreach (Game game1 in Form1.korzina)
            {
                PictureBox picture = new PictureBox();
                picture.Location = new Point(x, y);
                picture.Size = new Size(150, 200);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                try
                {
                    picture.Load("../../Маркет плэйс/" + game1.name + ".png");
                }
                catch (Exception)
                {
                    try
                    {
                        picture.Load("../../Маркет плэйс/" + game1.name + ".jpg");
                    }
                    catch (Exception) { }
                }

                picture.Tag = game1.name;
                picture.Click += new EventHandler(Form1.OpenGame);
                Controls.Add(picture);

            }
        }
    }
}
