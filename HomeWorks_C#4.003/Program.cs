/* SЗадача 3:   Напишите программу, которая создаёт массив заданной длины и выводит его на экран.
Примеры:        1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
                6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine("Создаём массив длиной А и выводим его на консоль");

int number = InputNumber("Укажите длину массива: ");

if (CheckNum(number))
{   //Вывод массива
    Console.WriteLine();
    Console.WriteLine($"[{string.Join(", ", ArrayOfValues(number))}]"); 
    // String.Join Метод Сцепляет элементы указанного массива или элементы коллекции, 
    // помещая между ними заданный разделитель. 
    // https://learn.microsoft.com/ru-ru/dotnet/api/system.string.join?view=net-7.0
    Console.WriteLine();
}
else Console.Write($"Ошибка ввода числа {number}");


// Преобразование типа переменной из string в  int
int InputNumber(string message)
{
    System.Console.Write(message + "> ");
    string str_num = Console.ReadLine();
    int num = Int32.Parse(str_num);
    return num;
}


// Проверка на не отрицательноcть введённого значения (num)
bool CheckNum(int num)
{
    if (num < 0)
    {
        Console.Write("Укажите целое положительное число ! ");
        return false;
    }
    else return true;
}

// Создаём массив  размерности num случайных чисел 
int[] ArrayOfValues(int num)
{
    int[] array = new int[num];   //Размерность массива
    for (int i = 0; i < num; i++) //Заполнение массива случайными значениями от 0 до 100
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

