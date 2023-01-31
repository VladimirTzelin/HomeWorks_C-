//Задача 4: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3 [6 7 3 6] -> 36 21

int[] CreateNumbersArray(int leng)      // создаем массив
{
    int[] array = new int[leng];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-10, 10);
    }
    return array;
}

// Преобразование типа переменной из string в  int
int InputNumber(string message)
{
    System.Console.Write(message + "-> ");
    string str_num = Console.ReadLine();
    int num = Int32.Parse(str_num);
    return num;
}
// вывод значений массива
// альтернатива Console.WriteLine($"[{string.Join(", ", ArrayOfValues(number))}]");
void PrintArray(int[] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
// функция перемножения "зеркальных" элементов исх. массива 0*n; 1*n-1; 2*n-2; и т.д.
int[] Multiplication(int[] array)
{       // находим длину массива результатов с учётом длины исх. массива чётное/не чётное число
        // и создаём новый массив multiplayArray  с результатами перемножения
    int[] multiplayArray = new int[array.Length / 2 + array.Length % 2];
        multiplayArray[multiplayArray.Length - 1] = array[multiplayArray.Length - 1];
    for (int i = 0; i < array.Length / 2; i++)
    {
        multiplayArray[i] = array[i] * array[array.Length - 1 - i];
    }
    return multiplayArray; 
}


int length = InputNumber("Укажите длину исходного массива "); // задаём параметры массива
int[] InitalArray = CreateNumbersArray(length);// вызываем функцию создания исх. массива
PrintArray(InitalArray, "Исходный массив:");    // выводим на консоль исх. массив
int[] MultipliedArray = Multiplication(InitalArray); // формируем массив произведений MultipliedArray
PrintArray(MultipliedArray, "Массив результатов умножения:");// выводим массив результатов
/*
Укажите длину исходного массива -> 11
Исходный массив:
2 -3 -5 -5 -9 -6 6 4 -1 9 2
Массив результатов умножения:
4 -27 5 -20 -54 -6
*/