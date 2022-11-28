/* Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

using static System.Console;
Clear();

// Gets the size of an array
int ArraySize()
{
    WriteLine("Input array size: ");
    int size = int.Parse(ReadLine());
    return (size);
}

// Creates an array [-100; 100]
int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 101);
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

// Sum the odd elements of an array
int SumOdd(int[] array)
{
    int sum = 0;
    int i = 1;
    while (i < array.Length)
    {
        sum += array[i];
        i += 2;
    }
    return sum;
}

int n = ArraySize();
int[] newArray = FillArray(n);
PrintArray(newArray);
WriteLine($"Sum odd elements =  {SumOdd(newArray)}");
