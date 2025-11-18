using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCoding.Problems
{
    /// <summary>
    /// 
    /// Return the first duplicate in an array of integers.
    /// Return NULL if there is no duplicate to be found.
    /// 
    /// </summary>
    internal class Find_duplicates_return_first: IProblem<int?>
    {
        private int[] _numbers;

        public Find_duplicates_return_first(int[] numbers)
        {
            _numbers = numbers;
        }

        public string Description => "Return first duplicate or NULL";

        public int? Solve()
        {
            var numberSet = new HashSet<int>();
            for (int i = 0; i < _numbers.Length; i++)
            {
                if (numberSet.Contains(_numbers[i]))
                    return _numbers[i];
                else
                    numberSet.Add(_numbers[i]);
            }
            return null;
        }

        #region TESTS
        public abstract class TestsBase
        {
            protected void Dump(IProblem<int?> problem, int[] input)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(problem.Description);
                Console.Write("Inputs:");
                Helpers.Dump("  Collection: ", input);
                Helpers.Dump("Result: ", problem.Solve());
            }
        }

        public class Test1 : TestsBase
        {
            public Test1()
            {
                int[] input = [6, 9, 3, 7, 8, 0, 14];
                var problem = new Find_duplicates_return_first(input);

                Dump(problem, input);
            }
        }

        public class Test2 : TestsBase
        {
            public Test2()
            {
                int[] input = [6, 9, 3, 7, 3, 0, 14];
                var problem = new Find_duplicates_return_first(input);

                Dump(problem, input);
            }
        }
        #endregion 
    }
}
