using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TvTablaNew
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
            return string.Join<Programme>("\r\n", programme);
        }
    }

    public class Programme
    {
        public string stop { get; set; }
        [JsonProperty(PropertyName = "desc")]
        public Desc description { get; set; }
        public Title title { get; set; }
        public Video video { get; set; }
        public Category category { get; set; }
        public string date { get; set; }
        public string channel { get; set; }
        public string start { get; set; }
        public string _new { get; set; }
        public Episodenum episodeNum { get; set; }
        public Credits credits { get; set; }
        public Subtitle subTitle { get; set; }
        public string[] url { get; set; }
        public Rating rating { get; set; }
        public string[] country { get; set; }

        public static DateTime ConvertFromUnixTimestampToDateTime(string timestamp)
        {
            var unixStartTime = new DateTime(1970, 1, 1, 2, 0 , 0, 0);
            return unixStartTime.AddSeconds(double.Parse(timestamp));
        }


        public override string ToString()
        {
            return title  + " (" + date + ") " +"\r\n" + 
                   ConvertFromUnixTimestampToDateTime(start).TimeOfDay.ToString(@"hh\:mm") + " - " + ConvertFromUnixTimestampToDateTime(stop).TimeOfDay.ToString(@"hh\:mm") + "\r\n" + "\r\n" +
                   description + "\r\n" + "\r\n" + 
                   episodeNum + "\r\n" + 
                   rating + "\r\n" + "-----------------------" + "\r\n";
            
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

    public class Title
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

    public class Category
    {
        public string[] en { get; set; }

        public override string ToString()
        {
            return en.ToString();
        }
    }

    public class Episodenum
    {
        public string xmltv_ns { get; set; }
        public string onscreen { get; set; }
        public string themoviedborg { get; set; }
        public string thetvdbcom { get; set; }

        public override string ToString()
        {
            return onscreen;
        }
    }

    public class Credits
    {
        public Presenter[] presenter { get; set; }
        public Commentator[] commentator { get; set; }
        public Director[] director { get; set; }
        public Producer[] producer { get; set; }
        public Writer[] writer { get; set; }
        public Actor[] actor { get; set; }

       


    }

    public class Presenter
    {
        public string name { get; set; }

        public override string ToString()
        {
            return name;
        }
    }

    public class Commentator
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

    public class Producer
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

    public class Actor
    {
        public string role { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return role + name;
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

    public class Rating
    {
        public string stars { get; set; }

        public override string ToString()
        {
            return stars;
        }
    }

}
