AERROFLOT[] flights = new AERROFLOT[7];
for (int i =0; i< flights.Length; i++)
{
    Console.WriteLine($"Введите данные для реейса номер {i+1}:");
    Console.WriteLine($"Название пункта назначения:");
    flights[i].target_point = Console.ReadLine();
    Console.WriteLine($"Номер рейса ");
    flights[i].flight_number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Тип самолета:");
    flights[i].airplane_type = Console.ReadLine();
}

Array.Sort(flights, (f1, f2) => f1.flight_number.CompareTo(f2.flight_number));
Console.Write("Введите название пункта назначения: ");
string destination = Console.ReadLine();
bool found = false;

for (int i = 0; i < flights.Length; i++)
{
    if (flights[i].target_point == destination)
    {
        Console.WriteLine("Рейс №" + flights[i].flight_number + ", тип самолета: " + flights[i].airplane_type);
        found = true;
    }
}

if (!found)
{
    Console.WriteLine("Рейсы в пункт назначения " + destination + " не найдены.");
}

Console.ReadKey();

struct AERROFLOT
{
    public string target_point;
    public int flight_number;
    public string airplane_type;
}
