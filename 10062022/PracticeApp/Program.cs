using System;

namespace PracticeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var arr = new string[] { "A", "B", "C", "D","E" };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            int num = 0;
            while (num<arr.Length)
            {
                Console.WriteLine(arr[num]);
                num++;
            }


            int[] nums = { 23, 10, 44, 50, -2, 75 };

            foreach(int item in nums)
            {
                if (item < 0)
                    continue;

                Console.WriteLine(item);
            }

            string[] names = { "Abbas", "Hikmet","Qezenfer", "Nezrin" };
           
            int longest = 0;
            foreach(string item in names)
            {
                if (item.Length > longest)
                {
                    longest = item.Length;
                }
            }
            Console.WriteLine(longest);



            string answer = null;

            int attempt = 0;
            bool isBlocked = false;

            do
            {
                attempt++;

                if (attempt == 4)
                {
                    isBlocked = true;
                    break;
                }

                Console.WriteLine("cavabinizi daxil edin (he/yox)");
                answer = Console.ReadLine();
            }
            while (answer != "he" && answer != "yox");


            if (isBlocked)
            {
                Console.WriteLine("Bloklandiniz");
            }
            else
            {
                Console.WriteLine($"answer: {answer}");
            }
        }
    }
}
