using System;
using System.Collections.Generic;
using System.Text;

namespace Trie
{
    public class CamelcaseMatching
    {
        /*
         * T.C: O(N) where n is number of quries
         * S.C: O(1)
         */
        public IList<bool> CamelMatch(string[] queries, string pattern)
        {
            if (queries == null || queries.Length == 0) return null;

            List<bool> result = new List<bool>();

            foreach (string query in queries)
            {
                int index = 0;
                bool isMatch = false;
                for (int i = 0; i < query.Length; i++)
                {
                    char c = query[i];
                    if (index < pattern.Length && c == pattern[index])
                    {
                        index++;
                        if (index == pattern.Length)
                        {
                            isMatch = true;
                        }
                    }
                    else if (Char.IsUpper(c))
                    {
                        isMatch = false;
                        break;
                    }
                }
                result.Add(isMatch);
            }
            return result;
        }
    }
}
