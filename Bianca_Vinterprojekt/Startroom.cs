using System;
using Raylib_cs;

namespace Bianca_Vinterprojekt
{
    public class Startroom : Room
    {

        // Door door;

        public Rectangle startBg;




        public Startroom()
        {
            door.rec.width = 150;
            door.rec.height = 400;
            door.rec.x = 600;
            door.rec.y = 700 - door.rec.height;

            door.target = new Livingroom();

            // current = "startroom";
            // target = "livingroom";
            // target = new Livingroom();

        }

        public override void Draw()
        {
            Raylib.DrawRectangle(0, 0, 1800, 900, Color.GREEN);
            Raylib.DrawRectangleRec(door.rec, Color.BROWN);
        }

    }
}