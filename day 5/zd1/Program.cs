try
{
    Console.Write("Задайтее число х: ");
    double number_x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Результат первой функции равен , {Func1(number_x)}");
    Console.WriteLine($"Результат второй функции равен , {Func2(number_x)}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Неверный формат");
}
Console.ReadLine();

static double Func1(double x)
{
    return ((Math.Sin(x)) / (x - 5)) + Math.Pow(x, 3);
    
}

static double Func2(double x)
{
    return(Math.Log(x) - ((Math.Cos(x) / 3 * x + 6)));

}