

using System.Numerics;

namespace Banking.Domain;

// An Object owns some data and the transformations associated with that data.
// Sound like a service? ... yep
public class BankAccount
{
    private decimal balance = 5000M; // Fields (class-level variables, instance variables)
    public void Deposit(decimal amountToDeposit)
    {
        if (amountToDeposit <= 0)
        {
            throw new InvalidTransactionAmountException();
        }
        balance += amountToDeposit;
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if (amountToWithdraw <= 0) // These are sometimes called "Guard" clauses.
        {
            throw new InvalidTransactionAmountException();
        }
        if (amountToWithdraw <= balance)
        {
            balance -= amountToWithdraw;
        } else
        {
            throw new AccountOverdraftException();
        }
    }
}
