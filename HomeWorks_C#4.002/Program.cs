/* Задача 2:    Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Примеры:        452 -> 11
                82 -> 10
                9012 -> 12
Работает при условии, что количество цифр в числе не более 10
*/

Console.WriteLine("Находим сумму цифр числа А ");

int number = InputNumber("Введите число А: ");

if (CheckNum(number))
{
    Console.Write($"Сумма цифр числа {number}  = {SumOfDigits(number)};");
}
else Console.Write($"Ошибка ввода числа {number}");


// Преобразование строковой переменной (string) в целое число (int)
int InputNumber(string message)
{
    System.Console.Write(message + "> ");
    string str_num = Console.ReadLine();
    int num = Int32.Parse(str_num);
    return num;
}

// Сумма цифр числа num

int SumOfDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

bool CheckNum(int deg)               // Проверка на не отрицательноcть значения степени 
{
    if (deg < 0)
    {
        Console.Write("Укажите целое положительное число ! ");
        return false;
    }
    else return true;
}