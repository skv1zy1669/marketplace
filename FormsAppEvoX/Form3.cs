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
    public partial class AddGame : Form
    {
        public AddGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
           File.AppendAllText("CharactersFiles.txt", Environment.NewLine + textBox1.Text + "; " + Filtergames);   
            textBox1.text + "; игры; 10");

           File.Create("../../Files/Игры/" + TextBox1.Text + ".txt");
           MessageBox.Show("Получилось");
            */

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
