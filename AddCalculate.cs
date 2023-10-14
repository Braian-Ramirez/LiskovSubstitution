using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public abstract class AddCalculate
    {
        protected readonly int[] _numbers;
        public AddCalculate(int[] numbers)
        {
            _numbers = numbers;
        }
        public abstract int Calculate();
    }
}
