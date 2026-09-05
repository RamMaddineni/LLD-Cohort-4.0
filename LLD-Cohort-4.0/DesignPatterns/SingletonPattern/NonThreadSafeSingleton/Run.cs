namespace LLD_Cohort_4._0.DesignPatterns.SingletonPattern.NonThreadSafeSingleton
{
    internal class Run
    {
        public static void Start()
        {
            NonThreadSafeSingleton? s1 = null;
            NonThreadSafeSingleton? s2 = null;

            using var StartGate = new ManualResetEventSlim(false);
            var thread1 = new Thread(() =>
            {
                StartGate.Wait();
                s1 = NonThreadSafeSingleton.GetInstance();
            });

            var thread2 = new Thread(() =>
            {
                StartGate.Wait();
                s2 = NonThreadSafeSingleton.GetInstance();
            });

            thread1.Start();
            thread2.Start();

            StartGate.Set();
            thread1.Join();
            thread2.Join();
            if (s1 == s2)
            {
                Console.WriteLine("Multi Thread singleton works without issues");
            }
            else
            {
                Console.WriteLine("Multi Threaded Singleton Failed!");
            }

        }
    }
}
