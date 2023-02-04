/*
Задача 4: Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, 
выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
Например, такой массив:	1 4 7 2
                        5 9 2 3
                        8 4 2 4
                        Введённый элемент 2, результат: [1, 4]
                        Введённый элемент 6, результат: такого элемента нет.    */

int[,] CreateArray(int l = 3, int c = 4)
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

int NumberInput(string msg)
{
    Console.WriteLine(msg + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

(bool, int, int) FindIndexes(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                return (true, i, j);
            }
        }
    }
    return (false, 0, 0);
}
int number = NumberInput("Введите число");
int[,] resultArray = CreateArray();
PrintArray(resultArray);

(bool check, int x, int y) = FindIndexes(resultArray, number);
if (check)
{
    Console.WriteLine($"Введенный элемент {number}, найден строка: {x + 1}, столбец: {y + 1}.");
}
else
{
    Console.WriteLine($"Данного элемента в массиве нет.");
}
