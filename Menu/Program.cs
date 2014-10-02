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
            Program prog=new Program();
            string choice;

            Console.WriteLine("Velommen til superprogrammet. Her kan du konvertere stuff!");
            Console.WriteLine("Tast 1 for: kg til pund");//for mange desimaler? sjekk ut Class Math! Her finnes avrundingsfunksjoner.
            Console.WriteLine("Tast 2 for: Celcius til fahrenheit");
            Console.WriteLine("Tast 3 for: Meter til fot");
            //mer ?
            choice = Console.ReadLine();//users choice
                       
        }

        private double ConvertKgToPounds(double kg)//this time we are using decimals. Mind the datatype. it is "double". 1 kilogram = 2.20462262 pounds
        {
            return kg * 2.20462262;
        }
    }
}
