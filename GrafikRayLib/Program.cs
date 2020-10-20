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
            //Så länge fönstret inte ska stängas; fortsätt while
            while(!Raylib.WindowShouldClose())
            {
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    x += 0.1f;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    x -= 0.1f;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    y -= 0.1f;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    y += 0.1f;
                }

                Raylib.BeginDrawing();

                Raylib.ClearBackground(myColor);

                Raylib.DrawCircle((int)x, (int)y, 20f, Color.BLUE);

                Raylib.EndDrawing();
            }

        }
    }
}
