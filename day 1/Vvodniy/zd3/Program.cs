double x = 4.3;
Console.WriteLine($"Число x = {x}");
double y = ((1 + Math.Sqrt(Math.Abs(3 - x * x))) / (Math.Atan(x * x))) - Math.Exp(Math.Sin(Math.Sqrt(x)));
Console.WriteLine($"y= {y}");
Console.ReadLine();