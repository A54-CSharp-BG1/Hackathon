using System;
using System.Collections.Generic;

namespace Hackaton
{
    public class ArrayHelpers
    {
        /// <summary>
        /// Adds the int element at the start of the array source.
        /// </summary>
        /// <param name="source">The array to add to</param>
        /// <param name="element">The element to add</param>
        /// <returns>A new array that has all the elements from the original array and the added element at head position.</returns>
        /// <author>Kiril Stanoev</author>
        public static int[] AddFirst(int[] source, int element)
        {
            //alex

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: AddFirst is not implemented!");
        }

        /// <summary>
        /// Adds element to the end of source.
        /// </summary>
        /// <param name="source">The array to add to</param>
        /// <param name="element">The element to add</param>
        /// <returns>A new array, the original array with element at the end.</returns>
        /// <author>Ivan Uzunov</author>
        public static int[] AddLast(int[] source, int element)
        {
            int[] newSource = new int[source.Length + 1];
            for (int i = 0; i < source.Length + 1; i++)
            {
                if(i < source.Length)
                {
                    newSource[i] = source[i];
                }
                else newSource[i] = element;
            }
            source = newSource;
            return source;
        }

        /// <summary>
        /// Appends new elements to the original array.
        /// </summary>
        /// <param name="source">The array to add to</param>
        /// <param name="elements">The elements to add</param>
        /// <returns>A new array that has all the elements from the original array and the new appended elements.</returns>
        /// <author>Maria Ivanova</author>

        public static int[] AppendAll(int[] source, int[] elements)
        {
            //Maria

            if (source.Length == elements.Length)
            {
                bool equal = true;
                for (int i = 0; i < source.Length; i++)
                {
                    if (source[i] != elements[i])
                    {
                        equal = false;
                    }
                }

                if (equal == true) return source;
            }

            int[] result = new int[source.Length + elements.Length];

            int index = 0;

            for (int i = 0; i < source.Length; i++)
            {
                result[index] = source[i];
                index++;
            }
            for (int i = 0; i < elements.Length; i++)
            {
                result[index] = elements[i];
                index++;
            }

            return result;
        }
        /// <summary>
        /// Insert specific element to specific index of the array and resize the array.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <param name="element"></param>/param>
        /// <returns>returns a new resized int array with changed element .</returns>
        /// <author>Milen Marinov</author>
        public static int[] InsertAt(int[] source, int index, int element)
        {
            //Milen
            int[] newArray = new int[source.Length+1];
            if (index == 0)
            {
                newArray[0] = element;
                for (int i = 1; i < newArray.Length; i++)
                {

                    newArray[i] = source[i - 1];
                }

            }
            if (index > source.Length-1)
            {
                for (int i = 0; i < newArray.Length; i++)
                {
                    if (i < source.Length - 1)
                    {
                        newArray[i] = source[i];
                    }
                    else
                    {
                        newArray[i] = element;
                    }
                  
                }
            }
            if(index<source.Length-1 && index != 0)
            {
                for (int i = 0; i < newArray.Length; i++)
                {
                    if(i == index)
                    {
                        newArray[i] = element;
                        for (int j = i+1; j < newArray.Length; j++)
                        {
                            newArray[j] = source[i];
                        }
                    }
                }
            }          
            return newArray;
         
        }

        /// <summary>
        /// Checks whether a given element is present in an array.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="element"></param>
        /// <returns>Returns true if the element is present and false if it is not.</returns>
        /// <author>Plamen Nedelchev</author>

        public static bool Contains(int[] source, int element)
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == element)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Copies a certain amount of int elements from one array onto another starting from the first position of the array
        /// </summary>
        /// <param name="sourceArray">The source array that is going to get copied</param>
        /// <param name="destinationArray">The destination of the new copy</param>
        /// <param name="count">The amount of parameters that will get copied</param>
        /// <author>Yasen Velinov</author>p
        public static void Copy(int[] sourceArray, int[] destinationArray, int count)
            {
                count = Math.Min(count, destinationArray.Length);
                count = Math.Min(sourceArray.Length, count);
                for (int i = 0; i < count; i++)
            {
                destinationArray[i] = sourceArray[i];
            }
            }
            
