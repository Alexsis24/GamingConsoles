using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using GamingConsoles.Models;

namespace GamingConsoles.Services
{
    internal static class GameConsolesServices
    {
        private static List<GameConsole> gameconsoles = new List<GameConsole>()
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
                SystemGeneralLifespan = new DateOnly[] { new DateOnly(1983, 7, 15),new DateOnly (2003,1,1) },
                SystemGeneralDiscontinuedAt = new DateOnly(2003,1,1),
                SystemGeneralReleasePrice = 14800,
                ReleasedBy = "Nintendo",
                SystemType = "Home Console",
                UnitsSold = 61910000,
                MediaType = "Cartridge",
                ControllerPorts = "2 controller ports, but expandable to 4 with external addon.",
                CPU = "Ricoh 2A03/2A07",
                CPUType = "Microprocessor",
                CPUSpeed = 17900000,
                RamSize = "2KB",
                GPURamSize = "2KB",
                DoesHaveRom = false,
                DoesHaveRemovableStorage = false,
                VideoOutputResolutions = new[]{"256 x 224","256 x 240" },
                VideoOutputTypes = new[]{"RF","Composite" },
                VideoOutputFrameRates = new[]{"60", "50" },
                TotalGamesReleasedWorldWide = 716,
                Top10GamesSoldWorldWide = new[]{"Super Mario Bros.","Duck Hunt","Super Mario Bros. 3","Tetris","Super Mario Bros. 2 (International Version)","The Legend of Zelda","Dr.Mario","Zelda II: The Adventure of Link","Excitebike","Golf7" },
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/8/82/NES-Console-Set.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/0/06/Nintendo-Famicom-Console-Set-FL.jpg"
                },
                HeroImage = "nes.png",
                Background = Color.FromArgb("#385D8F")
            },

            new()
            {
                SystemName = "Nintendo Entertainment System",
                IsSystemReleased = true,
                SystemReleaseState = "Released",
                SystemReleaseYearEurope = new DateOnly(1986,9,1),
                SystemReleaseYearAmerica = new DateOnly(1985,10,18),
                SystemReleaseYearJapan = new DateOnly(1983,7,15),
                SystemGeneralReleaseYear = new DateOnly(1983,7,15),
                SystemGeneralLifespan = new DateOnly[] { new DateOnly(1983, 7, 15),new DateOnly (2003,1,1) },
                SystemGeneralDiscontinuedAt = new DateOnly(2003,1,1),
                SystemGeneralReleasePrice = 14800,
                ReleasedBy = "Nintendo",
                SystemType = "Home Console",
                UnitsSold = 61910000,
                MediaType = "Cartridge",
                ControllerPorts = "2 controller ports, but expandable to 4 with external addon.",
                CPU = "Ricoh 2A03/2A07",
                CPUType = "Microprocessor",
                CPUSpeed = 17900000,
                RamSize = "2KB",
                GPURamSize = "2KB",
                DoesHaveRom = false,
                DoesHaveRemovableStorage = false,
                VideoOutputResolutions = new[]{"256 x 224","256 x 240" },
                VideoOutputTypes = new[]{"RF","Composite" },
                VideoOutputFrameRates = new[]{"60", "50" },
                TotalGamesReleasedWorldWide = 716,
                Top10GamesSoldWorldWide = new[]{"Super Mario Bros.","Duck Hunt","Super Mario Bros. 3","Tetris","Super Mario Bros. 2 (International Version)","The Legend of Zelda","Dr.Mario","Zelda II: The Adventure of Link","Excitebike","Golf7" },
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/8/82/NES-Console-Set.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/0/06/Nintendo-Famicom-Console-Set-FL.jpg"
                },
                HeroImage = "nes.png",
                Background = Color.FromArgb("#2B6641")
            },
        };
        public static List<GameConsole> Category_SelectionPicked()
        {
            var random = new Random();
            var randomizedconsoles = gameconsoles.OrderBy(item => random.Next());
            return randomizedconsoles.Take(2).ToList();
        }

        public static List<GameConsole> GetAllPlanets()
            => gameconsoles;
    }
}