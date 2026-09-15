# Traveling Salesperson Problem (TSP) Visualizer

A visual implementation of the classic Traveling Salesperson Problem written in C#. It generates a random set of cities and uses a **Simulated Annealing** algorithm to progressively find the shortest path connecting them all. Everything is rendered in real-time using Raylib.

## Features

* **Procedural City Generation:** Randomly generates non-overlapping cities within a given boundary.
* **Simulated Annealing Optimization:** Utilizes temperature and cooling rate variables to escape local minima and optimize the route.
* **Real-time Rendering:** Draws the cities and the currently evaluated paths on-screen using `Raylib_cs`.
* **Live Stats:** Tracks and outputs the current total distance and the best overall distance found.

## Prerequisites

To run this project, you will need:
* [.NET SDK](https://dotnet.microsoft.com/download)
* [Raylib-cs](https://github.com/ChrisDill/Raylib-cs) (can be added via NuGet)

## Getting Started

1. Clone the repository.
2. Ensure you have the `Raylib-cs` package installed in your project.
3. Run the project using your preferred C# IDE or the .NET CLI:
   ```bash
   dotnet run
