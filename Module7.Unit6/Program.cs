using Module7.Unit6.Models;

namespace Module7.Unit6
{
    internal class Program
    {
        public static void Swap<T>(ref T x, ref T y)
        {
            T t = x;
            x = y;
            y = t;
        }
        static void Main(string[] args)
        {
            //Order<int> order1 = new Order<int>();
            //Order<string> order2 = new Order<string>();

            //order1.Number = 1234;
            //order2.Number = "NN-1234";

            //int number1 = order1.Number;
            //string number2 = order2.Number;

            Obj obj = new Obj();
            obj.Display<int>(345);
            //obj.Display(number2);// Указание универсального параметра не всегда обязательно

            int num1 = 4;
            int num2 = 10;
            Swap<int>(ref num1, ref num2);

            Console.WriteLine("{0} {1}", num1, num2);
        }
    }
}
