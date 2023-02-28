Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine());

double result = Factorial(n - 3) / Factorial(n);

Console.WriteLine("f(n) = " + result);

    static double Factorial(int n)
{
    if (n <= 1)
    {
        return 1;
    }
    else
    {
        return n * Factorial(n - 1);
    }
}
Console.ReadLine();