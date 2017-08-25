using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;

namespace TVTableau
{

    public class RootObject
    {
        public JsonTv JsonTv { get; set; }

        public override string ToString() => JsonTv.ToString();
    }

    public class JsonTv
    {
        [JsonProperty(PropertyName = "programme")]
        public Programme[] Programmes { get; set; }

        public override string ToString() => string.Join<Programme>("\r\n\r\n", Programmes);
    }

    public class Programme
    {
        [JsonProperty(PropertyName = "desc")]
        public Desc Description { get; set; }
        [JsonProperty(PropertyName = "video")]
        public Video VideoAspect { get; set; }
        [JsonProperty(PropertyName = "episodeNum")]
        public EpisodeNum EpisodeNumber { get; set; }
        [JsonProperty(PropertyName = "category")]
        public Category Category { get; set; }
        [JsonProperty(PropertyName = "start")]
        public string Start { get; set; }
        [JsonProperty(PropertyName = "_new")]
        public string New { get; set; }
        [JsonProperty(PropertyName = "channel")]
        public string Channel { get; set; }
        [JsonProperty(PropertyName = "title")]
        public Title Title { get; set; }
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }
        [JsonProperty(PropertyName = "stop")]
        public string Stop { get; set; }
        [JsonProperty(PropertyName = "subTitle")]
        public Subtitle SubTitle { get; set; }
        [JsonProperty(PropertyName = "credits")]
        public Credits Credits { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string[] Url { get; set; }
        [JsonProperty(PropertyName = "country")]
        public string[] Country { get; set; }
        [JsonProperty(PropertyName = "rating")]
        public Rating Rating { get; set; }

        public string Header
        {
            get
            {
                var startTime = HelperMethods.ConvertFromUnixTimestampToDateTime(Start).TimeOfDay.ToString(@"hh\:mm");
                var endTime   = HelperMethods.ConvertFromUnixTimestampToDateTime(Stop).TimeOfDay.ToString(@"hh\:mm");
                return $"{startTime} - {endTime} {Title}";
            }
        }

        public override string ToString()
        {
            var title = Title?.ToString() ?? "No title";
            var description = Description?.ToString() ?? "No description";
            var episodeNum = EpisodeNumber?.ToString() ?? "No episode number";
            var startTime = HelperMethods.ConvertFromUnixTimestampToDateTime(Start).TimeOfDay.ToString(@"hh\:mm");
            var endTime = HelperMethods.ConvertFromUnixTimestampToDateTime(Stop).TimeOfDay.ToString(@"hh\:mm");
            var date = Date ?? "No date";
            var subtitle = SubTitle?.ToString() ?? "No subtitle";
            var credits = Credits;
            return $"{title} ({date})\r\n\r\n{subtitle} ({episodeNum})\r\n\r\n{startTime} - {endTime}\r\n\r\n{description}\r\n\r\n{credits}";
        }
    }

    public class Desc
    {
        [JsonProperty(PropertyName = "sv")]
        public string Swedish { get; set; }

        public override string ToString() => Swedish;
    }

    public class Video
    {
        [JsonProperty(PropertyName = "aspect")]
        public string Aspect { get; set; }

        public override string ToString() => Aspect;
    }

    public class EpisodeNum
    {
        [JsonProperty(PropertyName = "xmltv_ns")]
        public string XmltvNs { get; set; }
        [JsonProperty(PropertyName = "onscreen")]
        public string OnScreen { get; set; }
        [JsonProperty(PropertyName = "themoviedborg")]
        public string TheMovieDB { get; set; }

        //public override string ToString() => $"{xmltv_ns}, {onscreen}, {themoviedborg}";
        public override string ToString() => OnScreen;
    }

    public class Category
    {
        [JsonProperty(PropertyName = "en")]
        public string[] English { get; set; }

        public override string ToString() => string.Join(", ", English);
    }

    public class Title
    {
        [JsonProperty(PropertyName = "sv")]
        public string Swedish { get; set; }

        public override string ToString() => Swedish;
    }

    public class Subtitle
    {
        [JsonProperty(PropertyName = "sv")]
        public string Swedish { get; set; }

        public override string ToString() => Swedish;
    }

    public class Credits
    {
        [JsonProperty(PropertyName = "presenter")]
        public Presenter[] Presenters { get; set; }
        [JsonProperty(PropertyName = "director")]
        public Director[] Directors { get; set; }
        [JsonProperty(PropertyName = "writer")]
        public Writer[] Writers { get; set; }
        [JsonProperty(PropertyName = "producer")]
        public Producer[] Producers { get; set; }
        [JsonProperty(PropertyName = "actor")]
        public Actor[] Actors { get; set; }

        public override string ToString()
        {
            var presenters = Presenters != null ? "Presenters: " + string.Join<Presenter>(", ", Presenters) : "No presenters named";
            var writers    = Writers    != null ? "Writers: "    + string.Join<Writer>   (", ", Writers)    : "No writers named";
            var directors  = Directors  != null ? "Directors: "  + string.Join<Director> (", ", Directors)  : "No directors named";
            var producers  = Producers  != null ? "Producers: "  + string.Join<Producer> (", ", Producers)  : "No producers named";
            var actors     = Actors     != null ? "Actors: "     + string.Join<Actor>    (", ", Actors)     : "No actors named";
            return string.Join("\r\n", presenters, writers, directors, producers, actors);
        }
    }

    public class Presenter
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        public override string ToString() => Name ?? "No presenter";
    }

    public class Director
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        public override string ToString() => Name ?? "No director";
    }

    public class Writer
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        public override string ToString() => Name ?? "No writer";
    }

    public class Producer
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        public override string ToString() => Name ?? "No producer";
    }

    public class Actor
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        public override string ToString() => $"{Name}";
    }

    public class Rating
    {
        [JsonProperty(PropertyName = "stars")]
        public string Stars { get; set; }

        public override string ToString() => Stars ?? "No rating";
    }
}
