using System;
using Raylib_cs;

namespace Bianca_Vinterprojekt
{
    public class Livingroom : Room
    {
        public Livingroom()
        {
            // Door door = new Door(200, 700 - 400, 150, 400);
            door.rec.width = 150;
            door.rec.height = 400;
            door.rec.x = 200;
            door.rec.y = 700 - door.rec.height;

            // door.target = new Livingroom();

            // current = "livingroom";
            // target = ("startroom");
            // target = new Livingroom();

        }


        public override void Draw()
        {

            Raylib.DrawRectangle(0, 0, 1800, 900, Color.PINK);
            // Raylib.DrawRectangleRec(dRec, Color.BROWN);
            Raylib.DrawRectangleRec(door.rec, Color.BROWN);

        }
    }
}