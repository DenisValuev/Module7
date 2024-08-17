namespace Module7.Unit1
{
    enum FuelType
    {
        Gas =0,
        Electricity
    }
    class Car
    {
        public double Fuel;
        public int Mileage;
        public Car()
        {
            Fuel = 50;
            Mileage = 0;
        }
        public void Move()
        {
            Mileage++;
            Fuel -= 0.5;
        }
        public void FillTheCar()
        {
            Fuel = 50;
        }
    }
    class HybridCar : Car
    {
        public FuelType FuelType;
        public void ChangeFuelType(FuelType type)
        {
            FuelType = type;
        }
    }
    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }
    class ProjectManager : Employee
    {
        public string ProjectName;
    }
    class Developer : Employee
    {
        public string ProgrammingLanguage;
    }
    class Food { }
    class Fruit : Food { }
    class Apple : Fruit { }
    class Banana : Fruit{ }
    class Pear : Fruit { }
    class Vegetable : Food { }
    class Potato : Vegetable { }
    class Carrot : Vegetable { }
    class Obj
    {
        public string name;
        public string owner;
        public int length;
        private int count;
        public string description;
        public Obj()
        {
            Console.WriteLine("Вызван конструктор без параметром");
        }
        public Obj(string name, string description) : this()
        {
            this.name = name;
            this.description = description;
        }
        public Obj(string name, string ownerName, int objlength, int count )
        {
            this.name = name;
            owner = ownerName;
            length = objlength;
            this.count = count;
        }
    }
    class BaseClass
    {
        public string Name;
        //protected string Description;
        //private int value;
        //public BaseClass(int value)
        //{
        //    this.value = value;
        //}
        public BaseClass(string name)
        {
            Name = name;
        }
    }
    //class InheritedClass : BaseClass
    //{
    //    private int newValue;
    //    //public InheritedClass(int newValue) : base(100)
    //    //{
    //    //    this.newValue= newValue;
    //    //}
    //}
    class DerivedClass : BaseClass
    {
        public string Description;
        public int Counter;
        public DerivedClass(string name, string description) : base(name)
        {
            Description = description;
        }
        public DerivedClass(string name, string description, int counter) : this(name, description)
        {
            Counter = counter;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new HybridCar();
            car.Move();
        }
    }
}
