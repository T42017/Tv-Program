using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvTable
{
    class ProgramInfo
    {
        private string _title;
        private string _programStart;
        public string Info;

        public ProgramInfo(string title, string programStart)
        {
            _title = title;
            _programStart = programStart;          
            Info = _title + " --- "  + _programStart;
        }
              
    }
}
