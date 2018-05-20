using System.Collections.Generic;

namespace Werewolf_Node
{
    static class Settings
    {
#if DEBUG
        public static string ServerIP = "127.0.0.1";
#else
        public static string ServerIP = "127.0.0.1";

#endif
#if DEBUG
        public static int Port = 9049;
#elif RELEASE
        public static int Port = 9050;
#elif RELEASE2
        public static int Port = 9051;
#elif BETA
        public static int Port = 9052;
#endif


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
#if !DEBUG
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
            PlayerCountDoppelGanger = 22,
            PlayerCountCupid = 23,
            PlayerCountHunter = 24,
            PlayerCountSerialKiller = 25,
            PlayerCountSecondCultist = 26,
            MaxGames = 80,
            TannerChance = 40,
            FoolChance = 20,
            BeholderChance = 50,
            SeerConversionChance = 40,
            GuardianAngelConversionChance = 60,
            DetectiveConversionChance = 70,
            CursedConversionChance = 60,
            HarlotConversionChance = 70,
            HarlotDiscoverCultChance = 50,
            ChanceDetectiveCaught = 40,
            HunterConversionChance = 50,
            HunterKillCultChance = 50,
            HunterKillWolfChanceBase = 30,
            SerialKillerConversionChance = 20,
            AlphaWolfConversionChance = 20,
            SorcererConversionChance = 40,
            BlacksmithConversionChance = 75,
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
            PlayerCountDoppelGanger = 22,
            PlayerCountCupid = 23,
            PlayerCountHunter = 24,
            PlayerCountSerialKiller = 25,
            PlayerCountSecondCultist = 26,
            MaxGames = 80,
            TannerChance = 40,
            FoolChance = 20,
            BeholderChance = 50,
            SeerConversionChance = 40,
            GuardianAngelConversionChance = 60,
            DetectiveConversionChance = 70,
            CursedConversionChance = 60,
            HarlotConversionChance = 70,
            HarlotDiscoverCultChance = 50,
            ChanceDetectiveCaught = 40,
            HunterConversionChance = 50,
            HunterKillCultChance = 50,
            HunterKillWolfChanceBase = 30,
            SerialKillerConversionChance = 20,
            AlphaWolfConversionChance = 20,
            SorcererConversionChance = 40,
            BlacksmithConversionChance = 75,
#endif

            GameJoinTime = 180,
            MaxJoinTime = 300;



#if DEBUG
        //public static long MainChatId = -134703013;
        public static long MainChatId = -1001049529775; //Beta group
#else
        public static long MainChatId = -1001030085238;
#endif
        public static long VeteranChatId = -1001094614730;
        public static string VeteranChatLink = "werewolfvets";

        public static bool RandomLynch = false;
    }
}
