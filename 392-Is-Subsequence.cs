public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s == \\)
            return true;
        if (s.Length > t.Length)
            return false;

        int j = 0;

        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] == s[j])
            {
                if (j == s.Length - 1)
                    return true;
                j++;
            }
        }

        return false;
    }
}