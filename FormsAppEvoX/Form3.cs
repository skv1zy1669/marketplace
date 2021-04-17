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
            
           File.AppendAllText("../../../Маркет плэйс.txt", Environment.NewLine + 
               textBox1.Text + ", " + textBox2.Text + ", Приключения, 5");

           File.Create("../../Маркет плэйс/" + textBox1.Text + ".txt");
           MessageBox.Show("Получилось");
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string address;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                address = openFileDialog1.FileName;
                pictureBox1.Load(address);         
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
