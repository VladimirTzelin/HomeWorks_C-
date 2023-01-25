/* Задача 1:    Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
                в натуральную степень B.
Примеры:        3, 5 -> 243 (3⁵)
                2, 4 -> 16
*/

Console.WriteLine("Число А возводится в степень числа В " );

int number = InputNumber("Введите число А: ");
int degree = InputNumber("Введите степень числа: ");

if (CheckDegree(degree))
{
    Console.Write($"Число {number} в степени {degree} = {DegreeOf(number, degree)} ;");
}



int InputNumber(string message)          // Присвоение переменным свойства int
{
System.Console.Write(message + "> ");
string str_num = Console.ReadLine();
int num = Int32.Parse(str_num);
return num;
}

int DegreeOf(int num, int deg)           // возведение num в степень deg
{
    int result = 1;

    for (int i = 1; i <= deg; i++)
    {
        result = result * num;
    }
    return result;
}

bool CheckDegree(int deg)               // Проверка на не отрицательноcть значения степени 
{
    if (deg < 0 )
    {
        Console.Write("Укажите целое положительное число ! ");
        return false;
    }
    else return true;
}