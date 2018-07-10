using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态与非静态类
{
    public static class Person
    {
        // public int _age;  静态类中不允许使用实例变量
        private static int _age;

        public static int Age {
            get
            {
                return _age;
            }
            set
            {
                Person._age = value;
            }
        }

        // public void Test() 静态类中不允许使用实例方法
        //{

        //}
    }
}
