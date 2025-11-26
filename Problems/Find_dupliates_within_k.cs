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
    /// Find duplicates within "k" distance in an array of integers.
    /// Return empty array if no duplicate was found.
    /// 
    /// </summary>
    internal class Find_dupliates_within_k: IProblem<int[]>
    {
        private int[] _numbers;
        private int _distance;

        public Find_dupliates_within_k(int[] numbers, int distance)
        {
            _numbers = numbers;
            _distance = distance;
        }

        public string Description => "Find duplicates within 'k' distance";

        public int[] Solve()
        {
            var numberSet = new HashSet<int>();
            var duplicatesList = new HashSet<int>();
            for (int i = 0; i < _numbers.Length; i++)
            {
                if(i - _distance - 1 >= 0)
                    numberSet.Remove(_numbers[i - _distance - 1]);
                if (numberSet.Contains(_numbers[i]))
                    duplicatesList.Add(_numbers[i]);
                else
                    numberSet.Add(_numbers[i]);
            }
            return duplicatesList.ToArray();
        }

        #region TESTS
        public abstract class TestsBase
        {
            protected void Dump(IProblem<int[]> problem, int[] input, int distance)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(problem.Description);
                Console.Write("Inputs:");
                Helpers.Dump("  Collection: ", input);
                Helpers.Dump("  Distance: ", distance);
                Helpers.Dump("Result: ", problem.Solve());
            }
        }

        public class Test1 : TestsBase
        {
            public Test1()
            {
                int[] input = [5, 9, 3, 7, 8, 0, 14, 8, 3, 11, 11];
                int distance = 1;

                var problem = new Find_dupliates_within_k(input, distance);

                Dump(problem, input, distance);
            }
        }

        public class Test2 : TestsBase
        {
            public Test2()
            {
                int[] input = [5, 9, 3, 7, 8, 0, 14, 8, 3, 11, 11];
                int distance = 3;

                var problem = new Find_dupliates_within_k(input, distance);

                Dump(problem, input, distance);
            }
        }

        public class Test3 : TestsBase
        {
            public Test3()
            {
                int[] input = [5, 9, 3, 7, 8, 0, 14, 8, 3, 11, 11];
                int distance = 6;

                var problem = new Find_dupliates_within_k(input, distance);

                Dump(problem, input, distance);
            }
        }
        #endregion 
    }
}
