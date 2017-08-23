using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using HtmlAgilityPack;

namespace Tv_Table
{
    class Program
    {
        static public List<string> urlList = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Starting program...");

            /*
            XmlDocument Table1 = new XmlDataDocument();
            
            XmlTextReader reader = new XmlTextReader("http://xmltv.xmltv.se/tlcsverige.se_2017-09-02.xml.gz");

            Table1.Load(reader);

            XmlNodeList TitlesList;
            XmlNodeList EpisodesList;
            TitlesList = Table1.GetElementsByTagName("title");
            EpisodesList = Table1.GetElementsByTagName("sub-title");

            foreach (XmlNode xmlNode in TitlesList)
            {
                Console.WriteLine(xmlNode.InnerText + "\n");
            }
            foreach (XmlNode xmlNode in EpisodesList)
            {
                Console.WriteLine(xmlNode.InnerText + "\n");
            }
            */

            Console.ReadLine();

            htmlRetriever();

            for (int i = 0; i < urlList.Count; i++)
            {
                Console.WriteLine(urlList[i]);
            }

            Console.ReadLine();
        }

        static void htmlRetriever()
        {
            HtmlDocument doc = new HtmlDocument();
            HtmlWeb hw = new HtmlWeb();

            string urlToTvTables = "http://xmltv.xmltv.se/";

            doc = hw.Load(urlToTvTables);

            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                string hrefValue = link.GetAttributeValue("href", string.Empty);
                urlList.Add(hrefValue);
            }
        }
    }
}
