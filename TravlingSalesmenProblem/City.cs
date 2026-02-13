namespace TravlingSalesmenProblem;
using Raylib_cs;
using System.Numerics;

public struct Position
{
    public int x;
    public int y;

    public Position(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public class City
{
    public static List<City> Cities = new List<City>();
    public static int size = 10;
    private string name;
    private Position pos;
    

    public City(string n, int x, int y)
    {
        name = n;
        pos = new Position(x, y);
        Cities.Add(this);
    }

    public void Draw()
    {
        Raylib.DrawCircle(pos.x, pos.y,size, Color.Blue);
    }

    public static void CreateCities(int seed,int CityCount, Tuple<int,int> bounds)
    {
        Random ran = new Random(seed);
        for (int i = 0; i < CityCount; i++)
        {
            int x = ran.Next(10, bounds.Item1-10);
            int y = ran.Next(10, bounds.Item2-10);
            bool collision = false;
            foreach (var city in Cities)
            {
                int diffX = Math.Abs(city.pos.x - x);
                int diffY = Math.Abs(city.pos.y - y);
                if (diffY + diffX < size * 5)
                {
                    Console.WriteLine(i);
                    collision = true;
                    i--;
                    break;
                }
            }

            if (!collision)
            {
                new City("name", x, y);

            }
           
        }
        
    }

    public static void DrawCities()
    {
        foreach (var city in Cities)
        {
            city.Draw();
        }
    }
}

