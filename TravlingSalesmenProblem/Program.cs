using Raylib_cs;
using System.Numerics;
using TravlingSalesmenProblem;

class Program
{
    static void Main()
    {
        // Initialize the window
        Raylib.InitWindow(800, 600, "Sales");
        Raylib.SetTargetFPS(60);
        City.CreateCities(1224,25,new Tuple<int, int>(800,600));
        float timer = 0.0f;
        while (!Raylib.WindowShouldClose())
        {
            
            // --- 2. Drawing ---
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);
            City.DrawCities();
            City.DrawLines();
            
            
            
            timer += Raylib.GetFrameTime(); 

            if (timer >= 0.5f)
            {

                City.Improve();
                timer = 0.0f; // Reset timer
            }

            
            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
    
    
    
    
}