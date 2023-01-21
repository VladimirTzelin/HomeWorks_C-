/*  Задача 3:  Напишите программу, которая принимает на вход цифру, 
               обозначающую день недели, и проверяет, является ли этот день выходным.
    Примеры:   6 -> да
               7 -> да
               1 -> нет
*/

Console.Write(" Введите номер дня недели  ");
int DayOfWeek = int.Parse(Console.ReadLine());

if (DayOfWeek >= 1 && DayOfWeek <= 5)
{
    Console.Write(" Нет, это будний день");
}
else
{
    if (DayOfWeek >= 6 && DayOfWeek <= 7)
    {
        Console.Write(" Да, это суббота или воскресение");
    }
    else
    {
        Console.Write(" Такого дня в неделе нет ");
    }
}




