using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace OpenWeahterAPI_TP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string APIKey = "e31bf39feaef26033af1421e521b68fe";

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", CityForm.Text, APIKey);
                var json = web.DownloadString(url);
                Info.Root Info = JsonConvert.DeserializeObject<Info.Root>(json);

                IconLogo.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                Condition.Text = Info.weather[0].main;
                Details.Text = Info.weather[0].description;
                Sunset.Text = convertDateTime(Info.sys.sunset).ToString();
                Sunrise.Text = convertDateTime(Info.sys.sunrise).ToString();

                WSpeed.Text = Info.wind.speed.ToString() + "Km/h";
                Pressure.Text = Info.main.pressure.ToString() + "Bar";
                Temp.Text = (Info.main.temp-273,15).ToString() + "°C";
                Humidity.Text = Info.main.humidity.ToString() + "%";

                City.Text = CityForm.Text;
                Country.Text = Info.sys.country;
                

            }
        }

        DateTime convertDateTime(long milli)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddMilliseconds(milli).ToLocalTime();

            return day;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RechercheBtn_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        private void Sunset_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }
    }
}
