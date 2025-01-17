public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        IList<string> range = [];
        int i = 0;
        while(i < nums.Length)
        {
            int start = nums[i];
            while(i < nums.Length-1 && nums[i] + 1 == nums[i+1])
            {
                i += 1;
            }

            if(start != nums[i])
            {
                range.Add($\{start}->{nums[i]}\);
            }
            else
            {
                range.Add($\{nums[i]}\);
            }

            i += 1;
        }

        return range;
    }
}