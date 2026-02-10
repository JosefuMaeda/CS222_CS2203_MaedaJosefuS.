using System;

class CurrencyConverter
{
    static void Main()
    {
        Console.Write("Enter amount in USD: ");
        double usdAmount = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter exchange rate from USD to EUR: ");
        double exchangeRate = Convert.ToDouble(Console.ReadLine());
        
        double eurAmount = usdAmount * exchangeRate;
        
        Console.WriteLine($"Amount in EUR: {eurAmount:F2}");
    }
}