using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProiectInfo
{
    public partial class MainPage : Form
    {

        private const string API_KEY = "484580a83937225816fca0af7524e7bc";
        public MainPage()
        {
            InitializeComponent();
        }

        private string ApiUrl(string city, string key)
        {
            return "https://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&mode=xml&appid=" + key;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchBoxButton_Click(object sender, EventArgs e)
        {
            cityText.Text = searchCityBox.Text;

            using(WebClient client = new WebClient())
            {
                try
                {
                    DisplayWeather(client.DownloadString(ApiUrl(searchCityBox.Text, API_KEY)));
                }
                catch(WebException ex)
                {
                    DisplayError(ex);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Unknown error\n" + ex.Message);
                }
            }

        }

        private void DisplayWeather(string XMLData)
        {
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.LoadXml(XMLData);

            temperatureText.Text = xml_doc.SelectSingleNode("current/temperature").Attributes["value"].Value + "°";
            cityText.Text = xml_doc.SelectSingleNode("current/city").Attributes["name"].Value;
            statusText.Text = xml_doc.SelectSingleNode("current/weather").Attributes["value"].Value;
            weatherIcon.Load("http://openweathermap.org/img/w/" + xml_doc.SelectSingleNode("current/weather").Attributes["icon"].Value + ".png");
            countryText.Text = xml_doc.SelectSingleNode("current/city/country").InnerText;
        }

        private void DisplayError(WebException exception)
        {
            try
            {
                StreamReader reader = new StreamReader(exception.Response.GetResponseStream());
                XmlDocument response_doc = new XmlDocument();
                response_doc.LoadXml(reader.ReadToEnd());
                XmlNode message_node = response_doc.SelectSingleNode("//message");
                MessageBox.Show(message_node.InnerText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error\n" + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CityWikiPageForm cityWikiPageForm = new CityWikiPageForm("https://en.wikipedia.org/wiki/" + cityText.Text);
            cityWikiPageForm.Show();
        }
    }
}
