using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 1,3,2,1,3,2,2};
            //int[] nums = { 18, 43, 36, 13, 7 };
            //int[] nums = { 10, 12, 19, 14 };
            //int[] nums = { 4, 6, 10, 6 };
            int[] nums = { 229, 398, 269, 317, 420, 464, 491, 218, 439, 153, 482, 169, 411, 93, 147, 50, 347, 210, 251, 366, 401 };

        // var x = NumberOfPairs(nums);
        var x = MaximumSum(nums);
            //Console.WriteLine(x[0]);
            //Console.WriteLine(x[1]);
            Console.ReadLine(); 

        }
        public static int[] NumberOfPairs(int[] nums)
        {
            //store in HashMap
             var hashMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (hashMap.ContainsKey(nums[i]))
                {
                    hashMap[nums[i]] = hashMap[nums[i]] + 1;
                }
                else
                    hashMap[nums[i]] = 1;
            }

            int count = 0;
            //keep removing pair
            while(hashMap.Any(x => x.Value >= 2))
            {
                var key = hashMap.Where(x => x.Value >= 2).First().Key;
                hashMap[key] -= 2;
                count++;
            }
            int[] arr = new int[2];
            arr[0] = count;
            arr[1] = nums.Length - (2*count);

            return arr;
        }


        public static int MaximumSum(int[] nums)
        {
            int max = -1;
            var arr = new int[nums.Length];
            var hashMap = new Dictionary<int, int>();
            var list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int n = nums[i];
                int sum = 0;
                while (n != 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                arr[i] = sum;
                list.Add(sum);
                if (hashMap.ContainsKey(sum))
                {
                    hashMap[sum] = hashMap[sum] + 1;
                }
                else
                    hashMap[sum] = 1;
            }

            //iteate
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    // if(hashMap.ElementAt(i).Value == hashMap.ElementAt(j).Value)
                    if (list[i] == list[j])
                    {
                        if (max < (list[i] + list[j]))
                            max = nums[i] + nums[j];
                    }
                }
            }
            return max;
        }
    }
}
