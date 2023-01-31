// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// Пример:  [3, 7, 23, 12] -> 19
//          [-4, -6, 89, 6] -> 0


// Создаем массив произвольных значений
int[] CreateArray(int lgth)
{
    int[] newArray = new int[lgth];
    Random rnd = new Random();

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(-10, +10);
    }
    return newArray;
}

// Выводим массив array на консоль
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

// Находим сумму значений чётных элементов массива
int SumEvenPos(int[] array)
{
    int i = 0;   //Если присвоить i = 1, получим сумму значений  нечётных элементов?
    int sum = array[i];
    while (i < array.Length - 2)
    {
        i = i + 2;
        sum = sum + array[i];
    }
    return sum;
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
int[] InitalArray = CreateArray(lgth);
PrintArray(InitalArray);
Console.WriteLine($" -> {SumEvenPos(InitalArray)} ");
Console.Write("  ");