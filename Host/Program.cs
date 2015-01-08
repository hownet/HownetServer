using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
namespace Host
{
    class Program
    {

        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Host.Service)))
            {
                host.Open();
                Console.WriteLine("Host is started!!! Press any ENTER to stop.");
                Console.ReadLine();
                host.Close();
            }
        }

    }
}
