// Семинар 8. Задача 4: Напишите программу, которая заполнит спирально квадратный массив. 


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

//Создаём массив размерностью [row,col] заполняем нулями
int[,] CreateArray(int row, int col)
{
    int[,] array = new int[row, col];
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

// Заполняем массив по спирали
int[,] Spiral(int[,] array)
{
    int startRow = 0, stopRow = 0, startCol = 0, stopCol = 0;
    int k = 1, i = 0, j = 0;
    int nRows = array.GetLength(0);
    int nColumns = array.GetLength(1);
    while (k <= nRows * nColumns)
    {
        array[i, j] = k;
        if (i == startRow && j < nColumns - stopCol - 1)                    // налево 
            ++j;
        else if (j == nColumns - stopRow - 1 && i < nRows - stopRow - 1)    // вниз 
            ++i;
        else if (i == nRows - stopCol - 1 && j > startCol)                  // направо 
            --j;
        else
            --i;                                                            // вверх 
            // текущий оборот спирали завершён?
        if ((i == startRow + 1) && (j == startCol) && (startCol != nColumns - stopCol - 1))
        {   // параметры нового оборота спирали
            startRow++;
            stopRow++;
            startCol++;
            stopCol++;
        }
        ++k;
    }

    return array;
}
int rows = InputData($"Введите количество строк:");
int columns = InputData($"Введите количество столбцов:");
CheckingData(rows, columns);
int[,] SourceArray = CreateArray(rows, columns);
PrintArray(SourceArray, "Сформирован пустой массив: ");
int[,] SPRLarr = Spiral(SourceArray);
PrintArray(SPRLarr, "Сформирован 'спиральный массив' ");