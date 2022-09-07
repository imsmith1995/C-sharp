using Banking;

Console.WriteLine("Banking!");

SavingComp savings2 = new();
savings2.AccountNo = 123;


Savings savings1 = new Savings();
savings1.Deposit(1000);
savings1.Withdraw(500);
savings1.InterestRate = 0.12m;
savings1.CalcInterest(1);
Print(savings1);


Account checking = new Account();
checking.AccountNo = 100;
checking.Description = "My Checking Account";
checking.Balance = 0;

Account savings = new()
{
    AccountNo = 200,
    Description = "My Savings Account",
    Balance = 0
};

checking.Deposit(500);
Print(checking);
savings.Deposit(20);
Print(savings);

checking.Withdraw(200);
Print(checking);
savings.Withdraw(45);
Print(savings);

checking.Transfer(250, savings);
Print(checking);
Print(savings);




void Print(Account account)
{
    Console.WriteLine($"{account.AccountNo} | {account.Description} | {account.Balance:C2}");
}
