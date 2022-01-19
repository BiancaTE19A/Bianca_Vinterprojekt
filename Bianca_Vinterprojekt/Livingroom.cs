using System;
using Raylib_cs;

namespace Bianca_Vinterprojekt
{
    public class Livingroom : Room
    {
        public Livingroom()
        {
            door.rec.x = screenWidth - door.rec.width - 200;
            door.rec.y = floor - door.rec.height;

            // door.target = new Startroom();
        }

        public override void Draw()
        {
            Raylib.DrawRectangle(0, 0, 1800, 900, Color.PINK);
            door.Draw();
            // key.Draw();
        }
    }
}