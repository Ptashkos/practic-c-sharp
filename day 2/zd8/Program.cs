Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0 && num / 10 > 0) Console.WriteLine("Высказывание что данное число является четным и двузначным верно.");
else Console.WriteLine("Высказывание что данное число является четным и двузначным неверно.");
Console.ReadLine();