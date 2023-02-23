Console.WriteLine("Введите число");
var n = Console.ReadLine();

n = n.Replace("0", string.Empty)
     .Replace("2", string.Empty)
     .Replace("4", string.Empty)
     .Replace("6", string.Empty)
     .Replace("8", string.Empty);

n = n.Length > 0 ? n : "0";
if (n == "0") Console.WriteLine("");
else Console.WriteLine(n);
Console.ReadLine();