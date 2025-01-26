public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Length == 0) return intervals;

        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));

        List<int[]> merged = new List<int[]>();

        foreach (int[] i in intervals)
        {
            if(merged.Count == 0 || merged.Last()[1] < i[0])
            {
                merged.Add(i);
            }
            else
            {
                merged.Last()[1] = Math.Max(merged.Last()[1], i[1]);
            }
        }
        return merged.ToArray();
    }

}