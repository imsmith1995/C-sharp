namespace Banking
{
    public class TestAccount
    {
        Account checking;
        Account savings;
        
        public TestAccount()
        {
            checking = new Account();
            savings = new Account();
        }
        [Fact]
        public void TestDepositAndWithdraw()
        {
            checking.Deposit(100);
            Assert.Equal(100, checking.Balance);
            checking.Withdraw(50);
            Assert.Equal(50, checking.Balance);
            checking.Deposit(200);
            Assert.Equal(250, checking.Balance);

            savings.Deposit(150);
            savings.Withdraw(100);
            Assert.Equal(50, savings.Balance);

            checking.Transfer(100, savings);
            Assert.Equal(150, checking.Balance);
            Assert.Equal(150, savings.Balance);

        }
    }
}