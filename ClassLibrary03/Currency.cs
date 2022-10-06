using System.Runtime.CompilerServices;

namespace ClassLibrary03
{
    public abstract class Currency
    {
        public static double USD { get; set; }
        public static double EUR { get; set; }
        public static double RUB { get; set; }
        public double Value { get; protected set; }

        protected Currency() { Value = 0; }
        protected Currency(double value) => Value = value;

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    public class CurrencyUSD: Currency
    {
        private CurrencyUSD(): base() { }
        public CurrencyUSD(double value): base(value) { }

        public static implicit operator CurrencyUSD(CurrencyRUB rub)
        {
            CurrencyUSD NewValue = new();
            NewValue.Value = rub.Value * RUB / USD;
            return NewValue;
        }

        public static implicit operator CurrencyUSD(CurrencyEUR eur)
        {
            CurrencyUSD NewValue = new();
            NewValue.Value = eur.Value * EUR / USD;
            return NewValue;
        }

    }

    public class CurrencyEUR : Currency
    {
        private CurrencyEUR() : base() { }
        public CurrencyEUR(double value) : base(value) { }

        public static implicit operator CurrencyEUR(CurrencyRUB rub)
        {
            CurrencyEUR NewValue = new();
            NewValue.Value = rub.Value * RUB / EUR;
            return NewValue;
        }

        public static implicit operator CurrencyEUR(CurrencyUSD usd)
        {
            CurrencyEUR NewValue = new();
            NewValue.Value = usd.Value * USD / EUR;
            return NewValue;
        }

    }

    public class CurrencyRUB : Currency
    {
        private CurrencyRUB() : base() { }
        public CurrencyRUB(double value) : base(value) { }

        public static implicit operator CurrencyRUB(CurrencyEUR eur)
        {
            CurrencyRUB NewValue = new();
            NewValue.Value = eur.Value * EUR / RUB;
            return NewValue;
        }

        public static implicit operator CurrencyRUB(CurrencyUSD usd)
        {
            CurrencyRUB NewValue = new();
            NewValue.Value = usd.Value * USD / RUB;
            return NewValue;
        }
    }
}
