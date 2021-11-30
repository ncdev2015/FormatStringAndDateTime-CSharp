using System;
using System.Globalization;

namespace format_string_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get a Default DateTime
            DateTime dateTime = new DateTime();
            Console.WriteLine("dateTime: " + dateTime); // ->  1/1/0001 12:00:00 a. m.
            Console.WriteLine("dateTime (dd/MM/yyyy): " + dateTime.ToString("dd/MM/yyyy")); // -> 01/01/0001

            Console.WriteLine();

            // Convert string input to DateTime
            string dateTimeStringInput = "2020-08-02T06:00:00.000Z";
            DateTime dateTimeInput = DateTime.Parse(dateTimeStringInput, new CultureInfo("es-AR"));

            Console.WriteLine("dateTimeInput (String): " + dateTimeStringInput); // -> dateTimeInput(String): 2020 - 08 - 02T06: 00:00.000Z
            Console.WriteLine("dateTimeInput (DateTime): " + dateTimeInput); // -> dateTimeInput (DateTime): 2/8/2020 3:00:00 a. m.

            Console.WriteLine();

            // Creates a string output from DateTime with mont and year in ()
            string output = dateTimeInput.ToString("dd/MM/yyyy") + " (" + dateTimeInput.ToString("MMMM").ToUpper().Substring(0, 3) + " " + dateTimeInput.ToString("yy") + ")";
            Console.WriteLine(output); // -> 02/08/2020 (AGO 20)

            // Convert es-AR string dateTime to us-US format
            string inputDtString = "20/11/2021";
            string[] arr = inputDtString.Split("/");
            DateTime dt = new DateTime(Convert.ToInt32(arr[2]), Convert.ToInt32(arr[1]), Convert.ToInt32(arr[0]));

            Console.WriteLine();
            Console.WriteLine(dt.ToString("yyyy-MM-dd"));

            // Verify hours
            DateTime dt_hours = new DateTime(2021, 11, 30, 1, 50, 50);
            Console.WriteLine(dt_hours.ToString("HH:mm:ss")); // -> 01:50:50
        }
    }
}
