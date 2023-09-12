using System;

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

        public static int[] AddLast(int[] source, int element)
        {
            //Ivan

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: AddLast is not implemented!");
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

        public static void Fill(int[] source, int element)
        {
            //Ivan

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Fill is not implemented!");
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

        public static int[] Section(int[] source, int startIndex, int endIndex)
        {
            //Ivan

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Section is not implemented!");
        }
    }
}
