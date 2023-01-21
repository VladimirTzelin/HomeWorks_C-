/*
Задача 1:  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            456 -> 5
            782 -> 8
            918 -> 1
*/

Console.Write("Введите трёхзначное число > ");
string? str_number = Console.ReadLine();
int number = Int32.Parse(str_number);

if (СheckingDigits(number))
{
    Console.WriteLine($"Вторая цифра этого числа > {SeconDigit(number)}");
}


// Функции ======================

// СheckingDigits()   Проверка разрядности введённого числа

bool СheckingDigits(int num)        
{
    if (num < 100 || num > 999)
    {
        Console.Write("Вы ввели не трехзначное число");
        return false;
    }
    else
    {
        return true;
    }
}

// SeconDigit() Ищем значение второго разряда трёх значного числа

int SeconDigit(int num)
{
    num = num / 10;
    num = num % 10;
    return num;
}

