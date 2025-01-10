public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        int len = word.Length;
        int upperCount = 0;

        foreach(char ch in word)
        {
            if (char.IsUpper(ch))
                upperCount++;
        }

        if(upperCount == len || upperCount == 0 || (word[0] >= 'A' && word[0] <= 'Z' && upperCount == 1))
        {
            return true;
        }

        return false;



       
    }
}