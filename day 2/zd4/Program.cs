Console.WriteLine("Введите диапазон чисел от А до Б (А <= Б).");
Console.Write("Введите грань А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите грань Б: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число Y: ");
int y = Convert.ToInt32(Console.ReadLine());
int i = a;
while (i <= b)
{
    if (i % 10 == x || i % 10 == y) Console.WriteLine(i);
    i++;
}
Console.ReadLine();