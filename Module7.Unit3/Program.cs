using Module7.Unit3.Models;

namespace Module7.Unit3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Николай", true);
            Guest guest = new Guest("Андрей", new DateTime(2020, 11, 05));

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Describe();
            cat.Describe();
            FourLeggedAnimal animal = dog;
            animal.Describe();

            animal = cat;
            animal.Describe();
        }
    }
}
