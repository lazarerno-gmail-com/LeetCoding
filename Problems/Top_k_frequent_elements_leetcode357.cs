using LeetCoding.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCoding.Problems
{
    /// <summary>
    /// Given an integer array ‘nums’ and an integer ‘k’, return the ‘k’ most frequent elements.
    /// You may return the answer in any order.
    /// </summary>
    internal class Top_k_frequent_elements_leetcode357: IProblem<int[]>
    {
        private int[] _numbers;
        private int _topK;

        public Top_k_frequent_elements_leetcode357(int[] numbers, int topK)
        {
            _numbers = numbers;
            _topK = topK;
        }

        public string Description => "Top 'k' most frequent elements in an integer array";

        public int[] Solve()
        {
            if (_topK == _numbers.Length)
                return _numbers;
            Dictionary<int, int> count = new Dictionary<int, int>();
            foreach (int i in _numbers)
            {
                if (count.ContainsKey(i))
                    count[i]++;
                else
                    count.Add(i, 1);
            }
            PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
            foreach(var pair in count)
            {
                heap.Enqueue(pair.Key, pair.Value);
                if(heap.Count > _topK)
                    heap.Dequeue();
            }
            int[] answer = new int[_topK];
            for (int i = 0; i < _topK; i++)
            {
                answer[_topK - 1 - i] = heap.Dequeue();
            }
            return answer;
        }

        #region TESTS
        public abstract class TestsBase
        {
            protected void Dump(IProblem<int[]> problem, int[] input, int topK)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(problem.Description);
                Console.Write("Inputs:");
                Helpers.Dump("  Collection: ", input);
                Helpers.Dump("  Top K: ", topK);
                Helpers.Dump("Result: ", problem.Solve());
            }
        }
        public class Test1 : TestsBase
        {
            public Test1()
            {
                int[] input = [1,1,1,2,2,3,3,3,3,3];
                int topK = 2;

                var problem = new Top_k_frequent_elements_leetcode357(input, topK);

                Dump(problem, input, topK);
            }
        }
        #endregion
    }
}
