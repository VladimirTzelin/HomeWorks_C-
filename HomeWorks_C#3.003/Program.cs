/* Задача 3.3   Напишите программу, которая принимает на вход число (N)
                и выдаёт таблицу кубов чисел от 1 до N.
Примеры:        3 -> 1, 8, 27
                5 -> 1, 8, 27, 64, 125
*/


Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index <= num)
{
  Console.Write($"{Math.Pow(index, 3)}, "); 
  index ++;  
}  

           