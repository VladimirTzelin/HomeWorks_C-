﻿/*Решение в группах задачи:
Задача 1: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0	1	2	3
1	2	3	4
2	3	4	5  */


// Задаём массив 5х5 каждый элемент Aₘₙ = m+n
int[,] CreateArray(int l = 5, int c = 5)
{
    int[,] array = new int[l, c];
    Random rnd = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {           
              array[i, j] = i + j;                    
        }
    }
    return array;
}
// Вывод массива на печать
void PrintArray(int[,] array, string msg)
{
    Console.WriteLine(msg);
    for (int i = 0; i < array.GetLength(0); i++)  // array.GetLength(0) длина строки 
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)   // array.GetLength(1) длина столбца
        {
            Console.Write(array[i, j] + "\t");
        }
    }
    Console.WriteLine();
}

int[,] Array = CreateArray(5, 5);			// заказываем создать массив 5х5
PrintArray(Array, "Создан массив: ");		// распечатать созданный массив


