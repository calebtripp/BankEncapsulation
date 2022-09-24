using BankEncapsulation;
using System.Transactions;

BankAccount user1 = new BankAccount();
//var choice = Console.ReadLine();
//var deposit = user1.Deposit;
//var withdrawal = user1.Withdrawal;
//var balance = user1.GetBalance;
int newBalance;
Console.WriteLine("Please review the following options then enter your selection below\n");
Console.WriteLine("Type the word 'deposit' then press enter to make a deposit.\n");
Console.WriteLine("Type the word 'withdrawal' then press enter to make a withdrawal.\n");
Console.WriteLine("Type the word 'balance' then press enter to view your current balance.\n");
//Console.ReadLine();
//while (Console.ReadLine() != "deposit" || Console.ReadLine() != "withdrawal" || Console.ReadLine() != "balance")
//{
//   // Console.WriteLine("We couldn't understand your selection, please try again");
//}
while (Console.ReadLine() == "deposit")
{
    Console.WriteLine("Great, you're making a deposit. Please enter the amount you would like to deposit then press enter");
    //Console.WriteLine();
    bool couldParse = double.TryParse(Console.ReadLine(), out double dollarsCents);

    while (!couldParse)
    {
        Console.WriteLine("Your input wasn't a number, please try again.");

        Console.WriteLine("What amount would you like to Deposit?");

        couldParse = double.TryParse(Console.ReadLine(), out dollarsCents);
    }
    user1.Deposit(dollarsCents);
    Console.WriteLine($"Your deposit was successful. Your current balance is now:");
    Console.WriteLine(user1.GetBalance());
    
    break;
}

//Console.WriteLine("Great, you're making a deposit. Please enter the amount you would like to deposit then press enter");


//Console.WriteLine("Great, you're making a withdrawal. Please enter the amount you would like to withdraw then press enter.");
//toLower






// if one of the strings, then do that method. otherwise, 

//Console.WriteLine("How much money would you like to deposit today?");

////

////



//Console.WriteLine("How much money would you like to Withdraw today?");
//Console.ReadLine();

//user1.Withdrawal(56);

//Console.WriteLine("Your Balance is currently:");

//Console.WriteLine(user1.GetBalance);
    








//        //BankAccount.Deposit(Convert.ToDouble(Console.ReadLine()));

//        //Console.WriteLine(); BankAccount.balance + (Console.ReadLine());
   
        



