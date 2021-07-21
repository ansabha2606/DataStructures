using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxElementArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            int result=obj.maxElement(new int[] {20});

        }
        public int maxElement(int[] arr)
        {
            int maxElement=0;
            int len = arr.Length;
            if (len <= 0)
                return maxElement;
            else if (len == 1)
                return arr[0];
            else
            {
                maxElement = arr[0];
                for (int i = 1; i < len; i++)
                { 
                        if(maxElement<arr[i])
                        {
                            maxElement = arr[i];
                        }
                    
                }
            }
            return maxElement;
        }
    }
}
