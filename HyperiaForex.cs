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

    // TODO: implement comparison operators

    // TODO: implement arithmetic operators

    // TODO: implement type conversion operators
}
