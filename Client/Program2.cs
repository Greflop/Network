using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    class Program2
    {
        static void Main()
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
