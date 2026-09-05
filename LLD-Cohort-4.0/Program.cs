
// Singleton (one thread)
LLD_Cohort_4._0.DesignPatterns.Singleton.Run.Start();

// prooving that normal singleton will fail in multi threading.
LLD_Cohort_4._0.DesignPatterns.NonThreadSafeSingleton.Run.Start();

// Multi thread safe singleton
//locks the shared resource, until _instance is not created. (locking will be for some intial time, which helps us to not unncessarily lock things)
LLD_Cohort_4._0.DesignPatterns.ThreadSafeSingleton.Run.Start();