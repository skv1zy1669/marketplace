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
    public partial class LoginForm : Form
    {
        public static string Login = "";

        public LoginForm()

        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Login = textBox1.Text;
            if (textBox1.Text == "Admin" && textBox2.Text == "////")

                MessageBox.Show("Вы вошли в учётную запись");
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}