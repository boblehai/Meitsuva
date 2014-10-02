using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Menu
{
    class Program
    {
        //Her har vi et program som er påbegynt. Lag de andre metodene. Formler hjelper google deg med.
        //Menyalternativene må behandles. Her får du mange if-er. Det er helt ok. If er gratis.
        //Får du til at dette programmet kan stå å gå helt til at brukeren taster feks q, for quit?
        //Man kan runde av et tall om ønskelig.
        //Andre ting vi kan bygge videre på i denne menyen? km/t til knop? til miles?
        //etter at vi er ferdig med denne, så skal jeg vise deg hvordan vi lager en hjemmelagd klasse med funksjoner. Samt kaller på dem!
        //du ser kanskje at jeg har satt "private" foran metoden der nede? Hva betyr det? Vi har private og public methods.
        //google private vs public methods! Det får vi bruk for om litt :)

        //lykke til! Og for all del, spør om det trengs!
        static void Main(string[] args)
        {
            Program prog = new Program();
            string choice;
            int temp;

            Console.WriteLine("Velommen til superprogrammet. Her kan du konvertere stuff!");
            while (true)
            {
                Console.WriteLine("Tast 1 for: kg til pund");//for mange desimaler? sjekk ut Class Math! Her finnes avrundingsfunksjoner.
                Console.WriteLine("Tast 2 for: Celcius til fahrenheit");
                Console.WriteLine("Tast 3 for: Meter til fot");
                Console.WriteLine("Tast 4 for: Sjekk om string er et tall");
                Console.WriteLine("Tast Q for: Avslutte program");
                //mer ?
                choice = Console.ReadLine();//users choice
                if (choice == "1")
                {
                    double kg;
                    Console.WriteLine("Tast in antall kg");
                    kg = double.Parse(Console.ReadLine());
                    double pounds = prog.ConvertKgToPounds(kg);
                    Console.Clear();
                    Console.WriteLine(kg + " kg" + " = " + pounds + " pounds");
                    Console.WriteLine();
                }
                if (choice == "2")
                {
                    double c;
                    Console.WriteLine("Tast in antall celcius");
                    c = double.Parse(Console.ReadLine());
                    double f = prog.CelsiusToFahrenheit(c);
                    Console.Clear();
                    Console.WriteLine(c + " °C" + " = " + f + " °F");
                    Console.WriteLine();
                }
                if (choice == "3")
                {
                    double meter;
                    Console.WriteLine("Tast in antall meter");
                    meter = double.Parse(Console.ReadLine());
                    double feet = prog.CelsiusToFahrenheit(meter);
                    Console.Clear();
                    Console.WriteLine(meter + " meter" + " = " + feet + " fot");
                    Console.WriteLine();
                }
                if (choice == "4")
                {
                    Helpers helper=new Helpers();
                    Console.WriteLine("Tast inn en string");
                    bool isNumeric = helper.IsStringNumeric(Console.ReadLine());//her er det en bug jeg har lagt ut. Løser du den?
                    Console.WriteLine(isNumeric);
                }
                if (choice == "q" || choice == "Q")
                {
                    break;
                }
            }       
        }

        private double ConvertKgToPounds(double kg)//this time we are using decimals. Mind the datatype. it is "double". 1 kilogram = 2.20462262 pounds
        {
            return kg * 2.20462262;
        }
        private double CelsiusToFahrenheit(double c)
        {
            return c * 9/5 + 32;
        }
        private double MeterToFeet(double meter)
        {
            return meter * 3.2808399;
        }
        /// <summary>
        /// Ber om et helltall og vill loope hvis det får et tall med decimal
        /// </summary>
        /// <param name="text">Hva den skal spørre om</param>
        /// <returns>Returnerer tallet</returns>
        int NumberInputWithoutDecimal(string text)
        {
            bool numberCheck;
            int number;
            while (true)
            {
                Console.WriteLine(text);
                numberCheck = int.TryParse(Console.ReadLine(), out number);
                if (numberCheck == true)
                {
                    return number;
                    break;
                }
            }
        }
    }
}
