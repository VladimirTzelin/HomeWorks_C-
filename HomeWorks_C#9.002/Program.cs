/* Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int InputData(string msg)
{
    Console.Write($"{msg} ");
    return Convert.ToInt32(Console.ReadLine());
}
// Вдруг введено не натуральное число!?
bool Check(int num)
{
    bool b = true;
    if (num < 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"Введено не натуральное число!!! \n");
        Console.ForegroundColor = ConsoleColor.White;
        b = false;
    }
    return b;
}
// Сумма чисел в интервале от M до N
void SumNumbers(int m, int n, int sum)
{
    if (m > n)
    {
        Console.Write($"Сумма чисел в интервале = \t {sum}; ");
        return;
    }
    sum = sum + m;
    SumNumbers(m + 1, n, sum);
}

int M = InputData($"Введите значение\t\t M = ");
Check(M);
int N = InputData($"Введите значение N больше {M}\t N = ");
SumNumbers(M, N, 0);


