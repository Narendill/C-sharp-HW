/* Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да */

using static System.Console;
Clear();

while(true)
{
    string number = ReadLine();
    if(number.Length != 5)
    {
        WriteLine("Enter a FIVE-digit number:");
        continue;
    }
    else
    {
        if(number[0] == number[4] && number[1] == number[3])
        {
            WriteLine($"Yes, the number {number} is a palindrome.");
            break;
        }
        else
        {
            WriteLine($"No, the number {number} isn't a palindrome.");
            break;
        }
    }
}


