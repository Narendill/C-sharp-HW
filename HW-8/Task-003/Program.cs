/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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

//Gets matrix A * matrix B
int[,] GetMatrixProduct(int[,] array1, int[,] array2)
{
    int[,] matrixProduct = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int r = 0; r < array2.GetLength(0); r++)
            {
                matrixProduct[i, j] += array1[i, r] * array2[r, j];
            }
        }
    }
    return matrixProduct;
}

WriteLine("Your array #1:");
int[,] array1 = GetArray(2, 3, 0, 9);
PrintArray(array1);
WriteLine();

WriteLine("Your array #2:");
int[,] array2 = GetArray(3, 5, 0, 9);
PrintArray(array2);
WriteLine();


if (array1.GetLength(1) != array2.GetLength(0))
{
    WriteLine("Your matrices are inconsistent.");
}
else
{
    int[,] newArray = GetMatrixProduct(array1, array2);
    WriteLine("array #1 x array #2:");
    PrintArray(newArray);
}

// Try arrays from example
WriteLine();
WriteLine("Try arrays from example:");
int[,] array3 = {{2, 4}, {3, 2}};
int[,] array4 = {{3, 4}, {3, 3}};
int [,] result = GetMatrixProduct(array3, array4);
PrintArray(result);

