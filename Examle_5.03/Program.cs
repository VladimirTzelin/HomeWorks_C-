// Напишите программу, которая определяет присутствует ли заданное число в массиве
// 4; [8, 5, 6, 3 ] -> нет
// 3; [8, 5, 6, 3 ] -> да
int[] CreateNumbersArray()
{
    int[] array = new int[20];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 101);
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

int InputData(string message)
{
    Console.WriteLine(message + " > ");
    return Convert.ToInt32(Console.ReadLine());
}
bool Check(int[] array, int inputNumber)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == inputNumber)
        {
            return true;
        }
    }
    return false;
}
int number = InputData("Введите число");
int[] numbersArray = CreateNumbersArray();
PrintArray(numbersArray, "Массив:");
if (Check(numbersArray, number))
{
    Console.WriteLine("Да.");
}
else
{
    Console.WriteLine("Нет.");
}

