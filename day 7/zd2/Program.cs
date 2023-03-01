string input_stroka;
Console.Write("Введите строку: ");
input_stroka = Console.ReadLine();
int proizvedenie = 1;
int min_number = 9;

foreach (char c in input_stroka)
{
    if (char.IsDigit(c))
    {
        int digit = int.Parse(c.ToString());
        proizvedenie *= digit;

        if (digit < min_number)
        {
            min_number = digit;
        }
    }
}

Console.WriteLine($"Произведение чисел равно {proizvedenie}");
Console.WriteLine($"Минимальное число - {min_number}");
Console.ReadLine();