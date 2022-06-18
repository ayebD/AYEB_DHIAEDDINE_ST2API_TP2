
using System;

namespace OpenWeahterAPI_TP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CityName = new System.Windows.Forms.Label();
            this.CityForm = new System.Windows.Forms.TextBox();
            this.RechercheBtn = new System.Windows.Forms.Button();
            this.Condition = new System.Windows.Forms.Label();
            this.Details = new System.Windows.Forms.Label();
            this.Sunrise = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Sunset = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Pressure = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.WSpeed = new System.Windows.Forms.Label();
            this.IconLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Humidity = new System.Windows.Forms.Label();
            this.Temp = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IconLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // CityName
            // 
            this.CityName.AutoSize = true;
            this.CityName.Location = new System.Drawing.Point(257, 51);
            this.CityName.Name = "CityName";
            this.CityName.Size = new System.Drawing.Size(201, 25);
            this.CityName.TabIndex = 0;
            this.CityName.Text = "Write city/coutry name :";
            this.CityName.Click += new System.EventHandler(this.label1_Click);
            // 
            // CityForm
            // 
            this.CityForm.Location = new System.Drawing.Point(491, 51);
            this.CityForm.Name = "CityForm";
            this.CityForm.Size = new System.Drawing.Size(316, 31);
            this.CityForm.TabIndex = 1;
            // 
            // RechercheBtn
            // 
            this.RechercheBtn.Location = new System.Drawing.Point(880, 43);
            this.RechercheBtn.Name = "RechercheBtn";
            this.RechercheBtn.Size = new System.Drawing.Size(112, 34);
            this.RechercheBtn.TabIndex = 2;
            this.RechercheBtn.Text = "Recherche";
            this.RechercheBtn.UseVisualStyleBackColor = true;
            this.RechercheBtn.Click += new System.EventHandler(this.RechercheBtn_Click);
            // 
            // Condition
            // 
            this.Condition.AutoSize = true;
            this.Condition.Location = new System.Drawing.Point(809, 407);
            this.Condition.Name = "Condition";
            this.Condition.Size = new System.Drawing.Size(0, 25);
            this.Condition.TabIndex = 3;
            // 
            // Details
            // 
            this.Details.AutoSize = true;
            this.Details.Location = new System.Drawing.Point(807, 467);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(0, 25);
            this.Details.TabIndex = 4;
            this.Details.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Sunrise
            // 
            this.Sunrise.AutoSize = true;
            this.Sunrise.Location = new System.Drawing.Point(167, 407);
            this.Sunrise.Name = "Sunrise";
            this.Sunrise.Size = new System.Drawing.Size(0, 25);
            this.Sunrise.TabIndex = 5;
            this.Sunrise.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sunrise";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Sunset
            // 
            this.Sunset.AutoSize = true;
            this.Sunset.Location = new System.Drawing.Point(167, 467);
            this.Sunset.Name = "Sunset";
            this.Sunset.Size = new System.Drawing.Size(0, 25);
            this.Sunset.TabIndex = 7;
            this.Sunset.Click += new System.EventHandler(this.Sunset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sunset";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pressure";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Pressure
            // 
            this.Pressure.AutoSize = true;
            this.Pressure.Location = new System.Drawing.Point(526, 467);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(0, 25);
            this.Pressure.TabIndex = 11;
            this.Pressure.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Wind Speed";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // WSpeed
            // 
            this.WSpeed.AutoSize = true;
            this.WSpeed.Location = new System.Drawing.Point(526, 407);
            this.WSpeed.Name = "WSpeed";
            this.WSpeed.Size = new System.Drawing.Size(0, 25);
            this.WSpeed.TabIndex = 9;
            this.WSpeed.Click += new System.EventHandler(this.label10_Click);
            // 
            // IconLogo
            // 
            this.IconLogo.Location = new System.Drawing.Point(361, 183);
            this.IconLogo.Name = "IconLogo";
            this.IconLogo.Size = new System.Drawing.Size(340, 177);
            this.IconLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconLogo.TabIndex = 13;
            this.IconLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Condition";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Details";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(923, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Humidity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(923, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Temperature";
            // 
            // Humidity
            // 
            this.Humidity.AutoSize = true;
            this.Humidity.Location = new System.Drawing.Point(1056, 467);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(0, 25);
            this.Humidity.TabIndex = 17;
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.Location = new System.Drawing.Point(1058, 407);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(0, 25);
            this.Temp.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "City";
            this.label10.Click += new System.EventHandler(this.label10_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Country";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(167, 204);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(0, 25);
            this.City.TabIndex = 22;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(167, 288);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(0, 25);
            this.Country.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 654);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Humidity);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IconLogo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Pressure);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.WSpeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Sunset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sunrise);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.Condition);
            this.Controls.Add(this.RechercheBtn);
            this.Controls.Add(this.CityForm);
            this.Controls.Add(this.CityName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IconLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CityName;
        private System.Windows.Forms.TextBox CityForm;
        private System.Windows.Forms.Button RechercheBtn;
        private System.Windows.Forms.Label Condition;
        private System.Windows.Forms.Label Details;
        private System.Windows.Forms.Label Sunrise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Sunset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Pressure;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label WSpeed;
        private System.Windows.Forms.PictureBox IconLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Humidity;
        private System.Windows.Forms.Label Temp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label Country;
    }
}

