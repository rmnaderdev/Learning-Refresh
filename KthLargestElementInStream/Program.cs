
KthLargest kthLargest = new KthLargest(3, [4, 5, 8, 2]);
Console.WriteLine(kthLargest.Add(3));   // return 4
Console.WriteLine(kthLargest.Add(5));   // return 5
Console.WriteLine(kthLargest.Add(10));  // return 5
Console.WriteLine(kthLargest.Add(9));   // return 8
Console.WriteLine(kthLargest.Add(4));   // return 8

public class KthLargest
{
    private int _k;
    private PriorityQueue<int, int> _minHeap;
    
    public KthLargest(int k, int[] nums)
    {
        _k = k;
        _minHeap = new PriorityQueue<int, int>();

        foreach (var num in nums)
        {
            _minHeap.Enqueue(num, num);
            if (_minHeap.Count > k)
            {
                _minHeap.Dequeue();
            }
        }
    }

    public int Add(int val)
    {
        _minHeap.Enqueue(val, val);
        if (_minHeap.Count > _k)
        {
            _minHeap.Dequeue();
        }
        
        return _minHeap.Peek();
    }
}