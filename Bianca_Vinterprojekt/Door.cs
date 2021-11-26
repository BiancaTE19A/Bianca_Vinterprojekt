using System;
using Raylib_cs;

namespace Bianca_Vinterprojekt
{
    public class Door
    {
        public Rectangle rec = new Rectangle();

        Room targetRoom;



        public void CollisionDoor(Room currentR, Room targetR, Door targetD, Player p)
        {

            if (Raylib.CheckCollisionRecs(p.rec, targetD.rec))
            {
                currentR = targetR;
            }
        }



        // Room leftRoom;
        // Room rightRoom;

        // public Door(Room l, Room r)
        // {
        //     leftRoom = l;
        //     rightRoom = r;
        // }
    }
}