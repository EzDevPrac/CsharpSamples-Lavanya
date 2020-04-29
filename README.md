[![Build Status](https://dev.azure.com/lavanyakgf8840615/CsharpSample/_apis/build/status/EzDevPrac.CsharpSamples-Lavanya%20(1)?branchName=master)](https://dev.azure.com/lavanyakgf8840615/CsharpSample/_build/latest?definitionId=2&branchName=master)
# Design Pattern

## Observer Design Pattern

1.The Observer Design Pattern in which an object maintains a list of its dependents and notifies them automatically whenever any state changes by calling one of their methods.

2.The Observer Design Pattern defines a one-to-many dependency between objects so that when one objects state changes, all its dependents are notified and updated automatically.

### Diagram of Observer Pattern

![alt text](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/49e1fca1bd898c7784d2b20732ad0fb9/image.png)

1.`Subject` They are the publishers. When a change occurs to a subject it should notify all of its subscribers.

2.`Observers` They are the subscribers. They simply listen to the changes in the subjects.

### Example code

**Creating the Subject interface**

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
        public interface ISubject
        {
            string RegisterObserver(IObserver observer);
            string RemoveObserver(IObserver observer);
            void NotifyObservers();
        }
}

```
**Creating Concrete Subject**
```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
        public class Subject : ISubject
        {
            private List<IObserver> observers = new List<IObserver>();
            private string Month { get; set; }
            private int SalaryInRs { get; set; }
            private string SalaryStatus { get; set; }

            public Subject(string month, int salaryInrs, string salarystatus)
            {
                   Month = month;
                  SalaryInRs = salaryInrs;
                  SalaryStatus = salarystatus;
            }

            public string getSalaryStatus()
            {
                return SalaryStatus;
            }

            public string setSalaryStatus(string salarystatus)
            {
                   this.SalaryStatus = salarystatus;
                    NotifyObservers();
                   return "Salary status changed";
            }

            public string RegisterObserver(IObserver observer)
            {
                Console.WriteLine("Employee Added : " + ((User)observer).UserName);
                observers.Add(observer);
            return "employee add successfuly";
            }

            public void AddObservers(IObserver observer)
            {
                observers.Add(observer);
            }

            public string RemoveObserver(IObserver observer)
            {
                observers.Remove(observer);
                return "Removed successfully"; 
            }

            public void NotifyObservers()
            {
                Console.WriteLine("\n Month: "+Month+"\n Rs: "+ SalaryInRs + "\n Salary Status:"+SalaryStatus +" \n So notifying all employees ");

                foreach (IObserver observer in observers)
                {
                    observer.update(SalaryStatus);
                }
            }
        }
}
```
**Creating Observer Interface**
```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{

        public interface IObserver
        {
            string update(string availability);
        }
    
}
```

**Creating Concrete Observer**
```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{ 
        public class User : IObserver
        {
            public string UserName { get; set; }

            public User(string userName, ISubject subject)
            {
                UserName = userName;
                subject.RegisterObserver(this);
            }

            public string update(string status)
            {
                Console.WriteLine("Hello " + UserName + ",your salary is " + status + " enjoy.");
                return "Updated sucess";
            }
        }
    
}
```
**Client code**

```csharp
using System;

namespace ObserverPattern
{

        class Program
        {
            static void Main(string[] args)
            {
                Subject april = new Subject("April", 10000, "Not Done");
                User user1 = new User("Lavanya", april);

                User user2 = new User("Tereena", april);

                User user3 = new User("Raju", april);

                Console.WriteLine("April Month current Salary status : " + april.getSalaryStatus());
                Console.WriteLine();

            
            april.setSalaryStatus("Done");

                Console.Read();
            }
        }
}

