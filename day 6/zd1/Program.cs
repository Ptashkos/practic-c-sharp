double[] a = {1.1, 1.2, 1.3, 1.4};
double num1 = a.Length;
double num2 = 0;
for (int i = 0; i < a.Length; i++) num2 = num2 + a[i];
Console.WriteLine($"Среднее арифмеетическое чисел массива - {num2/num1}");
Console.ReadKey();