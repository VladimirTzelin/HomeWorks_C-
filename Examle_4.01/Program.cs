// задать размерность одномерного массива и вывести его на печать
int number = InputInt("Введите число");
int[] newArray = FillArray(number);
PrintArray(newArray);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] FillArray(int size)
{
    Random rnd = new Random();  // Создание объекта для генерации чисел
    int[] newArray = new int[size];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(1, 11);
    }
    return newArray;
}

int InputInt(string message)
{
    Console.WriteLine(message + " > ");
    // Проверки на ввод пустой строки или не корректного значения в message
    if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0) 
    {
        Console.WriteLine("Введите целое положительное число!");
        n = 0;
    }
    return n;
}
