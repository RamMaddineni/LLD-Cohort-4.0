
// Singleton (one thread)
using LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.Assignment1;
using LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.BuilderDesignPattern;
using LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.AbstractFactory;
using LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Factory;
using LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.SimpleFactory;
using LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.WithoutFactory;
using LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.SingletonPattern.NonThreadSafeSingleton;
using LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.SingletonPattern.Singleton;
using LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.SingletonPattern.ThreadSafeSingleton;

LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.SingletonPattern.Singleton.Run.Start();

// prooving that normal singleton will fail in multi threading.
LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.SingletonPattern.NonThreadSafeSingleton.Run.Start();

// Multi thread safe singleton
//locks the shared resource, until _instance is not created. (locking will be for some intial time, which helps us to not unncessarily lock things)
LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.SingletonPattern.ThreadSafeSingleton.Run.Start();



// Builder pattern.
LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.BuilderDesignPattern.Run.Start();

// Object creation using if/else (without factory pattern)
LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.WithoutFactory.Run.Start();

// Object creation using simple factory.
LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.SimpleFactory.Run.Start();

// Object creation using factory method.
LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Factory.Run.Start();


// Assignment on Singleton, Builder, Factory Design Patterns
Client.Start();

// Abstract Factory Design Pattern
LLD_Cohort_4._0.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.AbstractFactory.Run.Start();

// Decorator Design Pattern
LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.DecoratorDesignPattern.Run.Start();