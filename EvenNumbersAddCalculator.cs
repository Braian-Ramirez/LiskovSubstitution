using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class EvenNumbersAddCalculator : AddCalculate
    {
        public EvenNumbersAddCalculator(int[] numbers) : base(numbers)
        {

        }

        public override int Calculate() {
            int result = 0;

            foreach (var number in _numbers)
            {
                if (number % 2 == 0) {
                    result += number;
                }
            }
            return result;
        }
    }
}
