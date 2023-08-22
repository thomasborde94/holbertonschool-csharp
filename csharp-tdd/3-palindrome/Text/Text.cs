using System;

namespace Text
{
    /// <summary>
    /// Defines Str Class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Tells if a string is a palindrome
        /// </summary>
        /// <param name="s">String to analyse</param>
        /// <returns>True if s is a palindrome, else False</returns>
        public static bool IsPalindrome(string s)
        {
            string toUpper = s.ToUpper();
            string onlyUpper = "";
            for (int i = 0; i < toUpper.Length; i++)
            {
                if (toUpper[i] >= 65 && toUpper[i] <= 90)
                    onlyUpper += toUpper[i];
            }

            string palindrome = "";
            for (int i = onlyUpper.Length - 1; i >= 0; i--)
                palindrome += onlyUpper[i];
            
            if (palindrome == onlyUpper)
                return true;
            else
                return false;
        }
    }
}
