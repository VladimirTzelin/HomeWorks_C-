/*Семинар 8. Задача 2: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив: 1 4 7 2      1 строка
                        5 9 2 3
                        8 4 2 4
                        5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: */

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

//Создаём массив размерностью [row,col]
int[,] CreateArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

// Вывод массива на печать
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

// Находим строку с минимальной суммой элементов
void RowMinSum(int[,] array)
{
    int sumMin = 0;
    int row = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (i == 0)
        {
            sumMin = sum;
            row = 1;
        }
        if (sumMin > sum)
        {
            sumMin = sum;
            row = i + 1;
        }
        Console.WriteLine($"Сумма строки[{i + 1}] = {sum}");
    }
    Console.WriteLine($"Минимальное значение суммы элемнтов в строке[{row}]");
}

int rows = InputData($"Введите количество строк в массиве:");
int columns = InputData($"Введите количество столбцов в массиве:");
CheckingData(rows, columns);
int[,] SourceArray = CreateArray(rows, columns);
PrintArray(SourceArray, "Сформирован массив натуральных чисел: ");
RowMinSum(SourceArray);