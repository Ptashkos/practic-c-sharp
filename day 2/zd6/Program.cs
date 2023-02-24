Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());
double a = 0;
int n = 10;
double b = Math.PI / 4;
double h = (b - a) / n;
double ix = a;
double y = 0;

for (double i = a; i<=b; i+=h)
{
    y = Math.Tan(x);
    x = x + h;
    Console.WriteLine(y);
}
Console.ReadLine();