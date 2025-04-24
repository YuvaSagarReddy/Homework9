using System;
namespace HomeWork9
{
    public class Solution5
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                if (!counts.ContainsKey(num))
                {
                    counts[num] = 1;
                }
                else
                {
                    counts[num]++;
                }
            }

            int max = 0;
            int number = 0;

            foreach (var v in counts)
            {
                if (v.Value > max)
                {
                    max = v.Value;
                    number = v.Key;
                }
            }
            return number;
        }
    }
}

