namespace Sodavandsautomat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_20kr = new System.Windows.Forms.Button();
            this.button_10kr = new System.Windows.Forms.Button();
            this.button_5kr = new System.Windows.Forms.Button();
            this.button_2kr = new System.Windows.Forms.Button();
            this.button_1kr = new System.Windows.Forms.Button();
            this.label_Beløb = new System.Windows.Forms.Label();
            this.textBox_beløb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_20kr
            // 
            this.button_20kr.Location = new System.Drawing.Point(372, 135);
            this.button_20kr.Name = "button_20kr";
            this.button_20kr.Size = new System.Drawing.Size(75, 75);
            this.button_20kr.TabIndex = 0;
            this.button_20kr.Text = "20 kr.";
            this.button_20kr.UseVisualStyleBackColor = true;
            this.button_20kr.Click += new System.EventHandler(this.button_Click);
            // 
            // button_10kr
            // 
            this.button_10kr.Location = new System.Drawing.Point(453, 135);
            this.button_10kr.Name = "button_10kr";
            this.button_10kr.Size = new System.Drawing.Size(75, 75);
            this.button_10kr.TabIndex = 1;
            this.button_10kr.Text = "10 kr.";
            this.button_10kr.UseVisualStyleBackColor = true;
            this.button_10kr.Click += new System.EventHandler(this.button_Click);
            // 
            // button_5kr
            // 
            this.button_5kr.Location = new System.Drawing.Point(534, 135);
            this.button_5kr.Name = "button_5kr";
            this.button_5kr.Size = new System.Drawing.Size(75, 75);
            this.button_5kr.TabIndex = 2;
            this.button_5kr.Text = "5 kr.";
            this.button_5kr.UseVisualStyleBackColor = true;
            this.button_5kr.Click += new System.EventHandler(this.button_Click);
            // 
            // button_2kr
            // 
            this.button_2kr.Location = new System.Drawing.Point(372, 216);
            this.button_2kr.Name = "button_2kr";
            this.button_2kr.Size = new System.Drawing.Size(75, 75);
            this.button_2kr.TabIndex = 3;
            this.button_2kr.Text = "2 kr.";
            this.button_2kr.UseVisualStyleBackColor = true;
            this.button_2kr.Click += new System.EventHandler(this.button_Click);
            // 
            // button_1kr
            // 
            this.button_1kr.Location = new System.Drawing.Point(453, 216);
            this.button_1kr.Name = "button_1kr";
            this.button_1kr.Size = new System.Drawing.Size(75, 75);
            this.button_1kr.TabIndex = 4;
            this.button_1kr.Text = "1 kr.";
            this.button_1kr.UseVisualStyleBackColor = true;
            this.button_1kr.Click += new System.EventHandler(this.button_Click);
            // 
            // label_Beløb
            // 
            this.label_Beløb.AutoSize = true;
            this.label_Beløb.Location = new System.Drawing.Point(372, 69);
            this.label_Beløb.Name = "label_Beløb";
            this.label_Beløb.Size = new System.Drawing.Size(48, 17);
            this.label_Beløb.TabIndex = 6;
            this.label_Beløb.Text = "Beløb:";
            // 
            // textBox_beløb
            // 
            this.textBox_beløb.Location = new System.Drawing.Point(453, 69);
            this.textBox_beløb.Name = "textBox_beløb";
            this.textBox_beløb.ReadOnly = true;
            this.textBox_beløb.Size = new System.Drawing.Size(156, 22);
            this.textBox_beløb.TabIndex = 7;
            this.textBox_beløb.Text = "0";
            this.textBox_beløb.TextChanged += new System.EventHandler(this.textBox_beløb_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_beløb);
            this.Controls.Add(this.label_Beløb);
            this.Controls.Add(this.button_1kr);
            this.Controls.Add(this.button_2kr);
            this.Controls.Add(this.button_5kr);
            this.Controls.Add(this.button_10kr);
            this.Controls.Add(this.button_20kr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CocaCola = new System.Windows.Forms.Button();
            this.Sprite = new System.Windows.Forms.Button();
            this.FaxeKondi = new System.Windows.Forms.Button();
            this.Pepsi = new System.Windows.Forms.Button();
            this.PepsiMax = new System.Windows.Forms.Button();
            this.SevenUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CocaCola
            // 
            this.CocaCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CocaCola.Location = new System.Drawing.Point(16, 53);
            this.CocaCola.Name = "CocaCola";
            this.CocaCola.Size = new System.Drawing.Size(284, 58);
            this.CocaCola.TabIndex = 0;
            this.CocaCola.Text = "Coca-Cola";
            this.CocaCola.UseVisualStyleBackColor = true;
            this.CocaCola.Click += new System.EventHandler(this.CocaCola_Click);
            // 
            // Sprite
            // 
            this.Sprite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sprite.Location = new System.Drawing.Point(16, 119);
            this.Sprite.Name = "Sprite";
            this.Sprite.Size = new System.Drawing.Size(284, 54);
            this.Sprite.TabIndex = 1;
            this.Sprite.Text = "Sprite";
            this.Sprite.UseVisualStyleBackColor = true;
            this.Sprite.Click += new System.EventHandler(this.Sprite_Click);
            // 
            // FaxeKondi
            // 
            this.FaxeKondi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FaxeKondi.Location = new System.Drawing.Point(16, 179);
            this.FaxeKondi.Name = "FaxeKondi";
            this.FaxeKondi.Size = new System.Drawing.Size(284, 53);
            this.FaxeKondi.TabIndex = 2;
            this.FaxeKondi.Text = "Faxe Kondi";
            this.FaxeKondi.UseVisualStyleBackColor = true;
            this.FaxeKondi.Click += new System.EventHandler(this.FaxeKondi_Click);
            // 
            // Pepsi
            // 
            this.Pepsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pepsi.Location = new System.Drawing.Point(16, 238);
            this.Pepsi.Name = "Pepsi";
            this.Pepsi.Size = new System.Drawing.Size(284, 49);
            this.Pepsi.TabIndex = 3;
            this.Pepsi.Text = "Pepsi";
            this.Pepsi.UseVisualStyleBackColor = true;
            this.Pepsi.Click += new System.EventHandler(this.Pepsi_Click);
            // 
            // PepsiMax
            // 
            this.PepsiMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PepsiMax.Location = new System.Drawing.Point(16, 293);
            this.PepsiMax.Name = "PepsiMax";
            this.PepsiMax.Size = new System.Drawing.Size(284, 52);
            this.PepsiMax.TabIndex = 4;
            this.PepsiMax.Text = "Pepsi Max";
            this.PepsiMax.UseVisualStyleBackColor = true;
            this.PepsiMax.Click += new System.EventHandler(this.PepsiMax_Click);
            // 
            // SevenUp
            // 
            this.SevenUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenUp.Location = new System.Drawing.Point(16, 351);
            this.SevenUp.Name = "SevenUp";
            this.SevenUp.Size = new System.Drawing.Size(284, 53);
            this.SevenUp.TabIndex = 5;
            this.SevenUp.Text = "7-Up";
            this.SevenUp.UseVisualStyleBackColor = true;
            this.SevenUp.Click += new System.EventHandler(this.SevenUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "20Kr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "23Kr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "25Kr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "22Kr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "22Kr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "23Kr";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(306, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 35);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Sodavandsautomat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 421);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 221);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 654);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SevenUp);
            this.Controls.Add(this.PepsiMax);
            this.Controls.Add(this.Pepsi);
            this.Controls.Add(this.FaxeKondi);
            this.Controls.Add(this.Sprite);
            this.Controls.Add(this.CocaCola);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_20kr;
        private System.Windows.Forms.Button button_10kr;
        private System.Windows.Forms.Button button_5kr;
        private System.Windows.Forms.Button button_2kr;
        private System.Windows.Forms.Button button_1kr;
        private System.Windows.Forms.Label label_Beløb;
        private System.Windows.Forms.TextBox textBox_beløb;
        private System.Windows.Forms.Button CocaCola;
        private System.Windows.Forms.Button Sprite;
        private System.Windows.Forms.Button FaxeKondi;
        private System.Windows.Forms.Button Pepsi;
        private System.Windows.Forms.Button PepsiMax;
        private System.Windows.Forms.Button SevenUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

