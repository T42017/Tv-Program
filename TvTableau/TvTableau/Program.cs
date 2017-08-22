using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TvTableau
{
    class Program
    {

        static void Main(string[] args)
        {
            WebClient wc = new WebClient();
            string showTvGuide = wc.DownloadString("http://json.xmltv.se/svt1.svt.se_2017-08-22.js.gz");
            var showTableau = JsonConvert.DeserializeObject<Rootobject>(showTvGuide);
            Console.WriteLine(showTableau);
            Console.ReadKey();
        }
    }
}
