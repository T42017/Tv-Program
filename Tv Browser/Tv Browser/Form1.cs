using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tv_Browser
{
    public partial class Form1 : Form
    {
        public int timeIndex = 0;
        public int amountOfShows = 0;
        public Form1()
        {

            InitializeComponent();

            DateTime timeNow = DateTime.Today;

            var oldestDay = timeNow;
            oldestDay = oldestDay.AddDays(-9);
            var newestDay = timeNow;
            newestDay = newestDay.AddDays(19);

            while (oldestDay <= newestDay)
            {
                dayChooser.Items.Add(oldestDay.ToString("yyyy-MM-dd"));
                oldestDay = oldestDay.AddDays(1);
            }

            listBox1.SelectedIndex = 0;
            dayChooser.SelectedIndex = 9;

            StartTimer();
        }

        System.Windows.Forms.Timer time = null;
        private void StartTimer()
        {
            time = new System.Windows.Forms.Timer();
            time.Interval = 500;
            time.Tick += new EventHandler(t_Tick);
            time.Enabled = true;
        }

        void t_Tick(object sender, EventArgs e)
        {
            TimeSpan nextShow = GetNextShowTime();
            //var time = nextShow - DateTime.Now.TimeOfDay;
            string formattedTimespan = nextShow.ToString("hh\\:mm\\:ss");
            timer.Text = formattedTimespan;
        }

        private TimeSpan GetNextShowTime()
        {
            DateTime nextShowAiringTime = new DateTime(2020, 10, 1, 0, 0, 0);
            var nextShowTime = nextShowAiringTime.TimeOfDay;
            var timeNow =(DateTime.Now.ToString("yyyy-MM-dd"));

            if (RemoteFileExists("http://xmltv.xmltv.se/" + listBox1.SelectedItem + "_" + timeNow + ".xml.gz"))
            {
                XDocument tvList = XDocument.Load("http://xmltv.xmltv.se/" + listBox1.SelectedItem + "_" + timeNow + ".xml.gz");

                for (int i = 0; i < amountOfShows; i++)
                {
                    var tempData = tvList.Descendants("tv");
                    var airingTimeDataStart = tempData.Elements("programme").ElementAt(i).Attribute("start").Value;
                    DateTime start = DateTimeOffset.ParseExact(airingTimeDataStart, "yyyyMMddHHmmss zzz", System.Globalization.CultureInfo.InvariantCulture).DateTime;
                    var timeToday = DateTime.Now;

                    if ((start - timeToday) > nextShowTime)
                    {
                        if (i != 0)
                        {
                            var titleCurrentShow = tempData.Elements("programme").ElementAt(i - 1).Element("title").Value;
                            currentlyOnAirLink.Text = titleCurrentShow;
                        }
                        var titleNextShow = tempData.Elements("programme").ElementAt(i).Element("title").Value;
                        nextOnAirLink.Text = titleNextShow;
                        nextShowTime = (start - timeToday);
                        return nextShowTime;
                    }
                }
            }
            return nextShowTime;
        }

        private void tvChannelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var temp = listBox1.SelectedItem;
            if (dayChooser.SelectedItem != null)
            {
                LoadContent();
            }
        }

        private void dayChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            var temp = dayChooser.SelectedItem;

            LoadContent();

        }

        private void titlebox_TextChanged(object sender, EventArgs e)
        {

        }

        private bool RemoteFileExists(string url)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.Method = "HEAD";
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                response.Close();
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch
            {
                return false;
            }
        }

        public void LoadContent()
        {
            var url = "http://xmltv.xmltv.se/" + listBox1.SelectedItem + "_" + dayChooser.SelectedItem + ".xml.gz";

            if (RemoteFileExists(url))
            {
                XDocument tvList = XDocument.Load(url);
                var tempData = tvList.Descendants("tv");
                var title = tempData.Elements("programme").ElementAt(timeIndex).Element("title").Value;
                if (timeIndex != 0)
                {
                    if (timeIndex < amountOfShows - 1)
                    {
                        var title2 = tempData.Elements("programme").ElementAt(timeIndex + 1).Element("title").Value;
                    }  
                    else
                    {
                        var title2 = tempData.Elements("programme").ElementAt(0).Element("title").Value;
                    }
                    
                }
                var description = tempData.Elements("programme").ElementAt(timeIndex).Element("desc").Value;
                if (tempData.Elements("programme").ElementAt(timeIndex).Element("sub-title") != null)
                {
                    var subTitle = tempData.Elements("programme").ElementAt(timeIndex).Element("sub-title").Value;
                    subTitleLabel.Text = subTitle;
                }
                else
                {
                    subTitleLabel.Text = " ";
                }
                var episodeNumber = tempData.Elements("programme").ElementAt(timeIndex).Elements("episode-num")
                    .ElementAt(1).Value;
                var airingTimeDataStart = tempData.Elements("programme").ElementAt(timeIndex).Attribute("start").Value;
                DateTime start = DateTimeOffset.ParseExact(airingTimeDataStart, "yyyyMMddHHmmss zzz", System.Globalization.CultureInfo.InvariantCulture).DateTime;
                var airingTimeDataStop = tempData.Elements("programme").ElementAt(timeIndex).Attribute("stop").Value;
                DateTime stop = DateTimeOffset.ParseExact(airingTimeDataStop, "yyyyMMddHHmmss zzz", System.Globalization.CultureInfo.InvariantCulture).DateTime;

                descriptionTextBox.Text = description;
                episodeNumberLabel.Text = episodeNumber;
                amountOfShows = tempData.Elements("programme").Count();
                titleLabel.Text = title;
                airingTime.Text = start.TimeOfDay + " - " + stop.TimeOfDay;
            }
            else
            {
                string Error = "No Info Exists, Sorry!";
                descriptionTextBox.Text = " ";
                episodeNumberLabel.Text = "Episode 0 season 0";
                titleLabel.Text = Error;
                airingTime.Text = " ";
                subTitleLabel.Text = " ";
            }
        }

        private void airingTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void nextTime_Click(object sender, EventArgs e)
        {
            if (timeIndex < amountOfShows - 1)
            {
                timeIndex++;
            }
            else
            {
                timeIndex = 0;
            }

            LoadContent();
        }

        private void previousTime_Click(object sender, EventArgs e)
        {
            if (timeIndex != 0)
            {
                timeIndex--;
            }
            else
            {
                timeIndex = amountOfShows - 1;
            }
            LoadContent();
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void currentlyOnAirLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
