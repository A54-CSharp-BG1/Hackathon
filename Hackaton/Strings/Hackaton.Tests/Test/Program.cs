using System.Xml.Linq;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] source = new int[] { 1, 2, 3, 2, 4, 2, 5, 6 };
            int element = 2;
            List<int> result = new List<int>();
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] != element)
                {
                    result.Add(i);
                }
            }
            source = result.ToArray();
            foreach (int i in source) 
            {
                Console.Write(i + " ");
            }
        }
    }
}