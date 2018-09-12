using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace LearnPrograms
{
    class NetClass
    {
        public bool ValidateIPAdress(string pIpAdress)
        {
            if (IPAddress.TryParse(pIpAdress, out IPAddress ipAddress))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNetworkLikelyAvailable()
        {
            return System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces().Any(x => x.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up);
        }

        public string GetHostName(string ipAddress)
        {
            try
            {
                IPHostEntry entry = Dns.GetHostEntry(ipAddress);
                if (entry != null)
                {
                    return entry.HostName;
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

        public long PingRoundTime(string nameOrAddress)
        {            
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
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
