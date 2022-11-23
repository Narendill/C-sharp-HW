/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

using static System.Console;
Clear();

WriteLine("Input a number:");
string number = ReadLine();

if (number.Length < 3)
{
    WriteLine("There is no the 3rd number.");
}
else
{
    WriteLine(number[2]);
}
