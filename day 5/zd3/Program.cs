try
{
    Console.Write("Введите длину стороны а в сантиметрах для первого треугольника: ");
    double first_length = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите длину стороны а в сантиметрах для второго треугольника: ");
    double second_length = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите длину стороны а в сантиметрах для третьего треугольника: ");
    double third_length = Convert.ToDouble(Console.ReadLine());
    TrianglePS(first_length, out double P1, out double S1);
    TrianglePS(second_length, out double P2, out double S2);
    TrianglePS(third_length, out double P3, out double S3);
    Console.WriteLine($"Периметр первого треугольника равен {P1}, площадь равна {S1}");
    Console.WriteLine($"Периметр второго треугольника равен {P2}, площадь равна {S2}");
    Console.WriteLine($"Периметр третьего треугольника равен {P3}, площадь равна {S3}");
}

catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();
static void TrianglePS(double a, out double P, out double S)
{
    P = 0;
    S = 0;
    P = 3 * a;
    S = (a * a) * (Math.Sqrt(3) / 4);
}