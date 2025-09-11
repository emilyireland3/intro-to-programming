﻿namespace Banking.Domain;
public struct TransactionAmount
{
    private decimal _amount;

    public TransactionAmount(decimal amount)
    {
        if (amount <= 0)
        {
            throw new InvalidTransactionAmountException();
        }
        else
        {
            _amount = amount;
        }
    }
    // this allows an "implict" conversion from TransactionAmount to a decimal.
    // so: decimal x = t; 
    public static implicit operator decimal(TransactionAmount tx)
    {
        return tx._amount;
    }

    public static implicit operator TransactionAmount(decimal val)
    {
        return new TransactionAmount(val);
    }
}
