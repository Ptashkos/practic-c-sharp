try
{
    Console.Write("Задайте числу х значение вещественного числа: ");
    double number_x = Convert.ToDouble(Console.ReadLine());

    if (number_x > -3 && number_x < 3) Console.WriteLine($"Резльтат вычислеения функции равен{2 / number_x}");
    else if (number_x <= -3) Console.WriteLine($"Резльтат вычислеения функции равен{5 * number_x}");
    else throw new Exception("Введенное значение не подходит для вычислеения, так как н входит ни в один из двух диапазонов.");
}

catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.ReadLine();