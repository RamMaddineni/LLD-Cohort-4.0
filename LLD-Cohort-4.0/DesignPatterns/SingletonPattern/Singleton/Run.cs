namespace LLD_Cohort_4._0.DesignPatterns.SingletonPattern.Singleton
{
    internal class Run
    {
        public static void Start()
        {
            var s1 = SingletonDesignPattern.GetInstance();
            var s2 = SingletonDesignPattern.GetInstance();
            if (s1 == s2)
            {
                Console.WriteLine("SingleTon Works!");
            }
            else
            {
                Console.WriteLine("Singleton Failed!");
            }

        }
    }
}
