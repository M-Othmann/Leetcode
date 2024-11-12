public class Solution {
    public int LongestConsecutive(int[] nums) {
                var numset = nums.ToHashSet();

        int longest = 0;

        foreach (var n in numset)
        {
            //Check if its a start of a seqeuence
            if (!numset.Contains(n - 1))
            {
                int length = 0;
                while (numset.Contains(n + length))
                {
                    length += 1;
                }
                longest = int.Max(length,longest);
            }
        }
        


        return longest;
    }
}