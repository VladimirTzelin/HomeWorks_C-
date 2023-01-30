/* Напишите программу замены элементов массива: положительные элементы замените 
на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]  */

int[] CreateArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];         
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}
// вывод на печать элеменов массива в цикле
/*void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");         // вывод через табуляцию
    }
    Console.WriteLine();
}
*/
int[] Invers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;              // array[i] = array[i] * -1;
    }
    return array;
}
// Преобразование типа переменной из string в  int
int InputNumber(string message)
{
    System.Console.Write(message + "> ");
    string str_num = Console.ReadLine();
    int num = Int32.Parse(str_num);
    return num;
}

// задаём параметры массива
int length = InputNumber("Укажите длину массива: ");
int minVal = InputNumber("Укажите укажите нижнюю границу значений массива: ");
int maxVal = InputNumber("Укажите укажите верхнюю границу значений массива: ");

// передаём в CreateArray длину, нижний и верхний диапазон значений массива
int[] array = CreateArray(length, minVal, maxVal);

// выводим значения массива       
System.Console.WriteLine($"Значения  элементов массива: ");
Console.WriteLine($"[ {string.Join(", ", array)} ]");
System.Console.WriteLine($"Инвертированные  значения  элементов массива: ");
Console.WriteLine($"[ {string.Join(", ", Invers(array))} ]");


