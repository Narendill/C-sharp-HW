/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

using static System.Console;
Clear();

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

// Creates an spiral array
int[,] GetSpiral(int n)
{
    int[,] array = new int[n, n];
    int numberInSpiral = 1;
    int count = 0;
    while (numberInSpiral <= n * n)
    {
        for (int i = count; i < n - count; i++) // Fills up.
        {
            array[count, i] = numberInSpiral;
            numberInSpiral++;
        }
        for (int i = count + 1; i < n - count; i++) // Fills right.
        {
            array[i, n - count - 1] = numberInSpiral;
            numberInSpiral++;
        }
        for (int i = n - count - 2; i > count - 1; i--) // Fills down.
        {
            array[n - count - 1, i] = numberInSpiral;
            numberInSpiral++;
        }
        for (int i = n - 2 - count; i > count; i--) // Fills left.
        {
            array[i, count] = numberInSpiral;
            numberInSpiral++;
        }
        count++;
    }
    return array;
}

WriteLine("Input the size of your array: ");
int[,] newArray = GetSpiral(int.Parse(ReadLine()));
WriteLine();
PrintArray(newArray);

