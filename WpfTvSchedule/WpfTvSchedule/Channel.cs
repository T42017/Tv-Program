using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTvSchedule
{
    public class Channel
    {

        public string Name { get; set; }
        public string Website { get; set; }

        public Channel() { }

        public Channel(string name, string website)
        {
            this.Name = name;
            this.Website = website;
        }

    }
}
