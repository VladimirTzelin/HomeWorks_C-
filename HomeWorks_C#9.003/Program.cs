/*Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29     */

int InputData(string msg)
{
    Console.Write($"{msg} ");
    return Convert.ToInt32(Console.ReadLine());
}
// Вдруг введено не положительное число!?
bool Check(int num)
{
    bool b = true;
    if (num < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"Введено отрицательное число!!! \n");
        Console.ForegroundColor = ConsoleColor.White;
        b = false;
    }
    return b;
}

/* функция Аккермана Последовательность a+b,a*b,a^b,... 
         | m + 1               при m = 0;
A(n,m) = | A(n-1, 1)           при m > 0 & n = 0
         | A(n-1, A(n, m-1))   при m > 0 & n > 0             */
int AckermannFunction (int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n > 0) && (m == 0))
      return AckermannFunction(n - 1, 1);
    else
      return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
}



int M = InputData($"Введите значение\t M = ");
Check(M);
int N = InputData($"Введите значение\t N  = ");
Check(M);
Console.Write($"Функция Аккермана для чисел ({M}, {N}) ="); 
Console.Write($" {AckermannFunction(M, N)}");
