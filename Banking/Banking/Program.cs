using Banking;

Console.WriteLine("Banking!");

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
