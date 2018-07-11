using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Student zhangsan = new Student("张三", '男', 18, 90, 95, 80);
            Student xiaolan = new Student("小兰", '女', 16, 95, 85, 100);

            Ticket t = new Ticket(296);
            Console.WriteLine("距离为{0}公里，票价为{1}元", t.Distance, t.Price);
            Console.ReadKey();
        }
    }
}
