/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

using static System.Console;
Clear();

int InputNumber(string message)
{
    WriteLine(message);
    int M = int.Parse(ReadLine());
    return M;
}

void MoreThanZero(int quantity)
{
    int count = 0;
    for (int i = 0; i < quantity; i++)
    {
        WriteLine($"Input number #{i + 1}: ");
        int input_number = int.Parse(ReadLine());
        if (input_number > 0) count++;
    }
    WriteLine($"There are {count} numbers more than 0.");
}



int M = InputNumber("How many numbers do you want to input? ");
MoreThanZero(M);
