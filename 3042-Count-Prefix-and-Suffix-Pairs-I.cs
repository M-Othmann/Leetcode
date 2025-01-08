public class Solution
{
    public int CountPrefixSuffixPairs(string[] words)
    {
        int count = 0;
        for (int i = 0; i < words.Length; i++)
        {
            for(int j = i+1; j<words.Length; j++)
            {

                if (words[j].StartsWith(words[i]) && words[j].EndsWith(words[i]))
                {
                    count++;
                }
            }
        }

        return count;
    }
}