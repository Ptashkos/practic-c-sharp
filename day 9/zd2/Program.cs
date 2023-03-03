Accauntant accauntant = new Accauntant();

Console.WriteLine("Введите отработанные часы для менеджера:");
int managerHours = int.Parse(Console.ReadLine());

Console.WriteLine("Введите отработанные часы для программиста:");
int programmerHours = int.Parse(Console.ReadLine());

Console.WriteLine("Введите отработанные часы для дизайнера:");
int designerHours = int.Parse(Console.ReadLine());

if (accauntant.AskForBonus(Post.Manager, managerHours))
{
    Console.WriteLine("Менеджер заслуживает премию.");
}
else
{
    Console.WriteLine("Менеджер не заслуживает премию.");
}

if (accauntant.AskForBonus(Post.Programmer, programmerHours))
{
    Console.WriteLine("Программист заслуживает премию.");
}
else
{
    Console.WriteLine("Программист не заслуживает премию.");
}

if (accauntant.AskForBonus(Post.Designer, designerHours))
{
    Console.WriteLine("Дизайнер заслуживает премию.");
}
else
{
    Console.WriteLine("Дизайнер не заслуживает премию.");
}
Console.ReadLine();

enum Post
{
    Manager = 160,
    Programmer = 120,
    Designer = 140
}

class Accauntant
{
    public bool AskForBonus(Post worker, int hours)
    {
        return hours > (int)worker;
    }
}