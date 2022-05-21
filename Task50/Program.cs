// Задача 50: Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] array = new int[5, 5];
FillArrayRandom(array);
PrintArray(array);

System.Console.Write("Введите координаты элемента через пробел (например: 2 8): ");
string text = Console.ReadLine();
var indexOfNumbers = text.Split(" ")
                        .Select(e => int.Parse(e))
                        .ToArray();

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void CheckElemet(int[,] array)
{
    if (array.GetLength(0) < indexOfNumbers[0] || array.GetLength(1) < indexOfNumbers[1]) System.Console.WriteLine("Такого элемента нет");
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (i == indexOfNumbers[0] - 1)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == indexOfNumbers[1] - 1)
                    {
                        System.Console.WriteLine(array[i, j]);
                        break;
                    }
                }
        }
    }
}



CheckElemet(array);