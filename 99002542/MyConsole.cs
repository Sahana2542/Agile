using System;
namespace TrialConApp
{
    class MyConsole
    {
        internal static double getDouble(string question)
        {
            Console.WriteLine(question);
            return double.Parse(Console.ReadLine());
        }

        internal static string getString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        internal static int getNumber(string question)
        {
            return int.Parse(getString(question));
        }

        internal static DateTime getDate(string question)
        {
            return DateTime.Parse(getString(question));
        }

        internal static DateTime getDate()
        {
            Console.WriteLine("Enter the date as dd/MM/yyyy");
            string value = Console.ReadLine();
            return DateTime.ParseExact(value, "dd/MM/yyyy", null);
        }
    }
}