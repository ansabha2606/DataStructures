using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinElementArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            int res = obj.MinElement(new int[] { 12, 12, 11, 4, 5, 6 });
        }
        public int MinElement(int[] arr)
        {
            int minElement = int.MinValue;
            int len = arr.Length;
            if (len == 0)
                return minElement;
            else if (len == 1)
                return arr[0];
            else
                minElement = arr[0];
                for (int i = 0; i < len; i++)
                {
                if (arr[i] < minElement)
                    minElement = arr[i];

                }
            return minElement;
        }
    }
}
