/* Напишите программу, которая принимает на вход трёхзначное число и на 
выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

using static System.Console;
Clear();

WriteLine("Input a number:");
string number = ReadLine();
WriteLine(number[1]);
