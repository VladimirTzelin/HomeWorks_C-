// Задача 3:    Задайте массив вещественных чисел. 
//              Найдите разницу между максимальным и минимальным элементами массива.
// Пример: [3 7 22 2 78] -> 76

// Создаем массив вещественных чисел
double[] CreateArray(int lgth)
{
    double[] newArray = new double[lgth];
    Random rnd = new Random();

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.NextDouble() * 100;
    }
    return newArray;           
}

// Выводим массив array на консоль
void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]:F2}, ");
    }
    Console.Write(" ]");
}

// Преобразование строковой переменной (string) в целое число (int)
int InputNumber(string message)
{
    System.Console.Write(message + "-> ");
    string str_num = Console.ReadLine();
    int num = Int32.Parse(str_num);
    return num;
}

// Находим разность между минимальным и максимальным значениями элементов массива
double DiffMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
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
    return (max - min);
}

int lgth = InputNumber("Введите длину массива ");
double[] InitalArray = CreateArray(lgth);
PrintArray(InitalArray);
Console.WriteLine($" -> {DiffMinMax(InitalArray):F2} ");
Console.Write("  ");