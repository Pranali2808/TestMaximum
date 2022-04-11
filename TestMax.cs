﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
     class TestMax<T> where T : IComparable
    {
        public T[] values;

        public TestMax(T[] values)        //Constructor
        {
            this.values = values;
        }

        public T[] ArraySort()
        {
            Array.Sort(values);
            return values;
        }

        public T GetMaxOfGiven(T[] genValue)
        {
            ArraySort();
            int lastIndex = values.Length - 1;
            return values[lastIndex];
        }
        public T GetMax()
        {
            T maxValue = GetMaxOfGiven(this.values);
            return maxValue;
        }
        internal int MaxInThree(int intNum1, int intNum2, int intNum3)
        {
            throw new NotImplementedException();
        }
    }
}



