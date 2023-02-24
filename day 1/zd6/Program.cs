Console.Write("Введите двузначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int x = num % 10 + num / 10;
Console.WriteLine(x);
Console.ReadLine();