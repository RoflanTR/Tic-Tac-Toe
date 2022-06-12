using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Set : Form
    {
        public Set()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label2.Text = "Внимание! Поля не могут быть пустыми";

            }
            else if(textBox1.Text.Length>10 || textBox2.Text.Length > 10)
            {
                label2.Text = "Никнейм может содержать не более 10 символов";
            }
            else if (textBox1.Text ==  textBox2.Text)
            {
                label2.Text = "Никнеймы должны быть разными";
            }
            else
            {
                Game game = new Game(textBox1.Text, textBox2.Text, false);
                game.Show();
                Close();
            }
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
