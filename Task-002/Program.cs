/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Clear();
Console.WriteLine("Input the 1st number:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the 2nd number:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the 3rd number:");
int c = Convert.ToInt32(Console.ReadLine());

int max_number = a;

if(b > max_number)
{
    max_number = b;
}
if(c > max_number)
{
    max_number = c;
}

Console.Write("max = ");
Console.Write(max_number);