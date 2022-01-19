using System;
using Raylib_cs;
using System.Collections.Generic;

namespace Bianca_Vinterprojekt
{
    public class Player
    {
        private int screenWidth = 1800;
        private int screenHeight = 900;
        private int floor = 700;
        public int hp;
        public int movementX;
        public int movementY;

        public Rectangle rec = new Rectangle(200, 600, 100, 100);

        private HashSet<Key> carriedKeys = new HashSet<Key>();


        public Player()
        {
            movementX = 1;
        }

        private void Movement()
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                rec.x -= movementX;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                rec.x += movementX;
            }
        }

        public void Update(Room current)
        {
            Movement();
            CheckCollisionDoor(current);
        }

        public void Draw()
        {
            Raylib.DrawRectangleRec(rec, Color.BLUE);
        }

        public bool CheckCollisionDoor(Room current)
        {
            return (Raylib.CheckCollisionRecs(rec, current.door.rec));
        }

        // public bool CheckCollisionKey(Key key)
        // {
        //     return (Raylib.CheckCollisionRecs(rec, key.rec));
        // }

    }
}