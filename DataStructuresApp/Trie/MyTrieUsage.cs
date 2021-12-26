using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresApp.Trie
{
    internal class MyTrieUsage
    {
        public static void Run()
        {
            MyTrie trie = new();
            var items = new List<string> { "tom", "tom", "tomasz", "tomek", "tomeczek" };

            // const string s = "tome"; // False
            const string s = "tomek"; // True

            trie.InsertRange(items);
            var prefix = trie.Prefix(s);
            var foundT = prefix.Depth == s.Length && prefix.FindChildNode('$') != null;
            Console.WriteLine(foundT);
        }
    }
}
