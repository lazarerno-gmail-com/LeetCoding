using LeetCoding.Infrastructure;

namespace LeetCoding.Problems
{
    /// <summary>
    /// Roman numerals are represented by seven symbols: I, V, X, L, C, D, M.
    /// Given a roman numeral, covert it to an integer.
    /// </summary>
    internal class LeetCode_13_Roman_to_Integer : IProblem<int>
    {
        private string _romanNumber;
        public LeetCode_13_Roman_to_Integer(string romanNumber)
        {
            _romanNumber = romanNumber;
        }

        public string Description => "Integer representation of a Roman number";

        private Dictionary<string, int> values = new Dictionary<string, int>
        {
            { "I", 1 },
            { "V", 5 },
            { "X", 10 },
            { "L", 50 },
            { "C", 100 },
            { "D", 500 },
	        { "M", 1000 },
            { "IV", 4 },
            { "IX", 9 },
            { "XL", 40 },
            { "XC", 90 },
            { "CD", 400 },
            { "CM", 900 },
        };

        public int Solve()
        {
            int sum = 0;
            int i = 0;

            while (i < _romanNumber.Length)
            {
                if (i < _romanNumber.Length - 1)
                {
                    string twoSymbols = _romanNumber.Substring(i, 2);
                    if (values.ContainsKey(twoSymbols))
                    {
                        sum += values[twoSymbols];
                        i = i + 2;
                        continue;
                    }
                }
                string oneSymbol = _romanNumber.Substring(i, 1);
                sum += values[oneSymbol];
                i = i + 1;
            }

            return sum;

        }

        #region TESTS
        public abstract class TestsBase
        {
            protected void Dump(IProblem<int> problem, string input)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(problem.Description);
                Console.Write("Inputs:");
                Helpers.Dump("  Roman number: ", input);
                Helpers.Dump("Result: ", problem.Solve());
            }
        }
        public class Test1 : TestsBase
        {
            public Test1()
            {
                string input = "MCMXCIV";

                var problem = new LeetCode_13_Roman_to_Integer(input);

                Dump(problem, input);
            }
        }
        #endregion
    }
}
