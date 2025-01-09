public class Solution
{
    public int PrefixCount(string[] words, string pref)
    {
        int count = 0;
        foreach(string w in words)
        {
            if (w.StartsWith(pref))
                count++;

        }
        return count;
    }
}