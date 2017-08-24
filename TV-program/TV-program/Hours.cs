using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Windows.Forms;

namespace TV_program
{
    public class Hours
    {
        public static void channelAdder(string whatWasSearched)
        {
            string xmlTable = "http://xmltv.xmltv.se";
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            HtmlWeb hw = new HtmlWeb();

            doc = hw.Load(xmlTable);
            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                string hrefValue = link.GetAttributeValue("href", string.Empty);
                if (hrefValue.ToLower().Contains(whatWasSearched))
                {
                    dwnlList.Add(hrefValue.Replace(".xml.gz", string.Empty));
                }
            }
            
            
        }
        public static List<string> dwnlList = new List<string>();
        public static void HtmlRetriever(string searchChannel, ListBox text)
        {
            dwnlList.Clear();
            switch (searchChannel)
            {
                case "Viasat motor":

                    channelAdder("motor.viasat.se");
                    break;
                case "Viasat Film action":
                    channelAdder("actionhd.film.viasat.se");
                    break;
                case "TV6":
                   channelAdder("tv6.se");
                    break;
                default:
                    Channels.standardScreen(text);
                    break;

            }
        }
        
    }

    
}
