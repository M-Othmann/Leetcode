public class Solution {
     public bool check(char c)
{
    return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9');
}
public bool IsPalindrome(string s)
{
    int l = 0;
    int r = s.Length - 1;
    s = s.ToLower();
    while(l < r)
    {


        while (l < r && !check(s[l]))
        {
            l += 1;
        }
            

        while (l < r && !check(s[r]))
            r -= 1;

        if (s[l] != s[r])
            return false;
        l += 1;
        r -= 1;

    }
    return true;







}
}