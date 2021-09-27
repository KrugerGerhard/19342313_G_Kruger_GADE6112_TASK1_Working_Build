using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19342313_G_Kruger_GADE6112_TASK1
{
    class Goblin : Enemy //Enemy type Goblin class
    {
        public Goblin(int x, int y) : base( x, y, 10, 1, 'G') //Goblin stats
        {
            tiletype = TileType.Goblin;
        }
        EnumMovement GoblinMovement; //Movement enum related to Goblin Movement specifically 

        public override EnumMovement ReturnMove(EnumMovement move) // Movement for Goblin
        {
            int randomnum0 = random.Next(0, 4); //RNG for making Goblin movement random.

            if (randomnum0 == 0)
            {
                GoblinMovement = EnumMovement.Up; //If the RNG rolls 0 Goblin moves Upwards from previous coordinates
            }
            else if (randomnum0 == 1)
            {
                GoblinMovement = EnumMovement.Down; //If the RNG rolls 1 Goblin moves Downwards from previous coordinates
            }
            else if (randomnum0 == 2)
            {
                GoblinMovement = EnumMovement.Left; //If the RNG rolls 2 Goblin moves Left from previous coordinates
            }
            else if (randomnum0 == 3)
            {
                GoblinMovement = EnumMovement.Right; //If the RNG rolls 3 Goblin moves Right from previous coordinates
            }
            else if (randomnum0 == 4)
            {
                GoblinMovement = EnumMovement.NoMovement; //If the RNG rolls 4 Goblin does not move from previous coordinates
            }

            return GoblinMovement; //Returns Goblin Movement
        }
    }
}
