using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kcaspher.NETWORK;
using Projet_2._0;

namespace zbra
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server(4242);
            server.Run();
        }
    }
}
