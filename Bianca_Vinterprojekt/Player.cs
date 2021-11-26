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

        public Rectangle rec = new Rectangle(200, 600, 100, 100);

        public Player()
        {
            movementX = 1;
        }
        public void DrawPlayer()
        {
            Raylib.DrawRectangleRec(rec, Color.BLUE);
        }
        public void Update()
        {
            Movement();
            DrawPlayer();
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


    }
}