using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass c1 = new MyClass();
            Joey c2 = new Joey();
            Console.WriteLine($"Hello {c2.GetReturnMessage()}! {c1.GetReturnMessage()}");
        }
    }
}
