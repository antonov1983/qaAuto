using System;
using Xunit;

namespace Bank.Xunit
{
    public class UnitTest1
    {
        [Fact]
        public void AcountInitializeWithPositiveValue()
        {
            BankAcount acount = new BankAcount(2000m);

            Assert.Equal(2000m, acount.Amount);
        }

        [Fact]
        public void AcountInitializeWithNegaiveValue()
        {
            BankAcount acount = new BankAcount(-1m);

            Assert.Throws<ArgumentException>(() => acount.Withdraw(300m));
        }

        [Fact]
        public void AcountWithdrawWithMoreMoney()
        {
            BankAcount acount = new BankAcount(200m);

            Assert.Throws<ArgumentException>(() => acount.Withdraw(300m));
        }

        [Fact]
        public void AcountDepositNegativevalue()
        {
            BankAcount acount = new BankAcount(200m);

            Assert.Throws<ArgumentException>(() => acount.Deposit(-300m));
        }
    }
}
