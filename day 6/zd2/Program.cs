int n = 5;
double [] a = { -2, 3, -1, 2, 0, -6 };
double num1 = a.Length;
double num2 = 0;
for (int i = 0; i < a.Length; i++) num2 = num2 + a[i];
double result_sr = num2 / num1;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] < 0) a[i] = a[i] + 0.5;
    else if (a[i] < result_sr) a[i] = 0.1;
}
Array.Sort(a);
for (int i = 0; i < a.Length; i++) Console.Write($"{a[i]} ");

Console.Write("Введите число k - ");
double number_k = Convert.ToDouble(Console.ReadLine());
double result = BinarySearch(a, number_k);
if (result == -1)
{
    Console.WriteLine("Элемент не найден");
}
else
{
    Console.WriteLine($"Элемент найден в позиции {result}");
}

static int BinarySearch(double[] arr, double x)
{
    int left = 0;
    int right = arr.Length - 1;
    while (left <= right)
    {
        int mid = (left + right) / 2;
        if (arr[mid] == x)
        {
            return mid;
        }
        else if (arr[mid] < x)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }
    return -1; // элемент не найден
}
    Console.ReadKey();