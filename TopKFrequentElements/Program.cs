var input = new[]
{
    1, 1, 1, 2, 2, 3
};

var obj = new Solution();
var res = obj.TopKFrequent(input, 2);

Console.WriteLine(string.Join(",", res));

public class Solution
{
    private Dictionary<int, int> mp = new();

    public int[] TopKFrequent(int[] nums, int k)
    {
        foreach (var num in nums)
        {
            if (!mp.TryAdd(num, 1))
            {
                mp[num]++;
            }
        }

        var heap = new PriorityQueue<int, int>();

        foreach (var kv in mp)
        {
            heap.Enqueue(kv.Key, kv.Value);
            if (heap.Count > k)
            {
                heap.Dequeue();
            }
        }
        
        List<int> res = new List<int>();
        while (heap.Count > 0)
        {
            res.Insert(0, heap.);
        }
    }
}