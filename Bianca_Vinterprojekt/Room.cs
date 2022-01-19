using System;
using Raylib_cs;

namespace Bianca_Vinterprojekt
{
    public class Room
    {
        public Key key = new Key(0, 0, 25, 25);
        public Door door = new Door(0, 0, 150, 400);

        protected int screenWidth = 1800;
        protected int screenHeight = 900;
        protected int floor = 700;


        public virtual void Draw()
        {
            //behöver inte override på en draw-metod eftersom basklassen aldrig kommer ritas ut men tyckte det var coolt
        }
    }
}