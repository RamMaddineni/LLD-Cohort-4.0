# Design Patterns — Interview Answers from Your Repository

Source: [RamMaddineni/LLD-Cohort-4.0](https://github.com/RamMaddineni/LLD-Cohort-4.0). Reviewed 27 September 2026 at commit `4f0053d`.

Start with the definition, then explain your own example. Add the benefit if the interviewer wants more. Each answer below is phrased for speaking aloud; exact class names are anchors, not a script you must memorize word for word.

The repository contains 13 GoF pattern topics plus Simple Factory. Examples are based on source inspection; the project was not executed. Notes distinguish implemented behavior from incomplete demonstrations.

## Quick recall map

| Pattern | Memory cue |
| --- | --- |
| Singleton | One shared instance |
| Builder | Student built step by step |
| Simple Factory | One method selects Email or SMS |
| Factory Method | Email and SMS have separate factories |
| Abstract Factory | A matching Windows UI family |
| Adapter | Pay becomes MakePayment |
| Composite | Files and folders share GetSize |
| Decorator | Wrap an SMS with logging |
| Facade | One Login call coordinates services |
| Proxy | Check a site before connecting |
| Chain of Responsibility | Warning, then Error, then Fatal |
| Observer | Stock updates Phone and TV |
| State | ATM actions depend on its current state |
| Strategy | Switch a load-balancing algorithm |

## 1. Singleton · Creational

**Definition:** Ensures that a class has only one instance and provides a shared access point to it.

**My repo example:** In my singleton demo, GetInstance() keeps an object in a static _instance field and returns that stored reference on later calls. I also use this idea for TransactionLogger in Assignment1 so payment code can request a shared logger.

**Benefit:** Callers can reuse one instance when that lifetime is actually required.

**Likely follow-up:** Does Singleton make every method thread-safe? No. Safe instance creation and safe access to mutable instance data are separate concerns.

**Code note:** The singleton demos currently have public constructors. TransactionLogger also has an implicit accessible constructor. These allow callers in the assembly to create extra objects, so the code does not yet enforce the definition. A private constructor is required; synchronization also needs care.

Source: [SingletonDesignPattern.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/CreationalDesignPatterns/SingletonPattern/Singleton/SingletonDesignPattern.cs) · [ThreadSafeSingleton.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/CreationalDesignPatterns/SingletonPattern/ThreadSafeSingleton/ThreadSafeSingleton.cs) · [TransactionLogger.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/CreationalDesignPatterns/Assignment1/Logging/TransactionLogger.cs).

## 2. Builder · Creational

**Definition:** Separates an object's construction from the finished object, allowing it to be assembled step by step.

**My repo example:** In my Student example, I supply the name to StudentBuilder, optionally call setAge() and setAddress(), and finally call Build() to create the Student.

```csharp
Student student = new Student.StudentBuilder("Ram")
    .setAge(24)
    .setAddress("India")
    .Build();
```

**Benefit:** The call clearly names optional values and keeps construction steps together.

**Likely follow-up:** Is Builder required for immutability? No. Builder can help construct an immutable object, but constructors and read-only members can also provide immutability.

**Code note:** Your Build() currently copies the values without validation. Validation could be added there; it is not already implemented. The example is a fluent builder variation.

Source: [Student.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/CreationalDesignPatterns/BuilderDesignPattern/Student.cs) · [Run.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/CreationalDesignPatterns/BuilderDesignPattern/Run.cs).

## 3. Simple Factory · Creation idiom

**Definition:** Centralizes object creation in a method that selects a concrete implementation from an input.

**My repo example:** In my SimpleFactory folder, NotificationFactory.CreateNotification("sms") returns SMSNotification, while "email" returns EmailNotification. An unsupported type throws an ArgumentException.

**Benefit:** Callers do not need to repeat the creation conditions.

**Likely follow-up:** What happens when a new notification type is added? The central selection method must usually change.

**Code note:** Simple Factory is a common creation idiom, separate from the GoF Factory Method pattern.

Source: [NotificationFactory.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/CreationalDesignPatterns/FactoryDesignPattern/SimpleFactory/NotificationFactory.cs).

## 4. Factory Method · Creational

**Definition:** Delegates creation to a polymorphic factory method, letting concrete creators decide which product to return.

**My repo example:** In my Factory folder, NotificationFactory declares GetNotification(). EmailNotificationFactory returns EmailNotification, and Run.cs also uses SMSNotificationFactory to obtain an SMS notification. The caller uses the common factory and notification contracts.

**Benefit:** A new factory implementation can introduce another product without editing the existing factories.

**Likely follow-up:** Where does the concrete factory get selected? In setup or client code. Factory Method does not remove that decision; it separates it from product use.

**Code note:** Your version uses an interface-based creator contract. Classic GoF examples commonly show a base creator with an overridable creation method.

Source: [NotificationFactory.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/CreationalDesignPatterns/FactoryDesignPattern/Factory/NotificationFactory.cs) · [EmailNotificationFactory.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/CreationalDesignPatterns/FactoryDesignPattern/Factory/EmailNotificationFactory.cs) · [Run.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/CreationalDesignPatterns/FactoryDesignPattern/Factory/Run.cs).

## 5. Abstract Factory · Creational

**Definition:** Provides an interface for creating families of related objects without specifying their concrete classes.

**My repo example:** My I_UI_Factory creates a button, modal, and screen. WindowsFactory creates the Windows versions. UIRender receives the factory, and the demo switches to LinuxFactory through ToggleUI().

**Benefit:** The renderer can use a matching set of UI products while depending on their interfaces.

**Likely follow-up:** What is expensive to add? A new product kind, such as a menu, requires updating the factory contract and each concrete factory.

Source: [I_UI_Factory.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/CreationalDesignPatterns/FactoryDesignPattern/AbstractFactory/Interfaces/I_UI_Factory.cs) · [WindowsFactory.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/CreationalDesignPatterns/FactoryDesignPattern/AbstractFactory/Windows/WindowsFactory.cs) · [UIRender.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/CreationalDesignPatterns/FactoryDesignPattern/AbstractFactory/UIRender.cs) · [Run.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/CreationalDesignPatterns/FactoryDesignPattern/AbstractFactory/Run.cs).

## 6. Adapter · Structural

**Definition:** Converts an existing class's interface into the interface its client expects.

**My repo example:** My client expects IPaymentProcessor.Pay(amount), but the simulated StripePaymentGateway exposes MakePayment(amount). StripePaymentAdapter implements Pay() and delegates the call to MakePayment().

**Benefit:** The client can use the gateway through its existing payment contract.

**Likely follow-up:** How is this different from Facade? Adapter makes an interface compatible; Facade simplifies access to a subsystem.

**Code note:** StripePaymentGateway here is your local demonstration class, not an integration with the real Stripe SDK.

Source: [IPaymentProcessor.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/StructuralDesignPatterns/AdapterDesignPattern/IPaymentProcessor.cs) · [StripePaymentAdapter.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/StructuralDesignPatterns/AdapterDesignPattern/StripePaymentAdapter.cs) · [StripePaymentGateway.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/StructuralDesignPatterns/AdapterDesignPattern/StripePaymentGateway.cs).

## 7. Composite · Structural

**Definition:** Organizes objects into a tree so clients can treat individual objects and groups through the same abstraction.

**My repo example:** In my file-system example, File and Folder both inherit FileSystemNode. File.GetSize() returns its content length. Folder.GetSize() sums GetSize() over its children, which can themselves be files or folders.

**Benefit:** The same operation works on both a leaf and a whole subtree.

**Likely follow-up:** What are the roles? FileSystemNode is the component, File is the leaf, and Folder is the composite.

**Code note:** Your folder is named CompositionDesignPattern, but the pattern is Composite. The demo is partial: Run.Start() is empty and several operations throw NotImplementedException. Recursion supports this design; recursion alone does not define Composite.

Source: [FileSystemNode.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/StructuralDesignPatterns/CompositionDesignPattern/FileSystemNode.cs) · [File.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/StructuralDesignPatterns/CompositionDesignPattern/File.cs) · [Folder.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/StructuralDesignPatterns/CompositionDesignPattern/Folder.cs) · [Run.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/StructuralDesignPatterns/CompositionDesignPattern/Run.cs).

## 8. Decorator · Structural

**Definition:** Adds behavior to an individual object by wrapping it in another object that implements the same interface.

**My repo example:** In my notification demo, LoggingDecorator wraps RetryDecorator, which wraps SMSNotification. All expose INotification. LoggingDecorator writes a message before and after delegating Send(), so I can add logging without changing SMSNotification.

```csharp
INotification notification = new LoggingDecorator(
    new RetryDecorator(new SMSNotification()));
notification.Send("Hi there!");
```

**Benefit:** Wrappers can be composed to add selected behaviors without creating a subclass for every combination.

**Likely follow-up:** Which Send() is entered first? The outermost wrapper: LoggingDecorator. Constructor evaluation creates the inner objects first, but method calls enter from the outside.

**Code note:** RetryDecorator currently sends once and prints a retry message; it does not implement retry logic. In Assignment2, encryption is also simulated by appending text.

Source: [Run.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/StructuralDesignPatterns/DecoratorDesignPattern/Run.cs) · [LoggingDecorator.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/StructuralDesignPatterns/DecoratorDesignPattern/LoggingDecorator.cs) · [RetryDecorator.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/StructuralDesignPatterns/DecoratorDesignPattern/RetryDecorator.cs) · [EncryptionDecorator.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/StructuralDesignPatterns/Assignment2/Notification/EncryptionDecorator.cs).

## 9. Facade · Structural

**Definition:** Provides a simple entry point to a subsystem with several collaborating components.

**My repo example:** My AuthenticationFacade.Login() calls PasswordValidator, OtpService, TokenService, and AuditLogger. The caller supplies login details and receives a token without coordinating those services itself.

**Benefit:** The client is less coupled to the subsystem's steps and collaborators.

**Likely follow-up:** Does Facade have to implement the subsystem's interfaces? No. It can expose a new, higher-level operation such as Login().

**Code note:** Password and OTP validation are demonstration stubs that currently return true.

Source: [AuthenticationFacade.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/StructuralDesignPatterns/FacadeDesignPattern/AuthenticationFacade.cs) · [PasswordValidator.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/StructuralDesignPatterns/FacadeDesignPattern/PasswordValidator.cs) · [OtpService.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/StructuralDesignPatterns/FacadeDesignPattern/OtpService.cs).

## 10. Proxy · Structural

**Definition:** Provides a substitute for another object to control access to that object.

**My repo example:** My ProxyInternet and RealInternet both implement IInternet. ProxyInternet checks the host against a banned-site list. It blocks banned.com and forwards allowed requests to RealInternet.ConnectTo().

**Benefit:** Access checks can sit in front of the real service while the caller uses the same interface.

**Likely follow-up:** How is this different from Decorator? The intent here is controlling access. My Decorator example adds composable notification behavior. Their wrapper structures can look similar.

**Code note:** This is a protection-proxy demo. It eagerly creates RealInternet, so it does not demonstrate lazy initialization.

Source: [ProxyInternet.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/StructuralDesignPatterns/ProxyDesignPattern/ProxyInternet.cs) · [RealInternet.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/StructuralDesignPatterns/ProxyDesignPattern/RealInternet.cs) · [Run.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/StructuralDesignPatterns/ProxyDesignPattern/Run.cs).

## 11. Chain of Responsibility · Behavioral

**Definition:** Passes a request along a chain of handlers, each deciding whether to handle it or forward it.

**My repo example:** My chain is WarningHandler, then ErrorHandler, then FatalHandler. For a level-4 request, WarningHandler and ErrorHandler forward it, and FatalHandler handles it. The client starts the request at the head of the chain.

**Benefit:** The sender does not need to select the eventual handler directly.

**Likely follow-up:** Is handling guaranteed? No. The chain needs an explicit outcome when no handler accepts the request; my FatalHandler prints an escalation for level 6 and above.

**Code note:** With this chain order, warning handles levels below 2, error handles 2–3, and fatal handles 4–5. The checks are upper bounds, so directly invoking FatalHandler with level 1 also handles it.

Source: [Run.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/BehaviouralDesignPatterns/ChainOfResponsibilityDesignPattern/Run.cs) · [WarningHandler.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/BehaviouralDesignPatterns/ChainOfResponsibilityDesignPattern/WarningHandler.cs) · [ErrorHandler.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/BehaviouralDesignPatterns/ChainOfResponsibilityDesignPattern/ErrorHandler.cs) · [FatalHandler.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/BehaviouralDesignPatterns/ChainOfResponsibilityDesignPattern/FatalHandler.cs).

## 12. Observer · Behavioral

**Definition:** Defines a one-to-many subscription relationship so a subject can notify its observers when its state changes.

**My repo example:** My Stock keeps a list of IObserver objects. Phone and TV subscribe. When SetStockPrice(6) changes the price, both receive NotifyMe(6). The demo then removes TV, so the next change to 7 reaches only Phone.

**Benefit:** Stock can notify subscribers without depending on the concrete Phone and TV classes.

**Likely follow-up:** Are these notifications asynchronous? No. My implementation directly calls each observer in a loop, so delivery is synchronous.

**Code note:** Setting the same price again does not notify observers because SetStockPrice checks whether the value changed.

Source: [Stock.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/BehaviouralDesignPatterns/ObserverDesignPattern/Stock.cs) · [IObserver.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/BehaviouralDesignPatterns/ObserverDesignPattern/IObserver.cs) · [Run.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/BehaviouralDesignPatterns/ObserverDesignPattern/Run.cs).

## 13. State · Behavioral

**Definition:** Lets an object change its behavior when its internal state changes by delegating actions to state objects.

**My repo example:** My ATMMachine delegates actions to an IATMState. In NoCardState, DispenseCash() asks for a card. Inserting a card transitions to HasCardState, where dispensing transitions to MoneyDispenseState.

**Benefit:** Each state owns its action behavior and transitions instead of spreading state checks across the ATM methods.

**Likely follow-up:** How does this differ from Strategy? State represents the object's current situation and its transitions; Strategy represents a selected way to perform a task.

**Code note:** The state classes contain behavior, but Run.Start() currently does not create or exercise an ATM. Cash dispensing is represented by console output.

Source: [ATMMachine.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/BehaviouralDesignPatterns/StateDesignPattern/ATMMachine.cs) · [NoCardState.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/BehaviouralDesignPatterns/StateDesignPattern/NoCardState.cs) · [HasCardState.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/BehaviouralDesignPatterns/StateDesignPattern/HasCardState.cs) · [Run.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/BehaviouralDesignPatterns/StateDesignPattern/Run.cs).

## 14. Strategy · Behavioral

**Definition:** Encapsulates alternative algorithms behind a common interface so the algorithm used by a client can be replaced.

**My repo example:** My LoadBalancer depends on ILoadBalancingStrategy. The demo starts with RoundRobinStrategy, calls SendRequest(), then switches to LeastConnectionStrategy with SetStrategy() and sends again.

**Benefit:** The load balancer can delegate to a different algorithm without changing its SendRequest() method.

**Likely follow-up:** Does Strategy require switching at runtime? No. A strategy can also be selected once during construction.

**Code note:** This demonstrates strategy selection and delegation. Both strategies currently only print messages, and LoadBalancer._servers is uninitialized; actual server selection is not implemented.

Source: [LoadBalancer.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/BehaviouralDesignPatterns/StrategyDesignPattern/LoadBalancer.cs) · [Run.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/BehaviouralDesignPatterns/StrategyDesignPattern/Run.cs) · [RoundRobinStrategy.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/BehaviouralDesignPatterns/StrategyDesignPattern/RoundRobinStrategy.cs) · [LeastConnectionStrategy.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/BehaviouralDesignPatterns/StrategyDesignPattern/LeastConnectionStrategy.cs).

## Combining patterns in one explanation

Your Assignment2 is a useful follow-up example: NotificationServiceFacade exposes SendOrderPlaced(user); FirebaseAdapter converts INotification.Send() into FirebaseSend(); decorators wrap the adapted notification. Each pattern has a separate purpose: the facade coordinates the workflow, the adapter makes the API compatible, and decorators add behavior around the send operation.

The facade constructs the email and Firebase notification pipelines. Retry is a placeholder and the encryption decorator appends text; describe them as demonstrations of where those behaviors would go.

Source: [NotificationServiceFacade.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/StructuralDesignPatterns/Assignment2/Notification/NotificationServiceFacade.cs) · [FirebaseAdapter.cs](https://github.com/RamMaddineni/LLD-Cohort-4.0/blob/4f0053d72d908a2212120c1f0aaba3a523988035/LLD-Cohort-4.0/DesignPatterns/StructuralDesignPatterns/Assignment2/Adapters/FirebaseAdapter.cs).

## A small revision routine

1. Pick three pattern names and hide the answers.
2. For each, say the definition and your repository example aloud in about 30–45 seconds.
3. Check only what you missed, then try that answer once more.
4. On another day, mix the patterns and answer one follow-up per pattern.

Use this sentence frame: “This pattern ____. In my repo, ____ calls/creates/wraps ____. This helps because ____.”

Start with Builder, Adapter, and Observer: each has a concrete example you can picture quickly.

