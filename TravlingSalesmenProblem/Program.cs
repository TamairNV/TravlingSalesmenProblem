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
        
        while (!Raylib.WindowShouldClose())
        {
            
            // --- 2. Drawing ---
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);
            City.DrawCities();

            // Draw a Line: (StartPos, EndPos, Thickness, Color)
            Raylib.DrawLineEx(new Vector2(50, 50), new Vector2(200, 50), 3, Color.Black);

            
            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}