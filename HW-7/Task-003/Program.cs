/* Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

using static System.Console;
Clear();

// Gets an array
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

// Prints an array
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]}\t ");
        }
        WriteLine();
    }
}

// Finds means
void FindMean(int[,] array)
{
    double meanCol = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            meanCol += (double)array[j, i] / (double)array.GetLength(0);
        }
        Write($"{Math.Round(meanCol, 2)}\t");
        meanCol = 0;
    }
}

WriteLine("Your array:");
int[,] array = GetArray(4, 4, 0, 10);
PrintArray(array);
WriteLine();
FindMean(array);

// Let's try an array from example.
WriteLine();
WriteLine();
WriteLine("An array from example:");
int[,] exArray = new int[,]
{
    {1, 4, 7, 2}, 
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};
PrintArray(exArray);
WriteLine();
FindMean(exArray);


