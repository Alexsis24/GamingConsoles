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
    public static class GameConsolesServices
    {
        private static List<GameConsole> arcadeConsoles = new List<GameConsole>()
        {
            new()
            {
                SystemName = "Dance Dance Revolution",
                AlternativeNames = new[] {"DDR", "Dancing Stage" },
                IsSystemReleased = true,
                SystemReleaseState = "Released",
                SystemReleaseYearEurope = new DateOnly(1999,3,9),
                SystemReleaseYearAmerica = new DateOnly(1999,3,9),
                SystemReleaseYearJapan = new DateOnly(1998,9,26),
                SystemGeneralReleaseYear = new DateOnly(1998,9,26),
                SystemGeneralReleasePrice = 00,
                SystemGeneralDiscontinuedAt = new DateOnly(2015,9,10),
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
                    "https://upload.wikimedia.org/wikipedia/en/b/b4/DDR_1stMIX_flyer.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/1/17/DDR_Extreme.png/749px-DDR_Extreme.png",
                    "https://upload.wikimedia.org/wikipedia/commons/e/e5/Dance_Dance_Revolution_Solo_2000_arcade_machine.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/6/62/Stemania4_Alpha4.png"
                },
                HeroImage = "ddrlogo.png",
                Background = Color.FromArgb("#385D8F"),
                Background2 = Color.FromArgb("#649CC4"),
                AboutText = "Dance Dance Revolution (ダンスダンスレボリューション, Dansu Dansu Reboryūshon) (DDR) is a music video game series produced by Konami. Introduced in Japan in 1998 as part of the Bemani series, and released in North America and Europe in 1999, Dance Dance Revolution is the pioneering series of the rhythm and dance genre in video games. Players stand on a \"dance platform\" or stage and hit colored arrows laid out in a cross with their feet to musical and visual cues. Players are judged by how well they time their dance to the patterns presented to them and are allowed to choose more music to play to if they receive a passing score.\r\n\r\nDance Dance Revolution has been met with critical acclaim for its originality and stamina in the video game market, as well as popularizing the use of videogames as a medium for fitness and exercise. There have been dozens of arcade-based releases across several countries and hundreds of home video game console releases, promoting a music library of original songs produced by Konami's in-house artists and an eclectic set of licensed music from many different genres. The game is also known for its passionate fanbase, as well as its growing competitive tournament scene. The DDR series has also inspired similar games such as Pump it Up by Andamiro and In the Groove by Roxor Games.\r\n\r\nThe series' current arcade version is Dance Dance Revolution A3, released on March 17, 2022."

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
                Background = Color.FromArgb("#2B6641"),
                Background2 = Color.FromArgb("#55A348"),
                AboutText = "Donkey Kong[c] is a 1981 arcade video game developed and published by Nintendo. As Jumpman, the player runs and jumps on platforms and climbs ladders to ascend a construction site and rescue Pauline from the titular giant gorilla. It is the first game in the Donkey Kong series as well as Mario's first appearance in a video game.\r\n\r\nDonkey Kong is the product of Nintendo's efforts to develop a hit to rival Pac-Man (1980) and break into the North American market. Hiroshi Yamauchi, Nintendo's president at the time, assigned the project to first-time video game designer Shigeru Miyamoto. Drawing from inspirations including Beauty and the Beast as well as 1930s American classics such as Popeye and King Kong, Miyamoto developed the scenario and designed the game alongside chief engineer Gunpei Yokoi. They broke new ground by using graphics as a means of characterization, including cutscenes to advance the game's plot and integrating multiple stages into the gameplay.\r\n\r\nAlthough Nintendo's American staff was initially apprehensive, Donkey Kong succeeded commercially and critically in Japan and North America, where it became the highest-grossing 1981 and 1982, respectively. It was ported to the Game & Watch, selling 8 million units, while Nintendo licensed the game to Coleco, a developer of arcade conversions for home consoles, selling 6 million cartridges; the game's various ports sold more than 15 million units worldwide. Other companies cloned the game and avoided royalties altogether. Miyamoto's characters were mass marketed in multitudes of products, including breakfast cereal, toys, and television cartoons. Universal City Studios filed a lawsuit alleging Donkey Kong violated its trademark of King Kong, ultimately failing.\r\n\r\nThe success of Donkey Kong positioned the company for market dominance from 1981 through the late 1990s. The game debuts Mario, who became Nintendo's mascot and one of the world's most recognizable characters. Donkey Kong pioneered the platform game genre before the term existed, is one of the most important games from the golden age of arcade video games, and one of the most popular arcade games of all time."
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
                Background = Color.FromArgb("#385D8F"),
                Background2 = Color.FromArgb("#649CC4"),
                AboutText = "The Game Gear[a] is an 8-bit fourth generation handheld game console released by Sega on October 6, 1990, in Japan, in April 1991 throughout North America and Europe, and during 1992 in Australia. The Game Gear primarily competed with Nintendo's Game Boy, the Atari Lynx, and NEC's TurboExpress. It shares much of its hardware with the Master System, and can play Master System games through the use of an adapter. Sega positioned the Game Gear, which had a full-color backlit screen with a landscape format, as a technologically superior handheld to the Game Boy.\r\n\r\nThough the Game Gear was rushed to market, its unique game library and price point gave it an edge over the Atari Lynx and TurboExpress. However, due to its short battery life, lack of original games, and weak support from Sega, the Game Gear was unable to surpass the Game Boy, selling 10.62 million units by March 1996. The Game Gear was discontinued in 1997. It was re-released as a budget system by Majesco Entertainment in 2000, under license from Sega.\r\n\r\nReception of the Game Gear was mixed, with praise for its full-color backlit screen and processing power for its time, criticisms over its large size and short battery life, and questions over the quality of its game library."
            },
            new()
            {
                SystemName = "Brick Game",
                AlternativeNames = new[] {"Super Mouse", "Lucky Rabbit"},
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
                Background = Color.FromArgb("#2B6641"),
                Background2 = Color.FromArgb("#55A348"),
                AboutText = "The Brick Game is a dedicated handheld game console popular in the early 1990s. Introduced in China, it was originally intended as a clone variant of the original Tetris that dates back to 1984-1985 in the former Soviet Union which is developed by Russian programmer Alexey Pazhitnov for the Soviet ELEKTRONIKA-60 home computer system."
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
				Background = Color.FromArgb("#385D8F"),
                Background2 = Color.FromArgb("#649CC4"),
                AboutText = "Stadia was a cloud gaming service developed and operated by Google. Known in development as Project Stream, the service debuted through a closed beta in October 2018, and publicly launched in November 2019. The service was to compete with Sony's PlayStation Plus cloud streaming, Nvidia's GeForce Now, Amazon's Luna, and Microsoft's Xbox Cloud Gaming. Stadia initially received a mixed reception from reviewers, with most criticism directed at its limited library of games and lack of promised features. Google had initially intended to develop in-house games in addition to hosting games produced by third parties, but abandoned this plan in February 2021, shutting down its studios. The service continued to sell third party games, and Google offered the game-streaming technology as a white-label product. Google announced in September 2022 that it would be shutting down Stadia; the service went offline permanently on January 18, 2023, at 11:59 PM PST.[1]\r\n\r\nStadia was accessible through Chromecast Ultra and Android TV devices, on personal computers via the Google Chrome web browser and other Chromium-based browsers, Chromebooks and tablets running ChromeOS,[2] and the Stadia mobile app on supported Android devices[3] as long as the latest version of the Chrome browser and the latest version of the Stadia app were installed.[4] There was also an experimental mode with support for all Android devices that were capable of installing the Stadia mobile app.[5] In December 2020, Google released an iOS browser-based progressive web application for Stadia, enabling gameplay in the Safari browser.[6]\r\n\r\nStadia was capable of streaming video games to players from the company's numerous data centers at up to 4K resolution and 60 frames per second, with support for high-dynamic-range (HDR) video. It offered the option to purchase games from its store, along with a selection of free-to-play games.[7] While the base service was free and allowed users stream at resolutions up to 1080p, a Stadia Pro monthly subscription allowed for a maximum resolution of 4K, 5.1 surround sound, HDR, and offered a growing collection of free games that—once claimed—remained in the user's library whenever they had an active subscription. Both tiers allowed users to play online multiplayer games without any additional costs. Stadia was integrated with YouTube, and its \"state share\" feature allowed players to launch a supported game from a save state shared by another player via permalink. The service supported Google's proprietary Stadia game controller, along with various non-Stadia controllers through USB and Bluetooth connections.[3]"
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
				Background = Color.FromArgb("#2B6641"),
                Background2 = Color.FromArgb("#55A348"),
                AboutText = "GeForce Now (stylized as GeForce NOW) is the brand used by Nvidia for its cloud gaming service. The Nvidia Shield version of GeForce Now, formerly known as Nvidia Grid, launched in beta in 2013, with Nvidia officially unveiling its name on September 30, 2015. The subscription service provided users with unlimited access to a library of games hosted on Nvidia servers for the life of the subscription, being delivered to subscribers through streaming video. Certain titles were also available via a \"Buy & Play\" model. This version was discontinued in 2019, and transitioned to a new version of the service that enabled Shield users to play their own games.\r\n\r\nIn January 2017, Nvidia unveiled GeForce Now clients for Windows and Mac computers, available in North America and Europe as a free beta. GeForce NOW lets users access a virtual computer, where they can install their existing games from existing digital distribution platforms, and play them remotely. As with the original Shield version, the virtual desktop is also streamed from Nvidia servers. An Android client was also introduced in 2019.\r\n\r\nThe service exited Beta and launched to the general public on February 4, 2020.[1] It is available on Windows, macOS, Android, iOS, Shield TV, Chromebook, Tizen and WebOS devices, The technology that powers Geforce NOW was invented by Franck Diard, and Xun Wang.[2][3] The patent is owned by Nvidia.[4]"
            }
		};

        private static List<GameConsole> homeConsoles = new List<GameConsole>()
        {
            new()
            {
                SystemName = "Nintendo Entertainment System",
                AlternativeNames = new[] {"NES", "Famicom", "FC", "Family Computer"},
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
                Background = Color.FromArgb("#385D8F"),
                Background2 = Color.FromArgb("#649CC4"),
                AboutText = "The Nintendo Entertainment System (NES) is an 8-bit third-generation home video game console produced by Nintendo. It was first released in Japan in 1983 as the Family Computer (FC),[note 1] commonly known as the Famicom.[note 2] The NES, a redesigned version, was released in American test markets on October 18, 1985, before becoming widely available in North America and other countries.\r\n\r\nAfter developing a series of successful arcade games in the early 1980s, Nintendo planned to create a home video game console. Rejecting more complex proposals, the Nintendo president Hiroshi Yamauchi called for a simple, cheap console that ran games stored on cartridges. The controller design was reused from Nintendo's portable Game & Watch games. Nintendo released several add-ons, such as a light gun for shooting games.\r\n\r\nThe NES was one of the best-selling consoles of its time and helped revitalize the US gaming industry following the video game crash of 1983.[11][d] It introduced a now-standard business model of licensing third-party developers to produce and distribute games.[13] The NES featured a number of groundbreaking games, such as the 1985 platform game Super Mario Bros. and the 1986 action-adventure games The Legend of Zelda and Metroid, which became long-running franchises. It was succeeded in 1990 by the Super Nintendo Entertainment System. In 2011, IGN named the NES the greatest video game console of all time.[14]"
            },
            new()
            {
                SystemName = "PlayStation 2",
                AlternativeNames = new[] {"PS2"},
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
                Background = Color.FromArgb("#2B6641"),
                Background2 = Color.FromArgb("#55A348"),
                AboutText = "The PlayStation 2 (PS2) is a home video game console developed and marketed by Sony Computer Entertainment. It was first released in Japan on 4 March 2000, in North America on 26 October 2000, in Europe on 24 November 2000, and in Australia on 30 November 2000. It is the successor to the original PlayStation, as well as the second installment in the PlayStation brand of consoles. As a sixth-generation console, it competed with Nintendo's GameCube, Sega's Dreamcast, and Microsoft's Xbox. It is the best-selling video game console of all time, having sold over 155 million units worldwide.\r\n\r\nAnnounced in 1999, Sony began developing the console after the immense success of its predecessor. The highlight of the system was its Emotion Engine processor, co-developed by Sony and Toshiba, which was said to be more powerful than personal computers.[15] The PS2 offered backward-compatibility for its predecessor's DualShock controller, as well as its games.\r\n\r\nThe PlayStation 2 received widespread critical acclaim upon release. A total of over 4,000 game titles were released worldwide, with over 1.5 billion copies sold.[16] In 2004, Sony released a smaller, lighter revision of the console known as the PS2 Slim. Even after the release of its successor, the PlayStation 3, it remained popular well into the seventh generation. It continued to be produced until the beginning of 2013 when Sony finally announced that it had been discontinued after over twelve years of production, one of the longest lifespans of any video game console. New games for the console continued to be released until even shortly after the end of its life and support from Sony."
            } 
        };

        private static List<GameConsole> vrConsoles = new List<GameConsole>()
        {
            new()
            {
				SystemName = "Valve Index",
                AlternativeNames = new[] {"Valve"},
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
				Background = Color.FromArgb("#385D8F"),
                Background2 = Color.FromArgb("#649CC4"),
                AboutText = "The Valve Index is a consumer virtual reality headset created and manufactured by Valve. Announced on April 30, 2019, the headset was released on June 28 of the same year.[6][7] The Index is a second-generation headset and the first to be manufactured completely by Valve. Half-Life: Alyx is bundled in with the headset."
            },

			new()
			{
				SystemName = "Oculus Quest 2",
                AlternativeNames = new[] {"Quest 2", "Meta Quest 2"},
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
				Background = Color.FromArgb("#2B6641"),
                Background2 = Color.FromArgb("#55A348"),
                AboutText = "The Quest 2 is a virtual reality (VR) headset developed by Reality Labs, a division of Facebook, Inc. (now Meta Platforms). It was unveiled on September 16, 2020, and released on October 13 as the Oculus Quest 2. It was then rebranded as the Meta Quest 2 in 2022, as part of a company-wide phase-out of the Oculus brand after the rebranding of Facebook, Inc. as Meta.\r\n\r\nIt is a refresh of the original Oculus Quest with a similar design, but with a lighter weight, updated internal specifications, a display with a higher refresh rate and per-eye resolution, and updated Oculus Touch controllers with improved battery life. As with its predecessor, the Quest 2 can run as either a standalone headset with an internal, Android-based operating system, or with Oculus Rift-compatible VR software running on a desktop computer.\r\n\r\nThe Quest 2 received mostly positive reviews as an incremental update to the Quest, but some of its changes faced criticism, including its stock head strap, reduced interpupillary distance (IPD) options, and a new requirement for users to log in with a Facebook account to use the headset and Oculus services."
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