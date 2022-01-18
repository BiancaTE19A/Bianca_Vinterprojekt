using System;
using Raylib_cs;

namespace Bianca_Vinterprojekt
{
    public class Door
    {
        // public string label;
        // public Rectangle rec1 = new Rectangle(100, 400, 100, 300);
        // public Rectangle rec2 = new Rectangle(1600, 400, 100, 300);
        public Rectangle rec;
        public Room target;



        public Door(int x, int y, int w, int h)
        {
            rec = new Rectangle(x, y, w, h);
            // label = l;
        }


        public void Draw()
        {
            Raylib.DrawRectangleRec(rec, Color.BROWN);
        }

        // public void CollisionDoor(Room currentR, Room targetR, Door targetD, Player p)
        // {
        //     if (Raylib.CheckCollisionRecs(p.rec, targetD.rec))
        //     {
        //         currentR = targetR;
        //     }
        // }



        // Room leftRoom;
        // Room rightRoom;

        // public Door(Room l, Room r)
        // {
        //     leftRoom = l;
        //     rightRoom = r;
        // }
    }
}