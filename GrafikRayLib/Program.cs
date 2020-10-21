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
            float w = 0;
            float h = 0;
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


                if (Raylib.IsKeyDown(KeyboardKey.KEY_Q))
                {
                    w += 0.1f;
                    h += 0.1f;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_E))
                {
                    w -= 0.1f;
                    h -= 0.1f;
                }

                Raylib.BeginDrawing();

                Raylib.ClearBackground(myColor);

                Raylib.DrawRectangle((int)x, (int)y, (int)w, (int)h, Color.BLUE);

                if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
                {
                    Raylib.DrawCircle((int)x, (int)y, ((int)w*1.5f), Color.RED);    
                }

                Raylib.EndDrawing();
            }

        }
    }
}
