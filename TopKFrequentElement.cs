using System;
using System.Collections.Generic;
using System.Text;

namespace Trie
{
    public class TopKFrequentElement
    {
        /*
         * T.C: O(nlogk) where n is numer of element in nums array
         * s.C: O(k) 
         */
        public int[] TopKFrequent(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0) return new int[] { };

            Dictionary<int, int> map = new Dictionary<int, int>();
            int[] result = new int[k];

            foreach (int num in nums)
            {
                if (!map.ContainsKey(num))
                {
                    map.Add(num, 1);
                }
                else
                {
                    map[num]++;
                }
            }

            PriorityQueue<int[], int> pq = new PriorityQueue<int[], int>();

            foreach (int key in map.Keys)
            {
                pq.Enqueue(new int[] { key, map[key] }, map[key]);

                if (pq.Count > k)
                {
                    pq.Dequeue();
                }
            }

            while (pq.Count != 0 && k > 0)
            {
                int[] numArr = pq.Dequeue();
                Console.WriteLine(k);
                result[k - 1] = numArr[0];
                k--;
            }

            return result;
        }


    }
}

