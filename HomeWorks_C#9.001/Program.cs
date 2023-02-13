/* Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"  */

int InputData(string msg)
{
    Console.Write($"{msg} ");
    return Convert.ToInt32(Console.ReadLine());
}
bool Check(int num)
{
    bool b = true;
    if (num < 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"Введено не натуральное число \n");
        Console.ForegroundColor = ConsoleColor.White;
        b = false;
    }
    return b;
}

void EvenNumbers(int m, int n)
{
    if (m > n)
    {
        return;
    }
    if (m % 2 != 0)
    {
        m++;
    }

    Console.Write($"{m}; ");
    EvenNumbers(m + 2, n);
}

int M = InputData($"Введите значение\t\t M = ");
Check(M);
int N = InputData($"Введите значение N больше {M}\t N = ");
EvenNumbers(M, N);




