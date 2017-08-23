using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvTable
{
    class ProgramInfo
    {
        public string ChannelName;
        private string _title = "";
        private string _programStart = "";
        public string Info;

        public ProgramInfo(string title, string programStart, string channelName)
        {
            _title = title;
            _programStart = programStart;
            char[] trim = ".se".ToCharArray();           
            ChannelName = channelName.Trim(trim);
            Info = ChannelName + " : " + _title + " --- "  + _programStart;
        }
              
    }
}
