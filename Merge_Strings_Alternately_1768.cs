using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCoding
{
    /// <summary>
    /// You are given two strings word1 and word2.
    /// Merge the strings by adding letters in alternating order, starting with word1. 
    /// If a string is longer than the other, append the additional letters onto the end of the merged string.
    /// 
    /// Example:
    /// Input: word1 = "abc", word2 = "pqr"
    /// Output: "apbqcr"
    /// Explanation: The merged string will be merged as so:
    /// word1:  a b   c
    /// word2:    p q   r
    /// merged: a p b q c r
    /// </summary>
    public class Merge_Strings_Alternately_1768: IProblem
    {
        private string _word1;
        private string _word2;

        public Merge_Strings_Alternately_1768(string word1, string word2)
        {
            _word1 = word1;
            _word2 = word2;
        }

        public void Solve()
        {
            //char ch = _word1[0]
        }
    }
}
