using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.IO;

namespace LearnPrograms
{
    class NetClass
    {       
        /// <summary>
        /// Validate IP Adress
        /// </summary>
        /// <returns>True if IP is valid, false is isn't.</returns>
        /// <remarks>Checks that an IP address is valid.</remarks>
        /// <param name="pIpAddress">Ip Address</param>
        public bool ValidateIPAdress(string pIpAddress)
        {
            if (IPAddress.TryParse(pIpAddress, out IPAddress ipAddress))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Checks network availability.
        /// </summary>
        /// <returns>Is network likely available: true or false</returns>
        /// <remarks> Gives back true if network is available, false when it isn't.
        /// </remarks>        
        public bool IsNetworkLikelyAvailable()
        {
            //FIXME: Program futás közben kihúzott hálókábellel is azt írja, hogy van kapcsolat.
            return System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces().Any(x => x.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up);
        }

        /// <summary>
        /// Gets the host name of an IP address
        /// </summary>
        /// <returns>Host name of an IP address</returns>
        /// <param name="ipAddress">Host IP address</param>
        /// <exception cref="SocketException">Thrown when unknown host or, not every IP has a name.</exception>
        public string GetHostName(string ipAddress)
        {
            try
            {
                IPHostEntry entry = Dns.GetHostEntry(ipAddress);
                if (entry != null)
                {
                    return entry.HostName;
                }
                else
                {
                    return "Can't get host name.";
                }
            }
            catch (SocketException ex)
            {
                //unknown host or
                //not every IP has a name
                //log exception (manage it)
                Console.WriteLine("Exception" + ex);
            }

            return null;
        }

        /// <summary>
        /// Gets local IP adsresses
        /// </summary>
        /// <returns>List of local IP addresses</returns>
        public List<string> GetLocalIPAddress()
        {
            List<string> ipaddresses = new List<string>();

            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipaddresses.Add(ip.ToString());
                }
            }
            return ipaddresses;            
        }

        /// <summary>
        /// Gets public internet ip address
        /// </summary>
        /// <remarks>It uses http://checkip.dyndns.org/ to get IP address.</remarks>
        /// <returns>Public IP address</returns>
        public string GetPublicIP()
        {
            string direction;
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            WebResponse response = request.GetResponse();
            StreamReader stream = new StreamReader(response.GetResponseStream());
            direction = stream.ReadToEnd();
            stream.Close();
            response.Close(); //Search for the ip in the html
            int first = direction.IndexOf("Address: ") + 9;
            int last = direction.LastIndexOf("</body>");
            direction = direction.Substring(first, last - first);
            return direction;
        }

        /// <summary>
        /// Gets IP address of a Host name
        /// </summary>
        /// <returns>IP address of hostname</returns>
        /// <param name="host">Host Name</param>
        public string GetHostNameIP(string host)
        {
            IPHostEntry hostEntry;

            hostEntry = Dns.GetHostEntry(host);

            //you might get more than one ip for a hostname since 
            //DNS supports more than one record

            if (hostEntry.AddressList.Length > 0)
            {
                IPAddress ip = hostEntry.AddressList[0];
                return ip.ToString();
            }
            else
            {
                return "Can't resolve IP from Hostname.";
            }
        }


        /// <summary>
        /// Gets Ping round time
        /// </summary>
        /// <returns>Returns the ping round time.</returns>
        /// <param name="nameOrAddress">Host Name or IP address</param>
        public long PingRoundTime(string nameOrAddress)
        {            
            Ping pinger = null;
            int timeout = 1000, ttl = 127;
            string data = "[012345678901234567890123456789]";
            byte[] Buffer = Encoding.ASCII.GetBytes(data);
            PingOptions pingOpts = new PingOptions
            {
                Ttl = ttl,
                DontFragment = true
            };

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress, timeout, Buffer, pingOpts);
                return reply.RoundtripTime;
            }
            catch (PingException)
            {
                return 0;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }
        }


        /// <summary>
        /// Returns that an IP or Hostname is pingable.
        /// </summary>
        /// <returns>Returns that an IP or Hostname is pingable: True or false</returns>
        /// <param name="nameOrAddress">Host Name or IP address</param>
        public bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }



    }
}
