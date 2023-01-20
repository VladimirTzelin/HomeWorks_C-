/* Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    2, 3, 7 -> 7
    44 5 78 -> 78
    22 3 9 -> 22 */

Console.Write("Введите число а > ");
string str_a = Console.ReadLine();
int a = Int32.Parse(str_a);

Console.Write("Введите число b > ");
string str_b = Console.ReadLine();
int b = Int32.Parse(str_b);

Console.Write("Введите число c > ");
string str_c = Console.ReadLine();
int c = Int32.Parse(str_c);

int max = a;
if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine($"a = {a}; b = {b} ;  c = {c} ; max =  {max}");