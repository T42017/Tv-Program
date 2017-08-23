using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TvTablaNew
{
    public partial class Form1 : Form
    {

        public string Url = "";
        public string DateToday = DateTime.Today.ToString("yyyy-MM-dd");
        public int Counter = 0;
        

        public Form1()
        {
            InitializeComponent();

            Url = "http://json.xmltv.se/svt1.svt.se_"+DateToday+".js.gz";


            WebClient wc = new WebClient();
            string response = wc.DownloadString(Url);
            var programmes = JsonConvert.DeserializeObject<Rootobject>(response);

            textBox1.Text = programmes.ToString();

           //int counter = 0;
           //
           //var todayDate = DateTime.Now;
           //var yesterDay = todayDate.AddDays(-counter);
            lbl_date.Text = DateToday;
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            try
            {
                Counter--;
                DateToday = DateTime.Today.AddDays(Counter).ToString("yyyy-MM-dd");
                Url = "http://json.xmltv.se/svt1.svt.se_" + DateToday + ".js.gz";
                WebClient wc = new WebClient();

                string response = wc.DownloadString(Url);
                var programmes = JsonConvert.DeserializeObject<Rootobject>(response);

                textBox1.Text = programmes.ToString();

                lbl_date.Text = DateToday;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No older tablues to show");
                Counter++;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                Counter++;
                DateToday = DateTime.Today.AddDays(Counter).ToString("yyyy-MM-dd");
                Url = "http://json.xmltv.se/svt1.svt.se_" + DateToday + ".js.gz";
                WebClient wc = new WebClient();

                string response = wc.DownloadString(Url);
                var programmes = JsonConvert.DeserializeObject<Rootobject>(response);

                textBox1.Text = programmes.ToString();
                lbl_date.Text = DateToday;
            }
            catch (Exception exception)
            {
                string message = "No newer tableus to show";
                MessageBox.Show(message, exception.ToString());
                Counter--;
            }
        }
    }
}