        /// <summary>
            /// Copy certain amount of int elements from an array from certain position onto another array from certain position
            /// </summary>
            /// <param name="sourceArray">The Array that will get copied</param>
            /// <param name="sourceStartIndex">The position from which the elements shall get copied</param>
            /// <param name="destinationArray"> The array the elements shall get copied onto </param>
            /// <param name="destStartIndex">The position we shall paste the elements</param>
            /// <param name="count">The ammount of elements that will get copied</param>
            /// <autor>Yasen Velinov</autor>
        public static void CopyFrom(int[] sourceArray, int sourceStartIndex, int[] destinationArray, int destStartIndex, int count)
            {   
                count = Math.Min(count, destinationArray.Length - destStartIndex);
                count = Math.Min(sourceArray.Length - sourceStartIndex, count);
                for (int i = 0; i < count; i++)
                {
                destinationArray[i-destStartIndex] = sourceArray[i-sourceStartIndex];
                }
            }
        /// <summary>
        /// Fills source with element.
        /// </summary>
        /// <param name="source">The array to fill</param>
        /// <param name="element">The element to fill with</param>
        /// <returns>Void, an array that is filled entirely with the element integer.</returns>
        /// <author>Ivan Uzunov</author>    
        public static void Fill(int[] source, int element)
        {
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = element;
            }
        }

        /// <summary>
        /// Searches for the first appearance of a desired element in an array.
        /// </summary>
        /// <param name="source">Array to search</param>
        /// <param name="target">Target element</param>
        /// <returns>The index of the first occurrence of the target element.</returns>
        /// <author>Maria Ivanova</author>

        public static int FirstIndexOf(int[] source, int target)
        {
            //Maria

            int result = -1;

            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == target)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Finds specific integer in the array.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns>returns the index of the target value.</returns>
        /// <author>Milen Marinov</author>
        public static int LastIndexOf(int[] source, int target)
        {
            //Milen
            int result = -1;
            if(source.Length != 0)
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == target && i != 0)
                {
                    result = i;
                }
                else
                {
                    result = -1;
                }
            }
            
            return result;
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: LastIndexOf is not implemented!");
        }

        /// <summary>
        /// Check whether a given index is inside the bounds of the array.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns>Returns true if the index is inside the bounds of the array and false if it is not.</returns>
        /// <author>Plamen Nedelchev</author>

        public static bool IsValidIndex(int[] source, int index)
        {
            if (source.Length == 0
                || index < 0
                || index >= source.Length)
            {
                return false;
            }

            return true;
        }
        /// <summary>
        /// Removes all occurrences of element within source.
        /// </summary>
        /// <param name="source">The array to remove from></param>
        /// <param name="element">The element to check for</param>
        /// <returns>A new array with all occurences of element removed.</returns>
        /// <author>Ivan Uzunov</author>
        public static int[] RemoveAllOccurrences(int[] source, int element)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] != element)
                {
                    result.Add(source[i]);
                }
            }
            source = result.ToArray();
            return source;
        }

        public static void Reverse(int[] arrayToReverse)
        {
            //Alex

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Reverse is not implemented!");
        }
        /// <summary>
        /// Returns a new array, from source, starting from startIndex and until endIndex.
        /// </summary>
        /// <param name="source">The array to create the new array from</param>
        /// <param name="startIndex">The starting index</param>
        /// <param name="endIndex">The end index</param>
        /// <returns>A new array starting from startIndex and until endIndex.</returns>
        /// <author>Ivan Uzunov</author>
        public static int[] Section(int[] source, int startIndex, int endIndex)
        {  
            List<int> newSource = new List<int>();
            if (endIndex < source.Length && startIndex < endIndex)
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    newSource.Add(source[i]);
                    int temp = source[i];
                }
            }
            else if (endIndex >= source.Length && startIndex < endIndex)
            {
                for (int i = startIndex; i < source.Length; i++)
                {
                    newSource.Add(source[i]);
                }
            }
            else if (startIndex > endIndex)
            {
                for (int i = 0; i < source.Length; i++)
                {
                    newSource.Add(source[i]);
                }
            }
            int[] source2 = new int[newSource.Count];
            for (int i = 0; i < newSource.Count; i++)
            {
                source2[i] = newSource[i];
                int newSourceTemp = newSource[i];
            }
            source = source2;
            foreach (int i in source)
            {
                Console.Write(i + ", ");
            }
            return source;
        }
    }
}
