using System.Text.RegularExpressions;

Console.Write("Введите длину искомых слов: ");
int wordLength = int.Parse(Console.ReadLine());
string text = "Это пример текста, который мы будем анализировать. " +
              "В нём есть слова разной длины, но мы найдём только ";
string pattern = $@"\b\w{{{wordLength}}}\b";
MatchCollection matches = Regex.Matches(text, pattern);
Console.WriteLine($"\nНайдены слова длины {wordLength}:");
foreach (Match match in matches)
{
    Console.WriteLine(match.Value);
}
Console.ReadKey();