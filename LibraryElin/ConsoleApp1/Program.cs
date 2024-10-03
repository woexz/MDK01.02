using LibraryElin;
using static LibraryElin.Class1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 myFunctions = new Class1();

            int a = 10;
            int b = 5;

            Console.WriteLine("Add: " + myFunctions.Add(a, b));
            Console.WriteLine("Subtract: " + myFunctions.Subtract(a, b));
            Console.WriteLine("Multiply: " + myFunctions.Multiply(a, b));
            Console.WriteLine("Divide: " + myFunctions.Divide(a, b));
            Console.WriteLine("Modulus: " + myFunctions.Modulus(a, b));

            Console.ReadKey();
        }
    }
}
