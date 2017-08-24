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
        public bool IsRunning;
        public string Url;
        public Details ProgramDetails;

        public ProgramInfo(string title, string programStart, bool isRunning, string url, Details details)
        {
            _title = title;
            _programStart = programStart;          
            Info = _title + " --- "  + _programStart;
            IsRunning = isRunning;
            Url = url;
            ProgramDetails = details;
        }

        public string WriteDetails()
        {
            string detailsToBeWritten = ProgramDetails.EpisodeDescription + "\r\n\r\n" + "Skådespelare: \r\n";

            foreach (string actor in ProgramDetails.ActorList)
            {
                detailsToBeWritten += actor + "\r\n";
            }

            detailsToBeWritten += " \r\nKategorier: \r\n";
            foreach (string category in ProgramDetails.CategoryList)
            {
                detailsToBeWritten += category + "\r\n";
            }
            return detailsToBeWritten;
        }
    }
}
