using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;

namespace AustraliaEPG
{
    /// <summary>
    /// Generates all the information for a Free to Air TV Guide on a particular day for a particular region.
    /// </summary>
    public class Guide
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string GuideEndPoint = @"https://www.yourtv.com.au/api/guide/";
        private static readonly string ShowMetaEndPoint = @"https://www.yourtv.com.au/api/airings/";

        /// <summary>
        /// Gets a list of channels including addtional information based off parameters
        /// </summary>
        /// <param name="region">Free to Air TV Region</param>
        /// <param name="timeZone">Australian Timezone iana standard</param>
        /// <param name="dayOfWeek">3 letter abbreviation of the Day of the Week</param>
        /// <param name="showMetaData">Fetches meta data for TV Shows</param>
        /// <returns>List of Channel data</returns>
        public static List<Channel> getGuide(Region region, string timeZone, string dayOfWeek, bool showMetaData = true)
        {
            string data = GetDataResponse(GuideEndPoint + new WebRequestInfo()
            {
                day = dayOfWeek,
                region = region,
                timezone = timeZone
            }.ToString());

            JObject obj = JObject.Parse(jsonTrim(data));
            JToken channelData = obj.GetValue("channels");

            List<Channel> channels = new List<Channel>();

            if(channelData == null)
            {
                return channels;
            }

            Channel tempChannel;
            foreach (var channelToken in channelData.Children())
            {
                if (channelToken.Value<string>("adPlacement") != null || channelToken.Value<string>("fixedAd") != null)
                {
                    continue;
                }

                channels.Add(tempChannel = new Channel(channelToken.Value<string>("name"), channelToken.Value<int>("number")));

                JToken blockData = channelToken.Value<JToken>("blocks");
                foreach (var showsData in blockData.Children())
                {
                    foreach (var showData in showsData.Value<JToken>("shows").Children())
                    {
                        if(showMetaData)
                        {
                            obj = JObject.Parse(GetDataResponse(ShowMetaEndPoint + showData.Value<string>("id")));

                            tempChannel.addShow(new Show(
                                showData.Value<string>("title"),
                                showData.Value<string>("date"),
                                obj.Value<int>("duration"),
                                ClassificationSelector.Selector(showData.Value<string>("classification")),
                                obj.Value<string>("synopsis"),
                                obj.Value<string>("series") != null ? obj.Value<bool>("series") : false,
                                obj.Value<string>("warnings"),
                                obj.Value<string>("movie") != null ? obj.Value<bool>("movie") : false,
                                obj.Value<string>("yearProduction") != null ? obj.Value<int>("yearProduction") : 0,
                                obj.Value<string>("country"),
                                obj.Value<string>("language"),
                                obj.Value<string>("seriesNumber") != null ? obj.Value<int>("seriesNumber") : 0,
                                obj.Value<string>("episodeNumber") != null ? obj.Value<int>("episodeNumber") : 0,
                                obj.Value<string>("episodeTitle"),
                                obj.Value<string>("director"),
                                obj.Value<string>("mainCast") != null ? obj.Value<string>("mainCast").Split(',') : null,
                                obj.Value<string>("newEpisode") != null ? obj.Value<bool>("newEpisode") : false,
                                obj.Value<string>("premiere") != null ? obj.Value<bool>("premiere") : false,
                                obj.Value<string>("repeat") != null ? obj.Value<bool>("repeat") : false,
                                obj.Value<string>("final") != null ? obj.Value<bool>("final") : false,
                                obj.Value<string>("seriesReturn") != null ? obj.Value<bool>("seriesReturn") : false,
                                obj.Value<string>("live") != null ? obj.Value<bool>("live") : false,
                                obj.Value<string>("highDefinition") != null ? obj.Value<bool>("highDefinition") : false,
                                obj.Value<string>("colour") != null ? obj.Value<bool>("colour") : true,
                                obj.Value<string>("subtitles") != null ? obj.Value<bool>("subtitles") : false,
                                obj.Value<string>("closedCaptions") != null ? obj.Value<bool>("closedCaptions") : false
                            ));
                        }
                        else
                        {
                            tempChannel.addShow(new Show(
                                showData.Value<string>("title"),
                                showData.Value<string>("date")));
                        }

                        
                    }
                }
            }

            return channels;
        }

        /// <summary>
        /// Cleans up JSON return from API as it doesn't follow the ECMA-404 Standard
        /// </summary>
        /// <param name="json">Raw JSON Data</param>
        /// <returns>Cleaned JSON Data</returns>
        private static string jsonTrim(string json)
        {
            return json.TrimStart('[').TrimEnd(']');
        }

        /// <summary>
        /// Fetches a Raw JSON return.
        /// </summary>
        /// <param name="url">API Endpoint to fetch JSON from</param>
        /// <returns>string of Raw JSON</returns>
        private static string GetDataResponse(string url)
        {
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)GetHttpWebRequest(url).GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (WebException)
            {
                return "{}";
            }
        }

        /// <summary>
        /// Genetates a WebRequest package with required flags for Modern Web standards.
        /// </summary>
        /// <param name="uri">API Endpoint</param>
        /// <returns>HTTPWebRequest container with the URI and Flags</returns>
        private static HttpWebRequest GetHttpWebRequest(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            return request;
        }
    }
}
