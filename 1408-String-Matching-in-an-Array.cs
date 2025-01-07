public class Solution
{
    public IList<string> StringMatching(string[] words)
    {
        List<string> res = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            for(int j = 0; j < words.Length; j++)
            {
                if (i == j)
                    continue;

                if (words[i].Contains(words[j]) && !res.Contains(words[j]))
                {
                    res.Add(words[j]);
                    
                }
            }

 
        }

        return res;
    }
}