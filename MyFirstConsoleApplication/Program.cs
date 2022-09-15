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


        }

        private static void GetUserNameAndLocation()
        {

            Console.WriteLine("What it is your name? ");
            var personName = Console.ReadLine();
            Console.WriteLine("Hi " + personName + "!" + " Where are you from?");
            var pLocation = Console.ReadLine();
            
            var person = new Person
            {
                Name = personName,
                Location = pLocation
        };


            Console.WriteLine("I have never been to " + person.Location + ". I bet it is a nice place. Press any key to continue...");
        }
    }


}
