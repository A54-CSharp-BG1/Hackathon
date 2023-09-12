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

        public static int[] Section(int[] source, int startIndex, int endIndex)
        {
            //Ivan

            // Remove the line below then add your implementation.
            throw new NotImplementedException("Error: Section is not implemented!");
        }
    }
}
