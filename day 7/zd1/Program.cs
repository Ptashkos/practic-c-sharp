string input_stroka;
string output_stroka = "";
Console.Write("Введите желаемую строку: ");
input_stroka = Console.ReadLine();

for (int i = 0; i < input_stroka.Length; i++)
{
    if (char.IsLower(input_stroka[i]))
    {
        output_stroka += char.ToUpper(input_stroka[i]);
    }
    else if (char.IsUpper(input_stroka[i]))
    {
        output_stroka += char.ToLower(input_stroka[i]);
    }
    else
    {
        output_stroka += input_stroka[i];
    }
}

Console.WriteLine(output_stroka);
Console.ReadKey();