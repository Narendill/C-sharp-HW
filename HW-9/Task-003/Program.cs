/* Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

using static System.Console;
Clear();

// Gets the value of the Ackermann function
int GetAckermannFunct(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return GetAckermannFunct(m - 1, 1);
    return GetAckermannFunct(m - 1, GetAckermannFunct(m, n - 1));
}



Write("Input m: ");
int m = int.Parse(ReadLine());
Write("Input n: ");
int n = int.Parse(ReadLine());

WriteLine($"A({m},{n}) = {GetAckermannFunct(m, n)}");
