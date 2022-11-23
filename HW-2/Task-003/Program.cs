/* Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

using static System.Console;
Clear();

WriteLine("Input a number:");
int number = int.Parse(ReadLine());

if(number > 7 || number < 1)
{
    WriteLine("Your input isn't correct.");
}
else if(number == 6 || number == 7)
{
    WriteLine("Yes, it's a day off.");
}
else
{
    WriteLine("No, it isn't a day off.");
}