using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using GamingConsoles.Models;
using GamingConsoles.Views;
using static System.Net.WebRequestMethods;

namespace GamingConsoles.Services
{
    internal static class GameConsolesServices
    {
        private static List<GameConsole> arcadeConsoles = new List<GameConsole>()
        {
            new()
            {
                SystemName = "  Dance Dance Revolution / Dancing Stage",
                IsSystemReleased = true,
                SystemReleaseState = "Released",
                SystemReleaseYearEurope = new DateOnly(1999,3,9),
                SystemReleaseYearAmerica = new DateOnly(1999,3,9),
                SystemReleaseYearJapan = new DateOnly(1998,9,26),
                SystemGeneralReleaseYear = new DateOnly(1998,9,26),
                SystemGeneralReleasePrice = 00,
                ReleasedBy = "Konami",
                SystemType = "Arcade System",
                UnitsSold = 0,
                MediaType = "Built in ROM",
                ControllerPorts = "Solo dancepad",
                CPU = "R3000A 32 bit RISC processor",
                CPUType = "Central Processing Unit",
                CPUSpeed = 33868800,
                RamSize = "2MB",
                GPURamSize = "2MB",                
                DoesHaveRom = true,
                DoesHaveRemovableStorage = false,
                VideoOutputResolutions = new[]{"256x224", "740x480" },
                VideoOutputTypes = new[]{"Built in monitor" },
                VideoOutputFrameRates = new[]{"60", "50" },
                TotalGamesReleasedWorldWide = 78,
                Top10GamesSoldWorldWide = new[]{"Dance Dance Revolution" },
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/8/82/NES-Console-Set.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/0/06/Nintendo-Famicom-Console-Set-FL.jpg"
                },
                HeroImage = "ddrlogo.png",
                Background = Color.FromArgb("#385D8F"),
                
            },
            //https://web.archive.org/web/20100206030743/http://system16.com/hardware.php?id=822
            new()
            {
                SystemName = "Donkey Kong",
                IsSystemReleased = true,
                SystemReleaseState = "Released",
                SystemReleaseYearEurope = new DateOnly(1981,11,1),
                SystemReleaseYearAmerica = new DateOnly(1981,7,31),
                SystemReleaseYearJapan = new DateOnly(1981,7,9),
                SystemGeneralReleaseYear = new DateOnly(1981,7,9),
                SystemGeneralLifespan = new DateOnly[] { new DateOnly(1981, 7, 9),new DateOnly (2013,1,4) },
                SystemGeneralDiscontinuedAt = new DateOnly(2013,1,4),
                SystemGeneralReleasePrice = 0,
                ReleasedBy = "Nintendo",
                SystemType = "Arcade System",
                UnitsSold = 158700000,
                MediaType = "Upright cabinet",
                ControllerPorts = "Single Player",
                CPU = "Zilog Z80",
                CPUType = "Central Processing Unit",
                CPUSpeed = 3072000,
                RamSize = "3KB",
                DoesHaveRom = true,
                ROMSize = "16KB",
                ROMType = "On board",
                APU = "MB8884   ",
                DoesHaveRemovableStorage = false,
                VideoOutputResolutions = new[]{"256 x 224" },
                VideoOutputTypes = new[]{"Built in monitor"},
                VideoOutputFrameRates = new[]{"60", "50" },
                TotalGamesReleasedWorldWide = 106,
                Top10GamesSoldWorldWide = new[]{"Donkey Kong" },
                Images = new()
                {
                    "https://flyers.arcade-museum.com/flyers_video/nintendo/22119301.jpg",
                    "https://flyers.arcade-museum.com/flyers_video/nintendo/22007202.jpg",
                    "https://www.pixelatedarcade.com/pictures/Game/78/picture_fb21-.jpg",
                    "https://www.pixelatedarcade.com/pictures/Game/78/picture_cd93-donkey-kong-at-magfest-in-2016.jpg"
                },
                HeroImage = "dklogo.png",
                Background = Color.FromArgb("#2B6641")
            },
        };
        private static List<GameConsole> handheldConsoles = new List<GameConsole>()
        {
            new()
            {
                SystemName = "Game Gear",
                IsSystemReleased = true,
                SystemReleaseState = "Released",
                SystemReleaseYearEurope = new DateOnly(1991,4,1),
                SystemReleaseYearAmerica = new DateOnly(1991,4,1),
                SystemReleaseYearJapan = new DateOnly(1990,10,6),
                SystemGeneralReleaseYear = new DateOnly(1991,4,1),
                SystemGeneralLifespan = new DateOnly[] { new DateOnly(1990, 10, 6),new DateOnly (1997,4,30) },
                SystemGeneralDiscontinuedAt = new DateOnly(1997,4,30),
                SystemGeneralReleasePrice = 149.99,
                ReleasedBy = "Sega",
                SystemType = "Handheld Console",
                UnitsSold = 10620000,
                MediaType = "Cartridge",
                ControllerPorts = "One integrated controller, no additional controller ports",
                CPU = "Zilog Z80",
                CPUType = "Central Processing Unit",
                CPUSpeed = 3500000,
                RamSize = "8KB",
                GPURamSize = "16KB",
                GPUSpeed = 1474560000,
                DoesHaveRom = false,
                DoesHaveRemovableStorage = false,
                VideoOutputResolutions = new[]{"160 x 144" },
                VideoOutputTypes = new[]{"Does not output video to an external device."},
                VideoOutputFrameRates = new[]{"60"},
                TotalGamesReleasedWorldWide = 366,
                Top10GamesSoldWorldWide = new[]{"Sonic the Hedgehog",
                    "Sonic the Hedgehog 2",
                    "Mortal Kombat",
                    "Streets of Rage",
                    "Shinobi II: The Silent Fury",
                    "Columns",
                    "Castle of Illusion Starring Mickey Mouse",
                    "Sonic Chaos",
                    "The Lion King",
                    "Batman Returns" },
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cf/Sega-Game-Gear-WB.png/1024px-Sega-Game-Gear-WB.png",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/1/11/Sega-Game-Gear-wTv-Tuner.jpg/800px-Sega-Game-Gear-wTv-Tuner.jpg"
                },
                HeroImage = "sgg.png",
                Background = Color.FromArgb("#385D8F")

            },
            new()
            {
                SystemName = "Brick Game",
                IsSystemReleased = true,
                SystemReleaseState = "Released",
                SystemReleaseYearEurope = new DateOnly(1990,1,1),
                SystemReleaseYearAmerica = new DateOnly(1990,1,1),
                SystemReleaseYearJapan = new DateOnly(1990,1,1),
                SystemGeneralReleaseYear = new DateOnly(1990,1,1),
                SystemGeneralLifespan = new DateOnly[] { new DateOnly(1990, 10, 6),new DateOnly (2023,12,31) },
                SystemGeneralDiscontinuedAt = new DateOnly(2023,12,31),
                SystemGeneralReleasePrice = 0,
                ReleasedBy = "Unknown",
                SystemType = "Handheld Console",
                UnitsSold = 0,
                MediaType = "None",
                ControllerPorts = "One integrated controller, no additional controller ports",
                CPU = "Unknown/Varies",
                CPUType = "SOC - System on a Chip",
                CPUSpeed = 0,
                RamSize = "Unknown",
                GPURamSize = "Unknown",
                GPUSpeed = 0,
                DoesHaveRom = false,
                DoesHaveRemovableStorage = false,
                VideoOutputResolutions = new[]{"10 x 20 + custom shapes" },
                VideoOutputTypes = new[]{"Does not output video to an external device."},
                VideoOutputFrameRates = new[]{"60"},
                TotalGamesReleasedWorldWide = 0,
                Top10GamesSoldWorldWide = new[]{"Other than Tetris, none, all games are internal and vary from system to system", },
                Images = new()
                {
                    "https://static.wikia.nocookie.net/retroconsoles/images/1/1e/Brick_game.jpg/revision/latest?cb=20130529142328",
                    "https://image.made-in-china.com/43f34j00waEQdHTRqtnb/Brick-Game-Player-CD-9999-.webp"
                },
                HeroImage = "brick.png",
                Background = Color.FromArgb("#467893")
            },
        };
        

        private static List<GameConsole> cloudConsoles = new List<GameConsole>()
        {
            new(){} 
        };

        private static List<GameConsole> homeConsoles = new List<GameConsole>()
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
                SystemName = "PlayStation 2",
                IsSystemReleased = true,
                SystemReleaseState = "Released",
                SystemReleaseYearEurope = new DateOnly(2000,11,24),
                SystemReleaseYearAmerica = new DateOnly(2000,10,26),
                SystemReleaseYearJapan = new DateOnly(2000,3,4),
                SystemGeneralReleaseYear = new DateOnly(2004,1,1),
                SystemGeneralLifespan = new DateOnly[] { new DateOnly(2000, 3, 4),new DateOnly (2013,1,4) },
                SystemGeneralDiscontinuedAt = new DateOnly(2013,1,4),
                SystemGeneralReleasePrice = 299,
                ReleasedBy = "Sony",
                SystemType = "Home Console",
                UnitsSold = 158700000,
                MediaType = "DVD, CD-ROM",
                ControllerPorts = "2 controller ports, but expandable to 4 with external addon.",
                CPU = "MIPS R5900 Emotion Engine",
                CPUType = "Central Processing Unit",
                CPUSpeed = 2990000000,
                RamSize = "32MB",
                GPURamSize = "4MB",
                GPUSpeed = 1474560000,
                DoesHaveRom = true,
                ROMSize = "40GB",
                ROMType = "Internal HDD for PS2 fat models only.",
                DoesHaveRemovableStorage = true,
                RemovableStorageType = "Memory Card",
                RemovableStorageSize = "8MB",
                VideoOutputResolutions = new[]{"512 x 224","512 x 448","640 x 448","640 x 480" },
                VideoOutputTypes = new[]{"Composite","Scart","VGA","Component"},
                VideoOutputFrameRates = new[]{"60", "50" },
                TotalGamesReleasedWorldWide = 4218,
                Top10GamesSoldWorldWide = new[]{"Grand Theft Auto: San Andreas",
                    "Gran Turismo 3: A-Spec",
                    "Gran Turismo 4",
                    "Grand Theft Auto: Vice City",
                    "Final Fantasy X",
                    "Grand Theft Auto III",
                    "Metal Gear Solid 2: Sons of Liberty",
                    "Tekken 5",
                    "Final Fantasy XII",
                    "Kingdom Hearts" },
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1c/PS2-Versions.jpg/1024px-PS2-Versions.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b5/Sony-PlayStation-2-70001-Console-BR.jpg/1024px-Sony-PlayStation-2-70001-Console-BR.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7f/DualShock_2.jpg/1024px-DualShock_2.jpg"
                },
                HeroImage = "ps2fat.png",
                Background = Color.FromArgb("#253633")
            } 
        };

        private static List<GameConsole> vrConsoles = new List<GameConsole>()
        {
            new(){} 
        };
        //public static List<GameConsole> GetFeaturePlanets()
        //{
        //    var random = new Random();
        //    var randomizedconsoles = gameconsoles.OrderBy(item => random.Next());
        //    return randomizedconsoles.Take(2).ToList();
        //}


        //public static List<GameConsole> GetAllConsoles() => gameConsoles;
        public static List<GameConsole> GetArcadeConsoles() => arcadeConsoles;
        public static List<GameConsole> GetCloudConsoles() => cloudConsoles;
        public static List<GameConsole> GetHandheldConsoles() => handheldConsoles;
        public static List<GameConsole> GetHomeConsoles() => homeConsoles;
        public static List<GameConsole> GetVRConsoles() => vrConsoles;
        //public static List<GameConsole> GetConsolesByCategory(string category)
        //{
        //    //var random = new Random();
        //    //var randomizedPlanets = planets.OrderBy(item => random.Next());
        //    //return randomizedPlanets.Take(2).ToList();

        //    //var selectedConsoles = new List<GameConsole>();
        //    var consolesFromCategory = new List<GameConsole>();
        //    foreach (var console in gameConsoles)
        //    {
        //        if (console.SystemType == category)
        //        {
        //            consolesFromCategory.Add(console);
        //        }
        //    }
        //    return consolesFromCategory;
        //}
    }
}