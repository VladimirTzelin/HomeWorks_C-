/*Задача 1: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2                     В итоге получается вот такой массив:
5 9 2 3                                 7 4 2 1
8 4 2 4                                 9 5 3 2
                                        8 4 4 2
*/
// Предаём параметры массива из консоли
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
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rnd.Next(1, 100);
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

// Упорядочение элементов строки
int[,] ArraySort(int[,] array)
{
    //array[0, 0] = 0; array[1, 0] = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (array[i, j] < array[i, j + 1])
            {
                (array[i, j], array[i, j + 1]) = (array[i, j + 1], array[i, j]);
                j = -1;         // обеспечивает сортировку опзиций array[i,0]
            }
        }
    }
    return array;
}



int rows = InputData($"Введите количество строк в массиве:");
int columns = InputData($"Введите количество столбцов в массиве:");
int[,] SourceArray = CreateArray(rows, columns);
PrintArray(SourceArray, "\nСоздан массив натуральных чисел: ");
int[,]SortedArray = ArraySort(SourceArray);
PrintArray(SortedArray, "\nУпорядоченный массив: ");

