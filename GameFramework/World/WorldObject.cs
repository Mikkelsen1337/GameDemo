using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework.World
{
    public class WorldObject
    {
        public int X { get; set; }
        public int Y { get; set; }

        public bool Lootable { get; set; }
        public bool Removable { get; set; }
    }
}
