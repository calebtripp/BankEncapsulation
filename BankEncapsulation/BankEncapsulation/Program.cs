using BankEncapsulation;
using System.Transactions;

BankAccount user1 = new BankAccount();

Console.WriteLine("Please review the following options then enter your selection below\n");
Console.WriteLine("Type the word 'deposit' then press enter to make a deposit.\n");
Console.WriteLine("Type the word 'withdrawal' then press enter to make a withdrawal.\n");
Console.WriteLine("Type the word 'balance' then press enter to view your current balance.\n");

var response = Console.ReadLine();

while (response != "deposit" && response != "withdrawal" && response != "balance")
{
    Console.WriteLine();
    Console.WriteLine("Please review the following options then enter your selection below\n");
    Console.WriteLine("Type the word 'deposit' then press enter to make a deposit.\n");
    Console.WriteLine("Type the word 'withdrawal' then press enter to make a withdrawal.\n");
    Console.WriteLine("Type the word 'balance' then press enter to view your current balance.\n");

    var response2 = Console.ReadLine();

    while (response2 == "deposit")
    {
        Console.WriteLine("Great, you're making a deposit. Please enter the amount you would like to deposit then press enter");
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

    while (response2 == "balance")
    {
        Console.WriteLine("Your Balance is currently:");
        Console.WriteLine(user1.GetBalance());
        break;
    }

    while (response2 == "withdrawal")
    {
        Console.WriteLine("Great, you're making a withdrawal. Please enter the amount you would like to withdraw then press enter");
        bool couldParse = double.TryParse(Console.ReadLine(), out double dollarsCents);

        while (!couldParse)
        {
            Console.WriteLine("Your input wasn't a number, please try again.");
            Console.WriteLine("What amount would you like to withdraw?");
            couldParse = double.TryParse(Console.ReadLine(), out dollarsCents);
        }
        user1.Withdrawal(dollarsCents);
        Console.WriteLine($"Your withdrawal was successful. Your current balance is now:");
        Console.WriteLine(user1.GetBalance());
        break;
    }
}


while (response == "deposit")
{
    Console.WriteLine("Great, you're making a deposit. Please enter the amount you would like to deposit then press enter");
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

while (response == "balance")
{
    Console.WriteLine("Your Balance is currently:");
    Console.WriteLine(user1.GetBalance());
    break;
}

while (response == "withdrawal")
{
    Console.WriteLine("Great, you're making a withdrawal. Please enter the amount you would like to withdraw then press enter");
    bool couldParse = double.TryParse(Console.ReadLine(), out double dollarsCents);

    while (!couldParse)
    {
        Console.WriteLine("Your input wasn't a number, please try again.");
        Console.WriteLine("What amount would you like to withdraw?");
        couldParse = double.TryParse(Console.ReadLine(), out dollarsCents);
    }
    user1.Withdrawal(dollarsCents);
    Console.WriteLine($"Your withdrawal was successful. Your current balance is now:");
    Console.WriteLine(user1.GetBalance());
    break;
}

//I feel like there's a shorter way to have all the same redundancies for user input error?
