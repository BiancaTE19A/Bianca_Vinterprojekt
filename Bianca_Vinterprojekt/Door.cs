using System;
using Raylib_cs;

namespace Bianca_Vinterprojekt
{
    public class Door
    {
        public Rectangle rec;
        public Room target;


        public Door(int x, int y, int w, int h)
        {
            rec = new Rectangle(x, y, w, h);
        }

        public void Draw()
        {
            Raylib.DrawRectangleRec(rec, Color.BROWN);
        }

        // public bool IsLocked()
        // {
        //     return true;
        // }
    }
}