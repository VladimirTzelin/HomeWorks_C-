//Задача 2гр.: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10
//45 -> 101101
//3  -> 11
//2  -> 10


int InputData(string msg)
{
    Console.WriteLine($"{msg} > ");
    return Convert.ToInt32(Console.ReadLine());
}
// Функция вычисляет двоичное представление десятичного числа
int[] ConvertToBinary(int num)
{
    int[] binArray = new int[8];
    int ind = binArray.Length - 1;
    while (num != 0)
    {
        binArray[ind] = num % 2;    //массив формируется, начиная со старших значений
        num /= 2;
        ind--;
    }
   return binArray;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"Число в двоичной системе: ");
    foreach (int item in array)
    {
        Console.Write(item);
    }
    Console.WriteLine();
}

int number = InputData($"Введите число");
int[] binaryNumber = ConvertToBinary(number);
PrintArray(binaryNumber);

