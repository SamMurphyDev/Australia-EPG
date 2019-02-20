using AustraliaEPG;
using System;

namespace Epg
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Console.WriteLine(string.Join<Channel>(",\n\n", 
                Guide.getGuide(Regions.CANBERRA, AustraliaTimeZone.EASTERN_TIME, AustraliaEPG.DayOfWeek.WEDNESDAY, true)));
            Console.ReadLine();
        }
    }
}