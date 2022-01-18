
#region Formel A
// Satz des Pythagoras für a 

static double formela(double c, double b)
{
    double a = Math.Pow(c,2);
    double aa = Math.Pow(b,2);
    double aaa = a - aa;
    double aaaa = Math.Sqrt(aaa);

    Console.WriteLine("Das Ergebnis für a ist : " + aaaa);

    return aaaa;
}
Console.Write("Wollen Sie a, b oder c berechnen? ");
string antwort = Console.ReadLine();
string antwort1 = antwort.ToLower();


if (antwort1 == "a")
{
    Console.Write("Welchen Wert hat c?");
    double c = Convert.ToDouble(Console.ReadLine());
    double wic = c;

    Console.Write("Welchen Wert hat b?");
    double b = Convert.ToDouble(Console.ReadLine());
    double wib = b;

    if (b > c)
    {
        Console.WriteLine("b darf nicht größer sein als c!");
    }
    else
        formela(wic, wib);




}

if (antwort1 == "b")
{
    Console.Write("Welchen Wert hat a?");
    double a = Convert.ToDouble(Console.ReadLine());
    double wia = a;

    Console.Write("Welchen Wert hat c?");
    double c = Convert.ToDouble(Console.ReadLine());
    double wic = c;
    if (c > a)
    {
        Console.WriteLine("c darf nicht größer sein als a!");
    }
    else
        formelb(wia, wic);
}

if (antwort1 == "c")
{
    Console.Write("Welchen Wert hat a?");
    double a = Convert.ToDouble(Console.ReadLine());
    double wia = a;

    Console.Write("Welchen Wert hat b?");
    double b = Convert.ToDouble(Console.ReadLine());
    double wib = b;

    if (b > a)
    {
        Console.WriteLine("b darf nicht größer sein als a!");
    }
    else
        formelc(wia,wib);
}


#endregion

#region Formel B
// Satz des Pythagoras für b

static double formelb(double a, double c)
{
    double b = Math.Pow(c, 2);
    double bb = Math.Pow(a, 2);
    double bbb = b - bb;
    double bbbb = Math.Sqrt(bbb);

    Console.WriteLine("Das Ergebnis für b ist " + bbbb);


    return bbbb;
}



#endregion

#region Formel C

// Satz des Pythagoras für c

static double formelc(double a, double b)
{
    double c = Math.Pow(a, 2);
    double cc = Math.Pow(b, 2);
    double ccc = b + cc;
    double cccc = Math.Sqrt(ccc);

    Console.WriteLine("Das Ergebnis für c ist : " + cccc);

    return cccc;
}



#endregion

