//Задача 3: Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:     1 4 7 2
//                            5 9 2 3
//                            8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.   

int InputData(string msg)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
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
            array[i, j] = rnd.Next(-10, 10);
        }
    }
    return array;
}

// Вывод массива на печать
void PrintArray(int[,] array, string msg)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(msg);
    for (int i = 0; i < array.GetLength(0); i++)     // array.GetLength(0) длина строки 
    {
        Console.Write("\n" + "\t");
        for (int j = 0; j < array.GetLength(1); j++) // array.GetLength(1) длина столбца
        {
            Console.Write($"\t {array[i, j]:F2}");
        }
    }
}

void PrintArray1(double[] array, string msg)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(msg);
    for (int i = 0; i < array.Length; i++)     // array.GetLength(0) длина строки 
    {
        Console.Write($"\t {array[i]:F2}");
    }
}

// Ищем среднее арифметическое столбцов массива 
double[] Сalculator(int n, int m, int[,] array)
{
    int sum;
    double[] average = new double[m];
    for (int j = 0; j < m; j++)
    {
        sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum = sum + array[i, j];
        }
        average[j] = (Double)sum / array.GetLength(0);
    }
    return average;
}


int rows = InputData($"Введите количество строк в массиве:");
int columns = InputData($"Введите количество столбцов в массиве:");

int[,] Array = CreateArray(rows, columns);
PrintArray(Array, "\nСоздан массив чисел: ");
Сalculator(rows, columns, Array);
double[] Aaverage = Сalculator(rows, columns, Array);
PrintArray1(Aaverage, "\nСреднее: ");
Console.WriteLine("\n");
Console.ForegroundColor = ConsoleColor.White;