using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    public class Program2
    {
        public static void Mainq()
        {
            Client client = new Client();
            while (!client.Connected)
            {
                Console.Write("Server IP Adress : ");
                string ip = Console.ReadLine();
                Console.Write("Port : ");
                int port = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your name : ");
                client.Connect(ip, port, Console.ReadLine());
                Console.WriteLine();
            }
            client.Run();
        }
    }
}
