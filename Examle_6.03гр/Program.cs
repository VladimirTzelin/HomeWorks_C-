//Семинар 6
//Задача 3гр.
//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

int InputData(string msg)
{
    Console.WriteLine($"{msg} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] Fibonnaci(int number)
{
    int[] fib = new int[number];
    fib[0] = 0;
    if (number == 1)
    {
        return fib;
    }
    fib[1] = 1;
    for (int i = 2; i < fib.Length; i++)
    {
        fib[i] = fib[i-1] + fib[i - 2];
    }
    return fib;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"Последовательность Фибонначи: ");
    foreach (int item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

int number = InputData($"Введите число");
int[] result = Fibonnaci(number);
PrintArray(result);

