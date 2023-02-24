Console.WriteLine("Введите координаты первой вершины a треугольника(x,y): ");
Console.Write("Введите x: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй вершины b треугольника(x,y): ");
Console.Write("Введите x: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты третьей вершины c треугольника(x,y): ");
Console.Write("Введите x: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y: ");
double y3 = Convert.ToDouble(Console.ReadLine());

double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

Console.WriteLine($"Вершина а = {a:.##}, вершина b = {b:.##}, вершина c = {c:.##}.");
double P = a + b + c;
double p2 = P / 2;
Console.WriteLine($"Периметр треугольника равен {a:.##} + {b:.##} + {c:.##} = {P:.##}");

double S = Math.Sqrt(p2 * (p2 - a) * (p2 - b) * (p2 - c));
Console.WriteLine($"Площадь треугольника равна {S:.##}");

Console.ReadLine();