using System;
using System.Collections.Generic;

/** <remark>
 * Write a program that extracts from a given sequence of strings all elements that present in it odd number of times.
 * Example: {C#, SQL, PHP, PHP, SQL, SQL } -> {C#, SQL}
</remark> */

namespace _20180315_Task3_Generic
{
    internal class Program
    {
        private static void Main()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string[] words = { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            try
            {
                Console.Write("Words: { ");
                foreach (string item in words)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("}\n");

                SearchForAnOddNumberOfStrings(dictionary, words);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Method that extracts from a given sequence of strings all elements that present in it odd number of times.
        /// </summary>
        /// <param name="dictionary">A collection of keys and values.</param>
        /// <param name="words">List of strings.</param>
        private static void SearchForAnOddNumberOfStrings(IDictionary<string, int> dictionary, IEnumerable<string> words)
        {
            if (dictionary == null)
                throw new ArgumentNullException(nameof(dictionary));
            if (words == null)
                throw new ArgumentNullException(nameof(words));

            foreach (string values in words)
            {
                if (dictionary.ContainsKey(values))
                    dictionary[values]++;
                else
                    dictionary.Add(values, 1);
            }

            Console.Write("Words that meet odd number of times: { ");
            foreach (var item in dictionary)
            {
                if (item.Value % 2 != 0)
                    Console.Write(item.Key + " ");
            }
            Console.WriteLine("}");
        }
    }
}