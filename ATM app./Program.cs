using System;

namespace ATMapp
{
    class Program
    {
        

      
        static void Main(string[] args)
        {
            //Int64 card = 1234 - 1234 - 1234 - 1234;

            int amount = 650, deposit, withdraw = 250;
            int choice,  pin = 1139, x = 0;
            int card = 1234;
            Console.WriteLine("Welcome to the ATM app");

            Console.WriteLine("Enter your card number: "); 
            card = int.Parse(Console.ReadLine());
            //card = Int64.Parse(Console.ReadLine());

            Console.WriteLine("Enter your pin number: ");
            pin = int.Parse(Console.ReadLine());        

            while(true)
            {
                Console.WriteLine("**********Welcome to the ATM SERVICE********\n");
                Console.WriteLine("Welcome Dragan Tashev!\n");
                Console.WriteLine("What do you like to do:\n ");
                Console.WriteLine("1.Chek the balance\n");
                Console.WriteLine("2.Cash Withdrawal\n");
                Console.WriteLine("3.Cash Deposit\n");
                Console.WriteLine("********************************************\n");
                Console.WriteLine("Enter your Choice:\n ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                   // case 1:
                        //Console.WriteLine("\n Your Balance in Rs:{0}", amount);
                        case 2:
                        Console.WriteLine("\n Enter the amount to Withdraw", amount);
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n Please enter the amount in multiples of 100");
                        }
                        else if(withdraw > (amount - 500))
                        {
                            Console.WriteLine("\n Insufficient Balance");
                        }
                        else 
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n \n Please collect cash");
                            Console.WriteLine("\n your current balance is Rs:{0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n Enter the amount to deposit");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("Your balance is {0}", amount);
                        break;
                        Console.WriteLine("\n\n Thank you for using our ATM SERVICE");

                }
            }
            
        }
    }
}
