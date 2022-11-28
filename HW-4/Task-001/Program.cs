/* Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16 */

using static System.Console;
Clear();

// Read numbers
int Reader(string message)
{
    WriteLine(message);
    int inp = int.Parse(ReadLine());
    return inp;
}

int Exponentiate(int a, int b)
{
    int mult = 1;
    for (int i = 0; i < b; i++)
    {
        mult *= a;
    }
    return mult;
}

int A = Reader("Input A:");
int B = Reader("Input B >= 0:");

// Check if a number is natural
while (true)
{
    if (B < 0) 
    {
        B = Reader("Input B >= 0:");
    }
    else
    {
        break;
    }
}

WriteLine($"A ^ B = {Exponentiate(A, B)}");
