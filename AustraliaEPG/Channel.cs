using System.Collections.Generic;

namespace AustraliaEPG
{

    /// <summary>
    /// Container for all related TV Channel Information
    /// </summary>
    public class Channel
    {
        /// <param name="name">Title for the channel</param>
        /// <param name="channelNumber">Default channel number as allocated by Free TV Australia</param>
        public Channel(string name, int channelNumber)
        {
            Name = name;
            ChannelNumber = channelNumber;
        }

        public string Name { get; }

        public int ChannelNumber { get; }

        
        /// <summary>
        /// Generates a String containing Name, Channel Number and list of TV shows for that channel
        /// </summary>
        /// <returns></returns>
        public override string ToString() => "[Name: " + Name + ", ChannelNumber: " + ChannelNumber + ", Shows: " + string.Join<Show>(", ", Shows) + "]";

        public void addShow(Show show)
        {
            Shows.Add(show);
        }

        public List<Show> Shows { get; } = new List<Show>();
    }
}
