using System;
using System.Collections.Generic;
using System.Text;

using GameFramework.Creatures;

namespace GameFramework.World
{
    public class World
    {
        public int MaxX { get; set; }
        public int MaxY { get; set; }

        public List<Creature> Creatures { get; set; }
        public List<WorldObject> Objects { get; set; }
        
        public World( int maxX, int maxY)
        {
            MaxX = maxX;
            MaxY = maxY;
            Creatures = new List<Creature>();
            Objects = new List<WorldObject>();
        }
    }
}
