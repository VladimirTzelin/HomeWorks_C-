/* Семинар 8. Задача 3: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:   2 4 | 3 4
                            3 2 | 3 3
            Результирующая матрица будет:      18 20
                                               15 18        */

// Получаем параметры массива
int InputData(string msg)
{
    Console.Write($"{msg} ");
    return Convert.ToInt32(Console.ReadLine());
}

//Проверка введённых значений [rows,columns]
void CheckingData(int rows, int columns)
{
    if (rows < 1)
    {
        Console.WriteLine($"Количество строк: {rows} < 1 недопустимое значение!");
        Environment.Exit(0);
    }
    if (columns < 1)
    {
        Console.WriteLine($"Количество столбцов: {columns} < 1 недопустимое значение!");
        Environment.Exit(0);
    }
}

// Проверка соответствия размерности матриц (rowB == colA)
void CheckingSize(int colA, int rowB)
{
    if (colA != rowB)
    {
        Console.WriteLine($"Перемножение матриц не возможно!");
        Console.WriteLine($"Количество row B[{rowB},] не равно column A[,{colA}]");
        Environment.Exit(0);
    }
}

//Создаём массив размерностью [row,col]
int[,] CreateArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rnd.Next(1, 5);
        }
    }
    return array;
}

// Вывод на печать массива int[,]
void PrintArray(int[,] array, string msg)
{
    Console.Write(msg);
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

// Перемножение матриц, размерность массива multAB[rowA , colB]
int[,] MultMatr(int[,] matrA, int[,] matrB)
{
    int row = matrA.GetLength(0);
    int col = matrB.GetLength(1);
    int[,] multAB = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < matrB.GetLength(0); k++)
            {
                multAB[i, j] += matrA[i, k] * matrB[k, j];
            }
        }
    }
    return multAB;
}



int rowsA = InputData($"Введите количество строк в матрице А:");
int columnsA = InputData($"Введите количество столбцов в матрице A:");
CheckingData(rowsA, columnsA);
int rowsB = InputData($"Введите количество строк в матрице B:");
int columnsB = InputData($"Введите количество столбцов в матрице B:");
CheckingData(rowsB, columnsB);
CheckingSize(columnsA, rowsB);
int[,] SourceMatrixA = CreateArray(rowsA, columnsA);
PrintArray(SourceMatrixA, "Сформирована матрица А: ");
int[,] SourceMatrixB = CreateArray(rowsB, columnsB);
PrintArray(SourceMatrixB, "Сформирована матрица B: ");
int[,] multAB = MultMatr(SourceMatrixA, SourceMatrixB);
PrintArray(multAB, "Результат перемножения матриц А и B: ");
