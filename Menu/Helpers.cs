using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class Helpers//an example for using an external file containing one class, with some help methods
    {
        /// <summary>
        /// Check if a string is numeric. Only working with whole numbers. No decimals. Because of the char ','
        /// </summary>
        /// <param name="s">String to be tested</param>
        /// <returns>bool</returns>

        //public Helpers() { }

        public bool IsStringNumeric(string s)// 48 - 59 som ascii er fra 0-9. Om tegnene er innenfor dette, betyr det at stringen er et tall.
        {
            //introducing arrays and the datatype char. char is only one sign. eg. 'd'. char=character.
            //[] is the symbol for an array. can contain multiple variables of the same type.
            char[] charArray=s.ToCharArray();//takes the string and puts one by one char into the array. one char per index.
            //now we need to loop through the array to check if all chars are a number.

            //introducing the foreach loop
            foreach (char c in charArray)//på norsk: for hver char c i charArrayen
            {
                if (c < 48 || c > 59)// a char is represented by a ascii value. 
                    return false;//if the above is true, it is not a number
            }
            //lekse: Vi kunne også ha brukt andre typer loops. Kan du se for deg hvilke? Og hvordan ville koden ha blitt?
            return true;
        }
    }
}
