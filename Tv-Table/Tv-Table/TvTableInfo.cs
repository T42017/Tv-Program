using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Tv_Table
{
    public class TvTableInfo
    {
        public static List<string> titleList = new List<string>();
        public static List<string> timeListStart = new List<string>();
        public static List<string> timeListStop = new List<string>();
        public static List<string> completeTableInformation = new List<string>();
        public static List<string> moreInfoAboutShow = new List<string>();

        public static void WriteTableInformation()
        {
            TimeSpan now = DateTime.Now.TimeOfDay;

            for (int i = 0; i < titleList.Count; i++)
            {
                completeTableInformation.Add("\n" + titleList[i] + " // " + timeListStart[i] + " - " + timeListStop[i]);
            }

            for (int i = 0; i < completeTableInformation.Count; i++)
            {
                if ((now >= TimeSpan.Parse(timeListStart[i])) && (now <= TimeSpan.Parse(timeListStop[i])))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(completeTableInformation[i] + "\n More info: \n");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(completeTableInformation[i] + "\n");
                }
            }

            completeTableInformation.Clear();
            titleList.Clear();
            timeListStart.Clear();
            timeListStop.Clear();
            moreInfoAboutShow.Clear();
        }
    }

}
