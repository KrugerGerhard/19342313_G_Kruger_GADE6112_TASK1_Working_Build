using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19342313_G_Kruger_GADE6112_TASK1
{
    abstract class Character : Tile //Abstract Class for Character
    {    //Protected Integers alongside the Death Boolean, Char symbol for Characters and Vision
        protected int hp; // Integer for HP
        protected int maxhp; // Integer for Maximum Health Points
        protected int damage; // Integer for Damage
        protected char symbol; //Character Symbol for each of the Tile Types
        protected bool isdead;  // Boolean for Death True/False check.
        protected Tile[] player_vision; // Vision up, down, left and right around player.

        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int Damage { get; set; }
        protected Tile[] playerVision { get; set; }

        //Constructor for Characters
        public Character(int x, int y, int maxhp, int damage, char symbol) : base(x, y)
        {

        }

        //Attack method 
        public virtual void Attack(Character target)
        {
            target.HP--;
        }

        //Boolean for Death Check.
        public bool IsDead()
        {
            if (this.hp >= 0)
            {
                return false;
            }

            else
                return true;
        }
        // Check Range for characters.
        public virtual bool CheckRange(Character target)
        {
            if (DistanceTo(target) < -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Check Range for characters 
        private int DistanceTo(Character target)
        {
            int distance = (this.X - target.X) + (this.Y - target.Y);
            int value = Math.Abs(distance);
            return value;
        }


        // Movement Enums that relate to all characters 
        public enum EnumMovement
        {
            NoMovement,
            Up,
            Down,
            Left,
            Right
        }
        //Movement for Characters
        public void Move(EnumMovement move)
        {
            if (move == EnumMovement.Down)
            {
                this.Y++;
            }
            if (move == EnumMovement.Up)
            {
                this.Y--;
            }
            if (move == EnumMovement.Right)
            {
                this.X++;
            }
            if (move == EnumMovement.Left)
            {
                this.X--;
            }
        }
        //Return for Movement
        public abstract EnumMovement ReturnMove(EnumMovement move);
        //ToString
        public abstract override string ToString();
    }
}
