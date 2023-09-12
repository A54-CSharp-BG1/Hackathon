using System;
using System.Xml.XPath;

namespace Hackaton
{
    public class StringHelpers
    {
        public static string Abbreviate(string source, int maxLength)
        {
            //Maria
            
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Abbreviate is not implemented!");
        }
        /// <summary>
        /// Convert first letter of the string to UpperCase
        /// </summary>
        /// <param name="source"></param>
        /// <returns>returns a new string with first letter converted to Uppercase.</returns>
        /// <author>Milen Marinov</author>
        public static string Capitalize(string source)
        {
            string newString = string.Empty;
          if(source == string.Empty)
            {
                return string.Empty;
            }
            if (source != string.Empty)
            {
                newString = char.ToUpper(source[0]) + source.Substring(1);
            }
            else if (char.IsUpper(source[0]))
            {
                newString = source;
            }
            return newString;
        }

        /// <summary>
        /// Concatenates two strings and returns a new string.
        /// </summary>
        /// <param name="string1">The left part of the new string</param>
        /// <param name="string2">The right part of the new string</param>
        /// <returns>A string that represents the concatenation of string1's characters followed by string2's characters.</returns>
        /// <author>Plamen Nedelchev</author>
        
        public static string Concat(string string1, string string2)
        {
            return string1 + string2;
        }

        public static bool Contains(string source, char symbol)
        {
            //Yasen

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Contains is not implemented!");
        }

        public static bool StartsWith(string source, char target)
        {
            //Alex

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: StartsWith is not implemented!");
        }

        public static bool EndsWith(string source, char target)
        {
            //Ivan

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: EndsWith is not implemented!");
        }

        public static int FirstIndexOf(string source, char target)
        {
            //Maria

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: FirstIndexOf is not implemented!");
        }
        /// <summary>
        /// Finds specific char in string.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="symbol"></param>
        /// <returns>returns index of the char containing in the string.</returns>
        /// <author>Milen Marinov</author>
        public static int LastIndexOf(string source, char symbol)
        {
           
            int result = -1;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == symbol)
                {
                    result = i;
                }
            }
            return result;
        }

        /// <summary>
        /// Concatenates a given symbol N times both at the start and at the end of the string.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="length"></param>
        /// <param name="paddingSymbol"></param>
        /// <returns>Returns a new string.</returns>
        /// <author>Plamen Nedelchev</author>

        public static string Pad(string source, int length, char paddingSymbol)
        {
            if (length < source.Length)
            {
                return source;
            }

            int padLeftLength = (length - source.Length) / 2;
            int padRightLength = (length - source.Length) / 2;

            string result = string.Empty;

            result += new string(paddingSymbol, padLeftLength);
            result += source;
            result += new string(paddingSymbol, padRightLength);

            return result;
        }

        public static string PadEnd(string source, int length, char paddingSymbol)
        {
            //Yasen

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: PadEnd is not implemented!");
        }

        public static string PadStart(string source, int length, char paddingSymbol)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: PadStart is not implemented!");
        }
        /// <summary>
        /// Repeat a given string for N times.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="times"></param>
        /// <returns>returns a new string which is repeated by second parameter .</returns>
        /// <author>Milen Marinov</author>
        public static string Repeat(string source, int times)
        {
            string newString = "";
            for (int i = 0; i < times; i++)
            {
                newString += source;
            }
            return newString;
        }

        /// <summary>
        /// Reverses a given string.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>Returns a new reversed string.</returns>
        /// <author>Plamen Nedelchev</author>

        public static string Reverse(string source)
        {
            string reversedString = string.Empty;

            for (int i = source.Length - 1; i >= 0; i--)
            {
                reversedString += source[i];
            }

            return reversedString;
        }

        public static string Section(string source, int start, int end)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Section is not implemented!");
        }
    }
}
