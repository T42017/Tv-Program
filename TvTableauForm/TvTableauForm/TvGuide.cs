using Newtonsoft.Json;
using System;

namespace TvTableauForm
{

    public class Rootobject
    {
        [JsonProperty(PropertyName = "jsontv")]
        public Jsontv JsonTv { get; set; }

        public override string ToString()
        {
            return JsonTv.ToString();
        }
    }

    public class Jsontv
    {
        [JsonProperty(PropertyName = "programme")]
        public Programme[] Program { get; set; }

        public override string ToString()
        {
            return string.Join<Programme>("", Program);
        }
    }

    public class Programme
    {
        [JsonProperty(PropertyName = "desc")]
        public Desc Description { get; set; }
        [JsonProperty(PropertyName = "video")]
        public Video Video { get; set; }
        [JsonProperty(PropertyName = "episodeNum")]
        public Episodenum Episode { get; set; }
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
        public Subtitle Subtitles { get; set; }
        [JsonProperty(PropertyName = "credits")]
        public Credits Credits { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string[] Url { get; set; }
        [JsonProperty(PropertyName = "country")]
        public string[] Country { get; set; }
        [JsonProperty(PropertyName = "rating")]
        public Rating Rating { get; set; }

        public static DateTime ConvertFromUnixTimestamp(double timestamp)
        {

            var origin = new DateTime(1970, 1, 1, 2, 0, 0, 0);

            return origin.AddSeconds(timestamp);

        }

        public override string ToString()
        {
            var start = ConvertFromUnixTimestamp(double.Parse(Start));
            var stop = ConvertFromUnixTimestamp(double.Parse(Stop));
            return $"Title: {Title}\r\n\r\n" +
                   $"{Description}\r\n\r\n" +
                   $"Episode: {Episode}\r\n" +
                   $"Category: {Category}\r\n" +
                   "Starts: " + start.ToString("hh:mm") + " \r\n" +
                   "Ends: " + stop.ToString("hh:mm") + " \r\n" +
                   "___________________________________";
        }
    }

    public class Desc
    {
        [JsonProperty(PropertyName = "sv")]
        public string Sv { get; set; }

        public override string ToString()
        {
                return Sv;
        }
    }

    public class Video
    {
        [JsonProperty(PropertyName = "aspect")]
        public string Aspect { get; set; }

        public override string ToString()
        {
            return Aspect;
        }
    }

    public class Episodenum
    {
        [JsonProperty(PropertyName = "xmltv_ns")]
        public string Episode { get; set; }
        [JsonProperty(PropertyName = "onscreen")]
        public string OnscreenEpisode { get; set; }
        [JsonProperty(PropertyName = "themoviedborg")]
        public string MovieUrl { get; set; }

        public override string ToString()
        {
            return $"{OnscreenEpisode}";
        }
    }

    public class Category
    {
        [JsonProperty(PropertyName = "en")]
        public string[] En { get; set; }

        public override string ToString()
        {
            return string.Join(", ", En);
        }
    }

    public class Title
    {
        [JsonProperty(PropertyName = "sv")]
        public string Sv { get; set; }

        public override string ToString()
        {
            return Sv;
        }
    }

    public class Subtitle
    {
        [JsonProperty(PropertyName = "sv")]
        public string Sv { get; set; }

        public override string ToString()
        {
            return Sv;
        }
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
            return $"Presenter: {Presenters}\r\nDirector: {Directors}\r\nWriter: {Writers}\r\nProducer: {Producers}\r\nActor: {Actors}\r\n";
        }
    }

    public class Presenter
    {
        
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Director
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Writer
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Producer
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Actor
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\r\nRole: {Role}";
        }
    }

    public class Rating
    {
        public string Stars { get; set; }

        public override string ToString()
        {
            return Stars;
        }
    }

}