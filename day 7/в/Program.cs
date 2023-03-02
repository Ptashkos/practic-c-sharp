string inputString = "This Is a Sample String";
string outputString = "";

foreach (char c in inputString)
{
    if (!char.IsUpper(c))
    {
        outputString += c;
    }
}

Console.WriteLine(outputString);