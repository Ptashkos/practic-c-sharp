Console.Write("Задайте значение числу а: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Задайте значение числу b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Задайте значение шагу h: ");
double h = Convert.ToDouble(Console.ReadLine());
double y = 0;

for (double i = a; i <= b; i += h)
{
    
    Console.WriteLine($"{i:.##} {Func(i):.##}");
}
Console.ReadLine();


    static double Func(double x)
{
    double y;
    if (Math.Abs(x) <= 0.1) y = Math.Pow(x, 3) - 0.1;
    else if (x > 0.1 && x <= 0.2) y = 0.2 * x - 0.1;
    else y = Math.Pow(x, 3) + 0.1;
    return y;
}