using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Functions are blocks of code that are to be represented in a single line. These blocks of code are reusable and can be invoked multiple no of times. 
Typically it has a return type, name, args to the function...
These args are inputs to the function...
*/
namespace SampleConApp.Day2
{
    class Functions
    {
        const string menu = "Enter the Operation:\nTo Add: Press +\nTo Subtract: Press -\nTo Multiply: Press X\nTo Divide: Press /\nPS: Any other key is considered as EXIT";

        static void addOperation()
        {
            double v1 = getDouble("Enter the first value");

            double v2 = getDouble("Enter the second value");

            double result = addFunc(v1, v2);

            Console.WriteLine($"The Added value is {result}");

        }

        static void subOperation()
        {
            double v1 = getDouble("Enter the first value");

            double v2 = getDouble("Enter the second value");

            double result = subFunc(v1, v2);

            Console.WriteLine($"The Subtracted value is {result}");

        }

        static void mulOperation()
        {
            double v1 = getDouble("Enter the first value");

            double v2 = getDouble("Enter the second value");

            double result = mulFunc(v1, v2);

            Console.WriteLine($"The Product value is {result}");

        }

        static void divOperation()
        {
            double v1 = getDouble("Enter the first value");

            double v2 = getDouble("Enter the second value");

            double result = divFunc(v1, v2);

            Console.WriteLine($"The Divided value is {result}");

        }
        //Function only adds if 2 inputs are given...
        static double addFunc(double v1, double v2)
        {
            return v1 + v2;
        }

        static double subFunc(double v1, double v2)
        {
            return v1 - v2;
        }
        static double mulFunc(double v1, double v2)
        {
            return v1 * v2;
        }
        static double divFunc(double v1, double v2)
        {
            return v1 / v2;
        }

        static bool processMenu(string choice)
        {
            switch (choice)
            {
                case "+":
                    addOperation();
                    break;

                case "-":
                    subOperation();
                    break;

                case "X":
                   mulOperation();
                    break;

                case "/":
                    divOperation();
                    break;
                default:
                    return false;
            }
            return true;
        }
        static double getDouble(string question)
        {
            Console.WriteLine(question);
            return double.Parse(Console.ReadLine());
        }

        static string getString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            bool processing = true;
            do
            {
                string choice = getString(menu);
                processing = processMenu(choice);
            } while (processing);
        }
    }
}
