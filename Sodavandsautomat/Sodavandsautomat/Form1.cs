﻿using System;
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

        int number;
        private int GetNumberFromButton(string buttonName)
        {
            string num = "";
            int res = 1;
            // Converts through whole string
            for (int i = 0; i < buttonName.Length; i++)
            {
                // if the present char is a digit then add tostring
                if (char.IsDigit(buttonName[i]))
                {
                    num += buttonName[i];
                }

            }
            //if numer is located
            if (num.Length > 0)
            {
                res = int.Parse(num);
            }
            return res;
        }
        private void button_Click(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
            int result = int.Parse(textBox_beløb.Text) + GetNumberFromButton(b.Text);
            textBox_beløb.Text = result.ToString();
            //number = GetNumberFromButton(b.Name);
            //textBox_beløb.Text += number.ToString();

            
        }
     

        private void textBox_beløb_TextChanged(object sender, EventArgs e)
        {
            
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
