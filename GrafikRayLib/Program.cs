using System;
using Raylib_cs;

namespace GrafikRayLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "Hello World!");

            Color myColor = new Color(0, 225, 128, 187);

            float x = 0;
            float y = 0;

            float enemyX = 0;
            float enemyY = 0;

            bool enemyHitWall = false;
            //Så länge fönstret inte ska stängas; fortsätt while
            while(!Raylib.WindowShouldClose())
            {
                if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                {
                    x += 0.1f;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    x -= 0.1f;
                }
                
                if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                {
                    y -= 0.1f;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
                {
                    y += 0.1f;
                }

                if (enemyX == 0)
                {
                    enemyHitWall = false;
                    enemyX++;

                }

                if (enemyHitWall == false)
                {
                    enemyX++;
                }

                if (enemyX == 760)
                {
                    enemyHitWall = true;
                }


                if (enemyHitWall == true)
                {
                    enemyX--;

                }
                



                Raylib.BeginDrawing();

                Raylib.ClearBackground(myColor);

                Raylib.DrawRectangle((int)x, (int)y, 10, 10, Color.BLUE);

                Raylib.DrawRectangle((int)enemyX, (int)enemyY, 40, 40, Color.RED);

                Raylib.EndDrawing();
            }

        }
    }
}
