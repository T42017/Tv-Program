using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Navigation;

namespace WpfTvSchedule
{
    class Utility
    {

        public static DateTime GetDateTimeFromString(string dateAndTimeAsString)
        {
            return DateTimeOffset.ParseExact(dateAndTimeAsString, "yyyyMMddHHmmss zzz", CultureInfo.InvariantCulture)
                .DateTime;
        }

        public static List<string> ReadFile(string fileName)
        {
            List<string> lines = new List<string>();
            using (var reader = 
                new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(
                    "WpfTvSchedule." + fileName)))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines;
        }

        public static string CreateUrlFromChannelAndDate(Channel channel, DateTime date)
        {
            return "http://xmltv.xmltv.se/" + channel.Website + "_" + date.Year + "-" +
                   date.Month.ToString("d2") + "-" + date.Day.ToString("d2") + ".xml.gz";
        }

        public static void AddButtonToGrid(Grid grid, Button button, int row, int column)
        {
            while (grid.RowDefinitions.Count <= row)
                grid.RowDefinitions.Add(new RowDefinition());

            while (grid.ColumnDefinitions.Count <= column)
                grid.ColumnDefinitions.Add(new ColumnDefinition());

            Grid.SetRow(button, row);
            Grid.SetColumn(button, column);

            grid.Children.Add(button);
        }

        public static String ConvertToEncodingUtf8(string str)
        {
            byte[] stringAsByte = Encoding.Default.GetBytes(str);
            return Encoding.UTF8.GetString(stringAsByte);
        }

        public static Button ConvertChannelToButton(Channel channel)
        {
            Button button = new Button();
            button.Content = channel.Name;
            return button;
        }
    }
}
