using DesignPatternsTutorial.OOP.Abstraction;
using DesignPatternsTutorial.OOP.Composition;
using DesignPatternsTutorial.OOP.Coupling;
using DesignPatternsTutorial.OOP.Encapsulation;
using DesignPatternsTutorial.OOP.Inheritance;
using DesignPatternsTutorial.OOP.Polymorphism;

namespace DesignPatternsTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stuff from OOP tutorials
            // OOPLesson();

            // SOLID Principles

        }

        static void OOPLesson()
        {
            //Encapsulation
            //Encapsulation is the concept of wrapping data and methods that work on that data within one unit, i.e., a class.
            BadBankAccount badBankAccount = new BadBankAccount();
            badBankAccount.balance = 1000; // bad, classes can directly access the field
            //Console.WriteLine(badBankAccount.balance); 

            BankAccount bankAccount = new BankAccount(1000);
            bankAccount.Deposit(500);
            bankAccount.Withdraw(100);
            //Console.WriteLine(bankAccount.Balance); // good, classes can only access the property

            //Abstraction
            //Abstraction is the concept of hiding the complex implementation details and showing only the essential features of the object.
            EmailService emailService = new EmailService();
            //emailService.Connect();
            //emailService.Authenticate();
            //emailService.SendEmail();
            //emailService.Disconnect();

            // Issue with the code above that all classes will have to follow the same steps to send an email.

            // This is better
            // emailService.SendEmail();

            // Inheritance
            // Inheritance is the concept of acquiring the properties and behaviors of another class.
            OOP.Inheritance.Car car = new OOP.Inheritance.Car();
            // Shared
            car.Brand = "Toyota";
            //car.Start();
            //car.Stop();
            car.NumberOfDoors = 4;
            car.NumberOfWheels = 4;

            // Polymorphism
            // Ability of an object to take many forms.
            List<OOP.Polymorphism.Vehicle> vehicles = new List<OOP.Polymorphism.Vehicle>();
            vehicles.Add(new OOP.Polymorphism.Car() { Brand = "Toyota", Model = "Camry", Year = 2020, NumberOfDoors = 4 });
            vehicles.Add(new Motorcycle() { Brand = "Harley Davidson", Model = "Sportster", Year = 2021 });

            // Vehicle Inspection
            foreach (var vehicle in vehicles)
            {
                //vehicle.Start();
            }

            // Coupling
            // Coupling is the degree of dependency between different classes.
            // Tight Coupling: Classes are highly dependent on each other.
            // Loose Coupling: Classes are less dependent on each other.

            // Example of Tight Coupling
            var emailSender = new EmailSender();
            var smsSender = new SmsSender();
            var order = new Order(smsSender);
            //order.PlaceOrder();

            // Composition
            // Composition is a design principle where a class is composed of one or more simpler
            // objects or components. In composition, objects are assembled together to form larger structures, 
            // with each component object maintaining its own state and behavior. Composition is often referred
            // to as a "has-a" relationship
            var car2 = new CarComp();
            car2.StartCar();
        }
    }
}
