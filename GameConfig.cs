using System;
using System.Collections.Generic;
using System.Text;

namespace LuminousFortsHammer
{
    public abstract class GameConfig
    {
        public abstract bool WriteGameConfig(string fullname, string username);
    }
}
