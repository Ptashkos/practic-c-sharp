Console.Write("Введите число а: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int num2 = Convert.ToInt32(Console.ReadLine());
A num = new A(num1,num2);
num.chast();
num.func();
Console.ReadLine();

class A
{
    public int a;
    public int b;
    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public void chast()
    {
        Console.WriteLine($"Частное чисел {a}/{b} равно {a / b}");
    }
    public void func()
    {
        Console.WriteLine($"Результат вычисления заданной функции равен {Math.Pow(a + b, 1/3)}");
    }
}