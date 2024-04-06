using Polimorphism_Learn_in_lesson.Interfaces;
using Polimorphism_Learn_in_lesson.Models;

namespace Polimorphism_Learn_in_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDivide c = new Calculate();
            Console.WriteLine(c.Divide(40, 2));

            IAdd a = new Calculate();
            Console.WriteLine(a.Add(25, 30));

            IDifference d = new Calculate();
            Console.WriteLine(d.Difference(10, 8));

            IMultiply m = new Calculate();
            Console.WriteLine(m.Multiple(17, 4));


        }
    }
}
