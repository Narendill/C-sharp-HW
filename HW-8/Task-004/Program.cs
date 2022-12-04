/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

using static System.Console;
Clear();

// Gets an 3D array
int[,,] GetArray(int m, int n, int k, int minValue, int maxValue)
{
    string listOfNumbers = ""; // The string will store the numbers that are already in the array.
    int[,,] result = new int[m, n, k];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int q = 0;
            while (q < k)
            {
                int tempNumber = new Random().Next(minValue, maxValue + 1);
                if (listOfNumbers.IndexOf(tempNumber.ToString()) == -1)
                {
                    listOfNumbers += tempNumber.ToString() + "-";
                    result[i, j, q] = tempNumber;
                    q++;
                }
                else continue;
            }
        }
    }
    return result;
}


// Prints an 3D array
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int q = 0; q < array.GetLength(2); q++)
            {
                Write($"{array[i, j, q]}({i},{j},{q})\t ");
            }
            WriteLine();
        }
    }
}

// Let's try with a range [10; 17]. All 8 numbers have to be unique.
WriteLine("Your array:");
int[,,] array = GetArray(2, 2, 2, 10, 17);
PrintArray(array);