```
**Output**
![alt text](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/835e6d3e3b0f644dfd127287e49601a6/image.png)



## Decorator Design Pattern
 1.The Decorator Design Pattern allows us to dynamically add new functionalities to an existing object without altering or modifying its  structure.
 
2.This design pattern acts as a wrapper to the existing class.

3.Decorator design pattern adds additional functionalities to the object by wrapping it.

4.The Decorator Design Pattern provides an alternative approach to inheritance for modifying the behavior of an object. When we use inheritance to extend the behavior of a class, then this takes place at compile time.

**UML Diagram of Decorator Design Pattern**
![alt text](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/fb5229168f42633d3e05cd75b33cb093/image.png)

`Component:` This interface contains members that are going to be implemented by the concrete component classes and decorator classes.

`ConcreteComponent:` This class simply implements the Component interface.

`Decorator:` This class implements the Component interface and contains a reference to a component instance. This class also acts as the base class for all decorators. The decorator is essentially wrapping the Component.

`ConcreteDecoratorA / ConcreteDecoratorB:` These are concrete classes and inherited from the Decorator abstract class. This class adds the additional responsibility to the original component.



### Example Code

**Creating the Car interface**

```csharp
 namespace DecoratorDesignPattern
{
    public interface ICar
    {
        ICar ManufactureCar();
    }
}
```
**Creating Concrete Car**

```csharp
using System;
namespace DecoratorDesignPattern
{
    public class BMWCar : ICar
    {
        private string CarName = "BMW";
        public string CarBody { get; set; }
        public string CarDoor { get; set; }
        public string CarWheels { get; set; }
        public string CarGlass { get; set; }
        public string Engine { get; set; }

        public override string ToString()
        {
            return "\n CarName=" + CarName + "\n CarBody=" + CarBody + "\n CarDoor=" + CarDoor + "\n CarWheels="
                            + CarWheels + "\n CarGlass=" + CarGlass + "\n Engine=" + Engine ;
        }

        public ICar ManufactureCar()
        {
            CarBody = "carbon fiber material";
            CarDoor = "4 car doors";
            CarWheels ="4 MRF wheels";
            CarGlass = "6 car glasses";
            return this;
        }
    }
}
```
**Creating Car Decorator**
```csharp
namespace DecoratorDesignPattern
{
    public abstract class CarDecorator : ICar
    {
        protected ICar car;
        public CarDecorator(ICar car)
        {
            this.car = car;
        }

        public virtual ICar ManufactureCar()
        {
            return car.ManufactureCar();
        }
    }
}
```
**Creating Diesel Car Decorator**
```charp
using System;
namespace DecoratorDesignPattern
{
    public class DieselCarDecorator : CarDecorator
    {
        public DieselCarDecorator(ICar car) : base(car)
        {
        }

        public override ICar ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return car;
        }

        public void AddEngine(ICar car)
        {
            if (car is BMWCar)
            {
                BMWCar BMWCar = (BMWCar)car;
                BMWCar.Engine = "Diesel Engine";
                Console.WriteLine("DieselCarDecorator added Diesel Engine to the Car : " + car);
            }
        }
    }
}
```
**Client code**
```csharp
using System;
namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar bmwCar1 = new BMWCar();
            bmwCar1.ManufactureCar();
            Console.WriteLine(bmwCar1 + "\n");

            DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bmwCar1);
            carWithDieselEngine.ManufactureCar();

            Console.WriteLine();

            ICar bmwCar2 = new BMWCar();

            PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
            carWithPetrolEngine.ManufactureCar();

            Console.ReadKey();
        }
    }
}
```
**OutPut**

![alt text](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/c3f362a785677a3372a59e18c9965b9b/image.png)

## Singleton Design Pattern
1. We need to use the Singleton Design Pattern when we need to ensures that only one instance of a particular class is going to becreated and then provide simple global access to that instance for the entire application.

2. The most important advantage of using the singleton design pattern in C# is that it takes care of concurrent access to the shared resource. That means if we are sharing a resource with multiple clients simultaneously, then concurrent access to that resource is well managed by the singleton design pattern.

3. To share common data i.e. master data and configuration data which is not changed that frequently in an application. In that case we    need to cache the objects in memory.

### Diagram of Singleton Design Pattern

![alt text](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/27071ec0695a167a4cdd2c0b6b5b8988/image.png)

### There are many ways,we can implement the Singleton Design Pattern in C# are as follows.

1.No Thread-Safe Singleton design pattern.

2.Thread-Safety Singleton implementation.

3.The Thread-Safety Singleton Design pattern implementation using Double-Check Locking.

4.Thread-Safe Singleton Design pattern implementation without using the locks and no lazy instantiation.

5.Fully lazy instantiation of the singleton class.

###  we will see example code for all the ways
**1.No Thread-Safe Singleton design pattern**
```csharp
namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
        
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
```
The way we implement the singleton design pattern in the above example is not to thread-safe. It means in a multithreaded environment, it will able to create multiple instances of the singleton class.

**2.Thread-Safety Singleton implementation**
```csharp
namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly object Instancelock = new object();
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static Singleton instance = null;
       
        public static Singleton GetInstance
        {
            get
            {
                lock (Instancelock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }
        
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
```

But the problem with this code is slow down your application as only one thread can access the GetInstance property at any given point of time.

**3.The Thread-Safety Singleton Design pattern implementation using Double-Check Locking**

```csharp
namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly object Instancelock = new object();
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static Singleton instance = null;
       
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (Instancelock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }

                    }
                }
                return instance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
