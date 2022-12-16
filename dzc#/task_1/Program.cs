// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] a = new double[5, 10];

Random random = new Random();
System.Console.WriteLine("Двумерный массив размером mXn > ");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 10; j++)
    {
        a[i, j] = random.Next(100);
        Console.Write("{0,4}", a[i, j]);
    }
    Console.WriteLine();
}