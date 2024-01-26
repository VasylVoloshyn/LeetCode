namespace TestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
          
            var nums = new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var result = solution.MaxSubArray(nums);
            
        }

    }

    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSum = 0;
            int curSumm = 0;
            bool subUrrayIsPositive = false;
            if (nums.Length == 1 && nums[0] < 0)
            {
                maxSum = nums[0];
            }
            else if (nums.Length == 2 && nums.All(o => o < 0))
            {
                maxSum = nums.Max();
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {

                    if (nums[i] > 0)
                    {
                        curSumm = curSumm + nums[i];
                        if (curSumm > maxSum)
                        {
                            maxSum = curSumm;
                        }
                    }

                    if (nums[i] < 0)
                    {
                        subUrrayIsPositive = false;
                        if (curSumm + nums[i] > 0)
                        {
                            curSumm = curSumm + nums[i];
                            subUrrayIsPositive = true;
                        }

                        if (!subUrrayIsPositive)
                        {
                            curSumm = 0;
                        }
                    }
                }
            }
            return maxSum;
        }
    }

}