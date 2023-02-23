Console.Write("Введите расстояние в метрах: ");
int metrs = Convert.ToInt32(Console.ReadLine());
int kilometrs = 0;
if (metrs >= 1000)
{
    kilometrs = metrs / 1000;
    Console.WriteLine($"Количество киилометров в веденном расстоянии в метрах составляет {kilometrs} километра(ов).");
}
else Console.WriteLine("Нету ниодного киломметра.");
Console.ReadLine();