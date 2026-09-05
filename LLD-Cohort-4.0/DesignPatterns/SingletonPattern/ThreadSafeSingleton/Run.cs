namespace LLD_Cohort_4._0.DesignPatterns.SingletonPattern.ThreadSafeSingleton
{
    internal class Run
    {
        public static void Start()
        {
            ThreadSafeSingleton? s1 = null;
            ThreadSafeSingleton? s2 = null;

            using var StartGate = new ManualResetEventSlim(false);
            var thread1 = new Thread(() =>
            {
                StartGate.Wait();
                s1 = ThreadSafeSingleton.GetInstance();
            });

            var thread2 = new Thread(() =>
            {
                StartGate.Wait();
                s2 = ThreadSafeSingleton.GetInstance();
            });

            thread1.Start();
            thread2.Start();

            StartGate.Set();
            thread1.Join();
            thread2.Join();
            if (s1 == s2)
            {
                Console.WriteLine("Thread Safe Mode : Multi Thread singleton works without issues");
            }
            else
            {
                Console.WriteLine("Multi Threaded Singleton Failed!");
            }

        }
    }
}
