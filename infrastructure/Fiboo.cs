using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure
{
    public class Fiboo
    {
        public int result;
        public Fiboo(int number)
        {
            result = GetFiboo(number);
        }
        public int GetFiboo(int number)   
        {
            if (number == 0) return 0;
            if (number == 1) return 1;
            return GetFiboo(number-1) + GetFiboo(number-2);

        }   
    }
}
