using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvTable
{
    class Details
    {
        public string EpisodeDescription;
        public List<string> ActorList;
        public List<string> CategoryList;

        public Details(string episodeDescription, List<string> actorList, List<string> categoryList)
        {
            EpisodeDescription = episodeDescription;
            ActorList = actorList;
            CategoryList = categoryList;
        }
    }
}
