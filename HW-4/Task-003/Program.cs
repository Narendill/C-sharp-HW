/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

using static System.Console;
Clear();

int[] CreateArray(string message)
{
    WriteLine(message);
    int[] NewArray = new int[8];

    string str1 = ReadLine();
    string[] str2 = str1.Split(", ");

    for (int i = 0; i < 8; i++)
    {
        NewArray[i] = int.Parse(str2[i].ToString());
    }
    return NewArray;
}

void PrintArray(int[] arr)
{
    Write("[");
    for (int i = 0; i < 8; i++)
    {
        Write(arr[i]);
        if (i == 7) break;
        Write(", ");
    }
    Write("]");
}

int[] array1 = CreateArray("Enter 8 digits separated by a comma (for example: 1, 2, 3, 4, 5, 6, 7, 8):");
PrintArray(array1);
