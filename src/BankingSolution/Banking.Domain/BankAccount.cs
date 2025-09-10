

using System.Numerics;

namespace Banking.Domain;

// An Object owns some data and the transformations associated with that data.
// Sound like a service? ... yep
public class BankAccount
{
    private decimal balance = 5000M; // Fields (class-level variables, instance variables)
    public void Deposit(decimal amountToDeposit)
    {
        balance += amountToDeposit;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if (amountToWithdraw > balance)
        {
            throw new Exception("Insufficient funds- will overdraft");
        } else
        {
            balance -= amountToWithdraw;
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }
}