using System;
using System.Text.RegularExpressions;

namespace TGS.Challenge
{
    /*
          Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
          one another return true, else return false

          "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
          phrase to produce a new word or phrase, using all the original letters exactly once; for example
          orchestra can be rearranged into carthorse.

          areAnagrams("horse", "shore") should return true
          areAnagrams("horse", "short") should return false

          NOTE: Punctuation, including spaces should be ignored, e.g.

          horse!! shore = true
          horse  !! shore = true
            horse? heroes = true

          There are accompanying unit tests for this exercise, ensure all tests pass & make
          sure the unit tests are correct too.
       */
    public class Anagram
    {
        public bool AreAnagrams(string word1, string word2)
        {
            //check for empty strings
            if (string.IsNullOrEmpty(word1) | string.IsNullOrEmpty(word2))
                throw new ArgumentException();
            // check if there is special characters and ignore them
            string word1checked = word1.ignoreSpecialCharacters(); //call to the string extension class
            string word2checked = word2.ignoreSpecialCharacters();

            //checking if the words length before checking if they are anagrams or not
            if (word1checked.Length != word2checked.Length)
                return false;
            //converting the words into lowercase char arrays
            char[] firstchar = word1checked.ToLower().ToCharArray();
            char[] secondchar = word2checked.ToLower().ToCharArray();
            //sorting my char arrays
            Array.Sort(firstchar);
            Array.Sort(secondchar);
            //converting the sorted char arrays to strings
            String string1 = new string(firstchar);
            String string2 = new string(secondchar);
            // now checking if the 2 words are equal
            if (string.Equals(string1, string2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public static class StringExtensions
    {
        public static string ignoreSpecialCharacters(this string str)
        {
            return Regex.Replace(str, @"_|[^\w\d]|", "");
        }
    }
}
