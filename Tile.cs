using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19342313_G_Kruger_GADE6112_TASK1
{
    public abstract class Tile //Public Abstract Class for Tiles
    {
        protected int x;
        protected int y;

        protected Tile(int Valuex, int Valuey) // Setting initial x & y Tile values.
        {
            X = Valuex;
            Y = Valuey;
        }

        public int X { get; set; } // Setting X integer Coordinates 
        public int Y { get; set; } // Setting Y Integer Coordinates 


        public enum TileType // Enum for different Tile Types 
        {
            Hero,
            Enemy,
            Goblin,
            Weapon,
        }

        public TileType tiletype { get; set; }
    }
}
