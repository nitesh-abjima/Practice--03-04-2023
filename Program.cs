using AbstractClass;
using NestedClass;
using System;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p1 = new Program();
            p1.display(100);
            p1.display(100, 200);
            p1.displayType(100);
            p1.displayType("Hello World");

            // create an object of Dog class
            AbstractClass.Dog obj = new AbstractClass.Dog();
            obj.makeSound();

            // create an object of Dog1 class
            AbstractClass.Dog1 obj1 = new Dog1();
            obj1.Name = "Tom";
            Console.WriteLine("Name: " + obj1.Name);

            // create an object of Dog2 class
            AbstractClass.Dog2 d1 = new Dog2();

            // create an object of SportsBike class
            SportsBike s1 = new SportsBike();
            s1.brake();

            // create an object of MountainBike class
            MountainBike m1 = new MountainBike();
            m1.brake();

            // create object of outer class
            Car sportsCar = new Car();

            // access method of outer class
            sportsCar.displayCar();

            // create object of inner class
            Car.Engine petrolEngine = new Car.Engine();

            // access member of inner class
            petrolEngine.displayEngine();

            // Creating the object of the derived class
            My_Member ob = new My_Member();

            // Access the method of derived class
            ob.member();

            Console.ReadLine();
        }

        //Method Hiding

        // Base Class
        public class My_Family
        {

            public void member()
            {
                Console.WriteLine("Total number of family members: 3");
            }
        }

        // Derived Class
        public class My_Member : My_Family
        {

            // Reimplement the method of the base class
            // Using new keyword
            // It hides the method of the base class
            public new void member()
            {
                Console.WriteLine("Name: Rakesh, Age: 40 \nName: Somya, " +
                                       "Age: 39 \nName: Rohan, Age: 20 ");
            }
        }

        //Method overloading by changing the Number of Parameters
        // method with one parameter
        public void display(int a)
        {
            Console.WriteLine("Arguments: " + a);
        }

        // method with two parameters
        public void display(int a, int b)
        {
            Console.WriteLine("Arguments: " + a + " and " + b);
        }

        //Method overloading By changing the Data types of the parameters
        // method with int parameter
        public void displayType(int a)
        {
            Console.WriteLine("int type: " + a);
        }

        // method with string parameter
        public void displayType(string b)
        {
            Console.WriteLine("string type: " + b);
        }
        
    }
}

namespace AbstractClass
{
    //Abstract class and abstract method
    abstract class Animal
    {
        // abstract method
        public abstract void makeSound();
    }

    // inheriting from abstract class
    class Dog : Animal
    {

        // provide implementation of abstract method
        public override void makeSound()
        {

            Console.WriteLine("Bark Bark");

        }
    }

    //Abstract class with get and set accessors
    abstract class Animal1
    {

        public string name;
        public abstract string Name
        {
            get;
            set;
        }
    }

    // inheriting from abstract class
    class Dog1 : Animal1
    {
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            } 
        }

    }

    //Access Constructor of Abstract Classes
    abstract class Animal2
    {

        public Animal2()
        {
            Console.WriteLine("Animal Constructor");
        }
    }

    class Dog2 : Animal2
    {
        public Dog2()
        {
            Console.WriteLine("Dog Constructor");
        }
    }

    //Abstraction
    abstract class MotorBike
    {

        public abstract void brake();
    }

    class SportsBike : MotorBike
    {

        // provide implementation of abstract method
        public override void brake()
        {
            Console.WriteLine("Sports Bike Brake");
        }

    }

    class MountainBike : MotorBike
    {

        // provide implementation of abstract method
        public override void brake()
        {
            Console.WriteLine("Mountain Bike Brake");
        }
    }
}

//Example of Nested Class

namespace NestedClass
{

    // outer class
    public class Car
    {

        public void displayCar()
        {
            Console.WriteLine("Car: Bugatti");
        }

        // inner class
        public class Engine
        {
            public void displayEngine()
            {
                Console.WriteLine("Engine: Petrol Engine");
            }
        }
    }
}

