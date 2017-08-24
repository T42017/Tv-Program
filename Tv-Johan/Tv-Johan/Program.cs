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

            String Playing, hour, minutes;
            int hour1, minutes1, Totalshows, minutes2, day;
            day = 03;
            var adress1 = "http://xmltv.xmltv.se/action.cmore.dk_2017-09-0" + day.ToString() + ".xml.gz";

            hour = DateTime.Now.TimeOfDay.Hours.ToString();
            minutes = DateTime.Now.TimeOfDay.Minutes.ToString();

            hour1 = int.Parse(hour);
            minutes1 = int.Parse(minutes);

            minutes2 = (hour1 * 60) + minutes1;


            List<String> Titles = new List<string>();
            List<String> Time = new List<string>();
            List<String> Ending = new List<string>();
            List<String> Starting = new List<string>();
            List<String> desc = new List<string>();
            List<int> Startinghour = new List<int>();
            List<int> Startingmin = new List<int>();
            List<int> Endinghour = new List<int>();
            List<int> Endingmin = new List<int>();
            List<int> Startingtime = new List<int>();
            List<int> Endingtime = new List<int>();

            Totalshows = 0;

            XmlDocument TvSchedule = new XmlDocument();

            TvSchedule.Load(adress1);

            Playing = "";

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
                Starting[i] = Starting[i].Substring(15, 2) + ":" + Starting[i].Substring(17, 2);
                Startinghour.Add(int.Parse(Starting[i].Substring(0, 2)));
                Startingmin.Add(int.Parse(Starting[i].Substring(3, 2)));
                Startingtime.Add((Startinghour[i] * 60) + Startingmin[i]);


                Ending.Add(Time[i]);
                Ending[i] = Ending[i].Substring(43, 2) + ":" + Ending[i].Substring(45, 2);
                Endinghour.Add(int.Parse(Ending[i].Substring(0, 2)));
                Endingmin.Add(int.Parse(Ending[i].Substring(3, 2)));
                Endingtime.Add((Endinghour[i] * 60) + Endingmin[i]);

            }

            elemList = TvSchedule.GetElementsByTagName("desc");
            for (int i = 0; i < elemList.Count; i++)
            {

                desc.Add(elemList[i].InnerXml);



            }

            for (int i = 0; i < Totalshows; i++)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Titles[i] + " Börjar " + Starting[i] + " Slutar " + Ending[i]);


                if (minutes2 > Startingtime[i] && minutes2 < Endingtime[i])
                {

                    Playing = "\nDet som spelas nu är : " + Titles[i] + "\n" + desc[i];

                }
                else if (i == Totalshows)
                {

                    Playing = "Nothing is playing right now";

                }
                else
                {

                }

            }


            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Playing);


            Console.ReadKey();
            Console.WriteLine("Press the left arrow to see yesterdays tv." +
                " Press the Right arrow to see tomorrows tv.\nPress the up and down arrows to change channel");
            while (true) { 
            ConsoleKeyInfo keypress;
            keypress = Console.ReadKey();
            if (keypress.Key == ConsoleKey.LeftArrow)
            {
                {
                    Totalshows = 0;
                    Time.Clear(); Titles.Clear(); Ending.Clear(); Starting.Clear(); Ending.Clear();
                    Startinghour.Clear(); Startingmin.Clear(); Startingtime.Clear(); Endinghour.Clear(); Endingmin.Clear(); Endingtime.Clear();
                    Console.Clear();
                    day = day - 1;
                        if (day < 0)
                        {
                            day = 30;
                        }
                        if (day >= 10)
                        {
                        adress1 = "http://xmltv.xmltv.se/action.cmore.dk_2017-09-" + day.ToString() + ".xml.gz";
                        }
                        else
                        {
                        adress1 = "http://xmltv.xmltv.se/action.cmore.dk_2017-09-0" + day.ToString() + ".xml.gz";
                        }

                    
                    TvSchedule.Load(adress1);
                    elemList = TvSchedule.GetElementsByTagName("title");


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
                        Starting[i] = Starting[i].Substring(15, 2) + ":" + Starting[i].Substring(17, 2);
                        Startinghour.Add(int.Parse(Starting[i].Substring(0, 2)));
                        Startingmin.Add(int.Parse(Starting[i].Substring(3, 2)));
                        Startingtime.Add((Startinghour[i] * 60) + Startingmin[i]);


                        Ending.Add(Time[i]);
                        Ending[i] = Ending[i].Substring(43, 2) + ":" + Ending[i].Substring(45, 2);
                        Endinghour.Add(int.Parse(Ending[i].Substring(0, 2)));
                        Endingmin.Add(int.Parse(Ending[i].Substring(3, 2)));
                        Endingtime.Add((Endinghour[i] * 60) + Endingmin[i]);

                    }
                    for (int i = 0; i < Totalshows; i++)
                    {

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Titles[i] + " Börjar " + Starting[i] + " Slutar " + Ending[i]);


                    }
                }
            }
            else if (keypress.Key == ConsoleKey.RightArrow)
            {
                Totalshows = 0;
                Time.Clear(); Titles.Clear(); Ending.Clear(); Starting.Clear(); Ending.Clear();
                Startinghour.Clear(); Startingmin.Clear(); Startingtime.Clear(); Endinghour.Clear(); Endingmin.Clear(); Endingtime.Clear();
                Console.Clear();
                day = day + 1;
                    if (day >= 10)
                    {
                     adress1 = "http://xmltv.xmltv.se/action.cmore.dk_2017-09-" + day.ToString() + ".xml.gz";
                    }
                    else
                    {
                        adress1 = "http://xmltv.xmltv.se/action.cmore.dk_2017-09-0" + day.ToString() + ".xml.gz";
                    }

                    if (day > 30)
                    {
                        day = 1;
                    }
                    else
                    {

                    }

                TvSchedule.Load(adress1);
                elemList = TvSchedule.GetElementsByTagName("title");


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
                    Starting[i] = Starting[i].Substring(15, 2) + ":" + Starting[i].Substring(17, 2);
                    Startinghour.Add(int.Parse(Starting[i].Substring(0, 2)));
                    Startingmin.Add(int.Parse(Starting[i].Substring(3, 2)));
                    Startingtime.Add((Startinghour[i] * 60) + Startingmin[i]);


                    Ending.Add(Time[i]);
                    Ending[i] = Ending[i].Substring(43, 2) + ":" + Ending[i].Substring(45, 2);
                    Endinghour.Add(int.Parse(Ending[i].Substring(0, 2)));
                    Endingmin.Add(int.Parse(Ending[i].Substring(3, 2)));
                    Endingtime.Add((Endinghour[i] * 60) + Endingmin[i]);

                }
                for (int i = 0; i < Totalshows; i++)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Titles[i] + " Börjar " + Starting[i] + " Slutar " + Ending[i]);


                }
            }
                   else if (keypress.Key == ConsoleKey.DownArrow)
                    {
                    Totalshows = 0;
                    Time.Clear(); Titles.Clear(); Ending.Clear(); Starting.Clear(); Ending.Clear();
                    Startinghour.Clear(); Startingmin.Clear(); Startingtime.Clear(); Endinghour.Clear(); Endingmin.Clear(); Endingtime.Clear();
                    Console.Clear();
                    adress1 = "http://xmltv.xmltv.se/cartoonnetwork.se_2017-09-0" + day.ToString() + ".xml.gz";

                    TvSchedule.Load(adress1);
                    elemList = TvSchedule.GetElementsByTagName("title");


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
                        Starting[i] = Starting[i].Substring(15, 2) + ":" + Starting[i].Substring(17, 2);
                        Startinghour.Add(int.Parse(Starting[i].Substring(0, 2)));
                        Startingmin.Add(int.Parse(Starting[i].Substring(3, 2)));
                        Startingtime.Add((Startinghour[i] * 60) + Startingmin[i]);


                        Ending.Add(Time[i]);
                        Ending[i] = Ending[i].Substring(43, 2) + ":" + Ending[i].Substring(45, 2);
                        Endinghour.Add(int.Parse(Ending[i].Substring(0, 2)));
                        Endingmin.Add(int.Parse(Ending[i].Substring(3, 2)));
                        Endingtime.Add((Endinghour[i] * 60) + Endingmin[i]);

                    }
                    for (int i = 0; i < Totalshows; i++)
                    {

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Titles[i] + " Börjar " + Starting[i] + " Slutar " + Ending[i]);


                    }

                }

                   else if (keypress.Key == ConsoleKey.UpArrow)
                    {
                    Totalshows = 0;
                    Time.Clear(); Titles.Clear(); Ending.Clear(); Starting.Clear(); Ending.Clear();
                    Startinghour.Clear(); Startingmin.Clear(); Startingtime.Clear(); Endinghour.Clear(); Endingmin.Clear(); Endingtime.Clear();
                    Console.Clear();
                    adress1 = "http://xmltv.xmltv.se/aljazeera.net_2017-09-0" + day.ToString() + ".xml.gz";
                    TvSchedule.Load(adress1);
                    elemList = TvSchedule.GetElementsByTagName("title");


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
                        Starting[i] = Starting[i].Substring(15, 2) + ":" + Starting[i].Substring(17, 2);
                        Startinghour.Add(int.Parse(Starting[i].Substring(0, 2)));
                        Startingmin.Add(int.Parse(Starting[i].Substring(3, 2)));
                        Startingtime.Add((Startinghour[i] * 60) + Startingmin[i]);


                        Ending.Add(Time[i]);
                        Ending[i] = Ending[i].Substring(43, 2) + ":" + Ending[i].Substring(45, 2);
                        Endinghour.Add(int.Parse(Ending[i].Substring(0, 2)));
                        Endingmin.Add(int.Parse(Ending[i].Substring(3, 2)));
                        Endingtime.Add((Endinghour[i] * 60) + Endingmin[i]);

                    }
                    for (int i = 0; i < Totalshows; i++)
                    {

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Titles[i] + " Börjar " + Starting[i] + " Slutar " + Ending[i]);


                    }
                }

                    Console.ReadKey();
                  }
                }
            }
        }
    

