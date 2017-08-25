using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Tv_Table
{
    public class ChannelHandler
    {
        public static List<string> desiredTvTables = new List<string>();

        string date = DateTime.Now.ToString("yyyy-MM-dd");
        private string todaysTable;

        public ChannelHandler(int i)
        {
            switch (i)
            {
                case 1:
                    TvTableSelector("svt1hd");

                    todaysTable = desiredTvTables.FirstOrDefault(t => t.Contains(date));

                    XmlHtml.XmlReader(todaysTable);

                    TvTableInfo.WriteTableInformation();
                    break;

                case 2:
                    TvTableSelector("svt2hd");

                    todaysTable = desiredTvTables.FirstOrDefault(t => t.Contains(date));

                    XmlHtml.XmlReader(todaysTable);

                    TvTableInfo.WriteTableInformation();
                    break;

                case 3:
                    TvTableSelector("kunskapskanalen");

                    todaysTable = desiredTvTables.FirstOrDefault(t => t.Contains(date));

                    XmlHtml.XmlReader(todaysTable);

                    TvTableInfo.WriteTableInformation();
                    break;

                case 4:
                    Console.Clear();
                    break;

                case 5:
                    break;

                default:
                    Console.WriteLine("ERROR! Invalid input; please try again.");
                    break;
            }
        }

        public static void TvTableSelector(string i)
        {
            desiredTvTables.Clear();

            foreach (var s in XmlHtml.urlList)
            {
                if (s.Contains(i))
                {
                    desiredTvTables.Add(s);
                }
            }
        }
    }
}
