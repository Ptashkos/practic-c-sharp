Console.WriteLine("Введите два вещественных числа.");
Console.Write("Ввеедите первое число a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"a= {a}");
Console.WriteLine($"b= {b}");

double c = a * b;

Console.WriteLine($"{a}*{b}={c:.###}");
Console.ReadLine();