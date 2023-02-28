// Создаем двумерный массив для хранения доходов магазинов за каждый месяц
int[,] incomes = new int[10, 12];

// Заполняем массив случайными значениями для тестирования
Random rnd = new Random();
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 12; j++)
    {
        incomes[i, j] = rnd.Next(10000, 50000);
    }
}

// Выводим доходы каждого магазина за каждый месяц для проверки
Console.WriteLine("Доходы магазинов за каждый месяц:");
for (int i = 0; i < 10; i++)
{
    Console.Write("Магазин " + (i + 1) + ": ");
    for (int j = 0; j < 12; j++)
    {
        Console.Write(incomes[i, j] + " ");
    }
    Console.WriteLine();
}

// Вычисляем общий доход фирмы за сентябрь
int septemberTotalIncome = 0;
for (int i = 0; i < 10; i++)
{
    septemberTotalIncome += incomes[i, 8];
}

// Задаем заданное число и проверяем, превысил ли общий доход фирмы в сентябре это число
Console.WriteLine("Задайте число");
int targetIncome = Convert.ToInt32(Console.ReadLine());
if (septemberTotalIncome > targetIncome)
{
    Console.WriteLine("Общий доход фирмы в сентябре превысил " + targetIncome + ".");
}
else
{
    Console.WriteLine("Общий доход фирмы в сентябре не превысил " + targetIncome + ".");
}
Console.ReadLine();