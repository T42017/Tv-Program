using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTvSchedule;

namespace WpfTvSchedule
{
    class ChannelManager
    {
        public List<Channel> Channels { get; set; }

        public ChannelManager() { }

        public void LoadChannelsFromFile()
        {
            Channels = new List<Channel>();

            List<string> fileAsList = Utility.ReadFile("channels.txt");

            foreach (var line in fileAsList)
            {
                string[] splitedLine = line.Split(':');
                if (splitedLine.Length != 2)
                    continue;
                
                Channels.Add(new Channel(splitedLine[0], splitedLine[1]));
            }
        }

        public Channel FindChannelByName(String name)
        {
            foreach (var channel in Channels)
            {
                if (channel.Name.Equals(name))
                    return channel;
            }
            return null;
        }

        public void AddNewChannel(Channel channel)
        {
            Channels.Add(channel);
        }

        public void SaveChannelsToFile()
        {
            string[] lines = new string[Channels.Count];
            
            for (int i = 0; i < Channels.Count; i++)
            {
                lines[i] = Channels[i].Name + " " + Channels[i].Website;
            }

            System.IO.File.WriteAllLines(@"channels.txt", lines);
        }

    }
}
