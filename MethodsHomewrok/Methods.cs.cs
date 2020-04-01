using System;

namespace MethodsHomework
{
    class Program
    {
        static void Main(string[] args)
        {

            #region TASK 1
            string text = "Hello from SEDC Codecademy v7.0";
            Console.WriteLine(text);
            Console.WriteLine(text.Length);

            Console.WriteLine(text.StartsWith("h".ToUpper()));
            Console.Read();
            #endregion

            #region TASK 2
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime);

            DateTime addDays = currentDateTime.AddDays(3);
            Console.WriteLine(addDays);

            DateTime addMonth = currentDateTime.AddMonths(1);
            Console.WriteLine(addMonth);

            DateTime today = DateTime.Now;
            Console.WriteLine("Today is: " + today);
            Console.WriteLine("If you add 1 month and 3 days the date will be: " + today.AddDays(3).AddMonths(1));
            

            DateTime today2 = DateTime.Now;
            Console.WriteLine("Today date is: " + today2);
            Console.WriteLine("If we add 1 year and 2 months from now the date will be: " + today2.AddYears(1).AddMonths(2));

            string currnetMonth = DateTime.Now.ToString("MM");
            Console.WriteLine(currnetMonth);

            string currentYear = DateTime.Now.ToString("yyyy");
            Console.WriteLine(currentYear);

            #endregion

            #region TASK 3
            DateTime myBirthday = Convert.ToDateTime("07/12/1994");
            DateTime todayDate = DateTime.Today;
            int age = today.Year - myBirthday.Year;

            if (myBirthday > today.AddYears(-age))
                age--;

            Console.WriteLine("I am: " + age);           
            Console.ReadLine();


            #endregion

        }
        static void Substrings()
        { 
            

            //Console.WriteLine("Type any number");
            //string input = Console.ReadLine();
            //int x;
            //if (int.TryParse(input, out x))
            //{
            //    //do your stuff here
            //}
            //else
            //{
            //    Console.WriteLine("You didn't enter number");
            //}

           

        }
        
    }
}
