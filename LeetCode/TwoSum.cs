namespace LeetCode
{
    public class TwoSum
    {
        public static int[] Sum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[0];
        }
        public static void Print(int[] nums)
        {
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*************");
        }
    }
}
