//Семинар 6. Задача 1гр.: Напишите программу, которая принимает на вход три числа 
//и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int InputData(string msg)
{
    Console.WriteLine($"{msg} > ");
    return Convert.ToInt32(Console.ReadLine());
}

bool CheckSides(int a, int b, int c)
{
    return (a + b > c && a + c > b && b + c > a);
}

int side1 = InputData($"Введите размер стороны a");
int side2 = InputData($"Введите размер стороны b");
int side3 = InputData($"Введите размер стороны c");
Console.WriteLine(CheckSides(side1, side2, side3));


