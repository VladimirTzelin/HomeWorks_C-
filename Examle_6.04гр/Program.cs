//Семинар 6.
//Задача 4 гр.: Напишите программу, которая будет создавать копию заданного массива с 
//помощью поэлементного копирования.

//Функция создаёт массив из 6 элементов
int[] CreateArray()
{
    int[] array = new int[6];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 11);
    }
    return array;
}

void PrintArray(int[] array, string msg)
{
    Console.WriteLine($"{msg}:");
    foreach (int item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

int[] CopyArray(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }
    return result;
}

int[] baseArray = CreateArray();
PrintArray(baseArray, "Базовый массив");
int[] copiedArray = CopyArray(baseArray);
PrintArray(copiedArray, "Скопированный массив");

