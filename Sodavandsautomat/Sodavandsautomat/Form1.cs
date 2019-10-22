using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sodavandsautomat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
        }

        private void CocaCola_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:/Users/mikke/OneDrive/Documents/GitHub/Sodavandsautomat/Billeder/CocaCola.jpg");
        }

        private void Sprite_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:/Users/mikke/OneDrive/Documents/GitHub/Sodavandsautomat/Billeder/Sprite.jpeg");
        }

        private void FaxeKondi_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:/Users/mikke/OneDrive/Documents/GitHub/Sodavandsautomat/Billeder/FaxeKondi.png");
        }

        private void Pepsi_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:/Users/mikke/OneDrive/Documents/GitHub/Sodavandsautomat/Billeder/Pepsi1.jpg");
        }

        private void PepsiMax_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:/Users/mikke/OneDrive/Documents/GitHub/Sodavandsautomat/Billeder/PepsiMax.png");
        }

        private void SevenUp_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:/Users/mikke/OneDrive/Documents/GitHub/Sodavandsautomat/Billeder/SevenUp.jpg");
        }
        private void buttondown(object sender, EventArgs e)
        {

        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
