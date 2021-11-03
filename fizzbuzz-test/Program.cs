using System;
using System.Collections.Generic;

namespace fizzbuzz_test
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;

                if (fizz)
                {
                    if (buzz)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine("Fizz");
                    }
                }
                else if (buzz)
                {
                    Console.WriteLine("Buzz");
                }
                else
                { 
                    Console.WriteLine(i);
                }
            }
        }


        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> temp = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int left = target - nums[i];
                if (temp.ContainsKey(left))
                {
                    return new int[] { temp[left], i };
                }
                if (!temp.ContainsKey(nums[i]))
                {
                    temp.Add(nums[i], i);
                }
            }
            return null;
        }
    }
}
