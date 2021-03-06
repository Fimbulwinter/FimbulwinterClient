using System;
using FimbulwinterClient.Core;

namespace FimbulwinterClient
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            ROClient game = new ROClient();
            game.Run();
            SharedInformation.Config.Save();
        }
    }
#endif
}

