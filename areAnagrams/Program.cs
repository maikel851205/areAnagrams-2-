using System;

namespace areAnagrams
{
    class Program
    {
        static void Main()
        {
            bool areAnagrams(char[] str1, char[] str2) 
            {
                if (str1.Length != str2.Length)
                    return false;

                int[] count = new int[256];
                for (int i = 0; i < str1.Length; i++)
                {
                    count[str1[i]]++;
                }

                for (int i = 0; i < str2.Length; i++)
                {
                    count[str1[i]]--;
                }

                for (int i = 0; i < count.Length; i++)
                {
                    if (count[i] != 0)
                        return false;
                }

                return true;
            }

            string str1 = "listen";
            string str2 = "zilent";

            if (areAnagrams(str1.ToCharArray(), str2.ToCharArray()))
                Console.WriteLine("ARE ANAGRAMS");
            else
                Console.WriteLine("ARE NOT ANAGRAMS");
            Console.ReadLine();

        }
    }
}
