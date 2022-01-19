using System;
using Raylib_cs;

namespace Bianca_Vinterprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1800, 900, "Rooms");

            Player player = new Player();
            Room currentRoom = new Startroom();


            while (!Raylib.WindowShouldClose())
            {
                player.Update(currentRoom);

                if (player.CheckCollisionDoor(currentRoom) && Raylib.IsKeyDown(KeyboardKey.KEY_E))
                {
                    currentRoom = currentRoom.door.target;
                    player.rec.x = 50;
                    player.rec.y = 600;
                }//ändrar currentroom och återställer spelarens position

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                currentRoom.Draw();
                player.Draw();

                DrawInstructions();

                Raylib.EndDrawing();
            }
        }
        static void DrawInstructions()
        {
            Raylib.DrawText("Press 'E' to interract", 10, 10, 32, Color.BLACK);
        }
    }
}
