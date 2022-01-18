using System;
using Raylib_cs;

namespace Bianca_Vinterprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            // Startroom s1 = new Startroom();

            // Livingroom l1 = new Livingroom();
            // Livingroom l2 = new Livingroom();

            Room currentRoom = new Startroom();
            //currentroom = (det changeroom returnar) kanske inte säkert


            Raylib.InitWindow(1800, 900, "Rooms");

            while (!Raylib.WindowShouldClose())
            {
                player.CheckCollisionDoor(currentRoom);


                if (player.CheckCollisionDoor(currentRoom))
                {
                    currentRoom = currentRoom.door.target;
                    player.rec.x = 50;
                    player.rec.y = 600;
                }


                player.Update();

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                currentRoom.Draw();
                player.Draw();

                Raylib.EndDrawing();

            }
        }

        //         static void SwitchRoom(Player p, Room current, Room target)
        //         {
        //             bool colliding = false;
        //             if (colliding == false)
        //             {
        //                 if (Raylib.CheckCollisionRecs(p.rec, current.dRec))
        //                 {
        //                     colliding = true;
        //                 }
        // //check collision i game loop main. hoppar till en klass som kollar collision, hoppar till change room som sedan hoppar tillbaka till main
        //             }
        //             if (colliding == true)
        //             {
        //                 target.Draw();

        //             }
        //         }























        // static void SwitchRoom(Player p, Room current)
        // {
        //     bool switched = false;
        //     while (switched)
        //     {
        //         Console.WriteLine($"{current.target}");
        //         if (Raylib.CheckCollisionRecs(p.rec, current.dRec))
        //         {
        //             if (current.target == "livingroom")
        //             {

        //                 current = new Livingroom();


        //             }
        //             current.Draw();
        //             switched = true;
        //         }
        //     }
        // }
    }
}
