Console.Write("Введите значение альфа: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение бэта: ");
double b = Convert.ToDouble(Console.ReadLine());

double z1 = (Math.Sin(a) + Math.Cos(2 * b - a)) / (Math.Cos(a) - Math.Sin(2 * b - a));
double z2 = (1 + Math.Sin(2 * b)) / (Math.Cos(2 * b));

Console.WriteLine($"z1 = {z1}, z2 = {z2}");
Console.ReadLine();