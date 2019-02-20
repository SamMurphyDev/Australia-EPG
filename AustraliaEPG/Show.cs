namespace AustraliaEPG
{
    /// <summary>
    /// TV show container. Required to have Title of show and Time that it will be showing. Optional inclusion of meta data of the show.
    /// </summary>
    public class Show
    {
        public Show(string title, string time, int duration = 0, Classification classification = Classification.OTHER, 
            string synopsis = null, bool series = false, string warnings = null, bool movie = false, int yearProduced = 0000,
            string country = null, string language = null, int seriesNumber = 0, int episodeNumber = 0,
            string episodeTitle = null, string director = null, string[] mainCast = null, bool newEpisode = false,
            bool premiere = false, bool repeat = false, bool final = false, bool seriesReturn = false,
            bool live = false, bool highDefinition = false, bool colour = true, bool subtitles = false,
            bool closedCaptions = false)
        {
            Title = title;
            Time = time;
            Duration = duration;
            Series = series;
            Classification = classification;
            Warnings = warnings;
            Movie = movie;
            YearProduced = yearProduced;
            Country = country;
            Language = language;
            SeriesNumber = seriesNumber;
            EpisodeNumber = episodeNumber;
            EpisodeTitle = episodeTitle;
            Director = director;
            MainCast = mainCast;
            NewEpisode = newEpisode;
            Premiere = premiere;
            Repeat = repeat;
            Final = final;
            SeriesReturn = seriesReturn;
            Live = live;
            HighDefinition = highDefinition;
            Colour = colour;
            Subtitles = subtitles;
            ClosedCaptions = closedCaptions;
            Synopsis = synopsis;
        }

        public string Time { get; }

        public int Duration { get; }

        public bool Series { get; }

        public string Warnings { get; }

        public bool Movie { get; }

        public int YearProduced { get; }

        public string Country { get; }

        public string Language { get; }

        public int SeriesNumber { get; }

        public int EpisodeNumber { get; }

        public string EpisodeTitle { get; }

        public string Director { get; }

        public string[] MainCast { get; }

        public bool NewEpisode { get; }

        public bool Premiere { get; }

        public bool Repeat { get; }

        public bool Final { get; }

        public bool SeriesReturn { get; }

        public bool Live { get; }

        public bool HighDefinition { get; }

        public bool Colour { get; }

        public bool Subtitles { get; }

        public bool ClosedCaptions { get; }

        public string Synopsis { get; }

        public string Title { get; }

        public Classification Classification { get; }

        public override string ToString() => "[Title: " + Title + ", Time: " + Time + "]";
    }
}
