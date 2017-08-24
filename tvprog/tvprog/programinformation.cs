using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tvprog
{
    class ProgramInformation
    {
        private string atitle = "";
        private string progstart = "";
        public string Info;

        public ProgramInformation(string title, string programStart)
        {
            atitle = title;
            progstart = programStart;

            Info = atitle + " --- " + progstart;
        }

        public ProgramInformation()
        {
            Info = atitle + " --- " + progstart;
        }
    }


}
