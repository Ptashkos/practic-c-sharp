static void Func(double x,out double z)
{
    z = Math.Pow(x, 3) - Math.Sin(x);
    Console.WriteLine(z);
}
Console.Write("Введите число а: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b: ");
double b = Convert.ToDouble(Console.ReadLine());
double rez1, rez2;
Func(a, out rez1);
Func(b, out rez2);

if (rez1 > rez2) Console.WriteLine($"В точке {a} фунция принимает наибольшее значение. ");
else Console.WriteLine($"В точке {b} фунция принимает наибольшее значение. ");
Console.ReadLine();