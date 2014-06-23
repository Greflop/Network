using System;

namespace Projet_2._0
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (Game1 game = Game1.GetGame())
            {
                game.Run();
            }
        }
    }
#endif
}

