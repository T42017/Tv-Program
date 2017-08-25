﻿using Newtonsoft.Json;
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
        public int SvtOneCounter = 0;
        public int SvtTwoCounter = 0;
        public int TvFourCounter = 0;
        public string PrevMessage = "No older tableaus to show!";
        public string NextMessage = "No newer tableaus to show!";

        public Form1()
        {

            InitializeComponent();

            UrlSvtOne = "http://json.xmltv.se/svt1.svt.se_"+DateToday+".js.gz";
            UrlSvtTwo = "http://json.xmltv.se/svt2.svt.se_"+DateToday+".js.gz";
            UrlTvFour = "http://json.xmltv.se/tv4.se_"+DateToday+".js.gz";

            // Get data from Json.xmltv
            WebClient wc = new WebClient();
            string svtOneResponse = wc.DownloadString(UrlSvtOne);
            string svtTwoResponse = wc.DownloadString(UrlSvtTwo);
            string tvFourResponse = wc.DownloadString(UrlTvFour);
            var svtOneProgrammes = JsonConvert.DeserializeObject<Rootobject>(svtOneResponse);
            var svtTwoProgrames = JsonConvert.DeserializeObject<Rootobject>(svtTwoResponse);
            var tvFourProgrammes = JsonConvert.DeserializeObject<Rootobject>(tvFourResponse);

            //Print data to textbox and label*************

   /*SVT1*/rTbox_svt1.Text = svtOneProgrammes.ToString();
            lbl_svt1_date.Text = DateTime.Today.ToString("Den d MMMM");

   /*SVT2*/rTbox_svt2.Text = svtTwoProgrames.ToString();
            lbl_svt2_date.Text = DateTime.Today.ToString("Den d MMMM");

     /*TV4*/rTbox_tv4.Text = tvFourProgrammes.ToString();
            lbl_tv4_date.Text = DateTime.Today.ToString("Den d MMMM");

        }
        
        // SVT1 Buttons***************
        // SVT1 Prev
        private void btn_prev_Click(object sender, EventArgs e)
        {
            try
            {
                SvtOneCounter--;
                DateToday = DateTime.Today.AddDays(SvtOneCounter).ToString("yyyy-MM-dd");
                UrlSvtOne = "http://json.xmltv.se/svt1.svt.se_" + DateToday + ".js.gz";
                WebClient wc = new WebClient();

                string response = wc.DownloadString(UrlSvtOne);
                var programmes = JsonConvert.DeserializeObject<Rootobject>(response);

                rTbox_svt1.Text = programmes.ToString();
                lbl_svt1_date.Text = DateTime.Today.AddDays(SvtOneCounter).ToString("Den d MMMM");
            }
            catch (Exception exception)
            {
                MessageBox.Show(PrevMessage, exception.ToString());
                SvtOneCounter++;
            }
        }
        //SVT1 Next
        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                SvtOneCounter++;
                DateToday = DateTime.Today.AddDays(SvtOneCounter).ToString("yyyy-MM-dd");
                UrlSvtOne = "http://json.xmltv.se/svt1.svt.se_" + DateToday + ".js.gz";
                WebClient wc = new WebClient();

                string response = wc.DownloadString(UrlSvtOne);
                var programmes = JsonConvert.DeserializeObject<Rootobject>(response);

                rTbox_svt1.Text = programmes.ToString();
                lbl_svt1_date.Text = DateTime.Today.AddDays(SvtOneCounter).ToString("Den d MMMM");
            }
            catch (Exception exception)
            {
                MessageBox.Show(NextMessage, exception.ToString());
                SvtOneCounter--;
            }
        }
        //SVT2 *************
        //SVT2 Prev
        private void btn_svt2_prev_Click(object sender, EventArgs e)
        {
            try
            {
                SvtTwoCounter--;
                DateToday = DateTime.Today.AddDays(SvtTwoCounter).ToString("yyyy-MM-dd");
                UrlSvtTwo = "http://json.xmltv.se/svt2.svt.se_" + DateToday + ".js.gz";

                WebClient wc = new WebClient();
                string response = wc.DownloadString(UrlSvtTwo);
                var programmes = JsonConvert.DeserializeObject<Rootobject>(response);

                rTbox_svt2.Text = programmes.ToString();
                lbl_svt2_date.Text = DateTime.Today.AddDays(SvtTwoCounter).ToString("Den d MMMM");
            }
            catch (Exception exception)
            {
               MessageBox.Show(PrevMessage, exception.ToString());
                SvtTwoCounter++;
            }
        }
        //SVT2 Next
        private void btn_svt2_next_Click(object sender, EventArgs e)
        {
            try
            {
                SvtTwoCounter++;
                DateToday = DateTime.Today.AddDays(SvtTwoCounter).ToString("yyyy-MM-dd");
                UrlSvtTwo = "http://json.xmltv.se/svt2.svt.se_"+DateToday+".js.gz";

                WebClient wc = new WebClient();
                string response = wc.DownloadString(UrlSvtTwo);
                var programmes = JsonConvert.DeserializeObject<Rootobject>(response);

                rTbox_svt2.Text = programmes.ToString();
                lbl_svt2_date.Text = DateTime.Today.AddDays(SvtTwoCounter).ToString("Den d MMMM");
            }
            catch (Exception exception)
            {
                MessageBox.Show(NextMessage, exception.ToString());
                SvtTwoCounter--;
            }
        }

        //TV4 Buttons***************************
        //TV4 Prev
        private void btn_tv4_prev_Click(object sender, EventArgs e)
        {
            try
            {
                TvFourCounter--;
                DateToday = DateTime.Today.AddDays(TvFourCounter).ToString("yyyy-MM-dd");
                UrlTvFour = "http://json.xmltv.se/tv4.se_" + DateToday + ".js.gz";
                
                WebClient wc = new WebClient();
                string response = wc.DownloadString(UrlTvFour);
                var programmes = JsonConvert.DeserializeObject<Rootobject>(response);

                rTbox_tv4.Text = programmes.ToString();
                lbl_tv4_date.Text = DateTime.Today.AddDays(TvFourCounter).ToString("Den d MMMM");

            }
            catch (Exception exception)
            {
                MessageBox.Show(PrevMessage, exception.ToString());
                TvFourCounter++;
            }
        }
        //TV4 Next
        private void btn_tv4_next_Click(object sender, EventArgs e)
        {
            try
            {
                TvFourCounter++;
                DateToday = DateTime.Today.AddDays(TvFourCounter).ToString("yyyy-MM-dd");
                UrlTvFour = "http://json.xmltv.se/tv4.se_" + DateToday + ".js.gz";

                WebClient wc = new WebClient();
                string response = wc.DownloadString(UrlTvFour);
                var programmes = JsonConvert.DeserializeObject<Rootobject>(response);

                rTbox_tv4.Text = programmes.ToString();
                lbl_tv4_date.Text = DateTime.Today.AddDays(TvFourCounter).ToString("Den d MMMM");
            }
            catch (Exception exception)
            {
                MessageBox.Show(NextMessage, exception.ToString());
                TvFourCounter--;
            }
        }
    }
}
