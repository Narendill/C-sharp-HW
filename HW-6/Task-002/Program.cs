/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

using static System.Console;
Clear();

double InputNumber(string message)
{
    WriteLine(message);
    double M = double.Parse(ReadLine());
    return M;
}

void Intersection(double b1, double k1, double b2, double k2)
{
    if (k1 == k2 && b1 == b2) WriteLine("Lines on the plane coincide.");
    else if (k1 == k2 && b1 != b2) WriteLine("Lines on a plane are parallel. There are no intersection points.");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        WriteLine($"The point of intersection: [{x};{y}]");
    }

}

double b1 = InputNumber("Input b1: ");
double k1 = InputNumber("Input k1: ");
double b2 = InputNumber("Input b2: ");
double k2 = InputNumber("Input k2: ");

Intersection(b1, k1, b2, k2);
