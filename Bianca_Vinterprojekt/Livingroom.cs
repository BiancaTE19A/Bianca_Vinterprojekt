using System;
using Raylib_cs;

namespace Bianca_Vinterprojekt
{
    public class Livingroom : Room
    {



        public void Draw()
        {
            Raylib.DrawRectangleRec(background, Color.RED);
        }
    }
}