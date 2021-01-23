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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Podarok");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GameForm form = new GameForm("Destiry"); 
            form.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GameForm form = new GameForm("CS: GO");
            form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GameForm form = new GameForm("GTA V");
            form.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}