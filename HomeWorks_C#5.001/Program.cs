//Урок 5. Функции и одномерные массивы
//Задача 1: Задайте массив заполненный случайными положительными
// трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел 
//в массиве.
// Пример   [345, 897, 568, 234] -> 2

// Создаем массив положительных трёхзначных значений
int[] CreateArrayOfNumbers(int lgth)
{
    int[] newArray = new int[lgth];
    Random rnd = new Random();

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(100, 999); // положительные трёхзначные
    }
    return newArray;
}

// Выводим массив array и сообщение  message на консоль
void PrintArray(int[] array)
{
    //Console.WriteLine(message);
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}, ");
    }
    Console.Write(" ]");
}

// считаем количество четных значений в массиве
int EvenNumbers(int[] array)
{
    int evenCounter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenCounter++;
        }
    }
    return evenCounter;
}

// Преобразование строковой переменной (string) в целое число (int)
int InputNumber(string message)
{
    System.Console.Write(message + "-> ");
    string str_num = Console.ReadLine();
    int num = Int32.Parse(str_num);
    return num;
}

int lgth = InputNumber("Введите длину массива ");
int[] InitalArray = CreateArrayOfNumbers(lgth);
PrintArray(InitalArray);
Console.Write(" -> ");
Console.WriteLine(EvenNumbers(InitalArray));

