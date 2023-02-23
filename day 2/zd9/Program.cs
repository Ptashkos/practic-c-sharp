Console.Write("Введите целое число А, которое будет равнятся стоимости за один килограм конфет: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i<=10; i++)
{
    Console.WriteLine($"Стоимость конфет за {i} килограмм(а) составляет {a*i} рублей");
}
Console.ReadLine();