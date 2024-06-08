namespace maths_Fun;
public static class Question2
{

    public static double Arithmetic(double a, double d, double n)
    {
        double Tn = a + d * (n - 1); return Tn;
    }
    public static double ArithmeticTotal(double a, double d, double n, double l)
    {
        if (l == 0)
        {
            double Sn = (n / 2) * ((2 * a) + d * (n - 1)); return Sn;
        }
        else { double Sn = (n * (a + l)) / 2; return Sn; }

    }
    public static double Geometric(double a, double r, double n)
    {
        double Tn = a * Math.Pow(r, (n - 1)); return Tn;
    }
    public static double GeometricTotal(double a, double r, double n)
    {
        if (r > 1)
        {
            double Sn = (a * (Math.Pow(r, n) - 1)); return Sn;
        }
        else
        {
            double Sn = (a * (1 - Math.Pow(r, n))); return Sn;
        }
    }
    public static double infinity(double a, double r)
    {
        double Sn = a / (1 - r); return Sn;
    }
    public static double SigmaNotation(double n, double k, double p)
    {
        double Sn = n - k + 1; return Sn;
    }
    public static double SigmaNotationPattern(double n, double k, double p)
    {
        double Sn = n - k + 1;
        double total = 0;
        for (int i = 0; i < Sn; i++)
        {
            total = total + p;
        }
        return total;
    }

}

public static class Quesion3
{
    public static double parabola(double a, double x, double p, double q)
    {
        double y = a * Math.Pow((x - p), 2) + q; return y;
    }
    public static double parabolaForm2(double a, double b, double c, double x)
    {
        double y = (a * Math.Pow(x, 2) + (b * x) + c); return y;
    }
    public static double ParabolaTurningPoint(double a, double b, double p, double q)
    {
        double y = (-b) / (2 * a); return y;
    }

    public static double Hyperbole(double a, double x, double p, double q)
    {
        double y = (a / (x - p)) + q; return y;
    }
    public static double HyperboleSymetry(double a, double x, double p, double q)
    {
        if (a > 0)
        {
            double y = x - p + q; return y;
        }
        else
        {
            double y = -x + p + q; return y;
        }
    }
    public static double Exponetial(double a, double x, double p, double b, double q)
    {
        double y = a * Math.Pow(b, (x - p) + q); return y;
    }



}

