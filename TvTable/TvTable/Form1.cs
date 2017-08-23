using System;
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

        public Form1()
        {
            InitializeComponent();
        }

        static void htmlRetriever()
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            HtmlWeb hw = new HtmlWeb();

            string urlToTvTables = "http://xmltv.xmltv.se/";

            doc = hw.Load(urlToTvTables);

            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                string hrefValue = link.GetAttributeValue("href", string.Empty);
                urlList.Add(hrefValue);
            }
        }

        static List<string> urlList = new List<string>();
        static List<string> wantedUrlList = new List<string>();
        static List<string> requestedUrlList = new List<string>();

        List<ProgramInfo> _programInfos = new List<ProgramInfo>(); 
        List<Channel> _channels = new List<Channel>();

        private string date;
        List<string> titleList = new List<string>();
        List<string> timeList = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            htmlRetriever();

            foreach (var url in urlList)
            {
                if (url.Contains(".se"))
                {
                    wantedUrlList.Add(url);
                }
            }         
 
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            requestedUrlList.Clear();
            InfoList.Items.Clear();
            
            foreach (var url in wantedUrlList)
            {
                if (url.Contains(channelTbx.Text))
                {
                    requestedUrlList.Add(url);
                }
            }
            titleList.Clear();
            timeList.Clear();           

            foreach (string url in requestedUrlList)
            {
                var tempUrl = "http://xmltv.xmltv.se/" + url;
                var reader = new XmlTextReader(tempUrl);
                string channelName = "";
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {

                        case XmlNodeType.Element:
                            if (reader.Name == "title")
                            {
                                titleList.Add(reader.ReadInnerXml());
                            }
                          
                            if (reader.Name == "programme")
                            {
                                string tmpStart = reader.GetAttribute("start");
                                string tmpStop = reader.GetAttribute("stop");
                                date = tmpStart.Substring(4, 2) + "/" + tmpStart.Substring(6, 2);
                                timeList.Add(tmpStart.Substring(8, 2) + ":" + tmpStart.Substring(10, 2) + " - " + tmpStop.Substring(8, 2) + ":" + tmpStop.Substring(10, 2));                               
                                channelName = reader.GetAttribute("channel");
                            }
                            break;
                    }

                }

                for (int i = 0; i < titleList.Count; i++)
                {
                    _programInfos.Add(new ProgramInfo(titleList[i], timeList[i], channelName));
                }
                
                
                string overwiew = channelName + " - " + date;
                _channels.Add(new Channel(overwiew, _programInfos));
                               
            }

            foreach (Channel channel in _channels)
            {
                InfoList.Items.Add(channel.Overview);
            }
        }

        private void InfoList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
