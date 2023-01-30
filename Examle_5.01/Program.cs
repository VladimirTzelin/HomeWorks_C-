/*  Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20.
*/
// создаём массив длиной len со значениями от minValue до maxValu

int[] CreateArray(int len, int minValue, int maxValue)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}
// вывод на печать элеменов массива в цикле
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");         // вывод через табуляцию
    }
    Console.WriteLine();
}

int SumSign(int[] array, bool positive = true)
{
    int sign = -1;
    if (positive)
    {
        sign = 1;
    }

    int sum = 0;
    foreach (int item in array)
    {
        if ((item * sign) > 0)
        {
            sum += item;
        }
    }

    return sum;
}
// задаём параметры массива
int length = 12;
int minVal = -9;
int maxVal = 9;
// пердаём в CreateArray длину, нижний и верхний диапазон значений массива
int[] array = CreateArray(length, minVal, maxVal);
// выводим значения массива       
PrintArray(array);                          // вызов функции PrintArray(array)  вывод массива                
int sumPositive = SumSign(array);           // вызов функции SumSign(array) находит сумму положительных значений
int sumNegative = SumSign(array, false);    // вызов функции SumSign(array, false) находит сумму отрицательных значений
System.Console.WriteLine($"Сумма положительных элементов {sumPositive}");
System.Console.WriteLine($"Сумма отрицательных элементов {sumNegative}");
