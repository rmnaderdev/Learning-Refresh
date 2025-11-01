class Program
{
    static Queue<int> queue = new Queue<int>();
    static int itemCount = 0;

    static void Main()
    {
        Thread producerThread = new Thread(Producer);
        Thread consumerThread1 = new Thread(Consumer);
        Thread consumerThread2 = new Thread(Consumer);
        

        producerThread.Start();
        consumerThread1.Start();
        consumerThread2.Start();

        producerThread.Join();
        consumerThread1.Join();
        consumerThread2.Join();
    }

    static void Producer()
    {
        for (int i = 0; i < 10; i++)
        {
            queue.Enqueue(i);
            Console.WriteLine($"Produced: {i}");
            Thread.Sleep(100);
        }
    }

    static void Consumer()
    {
        for (int i = 0; i < 10; i++)
        {
            if (queue.Count > 0)
            {
                int item = queue.Dequeue();
                Console.WriteLine($"Consumed: {item}");
            }
            Thread.Sleep(150);
        }
    }
}