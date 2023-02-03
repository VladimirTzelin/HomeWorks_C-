// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// примеры: // 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//Ввод значений элементов массива с консоли
int[] EnteringArrayValues()
{
    Console.Write("\nУкажите длину массива->\t");
    string str_n = Console.ReadLine();
    int num = Int32.Parse(str_n);

   // int n = int.Parse(string.ReadLine());
    int[] arr = new int[num];

    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент ->\t");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}
// Выводим результат решения
void SummingUp(int[] array)
{
int k = 0;
Console.Write("Введены следующие значения: [");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}; ");
    if (array[i] > 0)
    {
        k++;
    }
}
Console.Write("]  ");
Console.WriteLine($"\nВ массиве из {array.Length} значений, {k}  больше нуля.");
}

SummingUp(EnteringArrayValues());


// Результат
//Укажите длину массива-> 3
//Введите 1-й элемент ->  4
//Введите 2-й элемент ->  0
//Введите 3-й элемент ->  -9
//Введены следующие значения: [4; 0; -9; ]  
//В массиве из 3 значений, 1  больше нуля.