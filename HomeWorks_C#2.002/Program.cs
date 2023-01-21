/* Задача 2:    Напишите программу, которая выводит третью цифру заданного числа, 
                начиная со старших разрядов или сообщает, что третьей цифры нет.
    
    Примеры:    645 -> 5
                78 -> третьей цифры нет
                32679 -> 6
*/

Console.Write("Введите число не менее 100  > ");
string str_number = Console.ReadLine();
int number = Int32.Parse(str_number);


if (СheckingDigits(number))
{
    Console.WriteLine($"Третья справа цифра числа {number} > {SearchDigit(number)}");
}

// Поиск третьей с права цифры числа
int SearchDigit(int num)
{

    // запоминаем первые три разряда
    int digit1 = num % 10;
    num = num / 10;
    int digit2 = num % 10;
    num = num / 10;
    int digit3 = num % 10;
    num = num / 10;

     // Console.Write($" digit1 {digit1} digit2 {digit2} digit3 {digit3} ");

    while (num > 0)
    {
        digit1 = digit2;
        digit2 = digit3;
        digit3 = num % 10;
        num = num / 10;
        
        // Console.Write($" digit1 {digit1} digit2 {digit2} digit3 {digit3} ");
    }
    return (digit1);
}


// СheckingDigits()   Проверка разрядности введённого числа

bool СheckingDigits(int num)
{
    if (num < 100)
    {
        Console.Write(" В этом числе нет третьего разряда ");
        return false;
    }
    else
    {
        return true;
    }
}



