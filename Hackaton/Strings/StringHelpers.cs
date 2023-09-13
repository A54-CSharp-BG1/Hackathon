using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.XPath;

namespace Hackaton
{
    public class StringHelpers
    {
        /// <summary>
        /// Shorten the string to a given length/abbreviate it.
        /// </summary>
        /// <param name="source">The source string</param>
        /// <param name="maxLength">The value that corresponds to the length of the new shortened version of the string</param>
        /// <returns>The shortened version of the string with appended dots to point out that it has continuation</returns>
        /// <remarks>
        /// - Returns empty string if the source is empty.
        /// <br></br>
        /// - Returns the source string if the given limit exceeds the source's length.
        /// </remarks>
        /// <author>Maria Ivanova</author>
        public static string Abbreviate(string source, int maxLength)
        {
            //Maria

            if (source == string.Empty) return string.Empty;

            if (maxLength > source.Length)
            {
                return source;
            }
            string result = string.Empty;

            for (int i = 0; i < maxLength; i++)
            {
                result += source[i];
            }
            result += "...";
            return result;
            
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
            if (source == string.Empty)
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
        /// <summary>
        /// Checks if the string source starts with the given character.
        /// </summary>
        /// <param name="source">The string to inspect</param>
        /// <param name="target">The character to search for</param>
        /// <returns>bool - true if string starts with target, otherwise false</returns>
        /// <author>Alex Cemirtan</author>
        public static bool StartsWith(string source, char target)
        {
            if (source == string.Empty)
            {
                return false;
            }
            else if (source[0] != target)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Checks if the string source ends with the given character.
        /// </summary>
        /// <param name="source">The string to check</param>
        /// <param name="target">The character to check for</param>
        /// <returns> A bool variable - true if the string ends with target, else false.</returns>
        /// <author>Ivan Uzunov</author>
        public static bool EndsWith(string source, char target)
        {
            if (source == string.Empty)
            {
                return false;
            }
            else if (source[source.Length - 1] != target)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Searches for the first occurrence of the desired character in the given string.
        /// </summary>
        /// <param name="source">The source string</param>
        /// <param name="target">The target character</param>
        /// <remarks>
        /// - Returns negative one if the string does not contain the given character.
        /// <br></br>
        /// - Returns negative one if the string is empty.
        /// </remarks>
        /// <returns>The index of the first occurrence of the target character.</returns>
        /// <author>Maria Ivanova</author>

        public static int FirstIndexOf(string source, char target)
        {
            //Maria
            int result = -1;

            for (int i = 0; i < source.Length;i++)
            {
                if (source[i] == target)
                {
                    result = i;
                }
            }

            return result;
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
        /// <summary>
        /// Pads source on the left side with PaddingSymbol enough times to reach length length.
        /// </summary>
        /// <param name="source">The string to pad</param>
        /// <param name="length">The length of the string to achieve</param>
        /// <param name="paddingSymbol">The character used as padding</param>
        /// <returns> The padded string.</returns>
        /// <author>Ivan Uzunov</author>
        public static string PadStart(string source, int length, char paddingSymbol)
        {
            char[] arr = new char[length];
            for (int i = 0; i < length - source.Length; i++)
            {
                arr[i] = paddingSymbol;
            }
            int index = 0;
            for (int i = length - source.Length; i < length; i++)
            {
                arr[i] = source[index];
                index++;
            }
            source = new string(arr);
            return source;
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
        /// <summary>
        /// Returns a new string, starting from start and ending at end.
        /// </summary>
        /// <param name="source">The string to extract a section from</param>
        /// <param name="start">The starting position in source (inclusive)</param>
        /// <param name="end">The end position in source (inclusive)</param>
        /// <returns> A new string, formed by the characters in source, starting from start to end.</returns>
        /// <author>Ivan Uzunov</author>
        public static string Section(string source, int start, int end)
        {            
            char[] sourceArr = source.ToCharArray(2, (end - start) + 1);
            source = new string(sourceArr);
            return source;
        }
    }
}
