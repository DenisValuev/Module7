using Module7.Unit2.Models;

namespace Module7.Unit2
{
    enum FuelType
    {
        Gas = 0,
        Electricity
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            HybridCar hybridCar = new HybridCar();

            car.Move(); // Метод класса Car
            hybridCar.Move(); // Метод класса HybridCar
            ((Car)hybridCar).Move(); // Метод класса HybridCar

            Console.WriteLine("___________________________");
            D d = new D();
            E e = new E();
            
            d.Display(); // D
            ((A)e).Display(); // C
            ((B)d).Display(); // B
            ((A)d).Display(); // A

            Vector a = new Vector { X = 3, Y = 5 };
            Vector b = new Vector { X = 7, Y = 13 };

            //Vector c = new Vector { X = a.X + b.X, Y = a.Y + b.Y };
            //Vector c = a.Add(b);
            Vector c = a + b;
            Console.WriteLine($"{c.X} , {c.Y}");

            var array = new Book[]
                {
                    new Book
                    {
                        Name = "Мастер и Маргарита",
                        Author = "М.А. Булгаков"
                    },
                    new Book
                    {
                        Name = "Отцы и дети",
                        Author = "И.С. Тургенев"
                    },
                };
            BookCollection collection = new BookCollection(array);
        }
    }
}
