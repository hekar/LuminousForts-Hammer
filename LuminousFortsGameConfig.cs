using System;
using System.Collections.Generic;
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

        public override bool WriteGameConfig(string path, string username)
        {
        	string template = null;
        	try
        	{
	            StreamReader reader = new StreamReader("mod_template.txt");
	            template = reader.ReadToEnd();
	            reader.Close();
            } 
            catch (IOException)
            {
            	MessageBox.Show("Failure to read mod_template.txt");
            	return false;
            }
            
            template = template.Replace("__MOD_ENGINE__", path + Const.SteamApps + username + Const.SourceModEngine);
            template = template.Replace("__SOURCESDK_BIN__", path + Const.SteamApps + username + Const.SourceSDK + Const.SourceSDKEngine);
            template = template.Replace("__MOD_DIR__", path + Const.SteamApps + Const.SourceMod + Const.ModDir);
            template = template.Replace("__MOD_MAPS__", path + Const.SteamApps + Const.SourceMod + Const.ModMaps);

            string gcpath = path + Const.SteamApps + username + Const.SourceSDK + Const.SourceSDKEngine + Const.GameConfig;
            string merged = "";
            string config = null;
            try
            {
	            StreamReader confreader = new StreamReader(gcpath);
	            config = confreader.ReadToEnd();
	            confreader.Close();
            }
            catch (IOException)
            {
            	MessageBox.Show("Failure to read game configuration");
            	return false;
            }

            Regex re = new Regex("\"Games\".*\\n\\s*?{\\s*?\\n");
            merged = re.Replace(config, "\"Games\"\n\t{\n\t\t" + template + "\n");
            
            try 
            {
	            StreamWriter writer = new StreamWriter(gcpath);
	            writer.Write(merged);
	            writer.Close();            	
            } 
            catch (IOException)
            {
            	MessageBox.Show("Failure to write to game configuration");
            	return false;
            }
            
            return true;
        }
    }
}
