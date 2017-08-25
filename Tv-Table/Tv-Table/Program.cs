using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using HtmlAgilityPack;

namespace Tv_Table
{
    class Program
    {
        static List<TvTableInfo> TtvTableInfos = new List<TvTableInfo>();

        private static int _channelChoice;
        private static bool _programIsRunning = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Starting program...");
            XmlHtml.urlCollector();

            do
            {
                tryAgain:
                Console.WriteLine("1. Svt1HD\n2. Svt2HD\n3. Kunskapskanalen\n4. Töm rutan\n5. Stäng programmet\n");

                try
                {
                    _channelChoice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\nERROR! Felinmatning; försök igen.\n");
                    goto tryAgain;
                }

                var usr = new ChannelHandler(_channelChoice);

                if (_channelChoice == 5)
                {
                    _programIsRunning = false;
                }
            } while (_programIsRunning);
        }
    }
}
