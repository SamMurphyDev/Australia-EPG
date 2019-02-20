namespace AustraliaEPG
{
    /// <summary>
    /// Contains a list of all the Free to Air TV Regions in Australia
    /// </summary>
    public class Regions
    {
        //NSW
        public static readonly Region SYDNEY = new Region("Sydney", Region.LocationState.NSW, 73);
        public static readonly Region BROKEN_HILL = new Region("Broken Hill", Region.LocationState.NSW, 63);
        public static readonly Region CENTRAL_COAST = new Region("Central Coast", Region.LocationState.NSW, 66);
        public static readonly Region COFFS_HARBOUR = new Region("Coffs Harbour", Region.LocationState.NSW, 292);
        public static readonly Region GRIFFITH = new Region("Griffith", Region.LocationState.NSW, 67);
        public static readonly Region LISMORE = new Region("Lismore", Region.LocationState.NSW, 261);
        public static readonly Region NEWCASTLE = new Region("Newcastle", Region.LocationState.NSW, 184);
        public static readonly Region ORANGE_DUBBO = new Region("Orange/Dubbo", Region.LocationState.NSW, 262);
        public static readonly Region REMOTE_AND_CENTRAL_NSW = new Region("Remote and Central", Region.LocationState.NSW, 106);
        public static readonly Region SOUTH_COAST = new Region("South Coast", Region.LocationState.NSW, 259);
        public static readonly Region TAMWORTH = new Region("Tamworth", Region.LocationState.NSW, 69);
        public static readonly Region TAREE_PORT_MACQUARIE = new Region("Taree/Port Macquarie", Region.LocationState.NSW, 263);
        public static readonly Region WAGGA_WAGGA = new Region("Wagga Wagga", Region.LocationState.NSW, 264);
        public static readonly Region WOLLONGONG = new Region("Wollongong", Region.LocationState.NSW, 71);

        //VIC
        public static readonly Region MELBOURNE = new Region("Melbourne", Region.LocationState.VIC, 94);
        public static readonly Region ALBURY_WODONGA = new Region("Albury/Wodonga", Region.LocationState.VIC, 268);
        public static readonly Region BALLARAT = new Region("Ballarat", Region.LocationState.VIC, 90);
        public static readonly Region BENDIGO = new Region("Bendigo", Region.LocationState.VIC, 266);
        public static readonly Region GEELONG = new Region("Geelong", Region.LocationState.VIC, 93);
        public static readonly Region GIPPSLAND = new Region("Gippsland", Region.LocationState.VIC, 98);
        public static readonly Region MILDURA_SUNRAYSIA = new Region("Mildura/Sunraysia", Region.LocationState.VIC, 95);
        public static readonly Region SHEPPARTON = new Region("Shepparton", Region.LocationState.VIC, 267);

        //SA
        public static readonly Region ADELAIDE = new Region("Adelaide", Region.LocationState.SA, 81);
        public static readonly Region PORT_AUGUSTA = new Region("Port Augusta", Region.LocationState.SA, 82);
        public static readonly Region REMOTE_AND_CENTRAL_SA = new Region("Remote and Central", Region.LocationState.SA, 107);
        public static readonly Region RIVERLAND = new Region("Riverland", Region.LocationState.SA, 83);
        public static readonly Region SOUTH_EAST_SA = new Region("South East SA", Region.LocationState.SA, 85);
        public static readonly Region SPENCER_GULF = new Region("Spencer Gulf", Region.LocationState.SA, 86);

        //QLD
        public static readonly Region BRISBANE = new Region("Brisbane", Region.LocationState.QLD, 75);
        public static readonly Region CAIRNS = new Region("CAIRNS", Region.LocationState.QLD, 79);
        public static readonly Region GOLD_COAST = new Region("GOLD COAST", Region.LocationState.QLD, 78);
        public static readonly Region MACKAY = new Region("Mackay", Region.LocationState.QLD, 253);
        public static readonly Region REMOTE_AND_CENTRAL_QLD = new Region("Remote and Central", Region.LocationState.QLD, 114);
        public static readonly Region ROCKHAMPTON = new Region("Rockhampton", Region.LocationState.QLD, 254);
        public static readonly Region SUNSHINE_COAST = new Region("Sunshine Coast", Region.LocationState.QLD, 255);
        public static readonly Region TOOWOOMBA = new Region("Toowoomba", Region.LocationState.QLD, 256);
        public static readonly Region TOWNSVILLE = new Region("Townsville", Region.LocationState.QLD, 257);
        public static readonly Region WIDE_BAY = new Region("Wide Bay", Region.LocationState.QLD, 258);

        //WA
        public static readonly Region PERTH = new Region("Perth", Region.LocationState.WA, 101);
        public static readonly Region ALBANY = new Region("Albany", Region.LocationState.WA, 344);
        public static readonly Region BUNBURY = new Region("Bunbury", Region.LocationState.WA, 343);
        public static readonly Region MANDURAH = new Region("Mandurah", Region.LocationState.WA, 342);
        public static readonly Region REGIONAL_WA = new Region("Regional WA", Region.LocationState.WA, 102);

        //ACT 
        public static readonly Region CANBERRA = new Region("Canberra", Region.LocationState.ACT, 126);

        //NT
        public static readonly Region DARWIN = new Region("Darwin", Region.LocationState.NT, 74);
        public static readonly Region REGIONAL_NT = new Region("Regional NT", Region.LocationState.NT, 108);

        //TAS
        public static readonly Region HOBART = new Region("Hobart", Region.LocationState.TAS, 88);
        public static readonly Region LAUNCESTON = new Region("Launceston", Region.LocationState.TAS, 293);
    }
}
