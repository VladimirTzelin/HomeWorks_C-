/* Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    5 -> 2, 4
    8 -> 2, 4, 6, 8 */




Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Чётные числа в интервале от 0 до {number}");

bool NoEvenNum = true;
int index = 2;

while (index <= number)
{
    Console.Write($"{index}, ");
    index = index + 2;
    NoEvenNum = false;
}

if (NoEvenNum)
{
    Console.WriteLine("В этом интервале нет чётных положительных ычисел!");
}





