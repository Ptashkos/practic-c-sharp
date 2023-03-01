Console.Write("Введите фамилию пользователя: ");
string lastName = Console.ReadLine();
Console.Write("Введите имя пользователя: ");
string firstName = Console.ReadLine();
Console.Write("Введите отчество пользователя: ");
string middleName = Console.ReadLine();

string fullName = lastName + firstName + middleName;
int sum = 0;
foreach (char c in fullName)
{
    if (char.IsLetter(c))
    {
        int code = char.ToUpper(c) - 64; // код буквы в алфавите
        sum += code;
    }
}

while (sum > 9)
{
    int tempSum = 0;
    while (sum > 0)
    {
        tempSum += sum % 10;
        sum /= 10;
    }
    sum = tempSum;
}

Console.WriteLine($"Код личности: {sum}");
Console.ReadLine();