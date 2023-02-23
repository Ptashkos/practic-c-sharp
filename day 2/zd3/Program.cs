Console.Write("Введите признак транспортного средства (1 - автомобиль, 2 - велосипед, 3 - мотоцикл, 4 - самолет, 5 - поезд): ");
int priznak = Convert.ToInt32(Console.ReadLine());
double counter = 0;

if (priznak == 1) counter = 490;
else if (priznak == 2) counter = 270;
else if (priznak == 3) counter = 350;
else if (priznak == 4) counter = 7000;
else if (priznak == 5) counter = 603;

Console.WriteLine($"Максимальная скорость выбранного траснпортного средства равна {counter} км/ч");
Console.ReadLine();
