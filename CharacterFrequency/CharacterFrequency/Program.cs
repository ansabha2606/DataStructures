using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            //obj.CharCount(new char[] { 'e', 'e', 'b', 'b', 'b', 'b', 'f', 'a', 'v' });
            obj.CharCountBestApproach(new char[] { 'e', 'e', 'b', 'b', 'b', 'b', 'f', 'a', 'v' });
        }
        public void CharCount(char[] arr)
        {
            List<char> nodeResult = new List<char>();
            int len = 0, count = 0;

            len = arr.Length;
            if (len == 1)
            {
                Console.WriteLine(arr[0] + " : " + 1);
                Console.ReadLine();
                return;
            }
            for (int i = 0; i < len; i++)
            {
                char node = arr[i];
                for (int j = 0; j < len; j++)
                {
                    if (arr[j] == node)
                        count++;
                }

                if (!nodeResult.Contains(node))
                {
                    nodeResult.Add(node);
                    Console.WriteLine(node + " : " + count);
                }
                count = 0;
            }
            Console.ReadLine();
        }

        public void CharCountBestApproach(char[] arr)
        {
            int[] count = new int[256];
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                count[arr[i]]++;
            }
            for (int i = 0; i < 256; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine((char)(i) + " : " + count[i]);

                }
            }
            Console.ReadLine();
        }
    }
}
