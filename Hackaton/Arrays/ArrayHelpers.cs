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
        /// Adds the int element at the end of the array source.
        /// </summary>
        /// <param name="source">The array to add to</param>
        /// <param name="element">The element to add</param>
        /// <returns>A new array that has all the elements from the original array and the added element at last position.</returns>
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

        public static int[] AppendAll(int[] source, int[] elements)
        {
            //Maria

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: AppendAll is not implemented!");
        }

        public static int[] InsertAt(int[] source, int index, int element)
        {
            //Milen

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: InsertAt is not implemented!");
        }

        public static bool Contains(int[] source, int element)
        {
            //Plamen

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Contains is not implemented!");
        }

        public static void Copy(int[] sourceArray, int[] destinationArray, int count)
        {
            //Yasen

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Copy is not implemented!");
        }

        public static void CopyFrom(int[] sourceArray, int sourceStartIndex, int[] destinationArray, int destStartIndex, int count)
        {
            //Alex

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: CopyFrom is not implemented!");
        }

        /// <summary>
        /// Adds only the int element at every position in the array source.
        /// </summary>
        /// <param name="source">The array to add to</param>
        /// <param name="element">The element to add</param>
        /// <returns>The new array is filled with only the element passed as a parameter.</returns>
        /// <author>Ivan Uzunov</author>
        public static void Fill(int[] source, int element)
        {
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = element;
            }
        }

        public static int FirstIndexOf(int[] source, int target)
        {
            //Maria

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: FirstIndexOf is not implemented!");
        }

        public static int LastIndexOf(int[] source, int target)
        {
            //Milen

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: LastIndexOf is not implemented!");
        }

        public static bool IsValidIndex(int[] source, int index)
        {
            //Plamen

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: IsValidIndex is not implemented!");
        }

        public static int[] RemoveAllOccurrences(int[] source, int element)
        {
            //Yasen

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: RemoveAllOccurrences is not implemented!");
        }

        public static void Reverse(int[] arrayToReverse)
        {
            //Alex

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Reverse is not implemented!");
        }
        /// <summary>
        /// Create a new array that contains a section of the previous one.
        /// </summary>
        /// <param name="source">The array to add to</param>
        /// <param name="startIndex">The index where the section starts from</param>
        /// <param name="endIndex">The index where the section ends</param>
        /// <returns>A new array that contains only a section of the previous array with indexes that are passed as parameters.</returns>
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
