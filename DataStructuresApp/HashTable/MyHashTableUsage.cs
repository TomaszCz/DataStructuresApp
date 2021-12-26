using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresApp.HashTable
{
    internal class MyHashTableUsage
    {
        public static void Run()
        {
            FixedSizeGenericHashTable<string, string> hash = new FixedSizeGenericHashTable<string, string>(20);

            hash.Add("1", "Steve Jobs");
            hash.Add("2", "Elon Musk");
            hash.Add("3", "Bill Gates");

   
            Console.WriteLine(hash.Find("3"));
            hash.Remove("1");
        }
    }
}
