using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaryClass<string, int> myDictionaryClass = new MyDictionaryClass<string, int>();
            myDictionaryClass.Add("First", 1);
            myDictionaryClass.Add("Second", 2);
            myDictionaryClass.Add("Third", 3);

            Console.WriteLine(myDictionaryClass.Count); // Output: 3

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("First", 1);
            dictionary.Add("Second", 2);
            dictionary.Add("Third", 3);

            Console.WriteLine(dictionary.Count); // Output: 3
        }
    }
}
