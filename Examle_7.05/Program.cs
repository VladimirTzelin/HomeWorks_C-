/*
Задача 5: Задайте двумерный массив. Найдите максимальный элемент массива и среднее арифметическое всех элементов массива.
Например, такой массив:
1 4 7 2
5 9 2 3
8 4 2 4

Максимальный элемент массива 9
Среднее арифметическое 4.25 */

// Создаём массив 3х4 случайных чисел
int[,] CreateArray(int l = 3, int c = 4)
{
    int[,] array = new int[l, c];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-20, 20);
        }
    }
    return array;
}
// Выводим массив на консоль
void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
    }
    Console.WriteLine();
}
// Поиск максимального значения 
int FindMax(int[,] array)
{
    int max = array[0, 0];
    foreach (int item in array)
    {
        if (item > max)
        {
            max = item;
        }
    }
    return max;
}
// Поиск среднего значения
double FindAverage(int[,] array)
{
    double sum = 0;
    foreach (int item in array)
    {
        sum += item;
    }
    return sum / array.Length; // количество ВСЕХ элементов массива
}

int[,] baseArray = CreateArray();
PrintArray(baseArray);
int maxResult = FindMax(baseArray);
Console.WriteLine($"Максимальное значение в массиве = {maxResult}");
double averageResult = FindAverage(baseArray);
Console.WriteLine($"Среднее арифметическое элементов массива = {averageResult:F2}");
