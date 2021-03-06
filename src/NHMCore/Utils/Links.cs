﻿using NHM.Common;
using NHM.Common.Enums;

namespace NHMCore.Utils
{
    public static class Links
    {
// TESTNET
        public const string VisitUrl_TESTNET = "https://test.nicehash.com";
        public const string CheckStats_TESTNET = "https://test.nicehash.com/mining/stats";
        public const string Register_TESTNET = "NO_URL";
        //public const string Login_TESTNET = "NO_URL";
        public const string NhmPayingFaq_TESTNET = "https://www.nicehash.com/support/mining-help/earnings-and-payments/when-and-how-do-you-get-paid"; // ADD TESTNET
// TESTNETDEV
        public const string VisitUrl_TESTNETDEV = "https://test-dev.nicehash.com";
        public const string CheckStats_TESTNETDEV = "https://test-dev.nicehash.com/mining/stats";
        public const string Register_TESTNETDEV = "NO_URL";
        //public const string Login_TESTNETDEV = "NO_URL";
        public const string NhmPayingFaq_TESTNETDEV = "https://www.nicehash.com/support/mining-help/earnings-and-payments/when-and-how-do-you-get-paid";  // ADD TESTNETDEV
// PRODUCTION
        public const string VisitUrl_PRODUCTION = "https://nicehash.com";
        public const string CheckStats_PRODUCTION = "https://nicehash.com/my/mining/stats";
        public const string Register_PRODUCTION = "https://nicehash.com/my/register";
        //public const string Login_PRODUCTION = "NO_URL";
        public const string NhmPayingFaq_PRODUCTION = "https://www.nicehash.com/support/mining-help/earnings-and-payments/when-and-how-do-you-get-paid";

        public static string VisitUrl
        {
            get
            {
                if (BuildOptions.BUILD_TAG == BuildTag.TESTNET) return VisitUrl_TESTNET;
                if (BuildOptions.BUILD_TAG == BuildTag.TESTNETDEV) return VisitUrl_TESTNETDEV;
                //BuildTag.PRODUCTION
                return VisitUrl_PRODUCTION;
            }
        }

        public static string CheckStats
        {
            get
            {
                if (BuildOptions.BUILD_TAG == BuildTag.TESTNET) return CheckStats_TESTNET;
                if (BuildOptions.BUILD_TAG == BuildTag.TESTNETDEV) return CheckStats_TESTNETDEV;
                //BuildTag.PRODUCTION
                return CheckStats_PRODUCTION;
            }
        }
        public static string Register
        {
            get
            {
                if (BuildOptions.BUILD_TAG == BuildTag.TESTNET) return Register_TESTNET;
                if (BuildOptions.BUILD_TAG == BuildTag.TESTNETDEV) return Register_TESTNETDEV;
                //BuildTag.PRODUCTION
                return Register_PRODUCTION;
            }
        }
        //public const string Login = "NO_URL";
        public static string NhmPayingFaq
        {
            get
            {
                if (BuildOptions.BUILD_TAG == BuildTag.TESTNET) return NhmPayingFaq_TESTNET;
                if (BuildOptions.BUILD_TAG == BuildTag.TESTNETDEV) return NhmPayingFaq_TESTNETDEV;
                //BuildTag.PRODUCTION
                return NhmPayingFaq_PRODUCTION;
            }
        }

        public static string PluginsJsonApiUrl
        {
            get
            {
                if (BuildOptions.IS_PLUGINS_TEST_SOURCE) return "https://miner-plugins-test-dev.nicehash.com/api/plugins";
                return "https://miner-plugins.nicehash.com/api/plugins";
            }
        }
        
        
        // add version
        public const string VisitReleasesUrl = "https://github.com/NiceHash/NiceHashMiner/releases/";
        public const string VisitNewVersionReleaseUrl = "https://github.com/NiceHash/NiceHashMiner/releases/tag/";

        public const string UpdaterUrlTemplate = "https://github.com/nicehash/NiceHashMiner/releases/download/{VERSION_TAG}/nhm_windows_updater_{VERSION_TAG}.exe";


        // add btc adress as parameter

        // help and faq
        public const string NhmHelp = "https://github.com/nicehash/NiceHashMiner/";
        public const string NhmNoDevHelp = "https://github.com/nicehash/NiceHashMiner/wiki/Troubleshooting#nosupportdev";
    }
}
