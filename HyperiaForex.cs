using Microsoft.FSharp.Core;
using System;
using System.Security.Cryptography.X509Certificates;

public struct CurrencyAmount
{
    private decimal amount;
    private string currency;
    public static CurrencyAmount operator +(CurrencyAmount lhs,  CurrencyAmount rhs)
    {
        return new CurrencyAmount(lhs.amount + rhs.amount, lhs.currency == rhs.currency ? lhs.currency : throw new ArgumentException());
    }
    public static CurrencyAmount operator -(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        return new CurrencyAmount(lhs.amount - rhs.amount, lhs.currency == rhs.currency ? lhs.currency : throw new ArgumentException());
    }
    public static CurrencyAmount operator *(CurrencyAmount lhs, decimal rhs)
    {
        return new CurrencyAmount(lhs.amount * rhs, lhs.currency);
    }
    public static CurrencyAmount operator /(CurrencyAmount lhs, decimal rhs)
    {
        return new CurrencyAmount(lhs.amount / rhs, lhs.currency);
    }

    public static explicit operator double(CurrencyAmount convert)
    {
        return (double)convert.amount;
    }
    public static implicit operator decimal(CurrencyAmount convert)
    {
        return convert.amount;
    }

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
