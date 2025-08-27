using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_numbers
{
    public class CalculatePlus : Calculate
    {
        public override int SomOfNumbers(List<int> numbers)
        {
            int sumNumberPlus = 0;
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    sumNumberPlus += number;
                }
            }
            return sumNumberPlus;
        }
    }
}
