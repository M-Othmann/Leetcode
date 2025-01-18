public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int l_multi = 1;
        int r_multi = 1;

        int n = nums.Length;
        int[] l_arr = [];
        int[] r_arr = [];
        int[] res = [];

        for(int i = 0; i < n; i++)
        {
            int j = -i - 1;
            l_arr[i] = l_multi;
            r_arr[j] = r_multi;

            l_multi *= nums[i];
            r_multi *= nums[j];
             
        }

        foreach(int l in l_arr)
        {
            foreach(int r in r_arr)
            {
                res.Append(l * r);
            }
        }
        return res;
    }
}