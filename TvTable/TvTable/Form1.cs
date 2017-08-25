﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using HtmlAgilityPack;

namespace TvTable
{
    public partial class Form1 : Form
    {
        static string currentDay = DateTime.Today.ToString("dd");
        static string currentMonth = DateTime.Today.ToString("MM");
        static string currentYear = DateTime.Today.ToString("yy");
        static string currentDate = currentYear + "-" + currentMonth + "-" + currentDay;



        public Form1()
        {
            InitializeComponent();
        }



        static void HtmlRetriever()
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            HtmlWeb hw = new HtmlWeb();

            string urlToTvTables = "http://xmltv.xmltv.se/";

            doc = hw.Load(urlToTvTables);

            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                string hrefValue = link.GetAttributeValue("href", string.Empty);
                _urlList.Add(hrefValue);
            }
        }



        static List<string> _urlList = new List<string>();
        static List<string> _wantedUrlList = new List<string>();
        static List<string> _requestedUrlList = new List<string>();

        List<Channel> _channels = new List<Channel>();
        List<ProgramInfo> _programInfos = new List<ProgramInfo>();



        private void Form1_Load(object sender, EventArgs e)
        {
            HtmlRetriever();

            foreach (var url in _urlList)
            {
                if (url.Contains(".se"))
                {
                    _wantedUrlList.Add(url);
                }
            }
        }



        private void SearchBtn_Click(object sender, EventArgs e)
        {
            currentDay = DateTime.Today.ToString("dd");
            currentMonth = DateTime.Today.ToString("MM");
            currentYear = DateTime.Today.ToString("yy");
            currentDate = currentYear + "-" + currentMonth + "-" + currentDay;

            _requestedUrlList.Clear();
            ProgramList.Items.Clear();
            ChannelList.Items.Clear();

            foreach (var url in _wantedUrlList)
            {                
                if (url.Contains(channelTbx.Text) && url.Contains(currentDate))
                {                   
                    _requestedUrlList.Add(url);
                }                
            }

            _channels.Clear();
            foreach (string url in _requestedUrlList)
            {
                var tempUrl = "http://xmltv.xmltv.se/" + url;
                string channelOverview = url.Replace(".xml.gz", string.Empty);
                channelOverview = channelOverview.Replace("_", " ---- ");

                _channels.Add(new Channel(channelOverview, tempUrl));
            }

            foreach (Channel channel in _channels)
            {
                ChannelList.Items.Add(channel.Overview);
            }

            if (ChannelList.Items.Count == 0)
            {
                MessageBox.Show("Tyvärr, inga kanaler funna...");
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            currentDay = (int.Parse(currentDay) - 1).ToString();
            currentDate = currentYear + "-" + currentMonth + "-" + currentDay;

            _requestedUrlList.Clear();
            ProgramList.Items.Clear();
            ChannelList.Items.Clear();

            foreach (var url in _wantedUrlList)
            {
                if (url.Contains(channelTbx.Text) && url.Contains(currentDate))
                {
                    _requestedUrlList.Add(url);
                }
            }

            _channels.Clear();
            foreach (string url in _requestedUrlList)
            {
                var tempUrl = "http://xmltv.xmltv.se/" + url;
                string channelOverview = url.Replace(".xml.gz", string.Empty);
                channelOverview = channelOverview.Replace("_", " ---- ");

                _channels.Add(new Channel(channelOverview, tempUrl));
            }

            foreach (Channel channel in _channels)
            {
                ChannelList.Items.Add(channel.Overview);
            }

            if (ChannelList.Items.Count == 0)
            {
                MessageBox.Show("Tyvärr, inga kanaler funna...");
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            currentDay = (int.Parse(currentDay) + 1).ToString();
            currentDate = currentYear + "-" + currentMonth + "-" + currentDay;

            _requestedUrlList.Clear();
            ChannelList.Items.Clear();
            ProgramList.Items.Clear();

            foreach (var url in _wantedUrlList)
            {
                if (url.Contains(channelTbx.Text) && url.Contains(currentDate))
                {
                    _requestedUrlList.Add(url);
                }
            }

            _channels.Clear();
            foreach (string url in _requestedUrlList)
            {
                var tempUrl = "http://xmltv.xmltv.se/" + url;
                string channelOverview = url.Replace(".xml.gz", string.Empty);
                channelOverview = channelOverview.Replace("_", " ---- ");

                _channels.Add(new Channel(channelOverview, tempUrl));
            }

            foreach (Channel channel in _channels)
            {
                ChannelList.Items.Add(channel.Overview);
            }
            if (ChannelList.Items.Count == 0)
            {
                MessageBox.Show("Tyvärr, inga kanaler funna...");
            }
        }



        private void ChannelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgramList.Items.Clear();
            _programInfos.Clear();

            List<string> titleList = new List<string>();
            List<string> programStartList = new List<string>();
            List<bool> isRunningList = new List<bool>();

            List<Details> detailList = new List<Details>();

            List<SubList> descriptionList = new List<SubList>();
            List<string> descriptions = new List<string>(); 
            
            List<SubList> actorList = new List<SubList>();
            List<string> actors = new List<string>();

            List<SubList> categoryList = new List<SubList>();
            List<string> categories = new List<string>();

            var reader = new XmlTextReader(_channels[ChannelList.SelectedIndex].Url);

            while (reader.Read())
            {
                
                if (reader.NodeType == XmlNodeType.EndElement)
                {
                    if (reader.Name == "programme")
                    {
                        actorList.Add(new SubList(actors));

                        categoryList.Add(new SubList(categories));

                        descriptionList.Add(new SubList(descriptions));
                        actors = new List<string>();
                        categories = new List<string>();
                        descriptions = new List<string>();
                    }
                }

                if (reader.NodeType == XmlNodeType.Element)
                {
                    
                    if (reader.Name == "title")
                    {
                        titleList.Add(reader.ReadInnerXml());                       
                    }

                    if (reader.Name == "programme")
                    {
                        

                        string tmpStart = reader.GetAttribute("start");
                        string tmpStop = reader.GetAttribute("stop");

                        tmpStart = tmpStart.Substring(8, 2) + ":" + tmpStart.Substring(10, 2);
                        tmpStop = tmpStop.Substring(8, 2) + ":" + tmpStop.Substring(10, 2);
                        DateTime compareStart = new DateTime(2017, 01, 01, int.Parse(tmpStart.Substring(0,2)), int.Parse(tmpStart.Substring(3,2)), 0);
                        DateTime compareStop = new DateTime(2017, 01, 01, int.Parse(tmpStop.Substring(0,2)), int.Parse(tmpStop.Substring(3,2)), 0);
                        DateTime compareNow = new DateTime(2017, 01,01,DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

                        if(compareNow <= compareStop && compareNow >= compareStart) isRunningList.Add(true);
                        else isRunningList.Add(false);

                        string tmpTime = tmpStart + " - " + tmpStop;
                        programStartList.Add(tmpTime);


                    }

                    if (reader.Name == "desc")
                    {
                        descriptions.Add(reader.ReadInnerXml());
                    }
                    if (reader.Name == "actor")
                    {
                        actors.Add(reader.ReadInnerXml());
                    }
                    if (reader.Name == "category")
                    {
                        categories.Add(reader.ReadInnerXml());
                    }
                   

                }
                
                
                

            }

            for (int i = 0; i < descriptionList.Count; i++)
            {
                detailList.Add(new Details(descriptionList[i].List, actorList[i].List, categoryList[i].List));
            }

            for (int i = 0; i < titleList.Count; i++)
            {
                _programInfos.Add(new ProgramInfo(titleList[i], programStartList[i], isRunningList[i], _channels[ChannelList.SelectedIndex].Url, detailList[i]));
            }

            foreach (ProgramInfo programInfo in _programInfos)
            {
                if (programInfo.IsRunning)
                {
                    programInfo.Info += "   Is running now!";
                }
                ProgramList.Items.Add(programInfo.Info);
            }
        }

        private void ProgramList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetailsTbx.Text = String.Empty;
            
            DetailsTbx.Text = _programInfos[ProgramList.SelectedIndex].WriteDetails();
        }

       
    }
}
