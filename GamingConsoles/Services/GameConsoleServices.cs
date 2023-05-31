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
                Background = Color.FromArgb("#2B6641")
            },
        };
        

        private static List<GameConsole> cloudConsoles = new List<GameConsole>()
        {
			new()
			{
				SystemName = "Stadia",
				IsSystemReleased = true,
				SystemReleaseState = "Closed",
				SystemReleaseYearEurope = new DateOnly(2019,11,19),
				SystemReleaseYearAmerica = new DateOnly(2019,11,19),
				SystemReleaseYearJapan = new DateOnly(2019, 11, 19),
				SystemGeneralReleaseYear = new DateOnly(2019,11,19),
				SystemGeneralLifespan = new DateOnly[] { new DateOnly(2019, 11, 19),new DateOnly (2023, 01, 18) },
				SystemGeneralDiscontinuedAt = new DateOnly(2023, 01, 18),
				SystemGeneralReleasePrice = 10,
				ReleasedBy = "Google",
				SystemType = "Cloud gaming service",
				UnitsSold = 750000,
				MediaType = "Cloud",
				CPU = "Intel x86",
				CPUType = "Central Processing Unit",
				CPUSpeed = 2700000000,
				RamSize = "16GB",
				GPURamSize = "8GB",
				GPUSpeed = 1471000000,
				DoesHaveRom = true,
				ROMSize = "Unspecified",
				ROMType = "SSD",
				VideoOutputResolutions = new[]{"10 Mbit/s 720p","20 Mbit/s 1080p","35 Mbit/s 4k"},
				VideoOutputTypes = new[]{"via streaming to user's device"},
				VideoOutputFrameRates = new[]{"60"},
				TotalGamesReleasedWorldWide = 278,
				Top10GamesSoldWorldWide = new[]{"PUBG: Battlegrounds",
					"Red Dead Redeption 2",
					"Terraria",
					"Human Fall Flat",
					"FIFA 21",
					"Far Cry 5",
					"Ark: Survive Evolved",
					"Elder Scrolls Online",
					"Cyberpunk 2077",
					"Assassin's Creed Valhalla" },
				Images = new()
				{
					"https://en.wikipedia.org/wiki/Google_Stadia#/media/File:Google_Stadia_Cloud_gaming_(48605754611).jpg"
				},
				HeroImage = "stadia.png",
				Background = Color.FromArgb("#385D8F")
			},

			new()
			{
				SystemName = "GeForce Now",
				IsSystemReleased = true,
				SystemReleaseState = "Full Release",
				SystemReleaseYearEurope = new DateOnly(2015,10,01),
				SystemReleaseYearAmerica = new DateOnly(2015,10,01),
				SystemReleaseYearJapan = new DateOnly(2015,10,01),
				SystemGeneralReleaseYear = new DateOnly(2020,02,04),
				SystemGeneralReleasePrice = 9.99,
				ReleasedBy = "Nvidia",
				SystemType = "Cloud gaming service",
				UnitsSold = 25000000,
				MediaType = "Cloud",
				CPU = "x86",
				CPUType = "Central Processing Unit",
				CPUSpeed = 4000000000,
				RamSize = "Unspecified",
				GPURamSize = "Unspedified",
				GPUSpeed = 1440000000,
				DoesHaveRom = true,
				ROMSize = "Unspecified",
				ROMType = "Unspedified",
				VideoOutputResolutions = new[]{"45 Mbit/s 4k"},
				VideoOutputTypes = new[]{"via streaming to user's device"},
				VideoOutputFrameRates = new[]{"60", "120"},
				TotalGamesReleasedWorldWide = 1675,
				Top10GamesSoldWorldWide = new[]{"Cyberpunk 2077",
					"Assassin's Creed Valhalla",
					"Mass Effect Legendary Edition",
					"Ready or Not",
					"Project Zomboid",
					"Dying Light 2 Stay Human",
					"Divinity: Originl Sin 2 - Definitve Edition",
					"Total War: WARHAMMER III",
					"Baldur's Gate 3",
					"Disco Elysium - The Final Cut" },
				Images = new()
				{
					"https://en.wikipedia.org/wiki/Google_Stadia#/media/File:Google_Stadia_Cloud_gaming_(48605754611).jpg"
				},
				HeroImage = "geforcenow.png",
				Background = Color.FromArgb("#2B6641")
			}
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
                Background = Color.FromArgb("#2B6641")
            } 
        };

        private static List<GameConsole> vrConsoles = new List<GameConsole>()
        {
            new()
            {
				SystemName = "Valve Index",
				IsSystemReleased = true,
				SystemReleaseState = "Released",
				SystemReleaseYearEurope = new DateOnly(2019,06,28),
				SystemReleaseYearAmerica = new DateOnly(2019,06,28),
				SystemReleaseYearJapan = new DateOnly(2019,06,28),
				SystemGeneralReleaseYear = new DateOnly(2019,06,28),
				SystemGeneralReleasePrice = 999,
				ReleasedBy = "Valve",
				SystemType = "Virtual reality headset",
				UnitsSold = 149000,
				ControllerPorts = "Valve Index Controllers, Supports HTC Vive and Vive Pro Controllers and HTC Vive and Vive Pro Base Stations",
				DoesHaveRom = false,
				DoesHaveRemovableStorage = false,
				VideoOutputResolutions = new[]{ "1440×1600" },
				VideoOutputTypes = new[]{"Composite","Scart","VGA","Component"},
				VideoOutputFrameRates = new[]{"80", "90", "120", "144" },
				TotalGamesReleasedWorldWide = 6120,
				Top10GamesSoldWorldWide = new[]{"Half-life: Alyx",
					"Beat saber",
					"Tetris Effect: Connected",
					"No Man's Sky VR",
					"VRChat",
					"Pistol Whip",
					"The Walking Dead: Saints & Sinners",
					"Superhot VR",
					"Blade and sorcery",
					"BONEWORKS" },
				Images = new()
				{
					"https://store.akamai.steamstatic.com/public/images/valveindex/valveindexheadset.png"
				},
				HeroImage = "steamindex.png",
				Background = Color.FromArgb("#385D8F")
			},

			new()
			{
				SystemName = "Oculus Quest 2",
				IsSystemReleased = true,
				SystemReleaseState = "Released",
				SystemReleaseYearEurope = new DateOnly(2020,10,13),
				SystemReleaseYearAmerica = new DateOnly(2020,10,13),
				SystemReleaseYearJapan = new DateOnly(2020,10,13),
				SystemGeneralReleaseYear = new DateOnly(2020,10,13),
				SystemGeneralReleasePrice = 399,
				ReleasedBy = "Reality Labs",
				SystemType = "Virtual reality headset",
				UnitsSold = 149000,
				ControllerPorts = "6DOF inside-out tracking through 4 built-in cameras and 2 controllers with accelerometers and gyroscopes",
				CPU = "Qualcomm Snapdragon XR2",
				CPUType = "Central Processing Unit",
				CPUSpeed = 2800000000,
				RamSize = "6GB LPDDR4X",
				DoesHaveRom = true,
				ROMSize = "256GB, 128GB, 64GB",
				ROMType = "Internal SSD",
				DoesHaveRemovableStorage = false,
				VideoOutputResolutions = new[]{ "1832x1920" },
				VideoOutputTypes = new[]{"USB-C", "Bluetooth 5", "Wi-Fi 6"},
				VideoOutputFrameRates = new[]{"72 - 120" },
				TotalGamesReleasedWorldWide = 266,
				Top10GamesSoldWorldWide = new[]{"Blade & Sorcery: Nomad",
					"Beat saber",
					"Among Us VR",
					"BONELAB",
					"Job Simulator",
					"Breachers",
					"Creed: Rise to Glory - Championship Edition",
					"Contractors",
					"TOTALLY BASEBALL",
					"SUPERHOT VR" },
				Images = new()
				{

					"https://scontent-hel3-1.xx.fbcdn.net/v/t39.8562-6/309429762_776284740263249_6847651965892883211_n.jpg?_nc_cat=111&ccb=1-7&_nc_sid=6825c5&_nc_ohc=PvTv1Ga8MiQAX9B4oBi&_nc_ht=scontent-hel3-1.xx&oh=00_AfAwGPew0v-JbjBFz2pinj0FURlx5ohMeKjdkRGC0E_1Kg&oe=6473CE92",
					"https://scontent-hel3-1.xx.fbcdn.net/v/t39.8562-6/275180934_5027591173967795_4509175604745275242_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=6825c5&_nc_ohc=VZIYdqD90nsAX9JtTBE&_nc_ht=scontent-hel3-1.xx&oh=00_AfAg85QkPRyaaiOOJARSg5al2p1uRjMyR75jHuHx8aCdug&oe=64734568",
					"https://scontent-hel3-1.xx.fbcdn.net/v/t39.8562-6/265586575_1723982231124599_7882970043049940222_n.png?_nc_cat=106&ccb=1-7&_nc_sid=6825c5&_nc_ohc=m_njdh9iPTcAX9il9Ew&_nc_ht=scontent-hel3-1.xx&oh=00_AfCJ7vqyOfo-mcfEJ6LyeNAldvTZwvZ9bA7fjH485cT5nQ&oe=64742199"

				},
				HeroImage = "oculusquesttwo.png",
				Background = Color.FromArgb("#2B6641")
			}
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