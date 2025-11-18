using LeetCoding.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCoding.Problems
{
    /// <summary>
    /// 
    /// Return TRUE if an array of integers contains duplicates, otherwise return FALSE
    /// 
    /// </summary>
    internal class Find_duplicates_true_false : IProblem<bool>
    {
        private int[] _numbers;

        public Find_duplicates_true_false(int[] numbers)
        {
            _numbers = numbers;
        }

        public string Description => "Does the array contain duplicates?";

        public bool Solve()
        {
            var numberSet = new HashSet<int>();
            for (int i = 0; i < _numbers.Length; i++)
            {
                if (numberSet.Contains(_numbers[i]))
                    return true;
                else
                    numberSet.Add(_numbers[i]);
            }
            return false;
        }

        #region TESTS
        public abstract class TestsBase
        {
            protected void Dump(IProblem<bool> problem, int[] input)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(problem.Description);
                Console.Write("Inputs:");
                Helpers.Dump("  Collection: ", input);
                Helpers.Dump("Result: ", problem.Solve());
            }
        }
        
        public class Test1: TestsBase
        {
            public Test1()
            {
                int[] input = [6, 9, 3, 7, 8, 0, 14];
                var problem = new Find_duplicates_true_false(input);

                Dump(problem, input);
            }
        }

        public class Test2 : TestsBase
        {
            public Test2()
            {
                int[] input = [6, 9, 3, 7, 3, 0, 14];
                var problem = new Find_duplicates_true_false(input);

                Dump(problem, input);
            }
        }
        #endregion 
    }
}
