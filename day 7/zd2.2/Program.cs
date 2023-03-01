string stroka;
int kolvo_numbers = 0;
int kolvo_simbols = 0;
Console.WriteLine("Введите строку: ");
stroka = Console.ReadLine();

foreach (char c in stroka)
{
    if (char.IsDigit(c)) kolvo_numbers += 1;
    else kolvo_simbols += 1;
}

Console.WriteLine($"Количество цифр в тексте - {kolvo_numbers}");
Console.WriteLine($"Количество символов, не являющимися цифрами, в тексте - {kolvo_simbols}");
Console.ReadKey();