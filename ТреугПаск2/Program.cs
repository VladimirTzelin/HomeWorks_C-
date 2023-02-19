
System.Console.WriteLine("Pascal Triangle Program");
System.Console.Write("Введите количество строк: ");
string input = System.Console.ReadLine();
int n = Convert.ToInt32(input);

for (int y = 0; y < n; y++)
{
    int c = 1;
    for (int q = 0; q < n - y; q++)
    {
        System.Console.Write("    "); // Заполняем начала строк пробелами
    }

    for (int x = 0; x <= y; x++)
    {
        System.Console.Write("     {0:D} ", c); // расстояния между элементами
        c = c * (y - x) / (x + 1);
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();


