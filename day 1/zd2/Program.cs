//Console.Write("Введите трехзначное число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int b;
//b = number % 100;
//number = 
//number = b * 100 + number;
//Console.WriteLine(number);
//Console.ReadLine();

int temp, k, x, y;
Console.WriteLine("Введите трехзначное число");
k = Convert.ToInt32(Console.ReadLine());
temp = k;
k = k / 100;
temp = temp % 100;
//x = k / 10;
y = k % 10;
k = temp;
Console.WriteLine($"Полученное трехзначное число:, {k}{y}");
Console.ReadLine();