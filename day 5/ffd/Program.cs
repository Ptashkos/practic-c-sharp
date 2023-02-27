double num1, num2, result;
char operation;
bool powOfFirstNum = false;

//5^6 + 5 - 6 * 8 

Console.WriteLine("Введите первое число: ");
num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
num2 = double.Parse(Console.ReadLine());

Console.WriteLine("Выберите операцию (+, -, *, /, ^): ");
operation = char.Parse(Console.ReadLine());

switch (operation)
{
    case '+':
        result = num1 + num2;
        Console.WriteLine("Результат: " + result);
        break;

    case '-':
        result = num1 - num2;
        Console.WriteLine("Результат: " + result);
        break;

    case '*':
        result = num1 * num2;
        Console.WriteLine("Результат: " + result);
        break;

    case '/':
        if (num2 == 0)
        {
            Console.WriteLine("Ошибка: Деление на ноль невозможно");
        }
        else
        {
            result = num1 / num2;
            Console.WriteLine("Результат: " + result);
        }
        break;

    case '^':
        Console.WriteLine($"Какое число вы ходите возвести в степень? (1-{num1}, 2- {num2})");
        int vvod = Convert.ToInt32(Console.ReadLine());
        if (vvod == 1)
        {
            Console.WriteLine($"Вы хотите возвести число {num1} в степень числа {num2}? (1- да, 2 - нет)");
            int vvod2 = Convert.ToInt32(Console.ReadLine());
            if (vvod2 == 1)
            {
                Console.WriteLine($"Хорошо. Вот результат - {Math.Pow(num1,num2)}");
            }
            else if (vvod2==2)
            {
                Console.WriteLine($"Хорошо. Введите число, в какую степень вы хотите возвести число {num1}");
                double number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Вот результат - {Math.Pow(num1,number)}");
            }
            else Console.WriteLine("Неверное значение. Введите 1 или 2");
        }
        else if (vvod == 2)
        {
            Console.WriteLine($"Вы хотите возвести число {num2} в степень числа {num1}? (1- да, 2 - нет)");
            int vvod2 = Convert.ToInt32(Console.ReadLine());
            if (vvod2 == 1)
            {
                Console.WriteLine($"Хорошо. Вот результат - {Math.Pow(num2, num1)}");
            }
            else if (vvod2 == 2)
            {
                Console.WriteLine($"Хорошо. Введите число, в какую степень вы хотите возвести число {num2}");
                double number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Вот результат - {Math.Pow(num2, number)}");
            }
            else Console.WriteLine("Неверное значение. Введите 1 или 2");
        }
        else Console.WriteLine("Неверное значение. Введите 1 или 2");
        break;
}
Console.ReadKey();    