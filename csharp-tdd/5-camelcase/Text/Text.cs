using System;

namespace Text
{
    /// <summary>
    /// Defines Str Class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// determines how many words are in a string. Each word begins
        /// with a capital letter except the first word
        /// </summary>
        /// <param name="s">String to analyse</param>
        /// <returns>Number of words in a string</returns>
        public static int CamelCase(string s)
        {
            if (s.Length == 0 || s == null)
                return 0;
            
            int wordCount = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                    wordCount++;
            }
            return wordCount;
        }
    }
}
