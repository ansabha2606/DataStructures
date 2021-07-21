using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSingleTraverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            int[] res = obj.maxMin(new int[] { 5,5,5,5,5,5});
        }
        public int[] maxMin(int[] arr)
        {
            int[] result = new int[2] { int.MinValue, int.MaxValue };
            int minValue = int.MinValue;
            int maxValue = int.MaxValue;
            int len = arr.Length;
            if (len <= 0)
                return result;
            minValue = arr[0];
            maxValue = arr[0];
            for (int i = 0; i < len; i++)
            {
                if (arr[i] >= maxValue)
                    maxValue = arr[i];
                else if (arr[i] < minValue)
                    minValue = arr[i];
            }
            result[0] = minValue;
            result[1] = maxValue;
            return result;
        }

    }
}