```
**4.Singleton Design pattern using Eager Loading**

```csharp
namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static int counter = 0;

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        private static readonly Singleton singleInstance = new Singleton(); 
        
        public static Singleton GetInstance
        {
            get
            {
                return singleInstance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
```
The advantage of using Eager Loading in the Singleton design pattern is that the CLR (Common Language Runtime) will take care of object initialization and thread-safety.

### Reference
https://github.com/EzDevPrac/CsharpSamples-Lavanya



## Facade Design Pattern
> Facade is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.

**UML diagram of Facade Design Pattern**

![alt text](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/99a57b3dae49876f959f5c5c8c26f55c/image.png)

`Façade class` The Façade class knows which subsystem classes are responsible for a given request and then it delegates the client requests to appropriate subsystem objects.

`SubSysyem Class` The Subsystem classes Implement their respective functionalities assigned to them and these subsystems do not have any knowledge of the facade.

**Example code**

### Creating subsystems
**Product.cs**
```csharp
using System;
namespace FacadeDesignPattern
{
    public class Product
    {
        public void GetProductDetails()
        {
            Console.WriteLine("Fetching the Product Details");
        }
    }
}
```
**Payment**
```csharp
using System;
namespace FacadeDesignPattern
{
    public class Payment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment Done Successfully");
        }
    }
}
```
**Invoice**
```csharp
using System;
namespace FacadeDesignPattern
{
    public class Invoice
    {
        public void Sendinvoice()
        {
            Console.WriteLine("Invoice Send Successfully");
        }
    }
}
```
**Creating Facade**
```csharp
using System;
namespace FacadeDesignPattern
{
    public class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");
            Product product = new Product();
            product.GetProductDetails();
            Payment payment = new Payment();
            payment.MakePayment();
            Invoice invoice = new Invoice();
            invoice.Sendinvoice();
            Console.WriteLine("Order Placed Successfully");
        }
    }
}
```
**Client**
```csharp
using System;
namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.PlaceOrder();
            Console.Read();
        }
    }
}
```
**Output**

![alt text](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/d79af598850b1456b8cfd52c6c2f10e3/image.png)

### Reference
https://github.com/EzDevPrac/CsharpSamples-Lavanya

## Factory Pattern

**Factory Design Pattern :**

>A factory is an object which is used for creating other objects. we can say that a factory is a class with a method. That method will create and return different types of objects based on the input parameter, it received

>The basic principle behind the factory design pattern is that, at run time, we get an object of similar type based on the parameter we pass.


**UML Class Diagram**

![alt text](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/040410756edf4a8b5fdf8d3c446f7a0f/image.png)

`Product` This defines the interface of objects the factory method creates.
 
`ConcreteProduct` This is a class that implements the Product interface.

`Creator`This is an abstract class and declares the factory method, which returns an object of type Product.

`ConcreteCreator`This is a class that implements the Creator class and overrides the factory method to return an instance of a ConcreteProduct.

**Sample Code**

**Product**

```csharp 
 public interface Animal
    {
          string  speak();
          string  dance();
    }
```
**ConcreteProduct**

**Cat** 

```csharp 

namespace FactoryMethodDesignPattern
{

