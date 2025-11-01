var obj = new Solution();

var arr1 = new int[][]
{
    [1, 3],
    [2, 6],
    [8, 10],
    [15, 18]
};

var arr2 = obj.Merge(arr1);

foreach (int[] interval in arr2) {
    Console.WriteLine(interval[0] + " " + interval[1]);
}

public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        
        List<int[]> res = new List<int[]>();
        res.Add([intervals[0][0], intervals[0][1]]);

        for (int i = 1; i < intervals.Length; i++)
        {
            var last = res[^1];
            var curr = intervals[i];

            if (last[1] >= curr[0])
            {
                last[1] = Math.Max(last[1], curr[1]);
            }
            else
            {
                res.Add([curr[0], curr[1]]);
            }
        }
        
        return res.ToArray();
    }
}