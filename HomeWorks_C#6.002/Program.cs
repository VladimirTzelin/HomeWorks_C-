// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// Пример: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// 
// xСoordinate = (b2-b1)/(k1-k2)
// yСoordinate = (k1*b2-k2*b1)/(k1-k2)

/*Укажитезначения коэффициентов k и b прямых      Введите значение  k1->  3
Введите значение  b1->  4
Введите значение  k2->  6
Введите значение  b2->  7
Координаты точки пересечения прямых -1 ; 1 */

//Ввод значений элементов прямых k1, b1; k2, b2

string s; float k1; float k2; float b1; float b2;
Console.WriteLine("\nУкажите значения коэффициентов k и b уравнений прямых\t");
Console.Write("Введите значение  k1->\t");
k1 = float.Parse(Console.ReadLine());
//k1 = Int32.Parse(Console.ReadLine());
Console.Write("Введите значение  b1->\t");
b1 = float.Parse(Console.ReadLine());
//b1 = Int32.Parse(Console.ReadLine());
Console.Write("Введите значение  k2->\t");
k2 = float.Parse(Console.ReadLine());
//k2 = Int32.Parse(Console.ReadLine());
Console.Write("Введите значение  b2->\t");
b2 = float.Parse(Console.ReadLine());
//b2 = Int32.Parse(Console.ReadLine());

if (k1 == k2)
{
    Console.Write("Прямые не пересекаются\n");
}
else
{
float x = (b2 - b1) / (k1 - k2);
float y = (k1 * b2 - k2 * b1) / (k1 - k2);

Console.Write($"Координаты точки пересечения прямых {x:F2} ; {y:F2}");
}


