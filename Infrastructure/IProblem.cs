using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCoding.Infrastructure
{
    public interface IProblem<T>
    {
        public T Solve();
        public string Description { get; }
    }
}
