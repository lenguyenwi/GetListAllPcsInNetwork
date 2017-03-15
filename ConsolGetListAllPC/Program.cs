using System;
using System.Collections;

namespace ConsolGetListAllPC
{
    class Program
    {
        private static NetworkBrowser nwB;

        static void Main(string[] args)
        {
            nwB = new NetworkBrowser();
            ArrayList networkComputers = new ArrayList();
            networkComputers = nwB.getNetworkComputers();
            //nwB.getNetworkComputers();

            foreach (string networkcomputer in networkComputers)
            {
                Console.WriteLine(networkcomputer);
            }
            Console.ReadLine();

        }
        public static void getMyComIpAdress()
        {
            string computerName = System.Net.Dns.GetHostName();
            System.Net.IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(computerName);
            System.Net.IPAddress[] ipAddress = ipEntry.AddressList;

            computerName = computerName + "|" + ipAddress[0].ToString();
            Console.WriteLine(computerName);
            Console.ReadLine();
        }
        public static void getListComputer()
        {

        }

     
    }
}
