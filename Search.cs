using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LuminousFortsHammer
{
    class SteamSearch
    {
        public SteamSearch()
        {
        }

        public Boolean IsSteamFolder(string path)
        {
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                foreach (var file in files)
                {
                    if (Path.GetFileName(file.ToLower()) == Const.SteamBinary.ToLower())
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
