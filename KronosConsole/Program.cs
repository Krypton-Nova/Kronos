﻿using System.Threading.Tasks;
using KronosConsole.Repo;
using KronosConsole.UI;

namespace KronosConsole
{
    internal static class Program
    {
        private static async Task Main(string[] args)
        {
            // Greeting
            UIConsole.Show("Kronos, at your service.\n");

            var unusedUserAgent = Shared.UserAgent;

            // Run until Quit command is given.
            while (true)
            {
                // Pass initial options to Program, or request user input
                var commands = UIConsole.UserCommandInput(args);

                // Run commands sequentially
                foreach (var command in commands) await command.Run();

                // Reset initial options
                args = new string[0];
            }
        }
    }
}