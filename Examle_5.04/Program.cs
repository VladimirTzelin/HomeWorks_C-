//Задача 3: Задайте одномерный массив из 10 случайных чисел в диапазоне от 1 до 200.
 //Найдите количество двузначных элементов массива. 
 //Пример для массива из 5, а не из 10 элементов. 
 //В своём решении сделайте для 10 [5, 18, 123, 6, 2] -> 1 
 //[1, 2, 3, 6, 2] -> 0 
 //[10, 11, 12, 13, 14] -> 5

int[] CreateNumbersArray()
{
    int[] array = new int[10];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 201);
    }
    return array;
}

void PrintArray(int[] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int CheckFromTen(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
        {
            count++;
        }
    }
    return count;
}

int[] numbersArray = CreateNumbersArray();
PrintArray(numbersArray, "Массив:");
Console.WriteLine("Количество двузначных чисел в массиве:");
Console.WriteLine(CheckFromTen(numbersArray));

 
