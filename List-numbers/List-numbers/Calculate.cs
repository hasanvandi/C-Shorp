using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_numbers
{
    public class Calculate
    {
        public virtual int SomOfNumbers(List<int> numbers)
        {
            int totalNumber = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                totalNumber += numbers[i];
            }
            return totalNumber;
        }
    }
}
