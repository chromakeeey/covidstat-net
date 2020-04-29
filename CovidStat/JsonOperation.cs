using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CovidStat
{
    public static class JsonOperation
    {
        private static string downloadJsonString(string Url)
        {
            string json = new WebClient().DownloadString(Url);

            return json;
        }

        public static CovidData sendItemData()
        {
            const string Url = "https://api.covid19api.com/summary";
            string json = downloadJsonString(Url);

            CovidData item = JsonConvert.DeserializeObject<CovidData>(json);
            return item;
        }

       
    }
}
