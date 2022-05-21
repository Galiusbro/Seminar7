// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArrayRandom(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Random rnd = new Random();
            array[i, j] = rnd.Next(-10, 10) + rnd.NextDouble();
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                System.Console.Write("{0:f2}", array[i, j]);
                System.Console.Write(" ");
            }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("Введите количество строк (m)");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов (n)");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];

FillArrayRandom(array);
PrintArray(array);