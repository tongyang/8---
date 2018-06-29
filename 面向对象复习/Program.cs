using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "童扬";
            Person p1 = Person.PersonWithName("徐娅");
            Console.WriteLine(p.Name);
            Console.WriteLine(p1.Name);
            Console.ReadKey();
        }
    }
}
