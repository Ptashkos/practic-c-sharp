Console.Write("Введите целое число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int chast = m % n;
if (chast == 0)
{
    Console.WriteLine($"Частное от деления чисел {m}/{n} равно {chast}");
}
else
{
    Console.WriteLine("M на N нацело не делится");
}
Console.ReadLine();