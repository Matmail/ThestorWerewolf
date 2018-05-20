using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werewolf_Control.Helpers
{
    internal static class Settings
    {

        //By the way, these admin ports will have IP whitelisting.  Don't even bother trying to connect to them :P
        //The regular ports are not even open on the firewall
#if DEBUG
        public static int Port = 9049;
        public static int AdminPort = 9059;
#elif RELEASE
        public static int Port = 9050;  //9050-@werewolfbot 
        public static int AdminPort = 9060;
#elif RELEASE2
        public static int Port = 9051;  //9051-@werewolfIIbot
        public static int AdminPort = 9063; //9061 not responding
#elif BETA
        public static int Port = 9052;
        public static int AdminPort = 9062;
#endif



        public static string TcpSecret => Environment.MachineName.GetHashCode().ToString();
        public static readonly long PersianSupportChatId = -1001059174638;
        public static readonly long MainChatId = -1001049529775; //Beta group
        public static readonly long SupportChatId = -1001060486754; //@werewolfsupport
        public static readonly long PrimaryChatId = -1001030085238; //@werewolfgame
        public static readonly string DevChannelId = "@werewolfdev"; //@werewolfdev
        public static readonly long VeteranChatId = -1001094614730;
        public static readonly string VeteranChatLink = "werewolfvets";
        public static readonly string VeteranChatUrl = "https://t.me/werewolfvets";
        public static readonly long TranslationChatId = -1001074012132;
        public static readonly long AdminChatId = -1001094155678;
        public static readonly long ErrorGroup = -1001098399855;
#if RELEASE2
        public static List<string> VillagerDieImages = new List<string> { "CgADBAAD2YUAAgobZAdLjy_G9R1OWgI" }; //laughing dog
        public static List<string> WolfWin = new List<string> { "CgADBAADp6AAAs4XZAd1OT59fE5v8gI" }; //1 wolf
        public static List<string> WolvesWin = new List<string> { "CgADBAAD8hUAAhYYZAfHjrJdIrslmgI" }; //2 wolves
        public static List<string> VillagersWin = new List<string> { "CgADBAADPqUAAvsYZAdpARA80fkboQI" }; //snowy village
        public static List<string> NoWinner = new List<string> { "CgADBAADq4EAAiscZAcQuPr65RLBqgI" }; // Loser
        public static List<string> StartGame = new List<string> { "CgADBAADs4IAAqEZZAfQEF0nCx7twAI" }; //"oh boy, here we go"
        public static List<string> StartChaosGame = new List<string> { "CgADAgADSwIAAhA_yUrrYsX5BcqIEwI" }; //rainbow-moon
        public static List<string> TannerWin = new List<string> { "CgADBAADmJ8AAnoZZAcJ08js65-tDwI" }; //weird guy
        public static List<string> CultWins = new List<string> { "CgADAgADSgIAAhA_yUoTBhYc4sCvMwI" }; //girl eating worms
        public static List<string> SerialKillerWins = new List<string> { "CgADBAADZgMAAp0YZAch-MOWBmoFVQI" }; //cat with knife
        public static List<string> LoversWin = new List<string> { "CgADAgADTAIAAhA_yUq9iZCjRT8fxQI" }; //wolf-girl
#elif RELEASE
        public static List<string> VillagerDieImages = new List<string> { "CgADBAAD2YUAAgobZAdLjy_G9R1OWgI" }; //laughing dog
        public static List<string> WolfWin = new List<string> { "CgADBAADp6AAAs4XZAd1OT59fE5v8gI" }; //1 wolf
        public static List<string> WolvesWin = new List<string> { "CgADBAAD8hUAAhYYZAfHjrJdIrslmgI" }; //2 wolves
        public static List<string> VillagersWin = new List<string> { "CgADBAADPqUAAvsYZAdpARA80fkboQI" }; //snowy village
        public static List<string> NoWinner = new List<string> { "CgADBAADq4EAAiscZAcQuPr65RLBqgI" }; // Loser
        public static List<string> StartGame = new List<string> { "CgADBAADs4IAAqEZZAfQEF0nCx7twAI" }; //"oh boy, here we go"
        public static List<string> StartChaosGame = new List<string> { "CgADAgADSwIAAhA_yUrrYsX5BcqIEwI" }; //rainbow-moon
        public static List<string> TannerWin = new List<string> { "CgADBAADmJ8AAnoZZAcJ08js65-tDwI" }; //weird guy
        public static List<string> CultWins = new List<string> { "CgADAgADSgIAAhA_yUoTBhYc4sCvMwI" }; //girl eating worms
        public static List<string> SerialKillerWins = new List<string> { "CgADBAADZgMAAp0YZAch-MOWBmoFVQI" }; //cat with knife
        public static List<string> LoversWin = new List<string> { "CgADAgADTAIAAhA_yUq9iZCjRT8fxQI" }; //wolf-girl
#else
        public static List<string> VillagerDieImages = new List<string> { "CgADBAAD2YUAAgobZAdLjy_G9R1OWgI" }; //laughing dog
        public static List<string> WolfWin = new List<string> { "CgADBAADp6AAAs4XZAd1OT59fE5v8gI" }; //1 wolf
        public static List<string> WolvesWin = new List<string> { "CgADBAAD8hUAAhYYZAfHjrJdIrslmgI" }; //2 wolves
        public static List<string> VillagersWin = new List<string> { "CgADBAADPqUAAvsYZAdpARA80fkboQI" }; //snowy village
        public static List<string> NoWinner = new List<string> { "CgADBAADq4EAAiscZAcQuPr65RLBqgI" }; // Loser
        public static List<string> StartGame = new List<string> { "CgADBAADs4IAAqEZZAfQEF0nCx7twAI" }; //"oh boy, here we go"
        public static List<string> StartChaosGame = new List<string> { "CgADAgADSwIAAhA_yUrrYsX5BcqIEwI" }; //rainbow-moon
        public static List<string> TannerWin = new List<string> { "CgADBAADmJ8AAnoZZAcJ08js65-tDwI" }; //weird guy
        public static List<string> CultWins = new List<string> { "CgADAgADSgIAAhA_yUoTBhYc4sCvMwI" }; //girl eating worms
        public static List<string> SerialKillerWins = new List<string> { "CgADBAADZgMAAp0YZAch-MOWBmoFVQI" }; //cat with knife
        public static List<string> LoversWin = new List<string> { "CgADAgADTAIAAhA_yUq9iZCjRT8fxQI" }; //wolf-girl
#endif

        /// <summary>
        /// How many games are allowed for any given node
        /// </summary>
        public static int MaxGamesPerNode = 60;

        /// <summary>
        /// How many games on each node before starting a new node (to be added later)
        /// </summary>
#if DEBUG
        public static int NewNodeThreshhold = 10;
#else
        public static int NewNodeThreshhold = 30;
#endif
        public static int ShutDownNodesAt = 15;

        public static int
#if DEBUG
            MinPlayers = 1,
#else
            MinPlayers = 5,
#endif
            MaxPlayers = 35,
            TimeDay = 60,
            TimeNight = 90,
            TimeLynch = 90,
#if DEBUG
            PlayerCountSeerCursed = 6,
            PlayerCountHarlot = 7,
            PlayerCountBeholderChance = 8,
            PlayerCountSecondWolf = 9,
            PlayerCountGunner = 9,
            PlayerCountTraitor = 10,
            PlayerCountGuardianAngel = 11,
            PlayerCountDetective = 12,
            PlayerCountApprenticeSeer = 13,
            PlayerCountCultist = 15,
            PlayerCountThirdWolf = 16,
            PlayerCountWildChild = 17,
            PlayerCountFoolChance = 18,
            PlayerCountMasons = 21,
            PlayerCountSecondCultist = 22,
            MaxGames = 80,
            TannerChance = 40,
            FoolChance = 20,
            BeholderChance = 50,
            SeerConversionChance = 40,
            GuardianAngelConversionChance = 60,
            DetectiveConversionChance = 70,
            CursedConversionChance = 60,
            HarlotConversionChance = 70,
            SorcererConversionChance = 40,
            BlacksmithConversionChance = 75,
            HarlotDiscoverCultChance = 50,
            ChanceDetectiveCaught = 40,

#else
            PlayerCountSeerCursed = 6,
            PlayerCountHarlot = 7,
            PlayerCountBeholderChance = 8,
            PlayerCountSecondWolf = 9,
            PlayerCountGunner = 9,
            PlayerCountTraitor = 10,
            PlayerCountGuardianAngel = 11,
            PlayerCountDetective = 12,
            PlayerCountApprenticeSeer = 13,
            PlayerCountCultist = 15,
            PlayerCountThirdWolf = 16,
            PlayerCountWildChild = 17,
            PlayerCountFoolChance = 18,
            PlayerCountMasons = 21,
            PlayerCountSecondCultist = 22,
            MaxGames = 80,
            TannerChance = 40,
            FoolChance = 20,
            BeholderChance = 50,
            SeerConversionChance = 40,
            GuardianAngelConversionChance = 60,
            DetectiveConversionChance = 70,
            CursedConversionChance = 60,
            HarlotConversionChance = 70,
            SorcererConversionChance = 40,
            BlacksmithConversionChance = 75,
            HarlotDiscoverCultChance = 50,
            ChanceDetectiveCaught = 40,
#endif

            GameJoinTime = 180,
            MaxExtend = 60;
    }
}
