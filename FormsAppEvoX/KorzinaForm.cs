using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            Controls.Clear();
            Controls.Add(button1);
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

                Button btn = new Button();
                btn.Tag = game1.name;
                btn.Location = new Point(x + 130, y);
                btn.Size = new Size(20, 20);
                btn.Text = "X";
                btn.Click += new EventHandler(DeleteGame);
                Controls.Add(btn);
                Controls.Add(picture);
                //Координаты
                x = x + 160;
                if (x + 160 > Width)
                {
                    x = 20;
                    y = y + 225;
                }
            }
        }

        private void DeleteGame(object sender, EventArgs e)
        {
            string game = ((Button)sender).Tag.ToString();

            Game game1 = new Game();
            foreach (Game g in Form1.korzina)
            {
                if (g.name == game)
                    game1 = g;
            }

            Form1.korzina.Remove(game1);
            KorzinaForm_Load(sender, e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("mikki.abrams1234567890@gmail.com", "Tom");
            // кому отправляем
            MailAddress to = new MailAddress("fantazygdh@gmail.ru");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);

            // тема письма
            m.Subject = "Текст";

            // текст письма
            m.Body = "Привет!" +
                Environment.NewLine + "Эти игры находятся у вас в избраные";

            File.WriteAllText("Заказ.csv", "Название, Жанр, Цена");
            foreach (Game game1 in Form1.korzina)
            {
                File.AppendAllText("Заказ.csv",
                     Environment.NewLine + 
                     game1.name + ",\"" + game1.genre + "\"," + game1.price);
            }

            //m.Attachments.Add(new Attachment("-_-"));
            m.Attachments.Add(new Attachment("Заказ.csv"));
            //адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential(from.Address, "Beavis123");
            smtp.EnableSsl = true;
            smtp.Send(m);

            MessageBox.Show("Отправлено");



        }
    }
}
