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
    }
}

