using ClassLibrary03;

Console.WriteLine("Enter current exchange rate.");
uint BasicCurrency = EnterBasicCurrency();
string NameOfBasicCurrency = " ";

switch (BasicCurrency)
{
    case 1:
        NameOfBasicCurrency = "RUB";
        Currency.RUB = 1;
        Console.Write("USD (in rub) = ");
        Currency.USD = Convert.ToDouble(Console.ReadLine());
        Console.Write("EUR (in rub) = ");
        Currency.EUR = Convert.ToDouble(Console.ReadLine());
        break;

    case 2:
        NameOfBasicCurrency = "USD";
        Currency.USD = 1;
        Console.Write("EUR (in usd) = ");
        Currency.EUR = Convert.ToDouble(Console.ReadLine());
        Console.Write("RUB (in usd) = ");
        Currency.RUB = Convert.ToDouble(Console.ReadLine());
        break;

    case 3:
        NameOfBasicCurrency = "EUR";
        Currency.EUR = 1;
        Console.Write("USD (in eur) = ");
        Currency.USD = Convert.ToDouble(Console.ReadLine());
        Console.Write("RUB (in eur) = ");
        Currency.RUB = Convert.ToDouble(Console.ReadLine());
        break;

    default:
        break;
}

Console.WriteLine($"Enter value in {NameOfBasicCurrency}");
double value = Convert.ToDouble(Console.ReadLine());

CurrencyRUB rub;
CurrencyEUR eur;
CurrencyUSD usd;

switch (BasicCurrency)
{
    case 1:
        rub = new(value);
        eur = rub;
        usd = rub;

        Console.WriteLine($"Value in {NameOfBasicCurrency}: {rub}");
        Console.WriteLine($"USD: {usd}");
        Console.WriteLine($"EUR: {eur}");
        break;

    case 2:
        usd = new(value);
        eur = usd;
        rub = usd;

        Console.WriteLine($"Value in {NameOfBasicCurrency}: {usd}");
        Console.WriteLine($"RUB: {rub}");
        Console.WriteLine($"EUR: {eur}");
        break;

    case 3:
        eur = new(value);
        rub = eur;
        usd = eur;

        Console.WriteLine($"Value in {NameOfBasicCurrency}: {eur}");
        Console.WriteLine($"RUB: {rub}");
        Console.WriteLine($"USD: {usd}");
        break;

    default:
        break;
}


uint EnterBasicCurrency()
{
    Console.WriteLine("What currency do you like to make base?");
    Console.WriteLine("1) RUB");
    Console.WriteLine("2) USD");
    Console.WriteLine("3) EUR");

    uint BasicCurrency = Convert.ToUInt32(Console.ReadLine());
    if (BasicCurrency == 0 || BasicCurrency > 3)
    {
        Console.WriteLine("Incorrect input! Try again.");
        return EnterBasicCurrency();
    }
    return BasicCurrency;
    
}