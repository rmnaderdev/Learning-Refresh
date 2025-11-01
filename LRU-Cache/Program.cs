LRUCache obj = new LRUCache(2);

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */

obj.Put(1, 1);
obj.Put(2, 2);
Console.WriteLine(obj.Get(1));    // return 1
obj.Put(3, 3);                     // evicts key 2
Console.WriteLine(obj.Get(2));    // returns -1 (not found)
obj.Put(4, 4);                     // evicts key 1
Console.WriteLine(obj.Get(1));    // return -1 (not found)
Console.WriteLine(obj.Get(3));    // return 3
Console.WriteLine(obj.Get(4));    // return 4
 
// Input
// ["LRUCache", "put", "put", "get",    "put",  "get",  "put",  "get",  "get",  "get"]
// [[2],        [1, 1],[2, 2],[1],      [3, 3], [2],    [4, 4], [1],    [3],    [4]]
// Output
// [null, null, null, 1, null, -1, null, -1, 3, 4]

public class LRUCache
{
    private LinkedList<int> _lruList;
    private Dictionary<int, (int value, LinkedListNode<int> node)> _cache;
    private int _capacity;
    
    public LRUCache(int capacity)
    {
        _lruList = new LinkedList<int>();
        _cache = new Dictionary<int, (int value, LinkedListNode<int> node)>();
        _capacity = capacity;
    }

    public int Get(int key)
    {
        // Check if key exists in cache
        if (!_cache.TryGetValue(key, out var cacheValue))
        {
            return -1;
        }

        // Move the accessed key to the front of the LRU linked list
        var (value, node) = cacheValue;
        _lruList.Remove(node);
        _lruList.AddFirst(node);
        
        // Update the node value in cache
        _cache[key] = (value, _lruList.First!);

        // Return cache value
        return value;
    }

    public void Put(int key, int value)
    {
        // Check if cache contains the key.
        if (_cache.ContainsKey(key))
        {
            // Update the value and move the key to the front of the LRU list
            var (_, node) = _cache[key];
            _lruList.Remove(node);
            _lruList.AddFirst(node);
            _cache[key] = (value, _lruList.First!);
        }
        else
        {
            if (_cache.Count >= _capacity)
            {
                // Remove the least recently used item
                var lruKey = _lruList.Last.Value;
                _lruList.RemoveLast();
                _cache.Remove(lruKey);
            }

            // Add the new key-value pair
            var newNode = new LinkedListNode<int>(key);
            _lruList.AddFirst(newNode);
            _cache[key] = (value, newNode);
        }
    }
}
