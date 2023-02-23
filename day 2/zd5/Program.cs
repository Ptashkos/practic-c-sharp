Console.Write("Введите вещественное число A(-5<=A<=5)");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите челок число N(1<=N<=10)");
double n = Convert.ToDouble(Console.ReadLine());
int x = 1;

while (x <= n) 
{
    Console.WriteLine($"{Math.Pow(a,x):.####}");
    x++;
}
Console.ReadLine();