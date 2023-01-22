/* Задача 3.2   Напишите программу, которая принимает на вход координаты двух точек 
                и находит расстояние между ними в 3D пространстве.
Примеры:        A (3,6,8); B (2,1,-7), -> 15.84
                A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double x1, x2, y1, y2, z1, z2, distance = 0;

Console.Write("Введите координату Х первой точки > ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки > ");
y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z первой точки > ");
z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Х второй точки > ");
x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второй точки > ");
y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z второй точки > ");
z2 = Convert.ToDouble(Console.ReadLine());

// L = [(x1-x2)^2 + (y1-y2)^2 = (z1 - z2)^2]^0.5

distance = Math.Sqrt
(
Math.Pow((x1 - x2), 2) +
Math.Pow((y1 - y2), 2) +
Math.Pow((z1 - z2), 2)
);
Console.WriteLine($" Расстояние между точками А({x1},{y1},{z1}) и B({x2},{y2},{z2})  = {distance:F2}");
