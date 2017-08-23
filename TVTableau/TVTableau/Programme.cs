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
            get { return $"{Title} \r\n({ConvertFromUnixTimestampToDateTime(Start).TimeOfDay.ToString(@"hh\:mm")} - {ConvertFromUnixTimestampToDateTime(Stop).TimeOfDay.ToString(@"hh\:mm")})"; }
        }

        private static DateTime ConvertFromUnixTimestampToDateTime(string timestamp)
        {
            try
            {
                var unixStartTime = new DateTime(1970, 1, 1, 1, 0, 0, 0);
                return unixStartTime.AddSeconds(double.Parse(timestamp));
            }
            catch (Exception ex)
            {
                const string message = "Error converting the date";
                const string title = "Error";
                MessageBox.Show(message, title);
                throw new ArgumentException(message);
            }
        }

        public override string ToString()
        {
            var title = Title?.ToString() ?? "No title";
            var description = Description?.ToString() ?? "No description";
            var episodeNum = EpisodeNumber?.ToString() ?? "No episode number";
            var startTime = ConvertFromUnixTimestampToDateTime(Start).TimeOfDay.ToString(@"hh\:mm") ?? "No start time";
            var endTime = ConvertFromUnixTimestampToDateTime(Stop).TimeOfDay.ToString(@"hh\:mm") ?? "No end time";
            var date = Date ?? "No date";
            var subtitle = SubTitle?.ToString() ?? "No subtitle";
            return $"{title} ({date})\r\n{subtitle} ({episodeNum})\r\n{startTime} - {endTime}\r\n{description}";
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
            var presenters = Presenters != null ? string.Join<Presenter>(", ", Presenters) : "No presenters";
            var directors = Directors != null ? string.Join<Director>(", ", Directors) : "No directors";
            var writers = Writers != null ? string.Join<Writer>(", ", Writers) : "No writers";
            var producers = Producers != null ? string.Join<Producer>(", ", Producers) : "No producers";
            var actors = Actors != null ? string.Join<Actor>(", ", Actors) : "No actors";
            return string.Join("; ", presenters + " (Presenters)", directors + " (Directors)", writers + " (Writers)", producers + " (Producers)", actors + " (Actors)");
            return $"{presenters} ( Presenters); {directors} (Directors); {writers} (Writers); {producers} (Producers); {actors} (Actors)";
            //var presenters = string.Join<Presenter>(", ", Presenters);
            //var directors = string.Join<Director>(", ", Directors);
            //var writers = string.Join<Writer>(", ", Writers);
            //var producers = string.Join<Producer>(", ", Producers);
            //var actors = string.Join<Actor>(", ", Actors);

            return string.Join("; ", presenters, directors, writers, producers, actors);
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

        public override string ToString() => $"Name: {Name ?? "No actor"}\r\nRole: {Role ?? "No role"}";
    }

    public class Rating
    {
        [JsonProperty(PropertyName = "stars")]
        public string Stars { get; set; }

        public override string ToString() => Stars ?? "No rating";
    }
}
