/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */ 

Console.Clear();
Console.WriteLine("Input N:");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;

if(N < 1)
{
    Console.WriteLine("Input a namber more than 0.");
}
if(N == 1)
{
    Console.WriteLine("There are no even numbers.");
}
if(N > 1)
{
    Console.Write("All even numbers: ");
    if(N % 2 != 0) N -= 1; // Это безобразие для красивых запятых в выводе =(
    while(count <= N)
    {
        Console.Write(count);
        if(count != N) Console.Write(", "); // И это тоже для них =(
        count += 2;
    }
    Console.Write(".");
}
