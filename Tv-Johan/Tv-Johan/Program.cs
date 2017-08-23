using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Tv_Johan
{
    class Program
    {
        static void Main(string[] args)
        {

            String detarlunch,hour,minutes;
            int hour1, minutes1,Totalshows,minutes2;

            hour = DateTime.Now.TimeOfDay.Hours.ToString();
            minutes = DateTime.Now.TimeOfDay.Minutes.ToString();

            hour1 = int.Parse(hour);
            minutes1 = int.Parse(minutes);

            minutes2 = (hour1 * 60) + minutes1;
            

            List<String> Titles = new List<string>();
            List<String> Time = new List<string>();
            List<String> Ending = new List<string>();
            List<String> Starting = new List<string>();
            List<int> Startinghour = new List<int>();
            List<int> Startingmin = new List<int>();
            List<int> Endinghour = new List<int>();
            List<int> Endingmin = new List<int>();
            List<int> Startingtime = new List<int>();
            List<int> Endingtime = new List<int>();

            Totalshows = 0;

            XmlDocument TvSchedule = new XmlDocument();
            TvSchedule.Load("http://xmltv.xmltv.se/action.cmore.dk_2017-09-03.xml.gz");



            XmlNodeList elemList = TvSchedule.GetElementsByTagName("title");
            
            
            for (int i = 0; i < elemList.Count; i++)
            {
                
                Titles.Add(elemList[i].InnerXml);
               
                Totalshows++;
                
            }
            elemList = TvSchedule.GetElementsByTagName("programme");

            for (int i = 0; i < elemList.Count; i++)
            {

                Time.Add(elemList[i].OuterXml);
                Time[i] = Time[i].Substring(11, 49);

                Starting.Add(Time[i]);
                Starting[i] = Starting[i].Substring(15,2)+":"+Starting[i].Substring(18,2);
                Startinghour.Add(int.Parse(Starting[i].Substring(0, 2)));
                Startingmin.Add(int.Parse(Starting[i].Substring(3, 2)));
                Startingtime.Add((Startinghour[i] * 60) + Startingmin[i]);


                Ending.Add(Time[i]);
                Ending[i] = Ending[i].Substring(43, 2)+":"+ Ending[i].Substring(45, 2);
                Endinghour.Add(int.Parse(Ending[i].Substring(0, 2)));
                Endingmin.Add(int.Parse(Ending[i].Substring(3, 2)));
                Endingtime.Add((Endinghour[i] * 60) + Endingmin[i]);

            }

            /*foreach ( in TvSchedule)
            {  
                Titles.Add(elements.ToString());
                i++;

            }
            
            foreach (XmlElement elements1 in TvSchedule.GetElementsByTagName(""))
            {
                Time.Add(elements1.ToString());
            }*/



            detarlunch = TvSchedule.ToString();





            /*WebClient wc = new WebClient();

            MemoryStream stream = new MemoryStream(wc.DownloadData("http://xmltv.xmltv.se/action.cmore.dk_2017-09-03.xml.gz"));
            GZipStream uncompressed = new GZipStream(stream, CompressionMode.Decompress);
            MemoryStream output = new MemoryStream();
            uncompressed.CopyTo(output);

            var data = output.ToArray();
            var s = System.Text.Encoding.UTF8.GetString(data);

            detarlunch = data.ToString();*/

            /*Console.WriteLine("Klockan är : "+detarlunch+"\nProgrammet som visas nu på Cmore Action är : "+"\nNästa program är : ");*/
            /*Console.WriteLine("Klockan  är " + hour + ":" + minutes + ":" + seconds + "\n";*/

            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
