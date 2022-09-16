using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main()
        {
            //Get the user name and location
            GetUserNameAndLocation();

            //Christmas countdown
            ChristmasCountDown();

            //Prompt for exit

            PromptForExit();
            
            
            


        }

        private static void GetUserNameAndLocation()
        {

            Console.WriteLine("What it is your name? ");
            string personName = Console.ReadLine();
            Console.WriteLine($"Hi {personName}! Where are you from?");
            string pLocation = Console.ReadLine();


            
            Console.WriteLine($"I have never been to {pLocation}. I bet it is a nice place. Press any key to continue.");
           
            Console.ReadKey();
            var person = new Person
            {
                Name = personName,
                Location = pLocation
            };
        }
        
        private static void ChristmasCountDown()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine($"Today's date is {today}");
            DateTime christmas = DateTime.Parse("12/25/2022");
            string daysToXmas = (christmas - today).Days.ToString();
            Console.WriteLine($"There are {daysToXmas} days until Christmas!");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        
        private static void PromptForExit()
        {
            Console.WriteLine("Press any key to exit...");
            

        }
    
    }


}
