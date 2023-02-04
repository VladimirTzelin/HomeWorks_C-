// Одномерный массив с повторяющимися значениями.
// Необходимо отыскать второй максимум в одном цикле без дополнительных массивов
// Пример:  5, 5, 4, 3, 2 -> 4
//          3, 5, 4, 2 -> 4
//          3, 2, 4, 5

int[] NumbersArray = new int[] {3, 2, 4, 5};  //{3, 5, 4, 2}; //{ 5, 5, 4, 3, 2 };
int max1 = NumbersArray.Max();
int max2 = NumbersArray.Min();
for (int i = 0; i < 5; i++)
{
    if (NumbersArray[i] < max1 && NumbersArray[i] > max2)
    {
        max2 = NumbersArray[i];
    }
    Console.WriteLine($"{i} : {max1} ; {max2};");
}
Console.Write($"{max1} ; {max2}");