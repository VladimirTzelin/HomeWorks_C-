﻿/* Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    4 -> да
    -3 -> нет
    7 -> нет */

    Console.Write("Введите число а > ");
string str_a = Console.ReadLine();
int a = Int32.Parse(str_a);

if (a % 2 == 0)
{
    Console.WriteLine($"a = {a} - чётное число");
}
else
{
    Console.WriteLine($"a = {a} - нечётное число");    
}



