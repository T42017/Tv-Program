using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace TV_program
{
    public class Hours
    {
        public static List<string> dwnlList = new List<string>();
        public static void HtmlRetriever()
        {

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            HtmlWeb hw = new HtmlWeb();

            string xmlTable = "http://xmltv.xmltv.se/";

            doc = hw.Load(xmlTable);

            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                string hrefValue = link.GetAttributeValue("href", string.Empty);
                dwnlList.Add("http://xmltv.xmltv.se/" + hrefValue);
            }
        }
    }
}
