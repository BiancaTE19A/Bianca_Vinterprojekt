using System;
using Raylib_cs;

namespace Bianca_Vinterprojekt
{
    public class Startroom : Room
    {
        public Startroom()
        {
            door.rec.x = screenWidth - door.rec.width;
            door.rec.y = floor - door.rec.height;

            door.target = new Livingroom();

            key.rec.x = 700;
            key.rec.y = floor - key.rec.height;
        }

        public override void Draw()
        {
            Raylib.DrawRectangle(0, 0, 1800, 900, Color.GREEN);
            door.Draw();
            key.Draw();
        }
    }
}