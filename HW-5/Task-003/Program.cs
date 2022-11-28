/* Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

using static System.Console;
Clear();

// Gets the size of an array
int ArraySize()
{
    WriteLine("Input array size: ");
    int size = int.Parse(ReadLine());
    return (size);
}

// Creates an array [-100.00; 100.00]
double[] FillArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(-100 + new Random().NextDouble() * 200, 2);
    }
    return array;
}

// Prints an array
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Write($"{array[i]} ");
    WriteLine();
}

// Finds the difference between the maximum and minimum
double MaxMinDiff(double[] array)
{
    double diff = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    diff = max - min;
    return diff;
}

int n = ArraySize();
double[] newArray = FillArray(n);
PrintArray(newArray);
WriteLine($"The difference between the maximum and minimum: {MaxMinDiff(newArray)}");

//Let's try the array from example
WriteLine();
WriteLine("Let's try the array from example");
double[] ArrayExample = { 3, 7, 22, 2, 78 };
PrintArray(ArrayExample);
WriteLine($"The difference from example: {MaxMinDiff(ArrayExample)}");
