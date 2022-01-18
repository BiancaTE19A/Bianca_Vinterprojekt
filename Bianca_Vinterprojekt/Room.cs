using System;
using Raylib_cs;

namespace Bianca_Vinterprojekt
{
    public class Room
    {
        public string current;
        // public string target;
        // public Room target;
        public Rectangle background = new Rectangle();
        public Door door = new Door(0, 0, 0, 0);
        public Rectangle dRec;


        // public Room()
        // {
        //     // door1 = new Door(100, 400, 100, 300, "door1");
        //     // door = new Door(1600, 400, 100, 300, "door");
        // }


        public virtual void Draw()
        {
            // door1.Draw();
            // door.Draw();
        }








        // Door rightDoor;
        // Door leftDoor;

        // public Room(Room r, Room l)
        // {
        //     rightDoor = new Door(r, this);
        //     leftDoor = new Door(this, l);
        // }
    }
}