// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3 
// error CS0029: Не удается неявно преобразовать тип "int" в "string".

Console.Write("Введите число а > ");
string str_a = Console.ReadLine();
int a = Int32.Parse(str_a);
// Console.WriteLine(a);
       
 Console.Write("Введите число b > ");
string str_b = Console.ReadLine();
int b = Int32.Parse(str_b);
// Console.WriteLine(b);       

int max = a;

if (max < b)
{
    max = b;
}
Console.WriteLine($"a = {a}; b = {b} ;  max =  {max}");