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
            
        }

        private void GetUserNameAndLocation()
        {
            var person = new Person();
            Console.WriteLine("What it is your name? ");
            person.Name = Console.ReadLine();
            Console.WriteLine("HI " + person.Name + "!" + "Where are you from?");
            person.Location = Console.ReadLine();

            Console.WriteLine("I have never been to " + person.Location + ". I bet it is a nice place. Press any key to continue...");
        }
    }


}
