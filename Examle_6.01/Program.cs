// Демонстрация решения Семинар 6 Задача 1
// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Функция ввода целого числа
int InputInt(string msg)
{
    System.Console.Write($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());
}
// Функция создаёт одномерный массив заданной длины {len}
int[] GenerateArray(int len, int minValue = 0, int maxValue = 10)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
    }
    return array;
}
// Функция PrintArray(...) выводит массив на экран
void PrintArray(int[] array)
{
    foreach (int item in array) // Цикл foreach см. параметр item 
    {
        System.Console.Write($"{item}; ");
    }
    System.Console.WriteLine();
}
// Функция "перворачивает" массив задом наперёд
int[] Reverse(int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        Swap1(array, i, array.Length - 1 - i); // Операция замены вызовом функции Swap1
    }
    return array;
}
// Функция замены значений элементов массива  с использованием переменной  temp
void Swap(int[] array, int i, int j)
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}
// Функция обмена значениями элементов массива  с использованием кортежа
void Swap1(int[] array, int i, int j)
{
    (array[i], array[j]) = (array[j], array[i]);
}

int len = InputInt("Введите длину массива");
int[] array = GenerateArray(len);
PrintArray(array);
PrintArray(Reverse(array));

