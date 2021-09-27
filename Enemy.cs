using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19342313_G_Kruger_GADE6112_TASK1
{
    abstract class Enemy : Character //Class for Different Enemy Tile types
    {
        protected Random random = new Random(); //Generates a random amount of enemies

        public Enemy(int x, int y, int maxhp, int damage, char symbol) : base (x,y,maxhp, damage, symbol) //Enemy constructor
        {

        }

        public override string ToString() //ToString for relating Enemy Data to Form
        {
            return this.GetType().Name + " at " + this.X + this.Y + this.damage;
        }
    }
}
