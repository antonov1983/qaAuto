namespace Bank.Nunit
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void AcountInitialize_WithPositiveValue_ShouldPass()
        {
            BankAcount acount = new BankAcount(2000m);

            Assert.AreEqual(2000m, acount.Amount);
        }

        [Test]
        public void AcountInitialize_WithNegaiveValue_ShouldThrowExeption()
        {
            

            Assert.Throws<ArgumentException>(() => { BankAcount acount = new BankAcount(-30m); });
        }

        [Test]
        public void AcountWithdraw_WithMoreMoney_ShouldThrowException()
        {
            BankAcount acount = new BankAcount(200m);

            Assert.Throws<ArgumentException>(() => acount.Withdraw(300m));
        }

        [Test]
        public void AcountDeposit_WithNegativevalue_ShouldThrowException()
        {
            BankAcount acount = new BankAcount(200m);

            Assert.Throws<ArgumentException>(() => acount.Deposit(-300m));
        }
        [Test]
        public void AcountWithdraw_WithNegativeAmount_ShouldThrowException()
        {
            BankAcount acount = new BankAcount(200m);
            
            Assert.Throws<ArgumentException>(() => acount.Withdraw(-30m));
        }
        [Test]
        public void Check_Withdraw_WithValidValuesOver1000_ShouldLeave_RightAmount()
        {
            BankAcount acount = new BankAcount(2000m);
            acount.Withdraw(1200m);
            Assert.AreEqual(776m, acount.Amount);
        }
        [Test]
        public void Check_Withdraw_WithValidValuesUnder1000_ShouldLeave_RightAmount()
        {
            BankAcount acount = new BankAcount(2000m);
            acount.Withdraw(800m);
            Assert.AreEqual(1160m, acount.Amount);
        }
    }
}
