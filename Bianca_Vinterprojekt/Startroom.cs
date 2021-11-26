using System;
using Raylib_cs;

namespace Bianca_Vinterprojekt
{
    public class Startroom : Room
    {

        Door door1;
        Rectangle recD1;


        public Startroom()
        {
            recD1.width = 150;
            recD1.height = 400;
            recD1.x = 1000;
            recD1.y = 700 - recD1.height;
        }

        public void Draw()
        {
            Raylib.DrawRectangleRec(recD1, Color.BROWN);
        }

    }
}