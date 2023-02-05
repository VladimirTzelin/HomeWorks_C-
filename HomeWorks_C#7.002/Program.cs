/* Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:                 Результат:
    1 4 7 2                             1, 7 -> такого числа в массиве нет
    5 9 2 3                             1, 2 -> 4
    8 4 2 4                                                 */

int InputData(string msg)
{
    Console.Write($"{msg} > ");
    return Convert.ToInt32(Console.ReadLine());
}


//Задаём массив row x col
int[,] CreateArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-100, 100);
        }
    }
    return array;
}

// Вывод массива на печать
void PrintArray(int[,] array, string msg)
{
    Console.WriteLine(msg);
    for (int i = 0; i < array.GetLength(0); i++)     // array.GetLength(0) длина строки 
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++) // array.GetLength(1) длина столбца
        {
            Console.Write(array[i, j] + "\t");
        }
    }
    Console.WriteLine();
}
// Ищем нужный адрес в массиве 
void Check(int n, int m, int[,]array)
{
if (n  < 1 || n > array.GetLength(0) || m  < 1 || m > array.GetLength(1))
{
    Console.Write("Нужного элемента в массиве нет!?\n ");
}
else
{
    Console.Write($"Такой элемент в массиве есть Array[{n } , {m }] = ");
    Console.Write($"{array[n-1, m-1]}.\n ");
}
}

int rows = InputData($"Введите количество строк в массиве:");
int columns = InputData($"Введите количество столбцов в массиве:");
int desValueN = InputData($"Введите номер строки искомого элемента:");
int desValueM = InputData($"Введите номер строки искомого элемента:");
int[,] Array = CreateArray(rows, columns);
PrintArray(Array, "\nСоздан массив натуральных чисел: ");
Check(desValueN, desValueM, Array);

