using LeetCoding.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace LeetCoding.Problems
{
    /// <summary>
    /// 
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// You can return the answer in any order.
    /// 
    /// </summary>
    internal class Two_Sum_1 : IProblem<int[]>
    {
        private int[] _numbers;
        private int _sum;

        public string Description => "Two sum problem";

        public Two_Sum_1(int[] numbers, int sum)
        {
            _numbers = numbers;
            _sum = sum;
        }

        public int[] Solve()
        {
            var indexMap = new Dictionary<int, int>();
            for (int i = 0; i < _numbers.Length; i++)
            {
                if (indexMap.ContainsKey(_sum - _numbers[i]))
                    return [i, indexMap[_sum - _numbers[i]]];
                if (!indexMap.ContainsKey(_numbers[i]))
                    indexMap.Add(_numbers[i], i);
            }
            return [];
        }

        #region TESTS
        public class Test1
        {
            public Test1()
            {
                int[] input = [6, 9, 3, 7, 3, 0, 14];
                int sum = 17;
                var problem = new Two_Sum_1(input, sum);

                Console.WriteLine(problem.Description);
                Console.Write("Inputs:");
                Helpers.Dump("  Collection: ", input);
                Helpers.Dump("  Sum:", [sum]);
                Helpers.Dump("Result: ", problem.Solve());
            }
        }
        #endregion 
    }
}
