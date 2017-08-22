using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tv_Browser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           /* XDocument tvList = XDocument.Load("http://xmltv.xmltv.se/travelchanneltv.se_2017-08-25.xml.gz");


            var tempData = tvList.Descendants("tv");
            //var programmeDetails = tempData.Elements("programme").Attributes();

            //tempData.Elements("programme").First().Attribute("start")
            //Console.WriteLine(programmeDetails.First().Value);

            foreach (var programme in tempData.Elements("programme"))
            {
                Console.WriteLine("Title: " + programme.Element("title").Value);
                var startText = programme.Attribute("start").Value;
                DateTime start = DateTimeOffset.ParseExact(startText, "yyyyMMddHHmmss zzz", System.Globalization.CultureInfo.InvariantCulture).DateTime;
                var stopText = programme.Attribute("stop").Value;
                DateTime stop = DateTimeOffset.ParseExact(stopText, "yyyyMMddHHmmss zzz", System.Globalization.CultureInfo.InvariantCulture).DateTime;
                Console.WriteLine(start.TimeOfDay + " - " + stop.TimeOfDay);
                Console.WriteLine("Description: " + programme.Element("desc").Value);

                //Console.WriteLine(programme.Attribute("start").Value + " - " + programme.Attribute("stop").Value);
                Console.ReadKey();
            }*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
