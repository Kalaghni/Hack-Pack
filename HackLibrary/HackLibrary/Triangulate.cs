using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HackLibrary
{
    public static class Triangulate
    {
        static int count = 0;
        static public Centroid points = new Centroid();

        public static void GraphPoints()
        {
            int xmin = -180, ymin = -90;
            int xmax = 180, ymax = 90;
            Uri URI = new Uri($"https://www.webmath.com/cgi-bin/grapher.cgi?param0=({ decimal.Round(points.y1, 7)}%2C+{ decimal.Round(points.x1, 7)})%2C({ decimal.Round(points.y2, 7)}%2C+{decimal.Round(points.x2, 7)})%2C({decimal.Round(points.y3, 7)}%2C+{decimal.Round(points.x3, 7)})%2C({decimal.Round(points.longitude, 7)}%2C+{decimal.Round(points.latitude, 7)})&ymax={ymax}&xmin={xmin}&xmax={xmax}&ymin={ymin}&to_plot=points");

            //System.Diagnostics.Process.Start("https://www.google.com/maps/@" + decimal.Round(points.latitude, 7) + "," + decimal.Round(points.longitude, 7) + ",15.5z");
            System.Diagnostics.Process.Start(URI.AbsoluteUri);
            return;
        }

        public static string GraphURL()
        {
            int xmin = -180, ymin = -90;
            int xmax = 180, ymax = 90;
            Uri URI = new Uri($"https://www.webmath.com/cgi-bin/grapher.cgi?param0=({ decimal.Round(points.y1, 7)}%2C+{ decimal.Round(points.x1, 7)})%2C({ decimal.Round(points.y2, 7)}%2C+{decimal.Round(points.x2, 7)})%2C({decimal.Round(points.y3, 7)}%2C+{decimal.Round(points.x3, 7)})%2C({decimal.Round(points.longitude, 7)}%2C+{decimal.Round(points.latitude, 7)})&ymax={ymax}&xmin={xmin}&xmax={xmax}&ymin={ymin}&to_plot=points");

            return URI.OriginalString;
        }

        public static async Task<(decimal, decimal)> CoordsFromIP(string ipaddress)
        {
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync("https://api.ipgeolocation.io/ipgeo?apiKey=6640be4c774f4aaeb646d5c1c70db52f&ip=" + ipaddress);
            Root data = JsonConvert.DeserializeObject<Root>(json);
            return (decimal.Parse(data.latitude), decimal.Parse(data.longitude));
        }

        public static async Task<Location> GrabLocation(string ipaddress)
        {
                Location location = new Location { Coordinates = await CoordsFromIP(ipaddress), IPaddress = ipaddress };

                SetPoints(location.Coordinates.Item1, location.Coordinates.Item2);

                return location;
        }
        public static async Task<List<Location>> GrabLocation(List<string> ipaddresses)
        {
            List<Location> locations = new List<Location>();
            foreach (string ipaddress in ipaddresses)
            {
                Location location = new Location { Coordinates = await CoordsFromIP(ipaddress), IPaddress = ipaddress };

                SetPoints(location.Coordinates.Item1, location.Coordinates.Item2);

                locations.Add(location);
            }
            return locations;
        }
        public static Location GrabLocation(decimal lat, decimal lng)
        {
            Location location = new Location { Coordinates = (lat, lng) };

            SetPoints(location.Coordinates.Item1, location.Coordinates.Item2);

            return location;
        }

        public static async Task<string> LocationDetails(Location location)
        {
            HttpClient client = new HttpClient();

            Uri URI = new Uri($"https://api.opencagedata.com/geocode/v1/json?key=3fc9b2bf7cef45c7b333d912f0ebcff4&q={location.Coordinates.Item1}%2C+{location.Coordinates.Item2}&pretty=1&no_annotations=1");

            string json = await client.GetStringAsync(URI);

            OpenCage.Root data = JsonConvert.DeserializeObject<OpenCage.Root>(json);
            OpenCage.Result result = data.results.First();

            string msg = $"{decimal.Round(location.Coordinates.Item1, 7)}, {decimal.Round(location.Coordinates.Item2, 7)} - {result.components.state}, {result.components.country}";
            return msg;
        }
        public static async Task<string> LocationDetails(string ipaddress)
        {
            Location location = await GrabLocation(ipaddress);
            HttpClient client = new HttpClient();

            Uri URI = new Uri($"https://api.opencagedata.com/geocode/v1/json?key=3fc9b2bf7cef45c7b333d912f0ebcff4&q={location.Coordinates.Item1}%2C+{location.Coordinates.Item2}&pretty=1&no_annotations=1");

            string json = await client.GetStringAsync(URI);

            OpenCage.Root data = JsonConvert.DeserializeObject<OpenCage.Root>(json);
            OpenCage.Result result = data.results.First();

            string msg = $"{decimal.Round(location.Coordinates.Item1, 7)}, {decimal.Round(location.Coordinates.Item2, 7)} - {result.components.state}, {result.components.country}";
            return msg;
        }
        public static async Task<string> LocationDetails(decimal lat, decimal lng)
        {
            Location location = GrabLocation(lat, lng);
            HttpClient client = new HttpClient();

            Uri URI = new Uri($"https://api.opencagedata.com/geocode/v1/json?key=3fc9b2bf7cef45c7b333d912f0ebcff4&q={location.Coordinates.Item1}%2C+{location.Coordinates.Item2}&pretty=1&no_annotations=1");

            string json = await client.GetStringAsync(URI);

            OpenCage.Root data = JsonConvert.DeserializeObject<OpenCage.Root>(json);
            OpenCage.Result result = data.results.First();

            string msg = $"{decimal.Round(location.Coordinates.Item1, 7)}, {decimal.Round(location.Coordinates.Item2, 7)} - {result.components.state}, {result.components.country}";
            return msg;
        }

        public static void ClearPoints()
        {
            points = new Centroid();
            count = 0;
        }

        public static void SetPoints(decimal lat, decimal lng)
        {
            count++;
            switch (count)
            {
                case 1:
                    points.x1 = lat;
                    points.y1 = lng;
                    break;
                case 2:
                    points.x2 = lat;
                    points.y2 = lng;
                    break;
                case 3:
                    points.x3 = lat;
                    points.y3 = lng;
                    break;
            }
            
        }

        public static async Task<List<Location>> GrabManyFromJSONURL(string URL)
        {
            HttpClient client = new HttpClient();

            string json = await client.GetStringAsync(URL);

            List<string> data = JsonConvert.DeserializeObject<List<string>>(json);

            List<Location> dataToPass = new List<Location>();

            foreach (string d in data)
            {
                dataToPass.Add(await GrabLocation(d));
            }

            return dataToPass;
            
        }
        public static async Task<List<Location>> GrabManyFromJSONFile(string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                List<List<string>> data = JsonConvert.DeserializeObject<List<List<string>>>(json);

                List<Location> dataToPass = new List<Location>();

                Console.WriteLine("Loading JSON data...");

                foreach (List<string> d in data)
                {
                    try
                    {
                        dataToPass.Add(await GrabLocation(d.First()));
                    }
                    catch { }
                    
                }

                return dataToPass;
            }
        }

        public static List<string> RandomIPs(int count)
        {
            Random random = new Random();
            List<string> ipaddresses = new List<string>();

            if (count > 1)
            {
                Console.WriteLine($"Generating {count} Random IPs");
            }

            for (int i = 0; i < count; i++)
            {
                try
                {
                    string str = $"{random.Next(0, 255)}.{random.Next(0, 255)}.{random.Next(0, 255)}.{random.Next(0, 255)}";
                    GrabLocation(str).Wait();
                    ipaddresses.Add(str);
                } catch { i--; }
            }

            return ipaddresses;
        }

        public static (decimal, decimal) GetCenter()
        {
            return (points.latitude, points.longitude);
        }

        public static async Task<string> RandomIPAsync()
        {
            Random random = new Random();

            while (true)
            {
                try
                {
                    string ip =  $"{random.Next(0, 255)}.{random.Next(0, 255)}.{random.Next(0, 255)}.{random.Next(0, 255)}";
                    (decimal, decimal) coords = await CoordsFromIP(ip);
                    return ip;
                }
                catch { }
            }
            
        }
    }
}
