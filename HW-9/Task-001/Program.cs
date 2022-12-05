/* Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

using static System.Console;
Clear();

// Creates a string with numbers
string PrintNaturelNumbers(int start)
{
    if (start == 1) return start.ToString();
    return (start + ", " + PrintNaturelNumbers(start - 1));
}


Write("Input N: ");
int n = int.Parse(ReadLine());
string newString = PrintNaturelNumbers(n);
WriteLine(newString);
