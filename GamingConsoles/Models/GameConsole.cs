using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingConsoles.Models
{
    public class GameConsole
    {
        public string SystemName { get; set; } //name of console, incase of arcade, Boardname here. Capcom CPS1 arcade for example. 
        public bool IsSystemReleased { get; set; } //if the system has even been released, is not reflected on the page.
        public string SystemReleaseState { get; set; }//Cancelled, Unreleased, Announced, Released, etc, only visible if it is not released
        public DateOnly? SystemReleaseYearEurope { get; set; } //release date for europe
        public DateOnly? SystemReleaseYearAmerica { get; set; } //release date for america
        public DateOnly? SystemReleaseYearJapan { get; set; } //release date for japan
        public DateOnly SystemGeneralReleaseYear { get; set; } //worldwide release date 
        public DateOnly[]? SystemLifespanEurope { get; set; } //lifespan duration using 2 dates for europe
        public DateOnly[]? SystemLifespanAmerica { get; set; } //lifespan duration using 2 dates for america
        public DateOnly[]? SystemLifespanJapan { get; set; } //lifespan duration using 2 dates for japan
        public DateOnly[] SystemGeneralLifespan { get; set; } //lifespan duration using 2 dates worldwide
        public DateOnly? SystemDiscontinuedAtEurope { get; set; } //discontinuation date for europe
        public DateOnly? SystemDiscontinuedAtAmerica { get; set; } //discontinuation date for america
        public DateOnly? SystemDiscontinuedAtapan { get; set; } //discontinuation date for japan
        public DateOnly SystemGeneralDiscontinuedAt { get; set; } //discontinuation date worldwide
        public double? SystemReleasePriceEurope { get; set; } //release price for europe
        public double? SystemReleasePriceAmerica { get; set; } //release price for america
        public double? SystemReleasePriceJapan { get; set; } //release price for japan
        public double SystemGeneralReleasePrice { get; set; } //release price worldwide
        public string ReleasedBy { get; set; }  //console company, example: nintendo
        public string? DevelopedBy { get; set; } //developer of console. may not differ, but can differ from releasing company
        public string[]? AlternativeNames { get; set; } //alternative popular names for the console
        public string SystemType { get; set; } //typ of system, example: home, handheld, VR, arcade, cloud etc
        // use systemtype to sort the consoles into the proper categories
        public int UnitsSold { get; set; } //lifetime worldwide unit sales total
        public string MediaType { get; set; } //what was media of choice, cartridge, card, cd, dvd, digital distribution, streamed/cloud etc
        public string? Predecessor { get; set; } //previous console for the company
        public string? Successor { get; set; } //succeeding console for the company
        public string ControllerPorts { get; set; } //how many controllers can be used at the same time, does not matter if physical connection or wireless.
        public bool? ExtensionPort { get; set; } //does console have expansion port
        public string? ExtensionPortType { get; set; } //what type is the expansion port
        public string CPU { get; set; } //name of primary cpu
        public string CPUType { get; set; } //type of primary cpu, can be cpu, SOC or whatever else
        public int CPUSpeed { get; set; } //clock speed of said cpu
        public string? GPU { get; set; } //name of primary gpu, can be same as cpu
        public string? GPUType { get; set; } //type of primary cpu - standalone, integrated, none, etc.
        public int? GPUSpeed { get; set; } //speed of said gpu
        public string? APU { get; set; } //audio processing unit, retro consoles often had separate chips to handle audio. equivalent to a pc sound card (not in performance, but its purpose)
        public string? APUType { get; set; } //type of apu - standalone, integrated, none, etc. can be omitted for modern consoles if none is described.
        public string[]? channels { get; set; } //audio channels as stringarray
        public string? RamType { get; set; } //ram type (sdr, ddr, gddr, eeprom, whatever)
        public string RamSize { get; set; } //size of ram, include measuring unit here too.
        public string? GPURamType { get; set; } //gpu ram type (sdr, ddr, gddr, eeprom, whatever)
        public string GPURamSize { get; set; } //size of gpu ram, include measuring unit here too.
        public string? L1CacheSize { get; set; } //L1 cpu cache, if retro console, use cpu ram, L1 if mentioned
        public string? L2CacheSize { get; set; } //L2 cpu cache
        public string? L3CacheSize { get; set; } //L3 cpu cache
        public string? CoreCount { get; set; } //amount of cpu cores
        public string? CpuBitBandwitchSize { get; set; } //how many "bits" does the main data bus have.
        public bool DoesHaveRom { get; set; } //if true, console has internal storage the user can read and write to for storage. most retro consoles dont have this
        public int? ROMSize { get; set; } //for modern consoles, consider this to be HDD/SSD
        public int? ROMType { get; set; } //here you say if it is eeprom, hdd or hdd or other.
        public bool DoesHaveRemovableStorage { get; set; } //if console has removable storage, that is not main mediatype, but no expansion port
        public string? RemovableStorageType { get; set; } //type of removable storage (usb stick, memory card)
        public string? RemovableStorageSize { get; set; } //max size of removable storage
        public string[] VideoOutputResolutions { get; set; } //resolutions the console is capable of outputting, standard ones only, no random ones pls. just follow wikipedia
        public string[] VideoOutputTypes { get; set; } //output types (hdmi, composite, component, s-video, displayport, vga, dvi etc)
        public string[] VideoOutputFrameRates { get; set; } //output framerates for the console. include regions manually in the strings.
        public bool? DoesHaveOnline { get; set; } //true if it can access internet/anything else outside of it.
        //some consoles like the SNES and megadrive had cable-based online services for downloading new games.
        //they technically count, but since they werent available on the base model, those consoles still need
        //this value as TRUE. since some other more modern consoles had online kits like the original ps2 and 
        //sega dreamcast, more values follow to clarify this
        public string? OnlineType { get; set; } //here you put either in base model or via Accessory. if both apply
        //like in the case of more modern consoles ps2 and dreamcast where online became standard later,
        //put something like not at lunch, as a kit, later in base model. etc.
        public string? OnlineMaxSpeed { get; set; } //speed of the online connection
        public int? TotalGamesReleasedInEU { get; set; } // number of games released in the eu
        public int? TotalGamesReleasedInUS { get; set; } // number of games released in the eu
        public int? TotalGamesReleasedInJP { get; set; } // number of games released in the eu
        public int TotalGamesReleasedWorldWide { get; set; } // number of games released worldwide
        public string[]? Top10GamesSoldInEU { get; set; } //top 10 sold games in eu
        public string[]? Top10GamesSoldInUS { get; set; } //top 10 sold games in eu
        public string[]? Top10GamesSoldInJP { get; set; } //top 10 sold games in eu
        public string[] Top10GamesSoldWorldWide { get; set; } //top 10 sold games in eu
        public bool? DoesHaveBackwardCompatibility { get; set; } //true if console has backward compatibility with an older console or consoles
        public string[]? BackwardCompatibleWith { get; set; } //list of consoles its backward compatible with
        public List<string> Images { get; set; }
        public string HeroImage { get; set; }
    }
}
