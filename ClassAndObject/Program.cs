using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 one = new Class1(1, "No1");
            one.showNameAndID();
            Class1 two = new Class1(2, "No2");
            two.showNameAndID();
            two.classID = 5;
            two.showNameAndID();
            Console.ReadKey();
        }
    }
}
