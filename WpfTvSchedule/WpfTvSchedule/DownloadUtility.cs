﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WpfTvSchedule;

namespace WpfTvSchedule
{
    class DownloadUtility
    {

        public static string DownloadSiteAsstring(string url)
        {
            string xmlStr;
            using (var wc = new WebClient())
            {
                xmlStr = wc.DownloadString(url);
            }
            return xmlStr;
        }

        public static List<TvProgram> DownloadTvPrograms(Channel channel, DateTime date)
        {
            string url = Utility.CreateUrlFromChannelAndDate(channel, date);
            string xml = DownloadSiteAsstring(url);

            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);

            List<TvProgram> programs = new List<TvProgram>();

            XmlNodeList programmeTagList = xmlDoc.GetElementsByTagName("programme");
            foreach (XmlNode programmeNode in programmeTagList)
            {
                DateTime startDateAndTime = 
                    Utility.GetDateTimeFromString(programmeNode.Attributes.Item(0).Value);
                DateTime stopDateAndTime = 
                    Utility.GetDateTimeFromString(programmeNode.Attributes.Item(1).Value);
                
                string title = "";

                XmlNodeList tags = programmeNode.ChildNodes;
                for (int i = 0; i < tags.Count; i++)
                {
                    XmlNode tagNode = tags[i];
                    switch (tagNode.Name)
                    {
                        case "title":
                            title = tagNode.InnerText;
                            break;
                    }
                }

                title = Utility.ConvertToEncodingUtf8(title);

                programs.Add(new TvProgram(startDateAndTime, stopDateAndTime, title));
            }

            return programs;
        }

    }
}
