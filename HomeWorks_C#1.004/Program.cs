/* Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    5 -> 2, 4
    8 -> 2, 4, 6, 8 */




Console.Write("Введите число: ");
int number= Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Чётные числа в интервале от 0 до {number}");

int index = 1;
bool NoEvenNum = true;

    while (index <= number)
        {
        if (index % 2 != 1)
            {
            Console.Write($"{index}, ");
            NoEvenNum = false;
            }
        index = index + 1;
        }

        if (NoEvenNum)
            {
            Console.WriteLine("В этом интервале нет чётных положительных ычисел!");
            }


   
    

