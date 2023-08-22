using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// Defines Str Class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Finds index of the first non-repeating character of a string
        /// </summary>
        /// <param name="s">String to analyse</param>
        /// <returns>index of the first non-repeating character of a string</returns>
        public static int UniqueChar(string s)
        {
            int occurences;
            for (int i = 0; i < s.Length; i++)
            {
                occurences = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j] && i != j)
                    {
                        occurences += 1;
                    }
                }
                if (occurences == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
