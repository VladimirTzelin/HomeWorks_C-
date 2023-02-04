/*
Задача 3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.
Например, задан массив:
1	4	7
5	9	2
8	4	2
Сумма элементов главной диагонали: 1+9+2 = 12       */
//Создаём массив случайных чисел 5х5
int[,] CreateArray(int l = 5, int c = 5)
{
    int[,] array = new int[l, c];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
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
//Находим сумму элементов на диагонале
int SumDiagonaly(int[,] array)
{
    int x = 0; //индексы элементов на диагонали совпадают
    int sum = 0;
    while (x < array.GetLength(0))
    {
        sum += array[x, x];
        x++;
    }
    return sum;
}

int[,] array = CreateArray();
PrintArray(array); // посылаем созданный массив на консоль 
int result = SumDiagonaly(array);
Console.WriteLine($"Сумма значений диагональных элементов  массива = {result}");

