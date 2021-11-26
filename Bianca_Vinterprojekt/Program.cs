using System;
using Raylib_cs;

namespace Bianca_Vinterprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Startroom sR = new Startroom();

            Livingroom l1 = new Livingroom();
            Livingroom l2 = new Livingroom();

            Room currentRoom = new Startroom();


            Raylib.InitWindow(1800, 900, "Rooms");

            while (!Raylib.WindowShouldClose())
            {
                DrawRaylib();

                player.Update();
                doorSR.Draw();

            }
        }
        static void DrawRaylib()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
            Raylib.EndDrawing();
        }
    }
}
