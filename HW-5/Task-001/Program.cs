/* Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

using static System.Console;
Clear();

// Gets the size of an array
int ArraySize()
{
    WriteLine("Input array size: ");
    int size = int.Parse(ReadLine());
    return (size);
}

// Creates an array with three digit numbers
int[] FillArray3(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

// Prints an array
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Write($"{array[i]} ");
    WriteLine();
}

// Counts the number of even array elements
int FindEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;

}

int n = ArraySize();
int[] newArray = FillArray3(n);
PrintArray(newArray);
WriteLine($"Number of even array elements = {FindEvenNumbers(newArray)}");