    public class Cat : Animal
    {
        public string speak()
        {
            return "Meow Meow";
        }
        public string dance()
        {
            return "Dam Dam";
        }
    }

}
```
**dog** 
```csharp
namespace FactoryMethodDesignPattern
{
  public  class Dog:Animal
    {
        public string speak()
        {
            return "Bark bark";
        }
        public string dance()
        {
            return "Ba Ba";
        }
    }
}
```
**Creator**
```csharp
 FactoryMethodDesignPattern
{
     abstract class AnimalFactory
    {
        protected abstract Animal MakeAnimal();
        public Animal CreateAnimal()
        {
            return this.MakeAnimal();
        }
    }
}
```
**ConcreteCreator**

```csharp
namespace FactoryMethodDesignPattern
{
    class CatFactory:AnimalFactory
    {
        protected override Animal MakeAnimal()
        {
            Animal animal = new Cat();
            return animal;
        }
    }
    class DogFactory : AnimalFactory
    {
        protected override Animal MakeAnimal()
        {
            Animal animal = new Dog();
            return animal;
        }
    }
}
```
**Factory Pattern Client Demo**

```csharp
namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = null;
            Console.WriteLine("Enter the animal you want to create :");

            string ani = Console.ReadLine();
            switch (ani.ToLower())
            {
                case "cat": 
                    animal = new CatFactory().CreateAnimal();
                    break;
                case "dog":
                    animal = new DogFactory().CreateAnimal();
                    break;
                default:
                    break;
            }
            if (animal != null)
            {
                Console.WriteLine("Animal Type : " + animal.GetType().Name);
                Console.WriteLine(animal.GetType().Name + " Speak : " + animal.speak());
                Console.WriteLine(animal.GetType().Name + " Dance like : " + animal.dance());

            }
            else
            {
                Console.Write("Invalid Animal Type");
            }
        }
    }
}
```
**Output**

![alt text](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/775112f9790f36df2ddda339317bb6cb/image.png)

### Reference
https://github.com/EzDevPrac/CsharpSamples-Lavanya

## Builder Pattern

**Builder Design Pattern** 

>Builder design pattern falls under the category of "Creational" design patterns. This pattern is used to build a complex object by using a step by step approach.

**UML Diagram For Builder Pattern**

![alt text](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/04f904a5d9422b9dba6cdc47c8332301/image.png)


###### Below are the main parts of the UML diagram,

`Builder `:This is an interface which is used to define all the steps required to create a product.
 
`ConcreteBuilder`:This is a class which implements the Builder interface to create a complex product.

`Product`:This is a class which defines the parts of the complex object which are to be generated by the Builder Pattern.

`Director` :This is a class that is used to construct an object using the Builder interface.

**Example code**

**Creating Product (Beverage)**
```csharp
namespace BuilderPatter
{
    public class Beverage
    {
        public int Water { get; set; }
        public int Milk { get; set; }
        public int Sugar { get; set; }
        public int PowderQuantity { get; set; }
        public string BeverageName { get; set; }
        
        public string ShowBeverage()
        {
            return "Hot " + BeverageName + " [" + Water + " ml of water, " + Milk + "ml of milk, " + Sugar
                            + " gm of sugar, " + PowderQuantity + " gm of " + BeverageName + "]\n";
        }
    }
}
```
**Creating Abstract Builder (BeverageBuilder)**

```csharp
namespace BuilderPatter
{
    public class Beverage
    {
        public int Water { get; set; }
        public int Milk { get; set; }
        public int Sugar { get; set; }
        public int PowderQuantity { get; set; }
        public string BeverageName { get; set; }
        
