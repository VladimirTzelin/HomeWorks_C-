/* Семинар 7 ДЗ 
Задача 1: Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
Пример: m = 3, n = 4.
                        0,5  7      -2    -0,2
                        1    -3,3   8     -9,9
                        8    7,8    -7,1  9                           */

// Назначаем с консоли размер (n,m) массива 
int InputData(string msg)
{
    Console.Write($"{msg} ");
    return Convert.ToInt32(Console.ReadLine());
}

// Создаем массив n*m вещественных чисел
double[,] CreateArrayRealValues(int n, int m)
{
    double[,] array = new double[n, m];
    Random rand = new Random(); 
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {   //Случ. вещественное число, вместо rnd -> rand
            array[i, j] = rand.Next(-100, 101) * 0.003; 
            //array[i, j] = Math.Round(rand.Next(-100, 101) * 0.01, 2);
        }
    }
    return array;
}

// Вывод массива на сонсоль
void PrintArray(double[,] array, string msg)
{
    Console.WriteLine(msg);
    for (int i = 0; i < array.GetLength(0); i++)  // array.GetLength(0) длина строки 
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)   // array.GetLength(1) длина столбца
        {   // Только так получилось отформатировать <array[i, j].ToString("F3")>
            Console.Write(array[i, j].ToString("F3") + "\t"); 
        }
    }
    Console.WriteLine();
}


int sizeN = InputData("Введите количество строк  массива   N: ");
int sizeM = InputData("Введите количество столбцов массива M: ");
double[,] InitalArray = CreateArrayRealValues(sizeN, sizeM);
PrintArray(InitalArray, "Создан массив вещественных значений: ");


//Введите строк  массива   N:  > 2
//Введите столбцов массива M:  > 6
//Создан массив вещественных значений: 
/*
0,066   0,028   0,040   0,026   -0,017  0,018
-0,036  0,041   -0,052  0,003   0,046   0,052   */