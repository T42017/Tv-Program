using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvTable
{
    class Channel
    {
        public string Overview;
        public string Url;

        public Channel(string overview, string url)
        {
            if (overview == null) Overview = "Channel overview not found.";
            else Overview = overview;

            Url = url;
        }
    }
}
