
using Banking.Domain;
namespace Banking.tests.MakingDeposits;
public class DepositsIncreaseBalance
{
    [Fact]
    public void MakingADeposit()
    {

        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100.10M;
 
        account.Deposit(amountToDeposit);

        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
    }
}
