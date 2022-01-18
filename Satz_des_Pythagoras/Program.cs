// See https://aka.ms/new-console-template for more information

#region Formel A
// Satz des Pythagoras für a 

static double formela(double c, double b)
{
    double a = Math.Pow(c,2);
    double aa = Math.Pow(b,2);
    double aaa = a - aa;
    double aaaa = Math.Sqrt(aaa);

    return aaaa;
}
Console.Write("Was ist c ?");
double wic = Convert.ToDouble(Console.ReadLine());

Console.Write("Was ist b ?");
double wib = Convert.ToDouble(Console.ReadLine());

Console.Write("Was ist a ?");
double wia = Convert.ToDouble(Console.ReadLine());



double forma = formela(wic,wib);
Console.WriteLine("Das Ergebnis für a ist : " + forma);
#endregion

#region Formel B
// Satz des Pythagoras für b

static double formelb(double a, double c)
{
    double b = Math.Pow(c, 2);
    double bb = Math.Pow(a, 2);
    double bbb = b - bb;
    double bbbb = Math.Sqrt(bbb);

    return bbbb;
}

double formb = formelb(wia, wic);
Console.WriteLine("Das Ergebnis für b ist " + formb);
#endregion

#region Formel C

// Satz des Pythagoras für c

static double formelc(double a, double b)
{
    double c = Math.Pow(a, 2);
    double cc = Math.Pow(b, 2);
    double ccc = b + cc;
    double cccc = Math.Sqrt(ccc);

    return cccc;
}

double formc = formelc(wia, wib);
Console.WriteLine("Das Ergebnis für c ist : " + formc);

#endregion

