/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12 */

using static System.Console;
Clear();

// Read numbers as a string
string Reader(string message)
{
    WriteLine(message);
    string inp = ReadLine();
    return inp;
}

// Sums up the numbers
int SumNumbers(string num)
{
    int sum = 0;
    for (int i = 0; i < num.Length; i++)
    {
        int digit = int.Parse(num[i].ToString());
        sum += digit;
    }
    return sum;
}

string number = Reader("Input a number:");
WriteLine($"Sum = {SumNumbers(number)}");