using System;

Console.Write("Введите чило х: ");
double x = Convert.ToDouble(Console.ReadLine());
double y;
if (x >= 1 && x <= 3)
{
    y = 2 * (x * x) - 3 * Math.Exp(Math.Sin(x));
    Console.WriteLine($"y = {y}");
}
if (x>3)
{
    y = 3 * Math.Tan(x);
    Console.WriteLine($"y = {y}");
}
Console.ReadLine();