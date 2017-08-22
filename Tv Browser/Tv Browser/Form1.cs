using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
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
            dayChooser.SelectedIndex = 10;

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

        public void LoadContent()
        {


            var url = "http://xmltv.xmltv.se/" + listBox1.SelectedItem + "_" + dayChooser.SelectedItem + ".xml.gz";
            XDocument tvList = XDocument.Load(url);
            var tempData = tvList.Descendants("tv");
            var title = tempData.Elements("programme").ElementAt(timeIndex).Element("title").Value;
            var description = tempData.Elements("programme").ElementAt(timeIndex).Element("desc").Value;
            var subTitle = tempData.Elements("programme").ElementAt(timeIndex).Element("sub-title").Value;
            var episodeNumber = tempData.Elements("programme").ElementAt(timeIndex).Elements("episode-num").ElementAt(1).Value;
            var airingTimeDataStart = tempData.Elements("programme").ElementAt(timeIndex).Attribute("start").Value;
            DateTime start = DateTimeOffset.ParseExact(airingTimeDataStart, "yyyyMMddHHmmss zzz", System.Globalization.CultureInfo.InvariantCulture).DateTime;
            var airingTimeDataStop = tempData.Elements("programme").ElementAt(timeIndex).Attribute("stop").Value;
            DateTime stop = DateTimeOffset.ParseExact(airingTimeDataStop, "yyyyMMddHHmmss zzz", System.Globalization.CultureInfo.InvariantCulture).DateTime;
            
            

            subTitleBox.Text = subTitle;
            descriptionTextBox.Text = description;
            episodeNumberBox.Text = episodeNumber;
            amountOfShows = tempData.Elements("programme").Count();
            titlebox.Text = title;
            airingTime.Text = start.TimeOfDay + " - " + stop.TimeOfDay;



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

        private void episodeNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void subTitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
