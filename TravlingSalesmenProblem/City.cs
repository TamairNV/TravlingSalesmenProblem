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

        currentTotal = FindPathLength();
        Console.WriteLine(currentTotal);

        

    }

    public static void DrawCities()
    {
        foreach (var city in Cities)
        {
            city.Draw();
        }
    }


    public static void FindPath()
    {
        
    }

    public static void Improve()
    {
        Random ran = new Random(1245);
        for (int i = 0; i < Cities.Count-1; i++)
        {

            Swap(i, ran.Next(1, Cities.Count - 1));
                
            
        }
    }

    public static int stuckCalls = 0;
    public static void Swap(int i, int j)
    {
        City temp = Cities[i + 1];
        Cities[i + 1] = Cities[j];
        Cities[j] = temp;
        float newTotal = FindPathLength();

        if (newTotal > currentTotal && stuckCalls < 30)
        {
            temp = Cities[i + 1];
            Cities[i + 1] = Cities[j];
            Cities[j] = temp;
            Console.WriteLine(stuckCalls);
            stuckCalls++;
        }
        else
        {
            stuckCalls = 0;
            Console.WriteLine(newTotal);
            currentTotal = newTotal;
        }
    }

    public static float FindPathLength()
    {
        float dis = 0;
        
        City past = Cities[0];
        bool first = true;
        foreach (var city in Cities)
        {
            if (first)
            {
                first = false;
                continue;
            }

            Vector2 p1 = new Vector2(past.pos.x, past.pos.y);
            Vector2 p2 = new Vector2(city.pos.x, city.pos.y);
            dis += Math.Abs(Vector2.Distance(p1 , p2));
            past = city;
        }

        return dis;

    }

    public static float currentTotal = 0;

    public static void DrawLines()
    {
        City past = Cities[0];
        bool first = true;
        foreach (var city in Cities)
        {
            if (first)
            {
                first = false;
                continue;
            }

            Vector2 p1 = new Vector2(past.pos.x, past.pos.y);
            Vector2 p2 = new Vector2(city.pos.x, city.pos.y);
            
            Raylib.DrawLineEx(p2,p1,2,Color.DarkBlue);
            past = city;
        }
        Vector2 last = new Vector2(Cities[0].pos.x, Cities[0].pos.y);
        Vector2 firstCity = new Vector2(Cities[Cities.Count-1].pos.x, Cities[Cities.Count-1].pos.y);
        Raylib.DrawLineEx(firstCity,last,2,Color.DarkBlue);
        
    }
}

class Path()
{
    public List<City> path = new List<City>();
    
}

