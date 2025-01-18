public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int len = nums.Length;
        int[] res = new int[len];

        int prefix = 1;

        for(int i = 0; i < len; i++)
        {
            res[i] = prefix;
            prefix *= nums[i];
        }


        int postfix = 1;
        for(int i = len -1; i>= 0; i--)
        {
            res[i] *= postfix;
            postfix *= nums[i];
     
        }

        return res;
    }
}
