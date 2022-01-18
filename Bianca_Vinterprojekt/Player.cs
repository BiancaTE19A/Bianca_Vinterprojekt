using System;
using Raylib_cs;

namespace Bianca_Vinterprojekt
{
    public class Player
    {
        public string name;
        public int height;
        public int width;
        public int hp;
        public int movementX;
        public int movementY;
        public bool colliding = false;

        public Rectangle rec = new Rectangle(200, 600, 100, 100);
        Room currentR = new Room();

        public Player()
        {
            movementX = 1;
        }
        public void Draw()
        {
            Raylib.DrawRectangleRec(rec, Color.BLUE);
        }
        public void Update()
        {
            Movement();
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
        public bool CheckCollisionDoor(Room curr)
        {
            if (Raylib.CheckCollisionRecs(rec, curr.door.rec))
            {
                // ChangeRooms(curr);
                return true;
            }
            return false;
        }

    }
}