using System;
using System.Collections.Generic;
using System.Linq;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        public int Count(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException();

            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            string convertedvalue = value.ToLower();//convert the sting tolower before checking for vowels


            int total = convertedvalue.Count(c => vowels.Contains(c));//using linq
            Console.WriteLine("Your total number of vowels is: {0}", total);
            return total;

        }
    }
}
