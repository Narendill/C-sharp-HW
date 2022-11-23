/* Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

using static System.Console;
Clear();

WriteLine("A:");
WriteLine("Input X:");
int x1 = int.Parse(ReadLine());
WriteLine("Input Y:");
int y1 = int.Parse(ReadLine());
WriteLine("Input Z:");
int z1 = int.Parse(ReadLine());

WriteLine("B:");
WriteLine("Input X:");
int x2 = int.Parse(ReadLine());
WriteLine("Input Y:");
int y2 = int.Parse(ReadLine());
WriteLine("Input Z:");
int z2 = int.Parse(ReadLine());

Write("Dist = ");
WriteLine(Math.Pow(Math.Pow(x1 - x2, 2) +
            Math.Pow(y1 - y2, 2) +
            Math.Pow(z1 - z2, 2), 0.5));
