using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AccountCreation
{
    /// <summary>
    /// Represents the account creditals that the user will enter in the program.
    /// </summary>
    public class AccountInformation
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Creates a new instance of the users account credentials.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        public AccountInformation(string username, string password, string email, string phoneNumber) 
        {
            Username = username;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Will prompt the user to create a user name for their account.
        /// </summary>
        public void CreateUserName()
        {
            Console.Write("Enter your username here: ");
            this.Username = Console.ReadLine();
        }

        /// <summary>
        /// Will prompt the user to create a password for their accont.
        /// </summary>
        public void CreatePassword()
        {
            Console.Write("Enter your password: ");
            this.Password = Console.ReadLine();
        }

        /// <summary>
        /// Will prompt the user to add a designated email to their account.
        /// </summary>
        public void CreateEmail()
        {
            Console.Write("Enter your email: ");
            this.Email = Console.ReadLine();
        }

        /// <summary>
        /// Will prompt the user to add a their mobile phone number to their account.
        /// </summary>
        public void CreatePhoneNumber()
        {
            Console.Write("Enter your phone number: ");
            this.PhoneNumber = Console.ReadLine();
        }

        /// <summary>
        /// Will ask the user to confirm their password as the final step in the account creation process.
        /// </summary>
        public void ConfirmPassword()
        {
            bool confirmPassword = true;
            string passwordMatched;

            while (confirmPassword)
            {
                Console.Write("Confirm your password: ");
                passwordMatched = Console.ReadLine();

                if (passwordMatched == this.Password)   // If the password matches what the user entered, it will break out of the while loop.
                {
                    confirmPassword = false;
                    break;
                }
                else     // If the password does not match, the program will loop until the user enters the correct password.
                {
                    Console.WriteLine("Incorrect password! Try again!");
                    continue;
                }
            }
        }

        /// <summary>
        /// Displays the users account information.
        /// </summary>
        public void DisplayAccount()
        {
            Console.WriteLine($"Username: {this.Username}");
            Console.WriteLine($"Password: {this.Password}");
            Console.WriteLine($"Email: {this.Email}");
            Console.WriteLine($"Phone Number: {this.PhoneNumber}");
        }

        /// <summary>
        /// The program will ask the user to verify their password first before editing their user name.
        /// Then the user will have the option to make a new username for their account.
        /// </summary>
        public void EditUsername()
        {
            string confirmPassword;
            string newUsername;
            bool passwordMatch = true;

            while (passwordMatch)
            {
                Console.Write("Please enter your password to continue: ");
                confirmPassword = Console.ReadLine();

                if (confirmPassword == this.Password)
                {
                    Console.Write("Please enter a new username: ");
                    newUsername = Console.ReadLine();

                    this.Username = newUsername;

                    Console.WriteLine("New username has been set.");
                    passwordMatch = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Password is incorrect, try again. ");
                    continue;
                }
            }
        }

        /// <summary>
        /// Prompts the user to enter the current password via the console and, if it matches the instance password,
        /// prompts for and sets a new password.
        /// </summary>
        public void EditPassword()
        {
            string confirmPassword;
            string newPassword;
            bool passwordMatch = true;

            while (passwordMatch)
            {
                Console.Write("Please enter your password to continue: ");
                confirmPassword = Console.ReadLine();

                if (confirmPassword == this.Password)
                {
                    Console.Write("Please enter a new password: ");
                    newPassword = Console.ReadLine();

                    this.Password = newPassword;

                    Console.WriteLine("New password has been set.");
                    passwordMatch = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Password is incorrect, try again. ");
                    continue;
                }
            }
        }

        /// <summary>
        /// Will ask the user again to verify their password.
        /// Then the user will have the option to edit their email.
        /// </summary>
        public void EditEmail()
        {
            string confirmPassword;
            string newEmail;
            bool passwordMatch = true;

            while (passwordMatch)
            {
                Console.Write("Please enter your password to continue: ");
                confirmPassword = Console.ReadLine();

                if (confirmPassword == this.Password)
                {
                    Console.Write("Please enter a new email: ");
                    newEmail = Console.ReadLine();

                    this.Email = newEmail;

                    Console.WriteLine("New username has been set.");
                    passwordMatch = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Password is incorrect, try again. ");
                    continue;
                }
            }
        }

        /// <summary>
        /// You get the point!
        /// After the user has verifed their password, they will be able to set a new phone number.
        /// </summary>
        public void EditPhoneNumber()
        {
            string confirmPassword;
            string newPhoneNumber;
            bool passwordMatch = true;

            while (passwordMatch)
            {
                Console.Write("Please enter your password to continue: ");
                confirmPassword = Console.ReadLine();

                if (confirmPassword == this.Password)
                {
                    Console.Write("Please enter a new phone number: ");
                    newPhoneNumber = Console.ReadLine();

                    this.PhoneNumber = newPhoneNumber;

                    Console.WriteLine("New username has been set.");
                    passwordMatch = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Password is incorrect, try again. ");
                    continue;
                }
            }
        }
    }
}
