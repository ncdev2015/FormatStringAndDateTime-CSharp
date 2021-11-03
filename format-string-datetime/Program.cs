using System;
using System.Globalization;

namespace format_string_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get a Default DateTime value
            DateTime dateTime = new DateTime();
            Console.WriteLine("dateTime: " + dateTime); // ->  1/1/0001 12:00:00 a. m.
            Console.WriteLine("dateTime (dd/MM/yyyy): " + dateTime.ToString("dd/MM/yyyy")); // -> 01/01/0001

            Console.WriteLine();

            // Convert a string input to DateTime value
            string dateTimeStringInput = "2020-08-02T06:00:00.000Z";
            DateTime dateTimeInput = DateTime.Parse(dateTimeStringInput, new CultureInfo("es-AR"));

            Console.WriteLine("dateTimeInput (String): " + dateTimeStringInput); // -> dateTimeInput(String): 2020 - 08 - 02T06: 00:00.000Z
            Console.WriteLine("dateTimeInput (DateTime): " + dateTimeInput); // -> dateTimeInput (DateTime): 2/8/2020 3:00:00 a. m.

            Console.WriteLine();

            // Creates a string output by DateTime values
            string output = dateTimeInput.ToString("dd/MM/yyyy") + " (" + dateTimeInput.ToString("MMMM").ToUpper().Substring(0, 3) + " " + dateTimeInput.ToString("yy") + ")";
            Console.WriteLine(output); // -> 02/08/2020 (AGO 20)
        }
    }
}
