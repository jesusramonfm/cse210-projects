using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fractionA = new Fraction();
        Fraction fractionB = new Fraction(5);
        Fraction fractionC = new Fraction(3, 4);

        string a = fractionA.GetFractionString();
        string b = fractionB.GetFractionString();
        string c = fractionC.GetFractionString();

        Console.WriteLine(a);
        double aa = fractionA.GetDecimalValue();
        Console.WriteLine(aa);
        Console.WriteLine(b);
        double bb = fractionB.GetDecimalValue();
        Console.WriteLine(bb);
        Console.WriteLine(c);
        double cc =  fractionC.GetDecimalValue();
        Console.WriteLine(cc);

        fractionA.SetTop(1);
        fractionA.SetBottom(3);
        a = fractionA.GetFractionString();
        aa = fractionA.GetDecimalValue();
        Console.WriteLine(a);
        Console.WriteLine(aa.ToString());


           
    }
}