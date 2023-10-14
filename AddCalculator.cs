using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class AddCalculator : AddCalculate
    {
        
        public AddCalculator(int[] numbers) : base(numbers)
        {
            
        }
        public override int Calculate() {
            return _numbers.Sum();
        }
    }
}
