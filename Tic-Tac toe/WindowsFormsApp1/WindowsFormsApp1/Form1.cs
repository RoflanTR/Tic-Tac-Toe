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
    
    public partial class Form1 : Form
    {
        
        
        
        
        public Form1()
        {
            InitializeComponent();
            
       
        }
        //иконка выхода из приложения
        private void PictureBox10_Click(object sender, EventArgs e)
        {
            Close();
        }
        //играть
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Set show = new Set();
            show.Show();
            
            
        }
        // правила
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Pr rules = new Pr();
            rules.ShowDialog();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Game game = new Game(true);
            
            game.Show();
            
        }
    }
}
