/* Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки
с наименьшей суммой элементов: 1 строка */

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

// Finds a row with min sum of elements.
void FindMinSumInRow(int[,] array)
{
    int sum = 0;
    int rowNumber = 0;
    int tempSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempSum += array[i, j];
        }
        
        if (i == 0) sum = tempSum;
        if (tempSum < sum) 
        {
            sum = tempSum;
            rowNumber = i;
        }
        tempSum = 0;
    }
    WriteLine($"The minimun sum is in the {rowNumber} row.");
}

WriteLine("Your array:");
int[,] array = GetArray(3, 3, 0, 9);
PrintArray(array);
WriteLine();
FindMinSumInRow(array);