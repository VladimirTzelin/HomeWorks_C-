/* Задача 1.    Напишите программу, которая принимает на вход пятизначное число и проверяет, 
                является ли оно палиндромом.
Примеры:        14212 -> нет
                12821 -> да
                23432 -> да
*/
Console.Write("Введите число > ");
string str_sequence = Console.ReadLine();
int sequence = Int32.Parse(str_sequence);

int revseq = sequence;
if (sequence >= 0 && (Reverse(revseq) == sequence))
    {
        Console.Write($"Число {sequence} - палиндром");
    }
else
    {
     Console.Write($"Число {sequence} - не палиндром");
    }

// Функция реверса последовательности цифр в чиселе

int Reverse(int seq)
{
    int digit, stack = 0;
    while (seq != 0)
    {
        digit = seq % 10;
        stack = stack * 10 + digit;
        seq = seq / 10;
    }
    return stack;
}

