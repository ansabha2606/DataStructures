using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.reverseWithoutArray(new char[] { 'a' ,'b','c','d','e'});
            //obj.reverse(new char[] { 'a' });
        }
        public void reverse(char[] arr)
        {
            int len = 0,k=0;
            
            len = arr.Length;
            if (len == 1)
            {
                Console.WriteLine(arr);
                Console.ReadLine();
                return;
            }
            char[] b = new char[len];
            for (int i = len - 1; i >= 0; i--)
            {
                b[k] = arr[i];
                k++;
            }

            Console.WriteLine(b);
            Console.ReadLine();
        }

        public void reverseWithoutArray(char[] arr)
        {
            char temp;

            int len = arr.Length;
            if (len == 1)
            {
                Console.WriteLine(arr);
                Console.ReadLine();
                return;
            }
            for (int i = len - 1,j=0; i >= len/2; i--,j++)
            {
                temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }

            Console.WriteLine(arr);
            Console.ReadLine();
        }
    }
}
