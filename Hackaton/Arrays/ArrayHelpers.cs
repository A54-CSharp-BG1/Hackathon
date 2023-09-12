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
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: AddFirst is not implemented!");
        }

        public static int[] AddLast(int[] source, int element)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: AddLast is not implemented!");
        }

        public static int[] AppendAll(int[] source, int[] elements)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: AppendAll is not implemented!");
        }

        public static int[] InsertAt(int[] source, int index, int element)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: InsertAt is not implemented!");
        }

        public static bool Contains(int[] source, int element)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Contains is not implemented!");
        }


        /// <summary>
        /// Copies a certain amount of int elements from one array onto another starting from the first position of the array
        /// </summary>
        /// <param name="sourceArray">The source array that is going to get copie</param>
        /// <param name="destinationArray">The destination of the new copy</param>
        /// <param name="count">The amount of parameters that will get copied</param>
        /// <author>Yasen Velinov</author>
        public static void Copy(int[] sourceArray, int[] destinationArray, int count)
        {
            count = Math.Min(count, destinationArray.Length);
            count = Math.Min(sourceArray.Length, count);
            for(int i=0; i < count; i++)
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
                destinationArray[i+destStartIndex] = sourceArray[i+sourceStartIndex];
            }
        }

        public static void Fill(int[] source, int element)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Fill is not implemented!");
        }

        public static int FirstIndexOf(int[] source, int target)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: FirstIndexOf is not implemented!");
        }

        public static int LastIndexOf(int[] source, int target)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: LastIndexOf is not implemented!");
        }

        public static bool IsValidIndex(int[] source, int index)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: IsValidIndex is not implemented!");
        }

        public static int[] RemoveAllOccurrences(int[] source, int element)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: RemoveAllOccurrences is not implemented!");
        }

        public static void Reverse(int[] arrayToReverse)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Reverse is not implemented!");
        }

        public static int[] Section(int[] source, int startIndex, int endIndex)
        {
            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Section is not implemented!");
        }
    }
}
