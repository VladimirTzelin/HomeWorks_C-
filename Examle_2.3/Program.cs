/* Задача 3:    Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
                и проверяет, является ли этот день выходным.
Примеры: 
                6 -> да
                7 -> да
                1 -> нет
                Решение Владимира Морозова
*/
Console.WriteLine("Введите номер недели >  ");
string dayofweek = Console.ReadLine();
int numberday = Int32.Parse(dayofweek);
if (numberday < 8 && numberday > 0)
{
    string[] weeks = new string[7] { "Это будний день", "Это будний день", "Это будний день", 
    "Это будний день", "Это будний день", "Это выходной день", "Это выходной день" };
    Console.WriteLine(weeks[numberday - 1]);
}
else
{
    Console.WriteLine("это не день недели");
}