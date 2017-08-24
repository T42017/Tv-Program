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

        public string UrlSvtOne = "";
        public string UrlSvtTwo = "";
        public string UrlTvFour = "";
        public string DateToday = DateTime.Today.ToString("yyyy-MM-dd");
        public int Counter = 0;
        

        public Form1()
        {
            InitializeComponent();

            UrlSvtOne = "http://json.xmltv.se/svt1.svt.se_"+DateToday+".js.gz";
            UrlTvFour = "http://json.xmltv.se/tv4.se_"+DateToday+".js.gz";
            // url tv2

            // Get data from Json.xmltv
            WebClient wc = new WebClient();
            string svtOneResponse = wc.DownloadString(UrlSvtOne);
            // svt2
            string tvFourResponse = wc.DownloadString(UrlTvFour);
            var svtOneProgrammes = JsonConvert.DeserializeObject<Rootobject>(svtOneResponse);
            //var tv2
            var tvFourProgrammes = JsonConvert.DeserializeObject<Rootobject>(tvFourResponse);

            //Print data to textbox and label
            rTbox_svt1.Text = svtOneProgrammes.ToString();
            lbl_svt1_date.Text = DateTime.Today.ToString("Den d MMMM");

            rTbox_tv4.Text = tvFourProgrammes.ToString();
            lbl_tv4_date.Text = DateTime.Today.ToString("Den d MMMM");

           


        }
        
        // SVT1
        private void btn_prev_Click(object sender, EventArgs e)
        {
            try
            {
                Counter--;
                DateToday = DateTime.Today.AddDays(Counter).ToString("yyyy-MM-dd");
                UrlSvtOne = "http://json.xmltv.se/svt1.svt.se_" + DateToday + ".js.gz";
                WebClient wc = new WebClient();

                string response = wc.DownloadString(UrlSvtOne);
                var programmes = JsonConvert.DeserializeObject<Rootobject>(response);

                rTbox_svt1.Text = programmes.ToString();

                lbl_svt1_date.Text = DateTime.Today.AddDays(Counter).ToString("Den d MMMM");
               

            }
            catch (Exception exception)
            {
                string message = "No older tablues to show";
                MessageBox.Show(message, exception.ToString());
                Counter++;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                Counter++;
                DateToday = DateTime.Today.AddDays(Counter).ToString("yyyy-MM-dd");
                UrlSvtOne = "http://json.xmltv.se/svt1.svt.se_" + DateToday + ".js.gz";
                WebClient wc = new WebClient();

                string response = wc.DownloadString(UrlSvtOne);
                var programmes = JsonConvert.DeserializeObject<Rootobject>(response);


               
                rTbox_svt1.Text = programmes.ToString();
                lbl_svt1_date.Text = DateTime.Today.AddDays(Counter).ToString("Den d MMMM");
            }
            catch (Exception exception)
            {
                string message = "No newer tableus to show";
                MessageBox.Show(message, exception.ToString());
                Counter--;
            }
        }
        //SVT2



        //TV4 Buttons
        private void btn_tv4_prev_Click(object sender, EventArgs e)
        {
            try
            {
                Counter--;
                DateToday = DateTime.Today.AddDays(Counter).ToString("yyyy-MM-dd");
                UrlTvFour = "http://json.xmltv.se/tv4.se_" + DateToday + ".js.gz";
                
                WebClient wc = new WebClient();
                string response = wc.DownloadString(UrlTvFour);
                var programmes = JsonConvert.DeserializeObject<Rootobject>(response);

                
                rTbox_tv4.Text = programmes.ToString();
                lbl_tv4_date.Text = DateTime.Today.AddDays(Counter).ToString("Den d MMMM");

            }
            catch (Exception exception)
            {
                string message = "No older tablues to show";
                MessageBox.Show(message, exception.ToString());
                Counter++;
            }
        }

        private void btn_tv4_next_Click(object sender, EventArgs e)
        {
            try
            {
                Counter++;
                DateToday = DateTime.Today.AddDays(Counter).ToString("yyyy-MM-dd");
                UrlTvFour = "http://json.xmltv.se/tv4.se_" + DateToday + ".js.gz";

                WebClient wc = new WebClient();
                string response = wc.DownloadString(UrlTvFour);
                var programmes = JsonConvert.DeserializeObject<Rootobject>(response);

                rTbox_tv4.Text = programmes.ToString();
                lbl_tv4_date.Text = DateTime.Today.AddDays(Counter).ToString("Den d MMMM");
            }
            catch (Exception exception)
            {
                string message = "Now newer tablues to show";
                Console.WriteLine(message, exception);
                Counter--;

            }
        }

       //private void CurrentProgramme()
       //{
       //    Rootobject test = new Rootobject();
       //    var todayTime = DateTime.Now;
       //    foreach (var programm in )
       //    {
       //        var programStart = Programme.ConvertFromUnixTimestampToDateTime(double.Parse());
       //    }
       //}


        


    }
}
