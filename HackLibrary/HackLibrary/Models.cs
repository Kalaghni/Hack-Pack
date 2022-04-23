using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackLibrary
{
    public class Currency
    {
        public string code { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class TimeZone
    {
        public string name { get; set; }
        public int offset { get; set; }
        public string current_time { get; set; }
        public double current_time_unix { get; set; }
        public bool is_dst { get; set; }
        public int dst_savings { get; set; }
    }

    public class Root
    {
        public string ip { get; set; }
        public string hostname { get; set; }
        public string continent_code { get; set; }
        public string continent_name { get; set; }
        public string country_code2 { get; set; }
        public string country_code3 { get; set; }
        public string country_name { get; set; }
        public string country_capital { get; set; }
        public string state_prov { get; set; }
        public string district { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public bool is_eu { get; set; }
        public string calling_code { get; set; }
        public string country_tld { get; set; }
        public string languages { get; set; }
        public string country_flag { get; set; }
        public string geoname_id { get; set; }
        public string isp { get; set; }
        public string connection_type { get; set; }
        public string organization { get; set; }
        public string asn { get; set; }
        public Currency currency { get; set; }
        public TimeZone time_zone { get; set; }
    }
    public class GamerzplanetNet : object
    {
        public string uid { get; set; }
        public string email_address { get; set; }
        public string username { get; set; }
        public string ipaddress { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
    }

    public class ImeshCom : object
    {
        public string userid { get; set; }
        public string email_address { get; set; }
        public string username { get; set; }
        public string ipaddress { get; set; }
        public string password { get; set; }
    }

    public class NeopetsCom : object
    {
        public string email_address { get; set; }
        public string username { get; set; }
        public string ipaddress { get; set; }
        public string password { get; set; }
    }

    public class ShacknewsCom
    {
        public string email_address { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }

    public class UbisoftCom
    {
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }

    public class Root2
    {
        [JsonProperty("gamerzplanet.net")]
        public List<GamerzplanetNet> GamerzplanetNet { get; set; }

        [JsonProperty("imesh.com")]
        public List<ImeshCom> ImeshCom { get; set; }

        [JsonProperty("neopets.com")]
        public List<NeopetsCom> NeopetsCom { get; set; }

        [JsonProperty("shacknews.com")]
        public List<ShacknewsCom> ShacknewsCom { get; set; }

        [JsonProperty("ubisoft.com")]
        public List<UbisoftCom> UbisoftCom { get; set; }
    }

    public class Centroid
    {
        public Centroid()
        {

        }

        public decimal latitude
        {
            get
            {
                return ((x1 + x2 + x3) / 3);
            }
        }
        public decimal longitude
        {
            get
            {
                return ((y1 + y2 + y3) / 3);
            }
        }

        public decimal x1 { get; set; }
        public decimal x2 { get; set; }
        public decimal x3 { get; set; }
        public decimal y1 { get; set; }
        public decimal y2 { get; set; }
        public decimal y3 { get; set; }
    }

    public class Location
    {
        public string IPaddress { get; set; }
        public (decimal, decimal) Coordinates { get; set; }
    }
}
