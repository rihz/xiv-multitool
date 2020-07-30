using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Data
{
    public class Content
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int iLevel { get; set; }
        public string ContentType { get; set; }

        public Content(string contentType, string name, int level, int ilevel)
        {
            Name = name;
            Level = level;
            iLevel = ilevel;
            ContentType = contentType;
        }
    }

    public class SeedZone
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string RegionName { get; set; }
    }

    public static class SeedCommon
    {
        // Regions, Zones, and Locations

        const string LA_NOSCEA = "La Noscea";
            const string LIMSAUPPER = "Limsa Lominsa Upper Decks";
            const string LIMSALOWER = "Limsa Lominsa Lower Decks";
            const string LOWERLN = "Lower La Noscea";
                //const string MORABYBAY = "Moraby Bay";
                //const string CEDARWOOD = "Cedarwood";
                //const string GODSGRIP = "The Gods' Grip";
                //const string MORABYDRYDOCKS = "Moraby Drydocks";
            const string MIDDLELN = "Middle La Noscea";
                //const string ZEPHYRDRIFT = "Zephyr Drift";
                //const string SUMMERFORD = "Summerford";
                //const string SUMMERFORDFARMS = "Summerford Farms";
                //const string THREEMALMBEND = "Three-malm Bend";
            const string EASTERNLN = "Eastern la Noscea";
                //const string BLOODSHORE = "Bloodshore";
                //const string COSTADELSOL = "Costa Del Sol";
                //const string RAINCATCHERGULLY = "Raincatcher Gully";
                //const string WINEPORT = "Wineport";
                //const string AGELYSSWISE = "Agelyss Wise";
            const string WESTERNLN = "Western la Noscea";
                //const string QUARTERSTONE = "Quarterstone";
                //const string SWIFTPERCH = "Swiftperch";
                //const string SKULLVALLEY = "Skull Valley";
                //const string ALEPORT = "Aleport";
                //const string ISLESOFUMBRA = "The Isles of Umbra";
                //const string HALFSTONE = "Halfstone";
                //const string SAPSASPAWNINGGROUNDS = "Sapsa Spawning Grounds";
            const string OUTERLN = "Outer La Noscea";
                //const string LONGCLIMB = "The Long Climb";
                //const string CAMPOVERLOOK = "Camp Overlook";
                //const string IRONLAKE = "Iron Lake";
                //const string UGHAMAROMINES = "U'Ghamaro Mines";
            const string UPPERLN = "Upper La Noscea";
                //const string BRONZELAKE = "Bronze Lake";
                //const string CAMPBRONZELAKE = "Camp Bronze Lake";
                //const string ZELMASRUN = "Zelma's Run";
                //const string OAKWOOD = "Oakwood";
            const string MIST = "The Mist";
            const string WOLVES_DEN = "Wolves' Den Pier";

        const string BLACK_SHROUD = "The Black Shroud";
            const string OLDGRID = "Old Gridania";
            const string NEWGRID = "New Gridania";
            const string CENTRALSHROUD = "Central Shroud";
                //const string BENTBRANCH = "Bentbranch";
                //const string BENTBRANCHMEADOWS = "Bentbranch Meadows";
                //const string JADEITETHICK = "Jadeite Thick";
                //const string STANDINGCORSES = "The Standing Corses";
                //const string SORRELHAVEN = "Sorrel Haven";
                //const string GREENTEAR = "Greentear";
            const string NORTHSHROUD = "North Shroud";
                //const string ALDERSPRINGS = "Alder Springs";
                //const string FALLGOURDFLOAT = "Fallgourd Float";
                //const string TREESPEAK = "Treespeak";
                //const string PEACEGARDEN = "Peacegarden";
                //const string PROUDCREEK = "Proud Creek";
            const string EASTSHROUD = "East Shroud";
                //const string HONEYYARD = "The Honey Yard";
                //const string LARKSCALL = "Larkscall";
                //const string SYLPHLANDS = "Sylphlands";
                //const string NINEIVIES = "Nine Ivies";
                //const string HAWTHORNEHUT = "The Hawthorne Hut";
                //const string BRAMBLEPATCH = "The Bramble Patch";
            const string SOUTHSHROUD = "South Shroud";
                //const string CAMPTRANQUIL = "Camp Tranquill";
                //const string LOWERPATHS = "Lower Paths";
                //const string QUARRYMILL = "Quarrymill";
                //const string SILENTARBOR = "Silent Arbor";
                //const string SNAKEMOLT = "Snakemolt";
                //const string UPPERPATHS = "Upper Paths";
                //const string URTHSGIFT = "Urth's Gift";
            const string LAVENDERBEDS = "Lavender Beds";

        const string THANALAN = "Thanalan";
            const string ULDAHNALD = "Ul'dah - Steps of Nald";
            const string ULDAHTHAL = "Ul'dah - Steps of Thal";
            const string CENTRALTHAN = "Central Thanalan";
                //const string SPINELESSBASIN = "Spineless Basin";
                //const string CLUTCH = "The Clutch";
                //const string BLACKBRUSHSTATION = "Black Brush Station";
                //const string BLACKBRUSH = "Black Brush";
            const string WESTERNTHAN = "Western Thanalan";
                //const string EIGHTYSINS = "The Eighty Sins of Sasamo";
                //const string HAMMERLEA = "Hammerlea";
                //const string HORIZONSEDGE = " Horizon's Edge";
                //const string HORIZON = "Horizon";
                //const string FOOTFALLS = "The Footfalls";
                //const string CAPEWESTWIND = "Cape Westwind";
            const string EASTERNTHAN = "Eastern Thanalan";
                //const string WELLWICKWOOD = "Wellwick Wood";
                //const string BURNINGWALL = "The Burning Wall";
                //const string SANDGATE = "Sandgate";
                //const string CAMPDRYBONE = "Camp Drybone";
                //const string DRYBONE = "Drybone";
            const string SOUTHERNTHAN = "Southern Thanalan";
                //const string SAGOLIIDESERT = "Sagolii Desert";
                //const string FORGOTTENSPRINGS = "Forgotten Springs";
                //const string REDLABYRINTH = "The Red Labyrinth";
                //const string ZANRAK = "Zanr'ak";
                //const string ZAHARAK = "Zahar'ak";
                //const string BROKENWATER = "Broken Water";
                //const string LITTLEALAMHIGO = "Little Ala Mhigo";
            const string NORTHERNTHAN = "Northern Thanalan";
                //const string CAMPBLUEFOG = "Camp Bluefog";
                //const string BLUEFOG = "Bluefog";
                //const string CERULEUMPP = "Ceruleum Processing Plant";
                //const string RAUBAHNSPUSH = "Raubahn's Push";
            const string GOBLET = "The Goblet";

        const string MOR_DHONA = "Mor Dhona";
            const string MORDHONA = "Mor Dhona";
                //const string FOGFENS = "Fogfens";
                //const string REVENANTSTOLL = "Revenant's Toll";
                //const string NORTHSILVERTEAR = "North Silvertear";
                //const string EIGHTSENTINELS = "The Eight Sentinels";

        const string COERTHAS = "Coerthas";
            const string FOUNDATION = "Foundation";
            const string PILLARS = "The Pillars";
            const string COERTHASCENTRAL = "Coerthas Central Highlands";
                //const string DRAGONHEAD = "Dragonhead";
                //const string CAMPDRAGONHEAD = "Camp Dragonhead";
                //const string PROVIDENCEPOINT = "Providence Point";
                //const string BOULDERDOWNS = "Boulder Downs";
                //const string WHITEBRIM = "Whitebrim";
            const string COERTHASWESTERN = "Coerthas Western Highlands";
                //const string RIVERSMEET = "Riversmeet";
                //const string FALCONSNEST = "Falcon's Nest";
                //const string TWINPOOLS = "Twinpools";
                //const string REDRIM = "Red Rim";

        const string ABALATHIA = "Abalathia's Spine";
            const string SEAOFCLOUDS = "The Sea of Clouds";
                //const string CLOUDTOP = "Cloudtop";
                //const string CAMPCLOUDTOP = "Camp CLoudtop";
                //const string LASTSTEP = "Last Step";
                //const string BLUEWINDOW = "The Blue Window";
                //const string OKZUNDU = "Ok' Zundu";
                //const string VOORSIANSIRAN = "Voor Sian Siran";
                //const string OKVUNDU = "Ok' Vundu";
                //const string WISENTHERD = "Wisent Herd";
                //const string GAUNTLET = "The Gauntlet";
            const string AZYSLLA = "Azys Lla";
        //const string ALPHAQUAD
        //    const string HELIX
        //    const string BETAQUAD
        //    const string GAMMAQUAD
        //    const string DELTAQUAD
        //    const string THEFLAGSHIP

        const string DRAVANIA = "Dravania";
            const string IDYLLSHIRE = "Idyllshire";
            const string DRAVANIANFORELANDS = "Dravanian Forelands";
        //const string CHOCOBOFOREST
        //    const string TAILFEATHER
        //    const string THESMOLDERINGWASTES
        //    const string AVALONIAFALLEN
        //    const string SOHMALFOOTHILLS
        //    const string MOURN
        //    const string ANYXTRINE
            const string DRAVANIANHINTERLANDS = "Dravanian Hinterlands";
        //const string THEMAKERSQUARTER
        //    const string THECOLLECTORSQUARTER
        //    const string THEANSWERINGQUARTER
        //    const string THERULINGQUARTER
            const string CHURNINGMISTS = "The Churning Mists";
        //const string SOHMALSUMMIT
        //    const string MOGHOME
        //    const string EILTOHM
        //    const string LANDLORDCOLONY
        //    const string FOURARMS
        //    const string ZENITH
        //    const string OHLTAHN
        //    const string GREENSWARD

        const string GYR_ABANIA = "Gyr Abania";
            const string RHALGRSREACH = "Rhalgr's Reach";
            const string FRINGES = "The Fringes";
        //const string CASTRUMORIENS
        //    const string EASTEND
        //    const string THESTRIPEDHILLS
        //    const string PIKEFALLS
        //    const string DIMWOLD
        //    const string DJANANQHAT
        //    const string VIRDJALA
        //    const string THEPEERINGSTONES
            const string LOCHS = "The Lochs";
        //const string PORTAPRAETORIA
        //    const string THEHIGHBANK
        //    const string LOCHSELD
        //    const string THEQUEENSGARDENS
        //    const string ABALATHIASSKULL
        //    const string THEALAMHIGANQUARTER
            const string PEAKS = "The Peaks";
        //const string ALAGANNHA
        //    const string THELASTFOREST
        //    const string RUSTROCK
        //    const string WIGHTROCK
        //    const string MOUNTYORN
        //    const string ALAGHIRI

        const string OTHARD = "Othard";
            const string AZIMSTEPPE = "The Azim Steppe";
        //const string ONSALHAKAIR
        //    const string THEDAWNTHRONE
        //    const string THESEAOFBLADES
        //    const string REUNION
        //    const string THETOWERINGSTILL
        //    const string NHAAMASRETREAT
        //    const string DHOROILOH
            const string RUBYSEA = "The Ruby Sea";
        //const string EASTOTHARDCOASTLINE
        //    const string THEISLEOFZEKKI
        //    const string ONOKORO
        //    const string RASENKAIKYO
        //    const string TAMAMIZU
            const string YANXIA = "Yanxia";
        //const string DOMA
        //    const string THEHOUSEOFTHEFIERCE
        //    const string VALLEYOFTHEFALLENRAINBOW
        //    const string THEGENSUICHAIN
        //    const string NAMAI
        //    const string THEGLITTERINGBASIN

        const string HINGASHI = "Hingashi";
            const string KUGANE = "Kugane";
            const string SHIROGANE = "Shirogane";

        const string NORVRANDT = "Norvrandt";
            const string CRYSTARIUM = "The Crystarium";
            const string EULMORECANOPY = "Eulmore - The Canopy";
            const string EULMOREUNDERSTORY = "Eulmore - The Understory";
            const string EULMOREBUTTRESS = "Eulmore - The Buttress";
        const string LAKELAND = "Lakeland";
        //const string WEATHERING
        //    const string LAXANLOFT
        //    const string THEOSTALLIMPERATIVE
        //    const string THEFORESTOFTHELOSTSHEPHERD
        //    const string THETHIRSTLESSSHORE
        //    const string THESOURCE
        //    const string THEEXARCHGATE
        //    const string FORTJOBB
        //    const string SULLEN
            const string KHOLUSIA = "Kholusia";
        //const string THEBRIGHTCLIFF
        //    const string STILLTIDE
        //    const string THEDUERGARMOUNTAINS
        //    const string SCREE
        //    const string TOMRA
        //    const string SHADOWFAULT
        //    const string WRIGHT
            const string AMHARAENG = "Amh Araeng";
            const string ILMHEG = "Il Mheg";
            const string RAKTIKA = "The Rak'tika Greatwood";
            const string TEMPEST = "The Tempest";
        const string DIADEM = "The Diadem";

        // Content Types
        const string DUNGEON = "Dungeon";
        const string RAID = "Raid";
        const string TRIAL = "Trial";
        const string ALLIANCE_RAID = "Alliance Raid";
        const string GUILDHEST = "Guildhest";

        public static string[] DisciplineNames = new string[] {
            "Warrior", "Paladin", "Dark Knight", "Gunbreaker", "White Mage", "Scholar", "Astrologian",
            "Red Mage", "Black Mage", "Blue Mage", "Summoner", "Monk", "Samurai", "Ninja",
            "Dragoon", "Bard", "Dancer", "Marauder", "Gladiator", "Conjurer", "Arcanist",
            "Thaumaturge", "Pugilist", "Rogue", "Lancer", "Archer", "Machinist", "Tank",
            "DPS", "Healer", "Alchemist", "Armorer", "Blacksmith", "Carpenter", "Culinarian",
            "Goldsmith", "Leatherworker", "Weaver", "Botanist", "Fisher", "Miner"
        };

        public static string[] DisciplineAbbrevs = new string[]
        {
            "WAR", "PLD", "DRK", "GNB", "WHM", "SCH", "AST",
            "RDM", "BLM", "BLU", "SMN", "MNK", "SAM", "NIN",
            "DRG", "BRD", "DNC", "MRD", "GLD", "CNJ", "ACN",
            "THM", "PGL", "ROG", "LNC", "ARC", "MCH", "", 
            "", "", "ALC", "ARM", "BSM", "CRP", "CUL",
            "GSM", "LTW", "WVR", "BTN", "FSH", "MIN"
        };

        public static int GetDisciplineId(string name)
        {
            var match = DisciplineNames.FirstOrDefault(x => x.ToLower() == name.ToLower());

            return match != default(string)
                ? DisciplineNames.IndexOf(match) + 1
                : -1;
        }

        public static int GetDisciplineIdByAbbreviation(string abbrev)
        {
            var match = DisciplineAbbrevs.FirstOrDefault(x => x.ToLower() == abbrev.ToLower());

            return match != default(string)
                ? DisciplineAbbrevs.IndexOf(match) + 1
                : -1;
        }

        public static string[] BeastTribes = new string[]
        {
            "Amalj'aa",
            "Ixal",
            "Kobold",
            "Sahagin",
            "Sylph",
            "Allied (A Realm Reborn)",
            "Moogle",
            "Vath",
            "Vanu Vanu",
            "Allied (Heavensward)",
            "Namazu",
            "Ananta",
            "Kojin",
            "Allied (Stormblood)",
            "Pixie"
        };

        public static int GetBeastTribeId(string name)
        {
            var match = BeastTribes.SelectArray<BeastTribe>()
                .FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

            return match != default(BeastTribe) ? match.Id : -1;
        }

        public static string[] BeastRanks = new string[]
        {
            "Neutral",
            "Recognized",
            "Friendly",
            "Trusted",
            "Respected",
            "Honored",
            "Sworn",
            "Bloodsworn",
            "Allied",
            "Sworn (All A Realm Reborn Tribes)",
            "Sworn (All Heavensward Tribes)",
            "Sworn (All Stormblood Tribes)"
        };

        public static string[] CollectionTypes = new string[]
        {
            "Aesthetics",
            "Bardings",
            "Emotes",
            "Minions",
            "Mounts"
        };

        public static string[] OrchestrionTypes = new string[]
        {
            "Dungeons",
            "Mog Station",
            "Others",
            "Raids",
            "Seasonal",
            "Trials",
            "Locales"
        };

        public static string[] MSQTypes = new string[]
        {
            "Seventh Umbral Era",
            "Seventh Astral Era",
            "Heavensward",
            "Dragonsong War",
            "Stormblood",
            "The Legend Returns",
            "Shadowbringers",
            "Post-Shadowbringers"
        };

        public static AchievementType[] AchievementTypes()
        {
            var list = new List<AchievementType>();
            AchievementTypeEnum[] values = (AchievementTypeEnum[])Enum.GetValues(typeof(AchievementTypeEnum));

            for(int i = 0; i < values.Length; i++)
            {
                list.Add(new AchievementType
                {
                    Id = i + 1,
                    Name = values[i].ToString()
                });
            }

            return list.ToArray();
        }

        public static int GetAchievementTypeId(string name)
        {
            var match = GetSeed<AchievementTypeEnum>().FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

            return match != default(AchievementType) ? match.Id : -1;
        }

        public static ICommon[] GetSeed<T>()
        {
            var list = new List<ICommon>();

            var values = (T[])Enum.GetValues(typeof(T));

            for(int i = 0; i < values.Length; i++)
            {
                list.Add(new Common
                {
                    Id = i + 1,
                    Name = values[i].ToString().Replace('_', ' ')
                });
            }

            return list.ToArray();
        }

        public static int GetCollectionTypeIndex(string name)
        {
            return CollectionTypes.IndexOf(name) + 1;
        }

        public static string[] CraftingLogTypes = new string[]
        {
            "ALC",
            "ARM",
            "BSM",
            "CRP",
            "CUL",
            "GSM",
            "LTW",
            "Shared",
            "WVR"
        };

        public static int GetCraftingLogTypeIndex(string name)
        {
            return CraftingLogTypes.IndexOf(name) + 1;
        }

        public static string[] FATETypes = new string[]
        {
            "Abalathia",
            "Black Shroud",
            "Coerthas",
            "Dravania",
            "Eureka",
            "Gyr Abania",
            "La Noscea",
            "Mor Dhona",
            "Norvrandt",
            "Othard",
            "Thanalan",
            "The Diadem"
        };

        public static string[] HuntingLogTypes = new string[]
        {
            "Arcanist",
            "Archer",
            "Conjurer",
            "Gladiator",
            "Lancer",
            "Marauder",
            "Pugilist",
            "Rogue",
            "Thaumaturge",
            "Flames",
            "Adder",
            "Maelstrom"
        };

        public static string[] SQTypes = new string[]
        {
            "Abalathia",
            "Amh Araeng",
            "Black Shroud",
            "Chronicles of a New Era",
            "Coerthas",
            "Crystalline Mean",
            "Dravania",
            "Grand Company",
            "Gyr Abania",
            "Il Mheg",
            "Ishgard",
            "Kholusia",
            "Kugane",
            "La Noscea",
            "Lakeland",
            "Mor Dhona",
            "Othard",
            "Rak'tika",
            "Side Story",
            "Tempest",
            "Thanalan"
        };

        public static string[] JobRoles = new string[]
        {
            "Tank",
            "Physical DPS",
            "Healer",
            "Magic DPS",
            "Epilogue"
        };

        public static int GetJobRoleId(string name)
        {
            var role = JobRoles.FirstOrDefault(x => x.ToLower() == name.ToLower());

            return role != default(string) ? JobRoles.IndexOf(role) + 1 : -1;
        }

        public static int GetSQTypeId(string name)
        {
            var type = SQTypes.FirstOrDefault(x => x.ToLower() == name.ToLower());

            return type != default(string) ? SQTypes.IndexOf(type) + 1 : -1;
        }

        public static int GetMajorPatchId(string name)
        {
            var patches = Patches.Where(x => x.Name.ToLower() == name.ToLower());

            return patches.Count() > 0 ? patches.First().Id : -1;
        }

        public static Patch[] Patches = new Patch[]
        {
            new Patch { Id = 1, Name = "A Realm Reborn", Number = "2.0" },
            new Patch { Id = 2, Name = "A Realm Awoken", Number = "2.1" },
            new Patch { Id = 3, Name = "A Realm Awoken", Number = "2.15" },
            new Patch { Id = 4, Name = "A Realm Awoken", Number = "2.16" },
            new Patch { Id = 5, Name = "Through the Maelstrom", Number = "2.2" },
            new Patch { Id = 6, Name = "Through the Maelstrom", Number = "2.21" },
            new Patch { Id = 7, Name = "Through the Maelstrom", Number = "2.25" },
            new Patch { Id = 8, Name = "Through the Maelstrom", Number = "2.28" },
            new Patch { Id = 9, Name = "Defenders of Eorzea", Number = "2.3" },
            new Patch { Id = 10, Name = "Defenders of Eorzea", Number = "2.35" },
            new Patch { Id = 11, Name = "Defenders of Eorzea", Number = "2.38" },
            new Patch { Id = 12, Name = "Dreams of Ice", Number = "2.4" },
            new Patch { Id = 13, Name = "Dreams of Ice", Number = "2.41" },
            new Patch { Id = 14, Name = "Dreams of Ice", Number = "2.45" },
            new Patch { Id = 15, Name = "Before the Fall", Number = "2.5" },
            new Patch { Id = 16, Name = "Before the Fall", Number = "2.51" },
            new Patch { Id = 17, Name = "Before the Fall", Number = "2.55" },
            new Patch { Id = 18, Name = "Before the Fall", Number = "2.56" },
            new Patch { Id = 19, Name = "Before the Fall", Number = "2.57" },
            new Patch { Id = 20, Name = "Heavensward", Number = "3.0" },
            new Patch { Id = 21, Name = "Heavensward", Number = "3.01" },
            new Patch { Id = 22, Name = "Heavensward", Number = "3.05" },
            new Patch { Id = 23, Name = "Heavensward", Number = "3.07" },
            new Patch { Id = 24, Name = "As Goes Light, So Goes Darkness", Number = "3.1" },
            new Patch { Id = 25, Name = "As Goes Light, So Goes Darkness", Number = "3.15" },
            new Patch { Id = 26, Name = "The Gears of Change", Number = "3.2" },
            new Patch { Id = 27, Name = "The Gears of Change", Number = "3.21" },
            new Patch { Id = 28, Name = "The Gears of Change", Number = "3.22" },
            new Patch { Id = 29, Name = "The Gears of Change", Number = "3.25" },
            new Patch { Id = 30, Name = "The Gears of Change", Number = "3.26" },
            new Patch { Id = 31, Name = "Revenge of the Horde", Number = "3.3" },
            new Patch { Id = 32, Name = "Revenge of the Horde", Number = "3.35" },
            new Patch { Id = 33, Name = "Revenge of the Horde", Number = "3.38" },
            new Patch { Id = 34, Name = "Soul Surrender", Number = "3.4" },
            new Patch { Id = 35, Name = "Soul Surrender", Number = "3.41" },
            new Patch { Id = 36, Name = "Soul Surrender", Number = "3.45" },
            new Patch { Id = 37, Name = "The Far Edge of Fate", Number = "3.5" },
            new Patch { Id = 38, Name = "The Far Edge of Fate", Number = "3.51" },
            new Patch { Id = 39, Name = "The Far Edge of Fate", Number = "3.55a" },
            new Patch { Id = 40, Name = "The Far Edge of Fate", Number = "3.55b" },
            new Patch { Id = 41, Name = "The Far Edge of Fate", Number = "3.56" },
            new Patch { Id = 42, Name = "The Far Edge of Fate", Number = "3.57" },
            new Patch { Id = 43, Name = "Stormblood", Number = "4.0" },
            new Patch { Id = 44, Name = "Stormblood", Number = "4.01" },
            new Patch { Id = 45, Name = "Stormblood", Number = "4.05" },
            new Patch { Id = 46, Name = "Stormblood", Number = "4.06" },
            new Patch { Id = 47, Name = "Stormblood", Number = "4.06a" },
            new Patch { Id = 48, Name = "The Legend Returns", Number = "4.1" },
            new Patch { Id = 49, Name = "The Legend Returns", Number = "4.11" },
            new Patch { Id = 50, Name = "The Legend Returns", Number = "4.15" },
            new Patch { Id = 51, Name = "The Legend Returns", Number = "4.18" },
            new Patch { Id = 52, Name = "Rise of a New Sun", Number = "4.2" },
            new Patch { Id = 53, Name = "Rise of a New Sun", Number = "4.21" },
            new Patch { Id = 54, Name = "Rise of a New Sun", Number = "4.25" },
            new Patch { Id = 55, Name = "Under the Moonlight", Number = "4.3" },
            new Patch { Id = 56, Name = "Under the Moonlight", Number = "4.31" },
            new Patch { Id = 57, Name = "Under the Moonlight", Number = "4.35" },
            new Patch { Id = 58, Name = "Under the Moonlight", Number = "4.36" },
            new Patch { Id = 59, Name = "Prelude in Violet", Number = "4.4" },
            new Patch { Id = 60, Name = "Prelude in Violet", Number = "4.41" },
            new Patch { Id = 61, Name = "Prelude in Violet", Number = "4.45" },
            new Patch { Id = 62, Name = "A Requiem for Heroes", Number = "4.5" },
            new Patch { Id = 63, Name = "A Requiem for Heroes", Number = "4.55" },
            new Patch { Id = 64, Name = "A Requiem for Heroes", Number = "4.56" },
            new Patch { Id = 65, Name = "A Requiem for Heroes", Number = "4.57" },
            new Patch { Id = 66, Name = "A Requiem for Heroes", Number = "4.58" },
            new Patch { Id = 67, Name = "Shadowbringers", Number = "5.0" },
            new Patch { Id = 68, Name = "Shadowbringers", Number = "5.01" },
            new Patch { Id = 69, Name = "Shadowbringers", Number = "5.05" },
            new Patch { Id = 70, Name = "Shadowbringers", Number = "5.08" },
            new Patch { Id = 71, Name = "Vows of Virtue, Deeds of Cruelty", Number = "5.1" },
            new Patch { Id = 72, Name = "Vows of Virtue, Deeds of Cruelty", Number = "5.11" },
            new Patch { Id = 73, Name = "Vows of Virtue, Deeds of Cruelty", Number = "5.15" },
            new Patch { Id = 74, Name = "Vows of Virtue, Deeds of Cruelty", Number = "5.18" },
        };

        public static GatherType[] GatherTypes = new GatherType[]
        {
            new GatherType { Id = 1, Name = "Mining" },
            new GatherType { Id = 2, Name = "Quarrying" },
            new GatherType { Id = 3, Name = "Logging" },
            new GatherType { Id = 4, Name = "Harvesting" },
            new GatherType { Id = 5, Name = "Fishing" }
        };

        public static int GetGatherTypeId(string gatherTypeName)
        {
            return GatherTypes.First(x => x.Name.ToLower() == gatherTypeName.ToLower())
                .Id;
        }

        public static IEnumerable<Region> Regions = new List<Region>()
        {
            new Region { Id = 1, Name = LA_NOSCEA },
            new Region { Id = 2, Name = BLACK_SHROUD },
            new Region { Id = 3, Name = THANALAN },
            new Region { Id = 4, Name = MOR_DHONA },
            new Region { Id = 5, Name = COERTHAS },
            new Region { Id = 6, Name = ABALATHIA },
            new Region { Id = 7, Name = DRAVANIA },
            new Region { Id = 8, Name = GYR_ABANIA },
            new Region { Id = 9, Name = OTHARD },
            new Region { Id = 10, Name = HINGASHI },
            new Region { Id = 11, Name = NORVRANDT },
            new Region { Id = 12, Name = DIADEM }
        };

        public static RewardType[] RewardTypes = new RewardType[]
        {
            new RewardType { Id = 1, Name = "None" },
            new RewardType { Id = 2, Name = "Item" },
            new RewardType { Id = 3, Name = "Mount" },
            new RewardType { Id = 4, Name = "Minion" },
            new RewardType { Id = 5, Name = "Title" },
            new RewardType { Id = 6, Name = "Card" },
            new RewardType { Id = 7, Name = "Barding" },
            new RewardType { Id = 8, Name = "Orchestrion" },
            new RewardType { Id = 9, Name = "Emote" }
        };

        public static int GetRewardTypeId(string name)
        {
            if(name.ToLower() == "tt") { name = "Card"; }

            var match = RewardTypes.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
            
            return match != default(RewardType) ? match.Id : -1;
        }
                      
        public static IEnumerable<PvEContentType> ContentTypes = new List<PvEContentType>()
        {
            new PvEContentType { Id = 1, Name = DUNGEON },
            new PvEContentType { Id = 2, Name = RAID },
            new PvEContentType { Id = 3, Name = TRIAL },
            new PvEContentType { Id = 4, Name = ALLIANCE_RAID },
            new PvEContentType { Id = 5, Name = GUILDHEST }
        };

        public static IEnumerable<PvEContent> GetPvEContent()
        {
            return _contents.Select((x, index) => new PvEContent()
            {
                Id = index + 1,
                Name = x.Name,
                Level = x.Level,
                iLevel = x.iLevel,
                PvEContentTypeId = ContentTypes.First(y => y.Name.ToLower() == x.ContentType.ToLower()).Id
            });
        }

        public static int GetContentId(string name)
        {
            var match = GetPvEContent().FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

            return match != default(PvEContent) ? match.Id : -1;
        }

        public static IEnumerable<Zone> GetZones()
        {
            return _zones.Select((x, index) => new Zone()
            {
                Id = x.Id,
                Name = x.Name,
                RegionId = Regions.First(y => y.Name.ToLower() == x.RegionName.ToLower()).Id
            });
        }

        public static ICommon[] SelectArray<T>(this string[] array)
        {
            return array.Select((x, index) =>
            {
                var obj = new Common
                {
                    Id = index + 1,
                    Name = x
                };

                return obj;
            })
            .ToArray();
        }

        public static int GetMatchId<T>(this string[] array, string name)
        {
            var match = array.SelectArray<T>()
                .FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

            return match != default(ICommon) ? match.Id : -1;
        }

        public static int GetZoneId(string name)
        {
            var match = _zones.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

            return match != default(SeedZone) ? match.Id : -1;
        }

        public static int GetLeveTypeId(string name)
        {
            var match = LeveTypes.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

            return match != default(LeveType) ? match.Id : -1;
        }

        public static int GetHuntingLogTypeId(string name)
        {
            var match = HuntingLogTypes.SelectArray<HuntingLogType>()
                .FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

            return match != default(HuntingLogType) ? match.Id : -1;
        }

        public static int GetMSQTypeId(string name)
        {
            var match = MSQTypes.SelectArray<MSQType>()
                    .FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

            return match != default(MSQType) ? match.Id : -1;
        }

        public static int GetOrchestrionTypeId(string name)
        {
            var match = OrchestrionTypes.SelectArray<OrchestrionType>()
                    .FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

            return match != default(OrchestrionType) ? match.Id : -1;
        }

        public static LeveType[] LeveTypes = new List<LeveType>
        {
            new LeveType { Id = 1, Name = "Battlecraft" },
            new LeveType { Id = 2, Name = "Tradecraft" },
            new LeveType { Id = 3, Name = "Fieldcraft" },
            new LeveType { Id = 4, Name = "Flames" },
            new LeveType { Id = 5, Name = "Maelstrom" },
            new LeveType { Id = 6, Name = "Twin Adder" },
            new LeveType { Id = 7, Name = "Battlecraft (Large-scale)" },
            new LeveType { Id = 8, Name = "Tradecraft (Large-scale)" },
            new LeveType { Id = 9, Name = "Fieldcraft (Large-scale)" },
            new LeveType { Id = 10, Name = "Alchemy" },
            new LeveType { Id = 11, Name = "Alchemy (Large-scale)" },
            new LeveType { Id = 12, Name = "Armorcrafting" },
            new LeveType { Id = 13, Name = "Armorcrafting (Large-scale)" },
            new LeveType { Id = 14, Name = "Blacksmithing" },
            new LeveType { Id = 15, Name = "Blacksmithing (Large-scale)" },
            new LeveType { Id = 16, Name = "Carpentry" },
            new LeveType { Id = 17, Name = "Carpentry (Large-scale)" },
            new LeveType { Id = 18, Name = "Culinary" },
            new LeveType { Id = 19, Name = "Culinary (Large-scale)" },
            new LeveType { Id = 20, Name = "Goldsmithing" },
            new LeveType { Id = 21, Name = "Goldsmithing (Large-scale)" },
            new LeveType { Id = 22, Name = "Leatherworking" },
            new LeveType { Id = 23, Name = "Leatherworking (Large-scale)" },
            new LeveType { Id = 24, Name = "Weaving" },
            new LeveType { Id = 25, Name = "Weaving (Large-scale)" },
            new LeveType { Id = 26, Name = "Mining" },
            new LeveType { Id = 27, Name = "Mining (Large-scale)" },
            new LeveType { Id = 28, Name = "Botany" },
            new LeveType { Id = 29, Name = "Botany (Large-scale)" },
            new LeveType { Id = 30, Name = "Fishing" },
            new LeveType { Id = 31, Name = "Fishing (Large-scale)" }
        }.ToArray();

        static List<Content> _contents = new List<Content>()
        {
            new Content(DUNGEON, "Sastasha", 15, 0),
            new Content(DUNGEON, "The Tam-Tara Deepcroft", 16, 0),
            new Content(DUNGEON, "Copperbell Mines", 17, 0),
            new Content(DUNGEON, "Halatali", 20, 0),
            new Content(DUNGEON, "The Thousand Maws of Toto-Rak", 24, 0),
            new Content(DUNGEON, "Haukke Manor", 28, 0),
            new Content(DUNGEON, "Brayflox's Longstop", 32, 0),
            new Content(DUNGEON, "The Sunken Temple of Qarn", 35, 0),
            new Content(DUNGEON, "Cutter's Cry", 38, 0),
            new Content(DUNGEON, "The Stone Vigil", 41, 0),
            new Content(DUNGEON, "Dzemael Darkhold", 44, 0),
            new Content(DUNGEON, "The Aurum Vale", 47, 0),
            new Content(DUNGEON, "Castrum Meridianum", 50, 42),
            new Content(DUNGEON, "The Praetorium", 50, 42),
            new Content(DUNGEON, "The Wanderer's Palace", 50, 45),
            new Content(DUNGEON, "Amdapor Keep", 50, 45),
            new Content(DUNGEON, "Pharos Sirius", 50, 48),
            new Content(DUNGEON, "Copperbell Mines (Hard)", 50, 48),
            new Content(DUNGEON, "Haukke Manor (Hard)", 50, 48),
            new Content(DUNGEON, "The Lost City of Amdapor", 50, 55),
            new Content(DUNGEON, "Halatali (Hard)", 50, 55),
            new Content(DUNGEON, "Brayflox's Longstop (Hard)", 50, 55),
            new Content(DUNGEON, "Hullbreaker Isle", 50, 70),
            new Content(DUNGEON, "The Stone Vigil (Hard)", 50, 70),
            new Content(DUNGEON, "The Tam-Tara Deepcroft (Hard)", 50, 70),
            new Content(DUNGEON, "Snowcloak", 50, 80),
            new Content(DUNGEON, "Sastasha (Hard)", 50, 80),
            new Content(DUNGEON, "The Sunken Temple of Qarn (Hard)", 50, 80),
            new Content(DUNGEON, "The Keeper of the Lake", 50, 90),
            new Content(DUNGEON, "The Wanderer's Palace (Hard)", 50, 90),
            new Content(DUNGEON, "Amdapor Keep (Hard)", 50 , 90),
            new Content(DUNGEON, "The Dusk Vigil", 51, 100),
            new Content(DUNGEON, "Sohm Al", 53, 105),
            new Content(DUNGEON, "The Aery", 55, 110),
            new Content(DUNGEON, "The Vault", 57, 115),
            new Content(DUNGEON, "The Great Gubal Library", 59, 120),
            new Content(DUNGEON, "The Aetherochemical Research Facility", 60, 142),
            new Content(DUNGEON, "Neverreap", 60, 145),
            new Content(DUNGEON, "The Fractal Continuum", 60, 145),
            new Content(DUNGEON, "Saint Mocianne's Arboretum", 60, 170),
            new Content(DUNGEON, "Pharos Sirius (Hard)", 60, 170),
            new Content(DUNGEON, "The Antitower", 60, 180),
            new Content(DUNGEON, "The Lost City of Amdapor (Hard)", 60, 180),
            new Content(DUNGEON, "Sohr Khai", 60, 200),
            new Content(DUNGEON, "Hullbreaker Isle (Hard)", 60, 200),
            new Content(DUNGEON, "Xelphatol", 60, 210),
            new Content(DUNGEON, "The Great Gubal Library (Hard)", 60, 210),
            new Content(DUNGEON, "Baelsar's Wall", 60, 230),
            new Content(DUNGEON, "Sohm Al (Hard)", 60, 230),
            new Content(DUNGEON, "The Sirensong Sea", 61, 240),
            new Content(DUNGEON, "Shisui of the Violet Tides", 63, 245),
            new Content(DUNGEON, "Bardam's Mettle", 65, 250),
            new Content(DUNGEON, "Doma Castle", 67, 255),
            new Content(DUNGEON, "Castrum Abania", 69, 260),
            new Content(DUNGEON, "Ala Mhigo", 70, 280),
            new Content(DUNGEON, "Kugane Castle", 70, 280),
            new Content(DUNGEON, "The Temple of the Fist", 70, 280),
            new Content(DUNGEON, "The Drowned City of Skalla", 70, 300),
            new Content(DUNGEON, "Hells' Lid", 70, 310),
            new Content(DUNGEON, "The Fractal Continuum (Hard)", 70, 310),
            new Content(DUNGEON, "The Swallow's Compass", 70, 330),
            new Content(DUNGEON, "Saint Mocianne's Arboretum (Hard)", 70, 340),
            new Content(DUNGEON, "The Burn", 70, 340),
            new Content(DUNGEON, "The Ghimlyt Dark", 70, 360),
            new Content(DUNGEON, "Holminster Switch", 71, 370),
            new Content(DUNGEON, "Dohn Mheg", 73, 375),
            new Content(DUNGEON, "The Qitana Ravel", 75, 380),
            new Content(DUNGEON, "Malikah's Well", 77, 385),
            new Content(DUNGEON, "Mt. Gulg", 79, 390),
            new Content(DUNGEON, "Amaurot", 80, 410),
            new Content(DUNGEON, "The Twinning", 80, 410),
            new Content(DUNGEON, "Akadaemia Anyder", 80, 410),
            new Content(DUNGEON, "The Grand Cosmos", 80, 430),
            new Content(TRIAL, "The Bowl of Embers", 20, 0),
            new Content(TRIAL, "The Navel", 34, 0),
            new Content(TRIAL, "The Howling Eye", 44, 0),
            new Content(TRIAL, "Cape Westwind", 49, 0),
            new Content(TRIAL, "The Chrysalis", 50, 90),
            new Content(TRIAL, "The Steps of Faith", 50, 90),
            new Content(TRIAL, "A Relic Reborn: The Chimera", 50, 52),
            new Content(TRIAL, "A Relic Reborn: The Hydra", 50, 52),
            new Content(TRIAL, "Battle on the Big Bridge", 50, 50),
            new Content(TRIAL, "The Dragon's Neck", 50, 80),
            new Content(TRIAL, "Battle in the Big Keep", 50, 90),
            new Content(TRIAL, "The Bowl of Embers (Hard)", 50, 49),
            new Content(TRIAL, "The Howling Eye (Hard)", 50, 52),
            new Content(TRIAL, "The Navel (Hard)", 50, 57),
            new Content(TRIAL, "Thornmarch (Hard)", 50, 54),
            new Content(TRIAL, "The Whorleater (Hard)", 50, 60),
            new Content(TRIAL, "The Striking Tree (Hard)", 50, 65),
            new Content(TRIAL, "Akh Afah Amphitheatre (Hard)", 50, 80),
            new Content(TRIAL, "Urth's Fount", 50, 95),
            new Content(TRIAL, "The Minstrel's Ballad: Ultima's Bane", 50, 61),
            new Content(TRIAL, "The Howling Eye (Extreme)", 50, 65),
            new Content(TRIAL, "The Navel (Extreme)", 50, 67),
            new Content(TRIAL, "The Bowl of Embers (Extreme)", 50, 67),
            new Content(TRIAL, "Thornmarch (Extreme)", 50, 80),
            new Content(TRIAL, "The Whorleater (Extreme)", 50, 80),
            new Content(TRIAL, "The Striking Tree (Extreme)", 50, 85),
            new Content(TRIAL, "Akh Afah Amphitheatre (Extreme)", 50, 95),
            new Content(TRIAL, "Thok ast Thok (Hard)", 53, 0),
            new Content(TRIAL, "The Limitless Blue (Hard)", 57, 0),
            new Content(TRIAL, "The Singularity Reactor", 60, 142),
            new Content(TRIAL, "The Final Steps of Faith", 60, 205),
            new Content(TRIAL, "Containment Bay S1T7", 60, 190),
            new Content(TRIAL, "Containment Bay P1T6", 60, 220),
            new Content(TRIAL, "Containment Bay Z1T9", 60, 235),
            new Content(TRIAL, "The Limitless Blue (Extreme)", 60, 165),
            new Content(TRIAL, "Thok ast Thok (Extreme)", 60, 175),
            new Content(TRIAL, "The Minstrel's Ballad: Thordan's Reign", 60, 190),
            new Content(TRIAL, "The Minstrel's Ballad: Nidhogg's Rage", 60, 220),
            new Content(TRIAL, "Containment Bay S1T7 (Extreme)", 60, 205),
            new Content(TRIAL, "Containment Bay P1T6 (Extreme)", 60, 235),
            new Content(TRIAL, "Containment Bay Z1T9 (Extreme)", 60, 250),
            new Content(TRIAL, "The Pool of Tribute", 63, 0),
            new Content(TRIAL, "Emanation", 67, 0),
            new Content(TRIAL, "The Royal Menagerie", 70, 280),
            new Content(TRIAL, "The Jade Stoa", 70, 325),
            new Content(TRIAL, "Castrum Fluminis", 70, 335),
            new Content(TRIAL, "The Great Hunt", 70, 320),
            new Content(TRIAL, "Hell's Kier", 70, 355),
            new Content(TRIAL, "The Wreath of Snakes", 70, 365),
            new Content(TRIAL, "Kugane Ohashi", 70, 365),
            new Content(TRIAL, "The Pool of Tribute (Extreme)", 70, 300),
            new Content(TRIAL, "Emanation (Extreme)", 70, 300),
            new Content(TRIAL, "The Minstrel's Ballad: Shinryu's Domain", 70, 320),
            new Content(TRIAL, "The Jade Stoa (Extreme)", 70, 340),
            new Content(TRIAL, "The Minstrel's Ballad: Tsukuyomi's Pain", 70, 350),
            new Content(TRIAL, "The Great Hunt (Extreme)", 70, 350),
            new Content(TRIAL, "Hell's Kier (Extreme)", 70, 370),
            new Content(TRIAL, "The Wreath of Snakes (Extreme)", 70, 380),
            new Content(TRIAL, "The Dancing Plague", 73, 0),
            new Content(TRIAL, "The Crown of the Immaculate", 79, 0),
            new Content(TRIAL, "The Dying Gasp", 80, 410),
            new Content(TRIAL, "The Dancing Plague (Extreme)", 80, 430),
            new Content(TRIAL, "The Crown of the Immaculate (Extreme)", 80, 430),
            new Content(TRIAL, "The Minstrel's Ballad: Hades' Elegy", 80, 450),
            new Content(RAID, "The Binding Coil of Bahamut", 50, 70),
            new Content(RAID, "The Second Coil of Bahamut", 50, 90),
            new Content(RAID, "The Second Coil of Bahamut (Savage)", 50, 90),
            new Content(RAID, "The Final Coil of Bahamut", 50, 90),
            new Content(RAID, "Alexander: Gordias", 60, 170),
            new Content(RAID, "Alexander: Gordia (Savage)", 60, 190),
            new Content(RAID, "Alexander: Midas", 60, 200),
            new Content(RAID, "Alexander: Midas (Savage)", 60, 215),
            new Content(RAID, "Alexander: The Creator", 60, 230),
            new Content(RAID, "Alexander: The Creator (Savage)", 60, 245),
            new Content(RAID, "Omega: Deltascape", 70, 295),
            new Content(RAID, "Omega: Deltascape (Savage)", 70, 310),
            new Content(RAID, "The Unending Coil of Bahamut (Ultimate)", 70, 340),
            new Content(RAID, "Omega: Sigmascape", 70, 325),
            new Content(RAID, "Omega: Sigmascape (Savage)", 70, 340),
            new Content(RAID, "The Minstrel's Ballad: The Weapon's Refrain (Ultimate)", 70, 370),
            new Content(RAID, "Omega: Alphascape", 70, 355),
            new Content(RAID, "Omega: Alphascape (Savage)", 70, 370),
            new Content(RAID, "Eden's Gate", 80, 425),
            new Content(RAID, "Eden's Gate (Savage)", 80, 440),
            new Content(RAID, "The Epic of Alexander (Ultimate)", 80, 470),
            new Content(ALLIANCE_RAID, "Labyrinth of the Ancients", 50, 50),
            new Content(ALLIANCE_RAID, "Syrcus Tower", 50, 70),
            new Content(ALLIANCE_RAID, "The World of Darkness", 50, 90),
            new Content(ALLIANCE_RAID, "The Void Ark", 60, 175),
            new Content(ALLIANCE_RAID, "The Weeping City of Mhach", 60, 205),
            new Content(ALLIANCE_RAID, "Dun Scaith", 60, 235),
            new Content(ALLIANCE_RAID, "The Royal City of Rabanastre", 70, 305),
            new Content(ALLIANCE_RAID, "The Ridorana Lighthouse", 70, 335),
            new Content(ALLIANCE_RAID, "The Orbonne Monastery", 70, 365),
            new Content(ALLIANCE_RAID, "The Copied Factory", 80, 435),
            new Content(GUILDHEST, "Basic Training: Enemy Parties", 10, 0),
            new Content(GUILDHEST, "Under the Armor", 10, 0),
            new Content(GUILDHEST, "Basic Training: Enemy Strongholds", 15, 0),
            new Content(GUILDHEST, "Hero on the Halfshell", 15, 0),
            new Content(GUILDHEST, "Pulling Poison Posies", 20, 0),
            new Content(GUILDHEST, "Stinging Back", 20, 0),
            new Content(GUILDHEST, "All's Well that Ends in the Well", 25, 0),
            new Content(GUILDHEST, "Flicking Sticks and Taking Names", 25, 0),
            new Content(GUILDHEST, "More than a Feeler", 30, 0),
            new Content(GUILDHEST, "Annoy the Void", 30, 0),
            new Content(GUILDHEST, "Shadow and Claw", 35, 0),
            new Content(GUILDHEST, "Long Live the Queen", 35, 0),
            new Content(GUILDHEST, "Ward Up", 40, 0),
            new Content(GUILDHEST, "Solemn Trinity", 40, 0),
            new Content(RAID, "Alexander - The Arm of the Father", 60, 170),
            new Content(RAID, "Alexander - The Burden of the Father", 60, 170),
            new Content(RAID, "Alexander - The Arm of the Son", 60, 200),
            new Content(RAID, "Alexander - The Burden of the Son", 60, 200),
            new Content(RAID, "Alexander - The Heart of the Creator", 60, 230),
            new Content(RAID, "Alexander - The Soul of the Creator", 60, 230),
            new Content(RAID, "Eden's Gate - Resurrection", 80, 0),
            new Content(RAID, "Eden's Gate - Descent", 80, 0),
            new Content(RAID, "Eden's Gate - Inundation", 80, 0),
            new Content(RAID, "Eden's Gate - Sepulture", 80, 0),
            new Content(RAID, "Eden's Gate - Resurrection (Savage)", 80, 0),
            new Content(RAID, "Eden's Gate - Descent (Savage)", 80, 0),
            new Content(RAID, "Eden's Gate - Inundation (Savage)", 80, 0),
            new Content(RAID, "Eden's Gate - Sepulture (Savage)", 80, 0),
            new Content(RAID, "The Binding Coil of Bahamut - Turn 1", 50, 0),
            new Content(RAID, "The Binding Coil of Bahamut - Turn 2", 50, 0),
            new Content(RAID, "The Binding Coil of Bahamut - Turn 3", 50, 0),
            new Content(RAID, "The Binding Coil of Bahamut - Turn 4", 50, 0),
            new Content(RAID, "The Binding Coil of Bahamut - Turn 5", 50, 0),
            new Content(RAID, "The Second Coil of Bahamut - Turn 1", 50, 0),
            new Content(RAID, "The Second Coil of Bahamut - Turn 2", 50, 0),
            new Content(RAID, "The Second Coil of Bahamut - Turn 3", 50, 0),
            new Content(RAID, "The Second Coil of Bahamut - Turn 4", 50, 0),
            new Content(RAID, "The Second Coil of Bahamut - Turn 1 (Savage)", 50, 0),
            new Content(RAID, "The Second Coil of Bahamut - Turn 2 (Savage)", 50, 0),
            new Content(RAID, "The Second Coil of Bahamut - Turn 3 (Savage)", 50, 0),
            new Content(RAID, "The Second Coil of Bahamut - Turn 4 (Savage)", 50, 0),
            new Content(RAID, "The Final Coil of Bahamut - Turn 1", 50, 0),
            new Content(RAID, "The Final Coil of Bahamut - Turn 2", 50, 0),
            new Content(RAID, "The Final Coil of Bahamut - Turn 3", 50, 0),
            new Content(RAID, "The Final Coil of Bahamut - Turn 4", 50, 0),
            new Content(RAID, "Alexander - The Fist of the Father", 60, 170),
            new Content(RAID, "Alexander - The Cuff of the Father", 60, 170),
            new Content(RAID, "Alexander - The Fist of the Father (Savage)", 60, 170),
            new Content(RAID, "Alexander - The Cuff of the Father (Savage)", 60, 170),
            new Content(RAID, "Alexander - The Arm of the Father (Savage)", 60, 170),
            new Content(RAID, "Alexander - The Burden of the Father (Savage)", 60, 170),
            new Content(RAID, "Alexander - The Fist of the Son", 60, 200),
            new Content(RAID, "Alexander - The Cuff of the Son", 60, 200),
            new Content(RAID, "Alexander - The Fist of the Son (Savage)", 60, 200),
            new Content(RAID, "Alexander - The Cuff of the Son (Savage)", 60, 200),
            new Content(RAID, "Alexander - The Arm of the Son (Savage)", 60, 200),
            new Content(RAID, "Alexander - The Burden of the Son (Savage)", 60, 200),
            new Content(RAID, "Alexander - The Eyes of the Creator", 60, 230),
            new Content(RAID, "Alexander - The Breath of the Creator", 60, 230),
            new Content(RAID, "Alexander - The Eyes of the Creator (Savage)", 60, 230),
            new Content(RAID, "Alexander - The Breath of the Creator (Savage)", 60, 230),
            new Content(RAID, "Alexander - The Heart of the Creator (Savage)", 60, 230),
            new Content(RAID, "Alexander - The Soul of the Creator (Savage)", 60, 230),
            new Content(RAID, "Deltascape V1.0", 70, 0),
            new Content(RAID, "Deltascape V2.0", 70, 0),
            new Content(RAID, "Deltascape V3.0", 70, 0),
            new Content(RAID, "Deltascape V4.0", 70, 0),
            new Content(RAID, "Deltascape V1.0 (Savage)", 70, 0),
            new Content(RAID, "Deltascape V2.0 (Savage)", 70, 0),
            new Content(RAID, "Deltascape V3.0 (Savage)", 70, 0),
            new Content(RAID, "Deltascape V4.0 (Savage)", 70, 0),
            new Content(RAID, "Sigmascape V1.0", 70, 0),
            new Content(RAID, "Sigmascape V2.0", 70, 0),
            new Content(RAID, "Sigmascape V3.0", 70, 0),
            new Content(RAID, "Sigmascape V4.0", 70, 0),
            new Content(RAID, "Sigmascape V1.0 (Savage)", 70, 0),
            new Content(RAID, "Sigmascape V2.0 (Savage)", 70, 0),
            new Content(RAID, "Sigmascape V3.0 (Savage)", 70, 0),
            new Content(RAID, "Sigmascape V4.0 (Savage)", 70, 0),
            new Content(RAID, "Alphascape V1.0", 70, 0),
            new Content(RAID, "Alphascape V2.0", 70, 0),
            new Content(RAID, "Alphascape V3.0", 70, 0),
            new Content(RAID, "Alphascape V4.0", 70, 0),
            new Content(RAID, "Alphascape V1.0 (Savage)", 70, 0),
            new Content(RAID, "Alphascape V2.0 (Savage)", 70, 0),
            new Content(RAID, "Alphascape V3.0 (Savage)", 70, 0),
            new Content(RAID, "Alphascape V4.0 (Savage)", 70, 0),
        };

        static List<SeedZone> _zones = new List<SeedZone>()
        {
            new SeedZone { Id = 1, RegionName = LA_NOSCEA, Name = LIMSAUPPER },
            new SeedZone { Id = 2, RegionName = LA_NOSCEA, Name = LIMSALOWER },
            new SeedZone { Id = 3, RegionName = LA_NOSCEA, Name = LOWERLN },
            new SeedZone { Id = 4, RegionName = LA_NOSCEA, Name = MIDDLELN },
            new SeedZone { Id = 5, RegionName = LA_NOSCEA, Name = EASTERNLN },
            new SeedZone { Id = 6, RegionName = LA_NOSCEA, Name = WESTERNLN },
            new SeedZone { Id = 7, RegionName = LA_NOSCEA, Name = OUTERLN },
            new SeedZone { Id = 8, RegionName = LA_NOSCEA, Name = UPPERLN },
            new SeedZone { Id = 9, RegionName = LA_NOSCEA, Name = MIST },
            new SeedZone { Id = 10, RegionName = LA_NOSCEA, Name = WOLVES_DEN },
            new SeedZone { Id = 11, RegionName = THANALAN, Name = ULDAHNALD },
            new SeedZone { Id = 12, RegionName = THANALAN, Name = ULDAHTHAL },
            new SeedZone { Id = 13, RegionName = THANALAN, Name = CENTRALTHAN },
            new SeedZone { Id = 14, RegionName = THANALAN, Name = WESTERNTHAN },
            new SeedZone { Id = 15, RegionName = THANALAN, Name = EASTERNTHAN },
            new SeedZone { Id = 16, RegionName = THANALAN, Name = SOUTHERNTHAN },
            new SeedZone { Id = 17, RegionName = THANALAN, Name = NORTHERNTHAN },
            new SeedZone { Id = 18, RegionName = THANALAN, Name = GOBLET },
            new SeedZone { Id = 19, RegionName = BLACK_SHROUD, Name = OLDGRID },
            new SeedZone { Id = 20, RegionName = BLACK_SHROUD, Name = NEWGRID },
            new SeedZone { Id = 21, RegionName = BLACK_SHROUD, Name = CENTRALSHROUD },
            new SeedZone { Id = 22, RegionName = BLACK_SHROUD, Name = NORTHSHROUD },
            new SeedZone { Id = 23, RegionName = BLACK_SHROUD, Name = EASTSHROUD },
            new SeedZone { Id = 24, RegionName = BLACK_SHROUD, Name = SOUTHSHROUD },
            new SeedZone { Id = 25, RegionName = BLACK_SHROUD, Name = LAVENDERBEDS },
            new SeedZone { Id = 26, RegionName = MOR_DHONA, Name = MORDHONA },
            new SeedZone { Id = 27, RegionName = COERTHAS, Name = FOUNDATION },
            new SeedZone { Id = 28, RegionName = COERTHAS, Name = PILLARS },
            new SeedZone { Id = 29, RegionName = COERTHAS, Name = COERTHASCENTRAL },
            new SeedZone { Id = 30, RegionName = COERTHAS, Name = COERTHASWESTERN },
            new SeedZone { Id = 31, RegionName = ABALATHIA, Name = SEAOFCLOUDS },
            new SeedZone { Id = 32, RegionName = ABALATHIA, Name = AZYSLLA },
            new SeedZone { Id = 33, RegionName = DRAVANIA, Name = IDYLLSHIRE },
            new SeedZone { Id = 34, RegionName = DRAVANIA, Name = DRAVANIANFORELANDS },
            new SeedZone { Id = 35, RegionName = DRAVANIA, Name = DRAVANIANHINTERLANDS },
            new SeedZone { Id = 36, RegionName = DRAVANIA, Name = CHURNINGMISTS },
            new SeedZone { Id = 37, RegionName = GYR_ABANIA, Name = RHALGRSREACH },
            new SeedZone { Id = 38, RegionName = GYR_ABANIA, Name = FRINGES },
            new SeedZone { Id = 39, RegionName = GYR_ABANIA, Name = LOCHS },
            new SeedZone { Id = 40, RegionName = GYR_ABANIA, Name = PEAKS },
            new SeedZone { Id = 41, RegionName = OTHARD, Name = AZIMSTEPPE },
            new SeedZone { Id = 42, RegionName = OTHARD, Name = RUBYSEA },
            new SeedZone { Id = 43, RegionName = OTHARD, Name = YANXIA },
            new SeedZone { Id = 44, RegionName = HINGASHI, Name = KUGANE },
            new SeedZone { Id = 45, RegionName = HINGASHI, Name = SHIROGANE },
            new SeedZone { Id = 46, RegionName = NORVRANDT, Name = CRYSTARIUM },
            new SeedZone { Id = 47, RegionName = NORVRANDT, Name = EULMORECANOPY },
            new SeedZone { Id = 48, RegionName = NORVRANDT, Name = EULMOREUNDERSTORY },
            new SeedZone { Id = 49, RegionName = NORVRANDT, Name = EULMOREBUTTRESS },
            new SeedZone { Id = 50, RegionName = NORVRANDT, Name = LAKELAND },
            new SeedZone { Id = 51, RegionName = NORVRANDT, Name = KHOLUSIA },
            new SeedZone { Id = 52, RegionName = NORVRANDT, Name = AMHARAENG },
            new SeedZone { Id = 53, RegionName = NORVRANDT, Name = ILMHEG },
            new SeedZone { Id = 54, RegionName = NORVRANDT, Name = RAKTIKA },
            new SeedZone { Id = 55, RegionName = NORVRANDT, Name = TEMPEST },
            new SeedZone { Id = 56, RegionName = DIADEM, Name = DIADEM }
        };
    }
}
