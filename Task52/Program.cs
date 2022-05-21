// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.


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
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void AverageVertical(int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    double count = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            count += array[i, j];
        }
        average[j] += (count / array.GetLength(0));
        count = 0;
    }
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    //string symbol = "; ";
    for (int i = 0; i < average.Length; i++)
    {
        if (i == average.Length - 1)
        {
            System.Console.Write(average[i]);
            System.Console.Write(".");
        }
        else
        {
            System.Console.Write(average[i]);
            System.Console.Write("; ");
        }

    }
}

int[,] array = new int[4, 7];
FillArrayRandom(array);
System.Console.WriteLine("Массив заполненный рандомными значениями:");
PrintArray(array);
AverageVertical(array);