using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19342313_G_Kruger_GADE6112_TASK1
{
    class Hero : Character
    {
        EnumMovement HeroMovement; //Movement Enum related to Hero Movement Specifically

        public Hero(int x, int y, int hp, int damage, char symbol) : base(x, y,hp, 2, 'H') //Stats and info for the Hero Character
        {
            tiletype = TileType.Hero; //For the Hero Tile Type called in Tile
            this.hp = HP;
            this.MaxHP = HP;
            this.damage = 2;
        }

        public override EnumMovement ReturnMove(EnumMovement move) //Movement for Hero Character
        {

            if (move == EnumMovement.Up) //for the Up arrow
            {
                HeroMovement = EnumMovement.Up;
            }
            else if (move == EnumMovement.Down) //For the Down arrow
            {
                HeroMovement = EnumMovement.Down;
            }
            else if (move == EnumMovement.Left) //for the Left arrow
            {
                HeroMovement = EnumMovement.Left;
            }
            else if (move == EnumMovement.Right) //for the Right arrow
            {
                HeroMovement = EnumMovement.Right;
            }
            else if (move == EnumMovement.NoMovement) //for when No Movement is made by the player
            {
                HeroMovement = EnumMovement.NoMovement;
            }

            return HeroMovement; //Returns Hero Movement
        }

        public override string ToString() //ToString for relating the Hero's data to the corresponding Label
        {
            return "Player Stats:\n" + "HP: " + hp + "/" + MaxHP + "\nDamage: 2\n" + "[" + Y + "," + X + "]";
        }
    }
}
