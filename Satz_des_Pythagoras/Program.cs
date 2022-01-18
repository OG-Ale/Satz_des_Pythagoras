// See https://aka.ms/new-console-template for more information

#region Formel A
// Satz des Pythagoras für a 

static double formela(int c, int b)
{
    double a = Math.Pow(c,2);
    double aa = Math.Pow(b,2);
    double aaa = a - aa;
    double aaaa = Math.Sqrt(aaa);

    return aaaa;
}

double forma = formela(2,1);
Console.WriteLine(forma);
#endregion

#region Formel B
// Satz des Pythagoras für b

static double formelb(int a, int c)
{
    double b = Math.Pow(c, 2);
    double bb = Math.Pow(a, 2);
    double bbb = b - bb;
    double bbbb = Math.Sqrt(bbb);

    return bbbb;
}

double formb = formelb(2, 4);
Console.WriteLine(formb);
#endregion

#region Formel C

// Satz des Pythagoras für c

static double formelc(int a, int b)
{
    double c = Math.Pow(a, 2);
    double cc = Math.Pow(b, 2);
    double ccc = b + cc;
    double cccc = Math.Sqrt(ccc);

    return cccc;
}

double formc = formelc(4, 8);
Console.WriteLine(formc);

#endregion

