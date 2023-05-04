using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamingConsoles.Models;

namespace GamingConsoles.Services
{
    internal static class GameConsolesServices
    {
        private static List<GameConsole> consoles = new List<GameConsole>()
        {
            new()
            {
                SystemName = "Nintendo Entertainment System",
                IsSystemReleased = true,
                SystemReleaseState = "Released",
                SystemReleaseYearEurope = new DateOnly(1986,9,1),
                SystemReleaseYearAmerica = new DateOnly(1985,10,18),
                SystemReleaseYearJapan = new DateOnly(1983,7,15),
                SystemGeneralReleaseYear = new DateOnly(1983,7,15),
                SystemGeneralLifespan = new DateOnly[] { new DateOnly(1983, 7, 15),new DateOnly (2003,1,1) }
            },
        };
    }
}
