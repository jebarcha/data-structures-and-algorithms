using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.HashTables
{
    public static class CSharpHashTableDemo
    {
        public static void Demo()
        {
            //Dictionary<int, string> hashTable = new Dictionary<int, string>();
            //HashSet<string> keys = new HashSet<string>();
            Hashtable ht = new Hashtable();
            ht.Add(1, "Jose");
            ht.Add(2, "Juan");
            ht.Add(3, "Luis");
            //ht.Add(4, null);  // allowed
            //ht.Add(null, null); // not allowed
            ht.Add(4, "Joe");
            //ht.Add(4, "Mary");
            
            ht.Remove(3);

            //ht[1] = "Jose de Jesus";
            Console.WriteLine(ht[1]);

            Console.WriteLine(ht.ContainsKey(4));  //O(1)
            Console.WriteLine(ht.ContainsValue("Joe"));  //O(n)


            //ICollection key = ht.Keys;
            //foreach (int k in key)
            //{
            //    Console.WriteLine(k + ": " + ht[k]);
            //}
            Console.WriteLine("\n");
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }

        }
        public static void FindFirstNonRepeatingCharacter()
        {
            // a green apple
            var charFinder = new CharFinder();
            var result = charFinder.FindFistNonRepeatingChar("a green apple");
            Console.WriteLine(result);

        }


    }
}

