/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет */

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

// Gets a number
int GetNumber(string message)
{
    WriteLine(message);
    int position = int.Parse(ReadLine());
    return position;
}

// Finds element by index
void FindElementByIndex(int m, int n, int[,] array)
{
    if (m >= array.GetLength(0) || n >= array.GetLength(1))
    {
        WriteLine("The element doesn't exist.");
    }
    else
    {
        WriteLine($"Your element: {array[m, n]}.");
    }
}

// Finds element by value
void FindElementByValue(int element, int[,] array)
{
    int find = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == element)
            {
                WriteLine($"Your element is in an array: {array[i, j]}, position: ({i};{j}).");
                find = 1;
                break;
            }
        }
    }
    if (find == 0) WriteLine("The element doesn't exist.");
}

WriteLine("Your array:");
int[,] array = GetArray(4, 4, 0, 10);
PrintArray(array);
WriteLine();

int a = GetNumber("Input row number: ");
int b = GetNumber("Input column number: ");
FindElementByIndex(a, b, array);
WriteLine();

int c = GetNumber("Input an element you want to find: ");
FindElementByValue(c, array);