public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        if (char.IsUpper(word[0]) && word.Substring(1) == word.Substring(1).ToLower())
            return true;

        if (word.ToUpper() == word)
            return true;

        if (word.ToLower() == word)
            return true;



        return false;
    }
}