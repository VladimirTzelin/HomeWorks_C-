//Задача 1: Создать двумерный массив случайныз чисел
//В каждой второй строке, каждый второй элемент возвести в степень 2
// Создание массива 5х5 случайных значений
//__________________________________________________
// Генерация случайных чисел в C#
// Создание объекта для генерации чисел
// ->     Random rnd = new Random();
// Получить очередное (в данном случае - первое) случайное число
// ->     int value = rnd.Next();
//Вывод полученного числа в консоль
// ->      Console.WriteLine(value);

//Задаём массив
int[,] CreateArray(int l = 5, int c = 5)
{
    int[,] array = new int[l, c];
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

int[,] BaseArray = CreateArray(5, 5);
PrintArray(BaseArray, "Созданный массив: ");

//Созданный массив: 
//
// -10      5       -5      -7      -6
//  5       3       -9      3       7 
//  0       8       -4      3       -9
//  1       -7      4       4       6 
//  8       2       5       -1      7