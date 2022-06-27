using System;
using System.Collections.Generic;

namespace MLOAN.TDD.Exercise1
{
    public class NumberHelper
    {
        public int Add(int x, int y)
        {
            //throw new NotImplementedException();
            return x + y;
        }
        public int[] FindMissing(int[] values)
        {
            //return new int[] { 1,2,3 };

            if (values == null) throw new ArgumentNullException(nameof(values));
            if (values.Length == 0) return new int[0];
            Array.Sort(values);
            for (int last = values[0], i = 1; last < values.Length; last++)
            {
                if (values[i] != last + 1) return new[] { last + 1 };
                last = values[i];
            }
            return new int[] { };
        }
    }
    //public List<int> TestMethod(){
    //    var res = new List<int>();


    //    return res;
    //}
}
