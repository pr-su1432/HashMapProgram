using System;
using HashMapprogram;

namespace HashAndTrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table Program Started");
            FrequencyOfWords<string, string> hash = new FrequencyOfWords<string, string>();
            Console.WriteLine("Frequency of words is:");
            hash.add("0", "prasanna");
            hash.add("1", "arjun");
            hash.add("2", "malli");
            hash.add("3", "siddu");
            hash.add("4", "soniya");
            hash.add("5", "prasanna");
            hash.getFrequencyOfWords();


        }
    }
}

