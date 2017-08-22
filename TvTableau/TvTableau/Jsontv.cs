using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvTableau
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
        public Desc desc { get; set; }
        public Video video { get; set; }
        public Episodenum episodeNum { get; set; }
        public Category category { get; set; }
        public string start { get; set; }
        public string _new { get; set; }
        public string channel { get; set; }
        public Title title { get; set; }
        public string date { get; set; }
        public string stop { get; set; }
        public Subtitle subTitle { get; set; }
        public Credits credits { get; set; }
        public string[] url { get; set; }
        public string[] country { get; set; }
        public Rating rating { get; set; }

        private static DateTime ConvertFromUnixTimestamp(double timestamp)
        {

            var origin = new DateTime(1970, 1, 1, 2, 0, 0, 0);

            return origin.AddSeconds(timestamp);

        }

        public override string ToString()
        {
            return $"Title: {title}\r\n" +
                   $"Description: {desc}\r\n" +
                   $"Videoaspect: {video}\r\n" +
                   $"Episode: {episodeNum}\r\n" +
                   $"Category: {category}\r\n" +
                   "Starts: " + ConvertFromUnixTimestamp(double.Parse(start)) + " \r\n" +
                   "Ends: " + ConvertFromUnixTimestamp(double.Parse(stop)) + " \r\n";
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
            return $"{onscreen}\r\n";
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
