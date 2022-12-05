/* Задайте значения M и N. Напишите программу, которая найдёт
сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

// Creates a string with numbers

using static System.Console;
Clear();

int SumNumbers(int start, int stop)
{
    if (start == stop) return start;
    return start + SumNumbers(start + 1, stop);
}


Write("Input M: ");
int m = int.Parse(ReadLine());
Write("Input N: ");
int n = int.Parse(ReadLine());

if (m > n) WriteLine("Your input isn't correct.");
else
{
    WriteLine($"Sum = {SumNumbers(m, n)}");
}