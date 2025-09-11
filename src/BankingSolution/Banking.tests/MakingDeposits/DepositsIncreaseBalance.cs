
using Banking.Domain;
namespace Banking.tests.MakingDeposits;
public class DepositsIncreaseBalance
{
    [Theory]
    [InlineData(-200)]
    public void MakingADeposit(decimal amountToDeposit)
    {

        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        //var amountToDeposit = 100.10M;
 
        account.Deposit(amountToDeposit);

        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    public void InvalidAmountCannotBeDeposited(decimal amountToDeposit)
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        Assert.Throws<InvalidTransactionAmountException>(() =>account.Deposit(amountToDeposit));
        
        Assert.Equal(openingBalance, account.GetBalance());

    }
}
