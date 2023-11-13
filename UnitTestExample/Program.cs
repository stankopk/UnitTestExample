using System;

namespace UnitTestExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            Divider d = new Divider();
            var div = d.Divide(a,b);
            Console.WriteLine(div);
        }
    }
}
