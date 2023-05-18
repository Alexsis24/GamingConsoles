using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamingConsoles.Models;

namespace GamingConsoles.Services
{
    internal static class ConsoleSelectionServices
    {
        private static List<Console> consoles = new()
        {
            if (true)
                {

	            }
        }

        public static List<Console> GetHomeConsoles()
        {            
            var HomeConsoles = consoles.Select(SystemType == "HomeConsole");

            return HomeConsoles();
        }
    }
}
