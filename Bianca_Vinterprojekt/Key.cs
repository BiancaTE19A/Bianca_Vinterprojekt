using System;
using Raylib_cs;
using System.Collections.Generic;

namespace Bianca_Vinterprojekt
{
    public class Key
    {
        public string label;

        public Rectangle rec;

        public Key(int x, int y, int w, int h)
        {
            rec = new Rectangle(x, y, w, h);
        }

        public void Draw()
        {
            Raylib.DrawRectangleRec(rec, Color.GOLD);
        }
    }
}