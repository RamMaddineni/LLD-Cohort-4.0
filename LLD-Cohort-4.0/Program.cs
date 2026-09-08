
// Singleton (one thread)
LLD_Cohort_4._0.DesignPatterns.SingletonPattern.Singleton.Run.Start();

// prooving that normal singleton will fail in multi threading.
LLD_Cohort_4._0.DesignPatterns.SingletonPattern.NonThreadSafeSingleton.Run.Start();

// Multi thread safe singleton
//locks the shared resource, until _instance is not created. (locking will be for some intial time, which helps us to not unncessarily lock things)
LLD_Cohort_4._0.DesignPatterns.SingletonPattern.ThreadSafeSingleton.Run.Start();



// Builder pattern.
LLD_Cohort_4._0.DesignPatterns.BuilderDesignPattern.Student.Run.Start();

// Object creation using if/else (without factory pattern)
LLD_Cohort_4._0.DesignPatterns.FactoryDesignPattern.WithoutFactory.Run.Start();

// Object creation using simple factory.
LLD_Cohort_4._0.DesignPatterns.FactoryDesignPattern.SimpleFactory.Run.Start();

// Object creation using factory method.
LLD_Cohort_4._0.DesignPatterns.FactoryDesignPattern.Factory.Run.Start();


// Assignment on Singleton, Builder, Factory Design Patterns
LLD_Cohort_4._0.DesignPatterns.Assignment1.Client.Start();