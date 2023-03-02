using System.Text.RegularExpressions;

string input = "всеем мамам ппривет тату";
string pattern = @"\b(\w+)\W+(\w+)\b";

MatchCollection matches = Regex.Matches(input, pattern);

foreach (Match match in matches)
{
    string word1 = match.Groups[1].Value;
    string word2 = match.Groups[2].Value;

    if (word1[word1.Length - 1] == word2[0])
    {
        Console.WriteLine(word1 + " " + word2);
    }
}

Console.ReadLine();