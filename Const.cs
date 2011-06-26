using System;
using System.Collections.Generic;
using System.Text;

namespace LuminousFortsHammer
{
    class Const
    {
        private static Const c = null;
        public static Const Instance()
        {
            if (c == null)
            {
                c = new Const();
            }

            return c;
        }

        public string HelpText
        {
            get
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine("Click okay to search for and find your Hammer configuration file.");
                builder.AppendLine("You must have installed and run the Source SDK and Source SDK 2007.");
                builder.AppendLine("It is very important that you run the Source SDK before attempting to install");
                builder.AppendLine("LuminousForts into the Game Configuration.");

                return builder.ToString();
            }
        }

        public List<string> PossibleSteamLocations
        {
            get
            {
                List<String> locs = new List<String>();

                locs.Add(@"\Program Files\steam\");
                locs.Add(@"\Program Files (x86)\steam\");
                locs.Add(@"\Program Files\valve\steam\");
                locs.Add(@"\Program Files (x86)\valve\steam\");
                locs.Add(@"\valve\steam\");
                locs.Add(@"\steam\");

                return locs;
            }
        }

        /// <summary>
        /// Do not use the HOMEDRIVE envirnoment variable, because we do
        /// not know which hard drive they'll put steam on
        /// </summary>
        public List<String> PossibleSteamDrives
        {
            get
            {
                List<String> drives = new List<String>();

                for (int i = 'c'; i < 'q'; i++)
                {
                    drives.Add((char)i + ":");
                }

                return drives;
            }
        }

        public const string ModDir = @"luminousforts\";
        public const string ModMaps = ModDir + @"maps\";
        public const string SourceMod = @"sourcemods\";
        public const string SourceModEngine = @"\source sdk base 2007\";
        public const string GameConfig = @"GameConfig.txt";
        public const string SourceSDK = @"\sourcesdk\";
        public const string SourceSDKEngine = @"bin\source2007\bin\";
        public const string SteamApps = @"steamapps\";
        public const string SteamBinary = @"steam.exe";
        public const string UsernameTag = "___USERNAME___";
        
        public List<string> SourceSDKPaths
        {
            get
            {
                List<String> paths = new List<String>();

                paths.Add(@"\Program Files\steam\");
                paths.Add(@"\Program Files\valve\steam\");
                paths.Add(@"\valve\steam\");
                paths.Add(@"\steam\");

                return paths;
            }
        }
    }
}
