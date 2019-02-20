using System.Net;
using System.Text;

namespace AustraliaEPG
{
    /// <summary>
    /// Builder for the URL arguments for the API Endpoint
    /// </summary>
    public class WebRequestInfo
    {
        public Region region;
        public string format = "JSON";
        public string timezone;
        public string day;

        public string GetArguments()
        {
            StringBuilder sb = new StringBuilder("?");
            sb.Append("day=");
            sb.Append(day);
            sb.Append("&timezone=");
            sb.Append(WebUtility.UrlEncode(timezone));
            sb.Append("&format=");
            sb.Append(format);
            sb.Append("&region=");
            sb.Append(region.RegionID);
            return sb.ToString();
        }

        public override string ToString()
        {
            return GetArguments();
        }
    }
}
