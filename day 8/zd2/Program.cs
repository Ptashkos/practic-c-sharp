using System.Text.RegularExpressions;
string wordSearch;
int nums = 0;
bool num;
string text = "Это пример пример пример текста, который мы будем анализировать. ";
Console.Write("Введите искомое слово: ");
wordSearch = Console.ReadLine();
string[] words = text.Split(new char[] { ' ', '.', ',', ';', ':', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
string pattern = @"\b" + wordSearch + @"\b";
MatchCollection matches = Regex.Matches(text, pattern);

foreach (Match match in matches) nums += 1;
if (nums > 1) Console.WriteLine($"Данное слово входит в этот текст {nums} раз ");
else Console.WriteLine("Это слово не входит в текст");

Console.ReadKey();