namespace AustraliaEPG
{
    /// <summary>
    /// Free to Air TV Region
    /// </summary>
    public class Region
    {
        private readonly string name;
        private readonly int regionID;
        private readonly LocationState state;

        public enum LocationState
        {
            ACT,
            NSW,
            VIC,
            NT,
            SA,
            WA,
            TAS,
            QLD
        }

        public Region(string name, LocationState state, int regionID)
        {
            this.name = name;
            this.regionID = regionID;
            this.state = state;
        }

        public int RegionID => regionID;

        public string Name => name;

        public LocationState State => state;
    }
}
