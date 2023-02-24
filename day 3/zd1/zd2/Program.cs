Product a = new Product();
Console.WriteLine(a.Vivod());
Knot b = new Knot();
Console.WriteLine(b.Vivod());
Mechanism c = new Mechanism();
Console.WriteLine(c.Vivod());
//Detail d = new Detail();
//d.Vivod();

Console.ReadLine();

public class Product: Detail
{
    int count;
    string name_product;
    public Product() : base()
    {
        this.count = 0;
        this.name_product = String.Empty;
        Input();
    }
    void Input()
    {
        Console.Write("Введите названия изделия: ");
        name_product = Console.ReadLine();
        Console.Write("Введите количесвто механизмов в изделии: ");
        count = Convert.ToInt32(Console.ReadLine());
    }
    public override string Vivod()
    {
        return base.Vivod() + "Название изделия -" + name_product + " Количесвто механизмов в изделии- " + count + "";
    }
}

public class Knot: Detail
{
    string name_knot;
    public Knot():base()
    {
        this.name_knot = String.Empty;
        Input();
    }
    void Input()
    {
        Console.Write("Введите названиее узла: ");
        name_knot = Console.ReadLine();
    }
    public override string Vivod()
    {
        return base.Vivod() + "Название узла- " + name_knot + "";
    }
}

public class Mechanism: Detail
{
    string name_mechanism;
    public Mechanism() : base()
    {
        this.name_mechanism = String.Empty;
        Input();
    }
    void Input()
    {
        Console.Write("Введите название механизма: ");
        name_mechanism = Console.ReadLine();
    }
    public override string Vivod()
    {
        return base.Vivod() + "Название механизма- " + name_mechanism + "";
    }
}

public class Detail
{
    string name_detail, material;
    int number;
    public Detail()
    {
        this.name_detail = String.Empty;
        this.number = 0;
        this.material = String.Empty;
        Vvod();
    }
    public void Vvod()
    {
        Console.Write("Введите название детали: ");
        name_detail = Console.ReadLine();
        Console.Write("Введите номер детали: ");
        number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите материал изделия: ");
        material = Console.ReadLine();
    }
    public virtual string Vivod()
    {
        return "Название детали - " + name_detail + "Номер детали - " + number + "Материал детали - " + material + "";
    }
}