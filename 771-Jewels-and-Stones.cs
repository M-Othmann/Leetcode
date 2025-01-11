public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        int count = 0;
        HashSet<char> set = new HashSet<char>(jewels);

        foreach (char ch in stones)
        {
      
            if (set.Contains(ch))
                count++;
        }
        return count;
    }
}