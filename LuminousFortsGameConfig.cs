using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LuminousFortsHammer
{
    class LuminousFortsGameConfig : GameConfig
    {
        public LuminousFortsGameConfig()
        {
        }

        public override void WriteGameConfig(string path, string username)
        {
            StreamReader reader = new StreamReader("mod_template.txt");
            string template = reader.ReadToEnd();
            reader.Close();

            template = template.Replace("__MOD_ENGINE__", path + Const.SteamApps + username + Const.SourceModEngine);
            template = template.Replace("__SOURCESDK_BIN__", path + Const.SteamApps + username + Const.SourceSDK + Const.SourceSDKEngine);
            template = template.Replace("__MOD_DIR__", path + Const.SteamApps + Const.SourceMod + Const.ModDir);
            template = template.Replace("__MOD_MAPS__", path + Const.SteamApps + Const.SourceMod + Const.ModMaps);

            template = template;

            string gcpath = path + Const.SteamApps + username + Const.SourceSDK + Const.SourceSDKEngine + Const.GameConfig;
            string merged = "";
            StreamReader confreader = new StreamReader(gcpath);
            string config = confreader.ReadToEnd();
            confreader.Close();

            Regex re = new Regex("\"Games\".*\\n\\s*?{\\s*?\\n");
            merged = re.Replace(config, "\"Games\"\n\t{\n\t\t" + template + "\n");
            
            StreamWriter writer = new StreamWriter(@"C:\users\hekark\desktop\hi.txt");
            writer.Write(merged);
            writer.Close();
        }
    }
}
