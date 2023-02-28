using System;

Console.Write("Введите значение N (N < 10): ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите значение a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите значение b: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите значение С: ");
int c = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];
Random rnd = new Random();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rnd.Next(a, b + 1);
    }
}

Console.WriteLine("Исходная матрица:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

// Вычисление суммы квадратов элементов, больших заданного числа C
int sumOfSquares = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (matrix[i, j] > c)
        {
            sumOfSquares += matrix[i, j] * matrix[i, j];
        }
    }
}
Console.WriteLine("Сумма квадратов элементов, больших " + c + ": " + sumOfSquares);

// Вычисление среднего арифметического элементов каждой строки
for (int i = 0; i < n; i++)
{
    int sum = 0;
    for (int j = 0; j < n; j++)
    {
        sum += matrix[i, j];
    }
    double avg = (double)sum / n;
    Console.WriteLine("Среднее арифметическое элементов " + (i + 1) + "-й строки: " + avg);
}
Console.ReadKey();