using Module7.Unit5.Models;

namespace Module7.Unit5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SimpleClass.MinValue);
            int num1 = 3;
            int num2 = 58;
            Helper.Swap(ref num1, ref num2);
            Console.WriteLine(num1);
            Console.WriteLine(num2);

            string str = "Hello";
            Console.WriteLine(str.GetLastChar());
            Console.WriteLine("Строка".GetLastChar());

            Console.WriteLine("_______________________________");
            num1 = 7;
            num2 = -13;
            int num3 = 0;

            Console.WriteLine(num1.GetNegative());
            Console.WriteLine(num1.GetPositive());
            Console.WriteLine(num2.GetNegative());
            Console.WriteLine(num2.GetPositive());
            Console.WriteLine(num3.GetNegative());
            Console.WriteLine(num3.GetPositive());

        }
    }
}
