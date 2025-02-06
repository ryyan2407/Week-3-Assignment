using week2_assignment;

Console.WriteLine("Bank Account: \n");
var account = new BankAccount("Ryyan", 5000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

account.MakeWithdrawal(1050, DateTime.Now, "Rent payment");
//Console.WriteLine(account.Balance);
account.MakeDeposit(200, DateTime.Now, "Friend paid me back");
//Console.WriteLine(account.Balance);
Console.WriteLine(account.GetAccountHistory());

// Test that the initial balances must be positive.
//BankAccount invalidAccount;
//try
//{
//    invalidAccount = new BankAccount("invalid", -55);
//}
//catch (ArgumentOutOfRangeException e)
//{
//    Console.WriteLine("Exception caught creating account with negative balance");
//    Console.WriteLine(e.ToString());
//    return;
//}

//// Test for a negative balance.
//try
//{
//    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
//}
//catch (InvalidOperationException e)
//{
//    Console.WriteLine("Exception caught trying to overdraw");
//    Console.WriteLine(e.ToString());
//}


Console.WriteLine("Gift Card Account: \n");
var giftCard = new GiftCardAccount("Gift Card", 300, 50);
giftCard.MakeWithdrawal(7.50m, DateTime.Now, "bought coffee");
giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
giftCard.PerformMonthEndTransactions();
// can make additional deposits:
giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
Console.WriteLine(giftCard.GetAccountHistory());

Console.WriteLine("Interest Earning Account: \n");
var savings = new InterestEarningAccount("savings account", 10000);
savings.MakeDeposit(900, DateTime.Now, "save some money");
savings.MakeDeposit(2000, DateTime.Now, "Add more savings");
savings.MakeWithdrawal(450, DateTime.Now, "Paid monthly bills");
savings.PerformMonthEndTransactions();
Console.WriteLine(savings.GetAccountHistory());

Console.WriteLine("Line of Credit Account: \n");
var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
// How much is too much to borrow?
lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
lineOfCredit.PerformMonthEndTransactions();
Console.WriteLine(lineOfCredit.GetAccountHistory());