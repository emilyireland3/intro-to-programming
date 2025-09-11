

using Banking.Domain;

namespace Banking.tests.MakingWithdrawls;
public class OverdraftNotAllowed
{
    [Fact]
    public void OverdraftDoesNotDecreaseYourBalance()
    {
        // Given I have am account with x balance
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        // When I withdraw X+1 from the account
        try
        {
            account.Withdraw(openingBalance + 0.01M);
        }
        catch (Exception)
        {

            // no need to throw, don't care what happened, or nothing happened
            // we just want to make sure that overdraft doesn't decrease the balance.
        }

        // Then the account still has a balance of X
        Assert.Equal(openingBalance, account.GetBalance());
    }

    [Fact]
    public void AnOverdraftExceptionIsProvided()
    {
        // Given I have am account with x balance
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        // When I withdraw X+1 from the account
        Assert.Throws<AccountOverdraftException>(() => account.Withdraw(openingBalance + 0.01M));


    }
}
