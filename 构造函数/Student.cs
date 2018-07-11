using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数
{
    
    class Student
    {
        private string _name;
        private int _age;
        private string _gender;
        private int _chinese;
        private int _english;
        private int _math;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public int Chinese { get => _chinese; set => _chinese = value; }
        public int English { get => _english; set => _english = value; }
        public int Math { get => _math; set => _math = value; }

        public Student(string name, int age, string gender) :this(name, age, gender, 100, 90, 99)
        {
            
        }

        public Student(string name, int age, string gender, int chinese, int english, int math)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
            this.Chinese = chinese;
            this.English = english;
            this.Math = math;
        }

        // 析构函数
        ~Student()
        {
            Console.WriteLine("我是析构函数");
            Console.ReadKey();
        }
    }
}
