using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TvTableauForm
{

    public class Rootobject
    {
        public Jsontv jsontv { get; set; }

        public override string ToString()
        {
            return jsontv.ToString();
        }
    }

    public class Jsontv
    {
        public Programme[] programme { get; set; }

        public override string ToString()
        {
            return string.Join<Programme>("\r\n\r\n", programme);
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

        private static DateTime ConvertFromUnixTimestamp(double timestamp)
        {

            var origin = new DateTime(1970, 1, 1, 2, 0, 0, 0);

            return origin.AddSeconds(timestamp);

        }



        public override string ToString()
        {
            return $"Title: {Title}\r\n\r\n" +
                   $"Description: {Description}\r\n\r\n" +
                   $"Episode: {Episode}\r\n" +
                   $"Category: {Category}\r\n" +
                   "Starts: " + ConvertFromUnixTimestamp(double.Parse(Start)) + " \r\n" +
                   "Ends: " + ConvertFromUnixTimestamp(double.Parse(Stop)) + " \r\n" +
                   "__________________________________________________________";
        }
    }

    public class Desc
    {
        public string sv { get; set; }

        public override string ToString()
        {
                return sv;
        }
    }

    public class Video
    {
        public string aspect { get; set; }

        public override string ToString()
        {
            return aspect;
        }
    }

    public class Episodenum
    {
        public string xmltv_ns { get; set; }
        public string onscreen { get; set; }
        public string themoviedborg { get; set; }

        public override string ToString()
        {
            return $"{onscreen}";
        }
    }

    public class Category
    {
        public string[] en { get; set; }

        public override string ToString()
        {
            return string.Join(", ", en);
        }
    }

    public class Title
    {
        public string sv { get; set; }

        public override string ToString()
        {
            return sv;
        }
    }

    public class Subtitle
    {
        public string sv { get; set; }

        public override string ToString()
        {
            return sv;
        }
    }

    public class Credits
    {
        public Presenter[] presenter { get; set; }
        public Director[] director { get; set; }
        public Writer[] writer { get; set; }
        public Producer[] producer { get; set; }
        public Actor[] actor { get; set; }

        public override string ToString()
        {
            return $"Presenter: {presenter}\r\nDirector: {director}\r\nWriter: {writer}\r\nProducer: {producer}\r\nActor: {actor}\r\n";
        }
    }

    public class Presenter
    {
        public string name { get; set; }

        public override string ToString()
        {
            return name;
        }
    }

    public class Director
    {
        public string name { get; set; }

        public override string ToString()
        {
            return name;
        }
    }

    public class Writer
    {
        public string name { get; set; }

        public override string ToString()
        {
            return name;
        }
    }

    public class Producer
    {
        public string name { get; set; }

        public override string ToString()
        {
            return name;
        }
    }

    public class Actor
    {
        public string name { get; set; }
        public string role { get; set; }

        public override string ToString()
        {
            return $"Name: {name}\r\nRole: {role}";
        }
    }

    public class Rating
    {
        public string stars { get; set; }

        public override string ToString()
        {
            return stars;
        }
    }

}

