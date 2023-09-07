using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSample
{
    public class View   //__VIEW__VIEW__VIEW__VIEW__VIEW__VIEW__VIEW__VIEW__VIEW__VIEW__VIEW__VIEW__VIEW__VIEW__VIEW__VIEW__VIEW__VIEW__VIEW__VIEW__VIEW
    {
        public void Display()
        {
            Console.WriteLine("Enter the first number:");  // get first number as double
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");
            // int operation = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine().ToLower();

            int result = 0;  // initialize result variable
            switch (operation)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    result = num1 / num2;
                    break;
            }
            
            Console.WriteLine("The result is {0}", result);
        } 
    }
}