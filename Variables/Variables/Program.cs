using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = ("Hello World");
            Console.WriteLine(helloWorld);
            Console.ReadKey();
            columbus();
        }
        public static void columbus()
        {
           int year = 1492;
        Console.WriteLine("Columbus Sailed the world in "+ year +".");
            Console.ReadKey();
            dogOwner();
        }
        public static void dogOwner()
        {
            Console.WriteLine("Do you have a dog at home?");
            Console.WriteLine("Type 'yes' or 'no'");
            string answer = Console.ReadLine();
            answer = answer.ToLower();
            if (answer == "yes")
            {
                Console.WriteLine("We thank you for keeping a stray dog off the streets.");

            }
            else if (answer == "no")
            {
                Console.WriteLine("We are dissapointed to hear that, please save a dogs life and adopt a new family member at the nearest dog shelter.");
            }
            else
            { Console.WriteLine("Please enter either yes or no");
                dogOwner();
            }
            Console.ReadKey();
            dateTime();
        }
        public static void dateTime()
        {
            DateTime localData = DateTime.Now;
            // DateTime stored as local variable--.Now grabs the date and time stored on computer
            // cultureFormats requires the namespace System.Globalization; which contains
            //culture-related information, including language, country/region, calendars in use, format patterns for dates, currency, and numbers, and sort order for strings

            ///String[] cultureFormats = { "en-US", "en-GB", "fr-FR",
            //"de-DE", "ru-RU" };
            ///select your culture format or include all to write the local time in all formats
            String[] cultureFormats = { "en-US"};

            // Stores different fromats of Date and time as strings
            foreach (var cultureFormat in cultureFormats)

            {
                var culture = new CultureInfo(cultureFormat);
                Console.WriteLine("The current time is {0}: {1}", cultureFormat,

                    localData.ToString(culture));
                Console.ReadKey();
            }
            wallet();
        }
        public static void wallet()
        {
            double money = 5.45;
            Console.WriteLine("I have $" + money + " in my wallet.");
            Console.ReadKey();
            x();
        }
        public static void x()
        {
            string x = "X";
            Console.WriteLine(x + " marks the spot");
            Console.ReadKey();
        }

    }
}
