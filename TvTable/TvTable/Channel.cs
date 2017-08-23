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
        public List<ProgramInfo> Programs = new List<ProgramInfo>();

        public Channel(string overview, List<ProgramInfo> programs)
        {
            Programs = programs;
            Overview = overview;
        }
    }
}
