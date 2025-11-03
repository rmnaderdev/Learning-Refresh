using System.Collections.Concurrent;

class Program
{
    static ConcurrentQueue<int> PendingQueue = new ConcurrentQueue<int>();
    static int TotalConsumerThreads = Environment.ProcessorCount;
    static int TotalItemsToProcess = int.MaxValue;


    // Instead of a lock, a ConcurrentDictionary<int, byte> can also be used here as a hashset
    private static ConcurrentDictionary<int, byte> ProcessedItems = new ConcurrentDictionary<int, byte>();

    static void Main()
    {
        List<Thread> consumers = new List<Thread>();

        Enumerable.Range(1, TotalConsumerThreads)
            .ToList()
            .ForEach(consumer =>
            {
                var t = new Thread(Consumer);
                t.Name = consumer.ToString();
                consumers.Add(t);
            });

        Thread producerThread = new Thread(Producer);

        producerThread.Start();
        Thread.Sleep(500);
        foreach (var consumer in consumers)
        {
            consumer.Start();
        }

        producerThread.Join();
        foreach (var consumer in consumers)
        {
            consumer.Join();
        }
    }

    static void Producer()
    {
        for (int i = 0; i < TotalItemsToProcess; i++)
        {
            PendingQueue.Enqueue(i);
            Console.WriteLine($"Produced: {i}");
        }
    }

    static void Consumer()
    {
        // No lock is needed to read from ProcessedItems
        while (ProcessedItems.Count < TotalItemsToProcess)
        {
            if (!PendingQueue.IsEmpty && PendingQueue.TryDequeue(out int num))
            {
                if (!ProcessedItems.TryAdd(num, 0))
                {
                    throw new Exception($"{num} has already been processed");
                }
                
                Console.WriteLine($"[{Thread.CurrentThread.Name}] {num} has been processed");
            }
        }

        Console.WriteLine($"{Thread.CurrentThread.Name} finished");
    }
}