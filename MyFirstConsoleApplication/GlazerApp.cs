using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    static class GlazerApp
    {
        public static void RunExample()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            //Get the width
            Console.WriteLine($"What is the width?:");
            widthString = Console.ReadLine();
            //Convert to a double
            width = double.Parse(widthString);

            //Get the height
            Console.WriteLine($"What is the height?:");
            heightString = Console.ReadLine();
            //Convert to a double
            height = double.Parse(heightString);
            
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            
            Console.WriteLine($"The length of the wood is {woodLength} feet");
            Console.WriteLine($"The area of the glass is {glassArea} square metres");
            Console.WriteLine($"Press any key to continue...");
            Console.ReadKey();

        }
    }




}
