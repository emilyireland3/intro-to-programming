

using Banking.Domain;
namespace Banking.tests.MakingWithdrawls;
public class WithdrawsDecreasesBalance
{
    [Theory]
    [InlineData(4900.000)]
    [InlineData(5000.00)]
    //InlineData(5100.00)]
    public void Withdrawing(decimal amountToWithdraw)
    {
        // Given
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }
}
