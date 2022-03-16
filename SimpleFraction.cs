using System;

class Program
{
    static void Main() 
    {
        Fraction f1 = new Fraction("2/3");
        Fraction f2 = new Fraction (1, 6);
        Fraction f3 = f1.Divide(f2);
        Console.WriteLine(f3);
    }
}

class Fraction
{
    private int numerator;
    private int denominator;
    
    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }
    
    public Fraction(string input)
    {
        this.numerator = int.Parse(input.Split("/")[0]);
        this.denominator = int.Parse(input.Split("/")[1]);
    }
    
    public Fraction Add(Fraction f)
    {
        int newNumerator = numerator * f.GetDenominator() + f.GetNumerator() * denominator;
        int newDenominator = denominator * f.GetDenominator();
        
        return new Fraction(newNumerator, newDenominator);
    }
    
    public Fraction Subtraction(Fraction f)
    {
        int newNumerator = numerator * f.GetDenominator() - f.GetNumerator() * denominator;
        int newDenominator = denominator * f.GetDenominator();
        
        return new Fraction(newNumerator, newDenominator);
    }
    
    public Fraction Multiplication(Fraction f)
    {
        int newNumerator = numerator * f.GetNumerator();
        int newDenominator = denominator * f.GetDenominator();
        
        return new Fraction(newNumerator, newDenominator);
    }
    
    public Fraction Divide(Fraction f)
    {
        int newNumerator = numerator * f.GetDenominator();
        int newDenominator = denominator * f.GetNumerator();
        
        return new Fraction(newNumerator, newDenominator);
    }
    
    public override string ToString()
    {
        return $"{numerator}/{denominator}";
    }
    
    // Getters
    public int GetNumerator()
    {
        return this.numerator;
    }
    
    public int GetDenominator()
    {
        return this.denominator;
    }
    
}
