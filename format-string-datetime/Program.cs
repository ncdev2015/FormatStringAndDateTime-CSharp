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
            Console.WriteLine("dateTime: " + dateTime);
            Console.WriteLine("dateTime (dd/MM/yyyy):" + dateTime.ToString("dd/MM/yyyy"));

            Console.WriteLine();

            string dateTimeStringInput = "2020-08-02T06:00:00.000Z";
            DateTime dateTimeInput = DateTime.Parse(dateTimeStringInput, new CultureInfo("es-AR"));

            Console.WriteLine("dateTimeInput (String): " + dateTimeStringInput);
            Console.WriteLine("dateTimeInput (DateTime): " + dateTimeInput);

            Console.WriteLine();

            string output = dateTimeInput.ToString("dd/MM/yyyy") + " (" + dateTimeInput.ToString("MMMM").ToUpper().Substring(0, 3) + " " + dateTimeInput.ToString("yy") + ")";
            Console.WriteLine(output);
        }
    }
}
