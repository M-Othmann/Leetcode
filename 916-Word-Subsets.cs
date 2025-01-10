public class Solution
{
    public IList<string> WordSubsets(string[] words1, string[] words2)
    {
        int[] maxChar = new int[26];
        foreach(var word in words2)
        {
            int[] currChar = new int[26];
            foreach(char ch in word)
            {
                currChar[ch - 'a']++;
            }

            for(int i = 0; i < 26; i++)
            {
                maxChar[i] = Math.Max(maxChar[i], currChar[i]);
            }

        }

        List<string> result = [];

        foreach (string w in words1)
        {
            int[] wordCount = new int[26];
            foreach (char c in w)
            {
                wordCount[c - 'a']++;
            }

            bool isUniversal = true;
            for (int i = 0; i < 26; i++)
            {
                if (wordCount[i] < maxChar[i])
                {
                    isUniversal = false;
                    break;
                }

            }

            if (isUniversal)
            {
                result.Add(w);
            }
        }


        return result;
    }
}