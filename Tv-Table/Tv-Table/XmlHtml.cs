using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Xml;
using System.Xml.Linq;

namespace Tv_Table
{
    public class XmlHtml
    {
        public static List<string> urlList = new List<string>();

        public static string moreInfo = "";

        public static void urlCollector()
        {
            HtmlDocument doc = new HtmlDocument();
            HtmlWeb hw = new HtmlWeb();

            string urlToTvTables = "http://xmltv.xmltv.se/";

            doc = hw.Load(urlToTvTables);

            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                string hrefValue = link.GetAttributeValue("href", string.Empty);
                urlList.Add("http://xmltv.xmltv.se/" + hrefValue);
            }
        }

        public static void XmlReader(string i)
        {
            XmlTextReader xmlTxtReader = new XmlTextReader(i);
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(i);
            
            while (xmlTxtReader.Read())
            {
                if (xmlTxtReader.NodeType == XmlNodeType.Element)
                {
                    if (xmlTxtReader.Name == "title")
                    {
                        TvTableInfo.titleList.Add(xmlTxtReader.ReadInnerXml());
                    }
                    else if (xmlTxtReader.Name == "programme")
                    {
                        DateTime start =
                            DateTimeOffset.ParseExact(xmlTxtReader.GetAttribute("start"), "yyyyMMddHHmmss zzz",
                                System.Globalization.CultureInfo.InvariantCulture).DateTime;

                        TvTableInfo.timeListStart.Add(start.TimeOfDay.ToString());

                        DateTime stop =
                            DateTimeOffset.ParseExact(xmlTxtReader.GetAttribute("stop"), "yyyyMMddHHmmss zzz",
                                System.Globalization.CultureInfo.InvariantCulture).DateTime;

                        TvTableInfo.timeListStop.Add(stop.TimeOfDay.ToString());
                    }
                }
            }
        }
    }
}
