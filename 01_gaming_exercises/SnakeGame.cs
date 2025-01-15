using System;
using System.Collections.Generic;
using System.Threading;
 static void Main() {

class SnakeGame
{
    static int width = 40;
    static int height = 20;
    static int score = 0;
    static bool gameOver = false;

    static List<(int x, int y)> snake = new List<(int x, int y)>();
    static (int x, int y) food = (0, 0);
    static (int x, int y) direction = (1, 0);

    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        StartGame();
        while (!gameOver)
        {
            DrawGame();
            Input();
            Update();
            Thread.Sleep(100); // Adjust speed here
        }
        Console.Clear();
        Console.WriteLine($"Game Over! Final Score: {score}");
    }

    static void StartGame()
    {
        snake.Clear();
        snake.Add((width / 2, height / 2));
        GenerateFood();
    }

    static void DrawGame()
    {
        Console.Clear();
        // Draw borders
        for (int i = 0; i < width + 2; i++) Console.Write("#");
        Console.WriteLine();
        for (int y = 0; y < height; y++)
        {
            Console.Write("#");
            for (int x = 0; x < width; x++)
            {
                if (snake.Contains((x, y))) Console.Write("O");
                else if ((x, y) == food) Console.Write("*");
                else Console.Write(" ");
            }
            Console.WriteLine("#");
        }
        for (int i = 0; i < width + 2; i++) Console.Write("#");
        Console.WriteLine($"\nScore: {score}");
    }

    static void Input()
    {
        if (!Console.KeyAvailable) return;
        var key = Console.ReadKey(true).Key;

        direction = key switch
        {
            ConsoleKey.UpArrow when direction != (0, 1) => (0, -1),
            ConsoleKey.DownArrow when direction != (0, -1) => (0, 1),
            ConsoleKey.LeftArrow when direction != (1, 0) => (-1, 0),
            ConsoleKey.RightArrow when direction != (-1, 0) => (1, 0),
            _ => direction
        };
    }

    static void Update()
    {
        var newHead = (x: snake[0].x + direction.x, y: snake[0].y + direction.y);

        // Check for collisions
        if (newHead.x < 0 || newHead.x >= width || newHead.y < 0 || newHead.y >= height || snake.Contains(newHead))
        {
            gameOver = true;
            return;
        }

        // Check for food
        if (newHead == food)
        {
            score++;
            snake.Insert(0, newHead);
            GenerateFood();
        }
        else
        {
            snake.Insert(0, newHead);
            snake.RemoveAt(snake.Count - 1);
        }
    }

    static void GenerateFood()
    {
        var rand = new Random();
        do
        {
            food = (rand.Next(0, width), rand.Next(0, height));
        } while (snake.Contains(food));
    }
}


  }