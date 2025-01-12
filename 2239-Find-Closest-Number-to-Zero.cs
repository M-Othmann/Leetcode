public class Solution
{
    public int FindClosestNumber(int[] nums)
    {
        int close = nums[0];
        foreach(int num in nums)
        {
            
            if (Math.Abs(num) <  Math.Abs(close))
                close = num;
        }

        if (close < 0 && nums.Contains(Math.Abs(close)))
            return Math.Abs(close);


        return close;
    }
}