// Задача 5 Реверс массива и макс мин

// функция создаёт м ассив
int[] CreateNumbersArray()
{
    int[] array = new int[6];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 51);
    }
    return array;
}
// функция выводит массив array и сообщение  message на консоль
void PrintArray(int[] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] Reverse(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        Swap2(array, i, array.Length - 1 - i); // Swap замена без временной переменной
    }
    return array;
}
// Вариант 1 функция "переворачивает" исходный массив задом наперёд
void Swap(int[] array, int i, int j)
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}
// Вариант 2 функция "переворачивает" исходный массив задом на перёд
void Swap2(int[] array, int i, int j)
{
    (array[i], array[j]) = (array[j], array[i]); // замена элементов без переменной temp
}
// Функция находит мир и макс значения в массиве
(int, int) MinMax(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return (min, max);
}

int[] InitalArray = CreateNumbersArray();
PrintArray(InitalArray, "Базовый массив:");
int[] reversedArray = Reverse(InitalArray);
PrintArray(reversedArray, "Перевернутый массив:");
(int min, int max) = MinMax(InitalArray);
PrintArray(InitalArray, $"Минимальное = {min}, максимальное = {max}:");
