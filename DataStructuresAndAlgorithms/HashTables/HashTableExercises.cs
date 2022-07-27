using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.HashTables
{
    public class HashTableExercises
    {

        public int MostFrequent(int[] numbers)
        {
            // To find the most frequent item in an array, we have to count the
            // number of times each item has been repeated. We can use a hash
            // table to store the items and their frequencies.
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (var number in numbers)
            {
                map.TryGetValue(number, out int count);
                if (count == 0)
                {
                    map.Add(number, 1);
                }
                else
                {
                    map[number] = count + 1;
                }
            }

            // Once we've populated our hash table, we need to iterate over all
            // key/value pairs and find the one with the highest frequency.
            int max = -1;
            int result = numbers[0];

            foreach (var item in map)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    result = item.Key;
                }

            }

            // Runtime complexity of this method is O(n) because we have to
            // iterate the entire array to populate our hash table.

            return result;
        }

    }
}
