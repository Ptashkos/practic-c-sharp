double pt, ct, pp, cp, sum;
pt = 2.75;
ct = 5;
pp = 0.85;
cp = 2;
Console.WriteLine($"Цена одной тетради - {pt}, кол-во тетрадей - {ct}, cтоимость одного карандаша - {pp}, кол-во карандашей - {cp}");

sum = pt * ct + pp * cp;
Console.WriteLine($"Стоимость всей покупки равна {sum}");
Console.ReadLine();