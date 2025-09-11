

using Banking.Domain;
namespace Banking.tests.MakingWithdrawls;

[Trait("Category", "Unit")]
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

    [Fact]
    public void MayWithdrawFullBalance()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        account.Withdraw(openingBalance);

        Assert.Equal(0, account.GetBalance());
    }

    // dont need anymore 
    //[Theory]
    //[InlineData(-1)]
    //[InlineData(0)]
    //public void InvalidAmountCannotBeWithdrawn(decimal amountToWithdraw)
    //{
    //    var account = new BankAccount();
    //    var openingBalance = account.GetBalance();

    //    Assert.Throws<InvalidTransactionAmountException>(() => account.Deposit(amountToWithdraw));

    //    Assert.Equal(openingBalance, account.GetBalance());

    //}
}
