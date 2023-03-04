﻿//обобщенный вариант сортировки подсчетом
int[] CountingSort(int[] array)
{
    //поиск минимального и максимального значений
    int min = array[0];
    int max = array[0];
    foreach (int element in array)
    {
        if (element > max)
        {
            max = element;
        }
        else if (element < min)
        {
            min = element;
        }
    }

    //Поправка если min > 0 correctionFactor уменьшается, если min < 0 - увеличивается
    int correctionFactor = min != 0 ? -min : 0; //тернарный условный оператор
    max += correctionFactor; // размерность массива счётчиков увеличивается / уменьшается  на -min

    int[] count = new int[max + 1];
    for (int i = 0; i < array.Length; i++)
    {
        count[array[i] + correctionFactor]++;
    }

    int index = 0;
    for (int i = 0; i < count.Length; i++)
    {
        for (int j = 0; j < count[i]; j++)
        {
            array[index] = i - correctionFactor;
            index++;
        }
    }

    return array;
}

//метод для получения массива заполненного случайными числами
int[] GetRandomArray(int arraySize, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] randomArray = new int[arraySize];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = rnd.Next(minValue, maxValue);
    }

    return randomArray;
}

int Promt(string msg)
{
    System.Console.Write(msg + "-> ");
    return int.Parse(Console.ReadLine()!);
}

// Вдруг введено не положительное число!?
bool Check(int num)
{
    bool b = true;
    if (num < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"Введено отрицательное число!!! \n");
        Console.ForegroundColor = ConsoleColor.White;
        Environment.Exit(0);
        b = false;
    }
    return b;
}

//Проверка введённых значений [rows,columns]
void CheckingData(int min, int max)
{
    if (min > max)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Введено недопустимое значение! Максимальное значение {max} < {min} ");
        Console.ForegroundColor = ConsoleColor.White;
        Environment.Exit(0);
    }
}


int arrSize = Promt("Укажите длину массива ");
Check(arrSize);
int minVal = Promt("Укажите минимальное значение в массиве ");
//Check(minVal);
int maxVal = Promt("Укажите максимальное значение в массиве ");
Check(maxVal);
CheckingData(minVal, maxVal);
int[] arr = GetRandomArray(arrSize, minVal, maxVal + 1);
Console.WriteLine("Входные данные: \t {0}", string.Join(", ", arr));
Console.WriteLine("Отсортированный массив:  {0}", string.Join(", ", CountingSort(arr)));
