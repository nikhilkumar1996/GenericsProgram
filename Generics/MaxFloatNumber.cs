using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MaxFloatNumber
    {
        public double FindMaxNumber(double inputFirst,double inputSecond,double inputThird)
        {
            if(inputFirst.CompareTo(inputSecond)>0 && inputFirst.CompareTo(inputThird) > 0)
            {
                return inputFirst;
            }
            if(inputSecond.CompareTo(inputFirst)>0 && inputSecond.CompareTo(inputThird) > 0)
            {
                return inputSecond;
            }
            else
            {
                return inputThird;
            }
        }
    }
}
