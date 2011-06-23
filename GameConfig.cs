using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuminousFortsHammer
{
    public abstract class GameConfig
    {
        public abstract void WriteGameConfig(string fullname, string username);
    }
}
