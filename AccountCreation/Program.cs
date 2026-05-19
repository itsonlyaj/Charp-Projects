namespace AccountCreation;

class Program
{
    static void Main(string[] args)
    {
            bool editAccount = true;
    string option;
    AccountInformation accountInfo = new AccountInformation("", "", "", "");    // Creates a new object for the account information.

    accountInfo.CreateUserName();
    accountInfo.CreatePassword();
    accountInfo.CreateEmail();
    accountInfo.CreatePhoneNumber();
    accountInfo.ConfirmPassword();

    Console.WriteLine("-----------------------------");
    accountInfo.DisplayAccount();
    Console.WriteLine("-----------------------------");

    /*
     *  This loop will ask the user if they would like to display, edit their username, password, email, phone number, and exit the program
     *  By entering the numbers 1 to 6.
     *  If the user enters a number greater than 6, or a random string, it will throw an error.
     */
    while (editAccount)
    {
        Console.WriteLine("What would you like to do for your account?");
        Console.WriteLine("1. Display your account.\n2. Edit your username.\n3. Edit your password\n4. Edit your email." +
                         "\n5. Edit your phone number.\n6. Exit program.");

        option = Console.ReadLine();

        switch (option)
        {
            case "1":
                Console.WriteLine("-----------------------------");
                accountInfo.DisplayAccount();
                Console.WriteLine("-----------------------------");
                break;
            case "2":
                accountInfo.EditUsername();
                break;
            case "3":
                accountInfo.EditPassword();
                break;
            case "4":
                accountInfo.EditEmail();
                break;
            case "5":
                accountInfo.EditPhoneNumber();
                break;
            case "6":
                editAccount = false;
                break;
            default:
                Console.WriteLine("Invalid option!");
                break;
            }     
        }
    }
}