        public string ShowBeverage()
        {
            return "Hot " + BeverageName + " [" + Water + " ml of water, " + Milk + "ml of milk, " + Sugar
                            + " gm of sugar, " + PowderQuantity + " gm of " + BeverageName + "]\n";
        }
    }
}
```
**Creating Concrete Builder**

```csharp

        public class CoffeeBuilder : BeverageBuilder
    {
        public override void SetWater()
        {
            Console.WriteLine("Step 1 : Boiling water");
            GetBeverage().Water = 40;
        }

        public override void SetMilk()
        {
            Console.WriteLine("Step 2 : Adding milk");
            GetBeverage().Milk = 50;
        }

        public override void SetSugar()
        {
            Console.WriteLine("Step 3 : Adding Sugar");
            GetBeverage().Sugar = 10;
        }

        public override void SetPowderQuantity()
        {
            Console.WriteLine("Step 4 : Adding 15 Grams of coffee powder");
            GetBeverage().PowderQuantity = 15;
        }

        public override void SetBeverageType()
        {
            Console.WriteLine("Coffee");
            GetBeverage().BeverageName = "Coffee";
        }
    }

    public class TeaBuider : BeverageBuilder
    {
        public override void SetWater()
        {
            Console.WriteLine("Step 1 : Boiling water");
            GetBeverage().Water = 50;
        }
        public override void SetMilk()
        {
            Console.WriteLine("Step 2 : Adding milk");
            GetBeverage().Milk = 60;
        }
        public override void SetSugar()
        {
            Console.WriteLine("Step 3 : Adding Sugar");
            GetBeverage().Sugar = 15;
        }
        public override void SetPowderQuantity()
        {
            Console.WriteLine("Step 4 : Adding 20 Grams of coffee powder");
            GetBeverage().PowderQuantity = 20;
        }
        public override void SetBeverageType()
        {
            Console.WriteLine("Tea");
            GetBeverage().BeverageName = "Tea";
        }
    }
}
```
**Creating the Director (BeverageDirector)**

```csharp
namespace BuilderDesignPattern
{
    public class BeverageDirector
    {
        public Beverage MakeBeverage(BeverageBuilder beverageBuilder)
        {
            beverageBuilder.CreateBeverage();

            beverageBuilder.SetBeverageType();
            beverageBuilder.SetWater();
            beverageBuilder.SetMilk();
            beverageBuilder.SetSugar();
            beverageBuilder.SetPowderQuantity();
            
            return beverageBuilder.GetBeverage();
        }
    }
}
```
**Client Code**

```csharp
using System;
namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage;
            BeverageDirector beverageDirector = new BeverageDirector();
            
            TeaBuider tea = new TeaBuider();
            beverage = beverageDirector.MakeBeverage(tea);
            Console.WriteLine(beverage.ShowBeverage());

            CoffeeBuilder coffee = new CoffeeBuilder();
            beverage = beverageDirector.MakeBeverage(coffee);
            Console.WriteLine(beverage.ShowBeverage());

            Console.ReadKey();
        }
    }
}
```
**Outpt**

![alt text](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/a4cf3648a26b7ccfc4de7736cf159d5d/image.png)

### Reference
 https://github.com/EzDevPrac/CsharpSamples-Lavanya


## Command Design

**Command Design Pattern :**
 >The Command Design Pattern is used to encapsulate a request as an object and pass to an invoker, wherein the invoker does not know how to service the request but uses the encapsulated command to perform an action.

**UML diagram of Command Design Pattern**

![alt text](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/0de6998b1160df22e5bfab252458ff43/image.png)

`Client` client class sends the command object that needs to be executed to the invoker class.

`Invoker` The invoker does not know how to handle the request. What the invoker will do is, it will call the Execute method of the command object.

`Interface` Since all the commands have similar method execute so we will implement interface.

`Concrete Command` Class that implements the execute operation by invoking on the receiver.

 `Receiver class`  Class that performs the Action Associated with the Request.

**Example code**

**Creating Receiver object**
```csharp
using System;
namespace CommandPattern
{
    public class Document
    {
        public void Open()
        {
            Console.WriteLine("Document Opened");
        }
        public void Save()
        {
            Console.WriteLine("Document Saved");
        }
        public void Close()
        {
            Console.WriteLine("Document Closed");
        }
    }
}
```
**Creating a Command**
```csharp
namespace CommandPattern
{
    public interface ICommand
    {
        void Execute();
    }
}
```
**OpenCommand:**
```csharp
namespace CommandPattern
{
    public class OpenCommand : ICommand
    {
        private Document document;
        public OpenCommand(Document doc)
        {
            document = doc;
        }
        public void Execute()
        {
            document.Open();
        }
    }
}
```
**SaveCommand**
```csharp
namespace CommandPattern
{
    class SaveCommand : ICommand
    {
        private Document document;
        public SaveCommand(Document doc)
        {
            document = doc;
        }
        public void Execute()
        {
            document.Save();
        }
    }
}
```
**CloseCommand:**
```csharp
namespace CommandPattern
{
    class CloseCommand : ICommand
    {
        private Document document;
        public CloseCommand(Document doc)
        {
            document = doc;
        }
        public void Execute()
        {
            document.Close();
        }
    }
}
```
**Creating the Invoker**

```csharp
namespace CommandPattern
{
    public class CommandInvoker
    {
        public CommandInvoker ()
         {

          }
        public void Invoke(ICommand cmd)
        {
             cmd.Execute();
        }
    }
}
```
**Client**
```csharp
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            CommandInvoker cmi = new CommandInvoker();
            Console.WriteLine("Enter the command you want to execute");
            Console.WriteLine("1.Open");
            Console.WriteLine("2.Save");
            Console.WriteLine("3.Close");
            string option = Console.ReadLine();
            switch (option.ToLower())
            {
                case "open":  ICommand openCommand = new OpenCommand(document);
                
                          cmi.Invoke(openCommand);
                      break;
                case "save": ICommand saveCommand = new SaveCommand(document);
                          cmi.Invoke(saveCommand);
                          break;
                case "close":  ICommand closeCommand = new CloseCommand(document);
                         cmi.Invoke(closeCommand);
                         break;             
                
                default:
                 break;
            }
             
        }
    }
}
```
**Output**

![alt text](https://gitlab.com/vr.srinidhi/retailplusrota/-/wikis/uploads/163993b26fa8559fb471f3ae2dd0e2b0/image.png)

### Reference

https://github.com/EzDevPrac/CsharpSamples-Lavanya








