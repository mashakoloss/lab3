using Bogus.DataSets;
using System;

namespace Lecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public virtual void Display()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
    }

    static void Main(string[] args);
    {
    Person p1 = new Person("Bill");
    p1.Display(); // Display 

    Employee p2 = new Employee("Tom", "Microsoft");
    p2.Display(); // Display 

    Console.ReadKey();
}
class Employee : Person
{
    public string Company { get; set; }
    public Employee(string name, string company) : base(name)
    {
        Company = company;
    }
    public override void Display()
    {
        Console.WriteLine($"{Name} {Company}");
    }
}
static void Main(string[] args)
{
    Person p1 = new Person("Bill");
    p1.Display(); // Display

    Employee p2 = new Employee("Tom", "Microsoft");
    p2.Display(); // Display

    Console.ReadKey();
}

class Credit
{
    public virtual decimal Sum { get; set; }
}
class LongCredit : Credit
{
    private decimal sum;
    public override decimal Sum
    {
        get
        {
            return sum;
        }
        set
        {
            if (value > 1000)
            {
                sum = value;
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        LongCredit credit = new LongCredit { Sum = 6000 };
        credit.Sum = 490;
        Console.WriteLine(credit.Sum);
        Console.ReadKey();
    }
}
class Employee : Person
{
    public string Company { get; set; }
    public Employee(string name, string company) 
        : base(name)
    {
        Company = company;
    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"працюєв {Company}");
    }
}
class Employee : Person
{
    public string Company { get; set; }
    public Employee(string name, string company) 
        : base(name)
    {
        Company = company;
    }
    public override sealed void Display()
    {
        Console.WriteLine($"{Name} працюєв {Company}");
    }
}
abstract class Human
{
    public int Length { get; set; }
    public double Weight { get; set; }
}
abstract class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public void Display()
    {
        Console.WriteLine(Name);
    }
}
class Client : Person
{
    public int Sum { get; set; }
    public Client(string name, int sum)
        : base(name)
    {
        Sum = sum;
    }
}
class Employee : Person
{
    public string Position { get; set; }
    public Employee(string name, string position) 
        : base(name)
    {
        Position = position;
    }
}
Client client = new Client("Tom", 500);
Employee employee = new Employee("Bob", "Apple");
client.Display();
employee.Display();

abstract class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public abstract void Display();
}
class Client : Person
{
    public int Sum { get; set; }
    public Client(string name, int sum) 
        : base(name)
    {
        Sum = sum;
    }
    public override void Display()
    {
        Console.WriteLine($"{Name} маєнарахунку {Sum}");
    }
}
class Employee : Person
{
    public string Position { get; set; }
    public Employee(string name, string position) 
        : base(name)
    {
        Position = position;
    }
    public override void Display()
    {
        Console.WriteLine($"{Position} {Name}");
    }
}
abstract class Person
{
    public abstract string Name { get; set; }
}
class Client : Person
{
    private string name;
    public override string Name
    {
        get { return "Mr/Ms. " + name; }
        set { name = value; }
    }
}
class Employee : Person
{
    public override string Name { get; set; }
}
abstract class Person
{
    public abstract string Name { get; set; }
}
abstract class Manager : Person
{
}
abstract class Figure
{
    public abstract float Perimeter();
    public abstract float Area();
}
class Rectangle : Figure
{
    public float Width { get; set; }
    public float Height { get; set; }
    public Rectangle(float width, float height)
    {
        this.Width = width;
        this.Height = height;
    }
    public override float Perimeter()
    {
        return Width * 2 + Height * 2;
    }
    public override float Area()
    {
        return Width * Height;
    }
}