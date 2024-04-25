using System;

public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    public static bool operator ==(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        return lhs.amount == rhs.amount && lhs.currency == rhs.currency;
    }
    public static bool operator !=(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        return !(lhs == rhs);
    }

    public static bool operator <(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        return lhs.amount < rhs.amount && lhs.currency == rhs.currency ? true : throw new ArgumentException();
    }
    public static bool operator >(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        return lhs.amount > rhs.amount && lhs.currency == rhs.currency ? true : throw new ArgumentException();
    }

    // TODO: implement arithmetic operators

    // TODO: implement type conversion operators
}
