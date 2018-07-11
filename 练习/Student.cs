using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习
{
    class Student
    {
        private string _name;
        private char _sex;
        private int _age;
        private int _chinese;
        private int _english;
        private int _math;

        public string Name { get => _name; set => _name = value; }
        public char Sex { get => _sex; set => _sex = value; }
        public int Age { get => _age; set => _age = value; }
        public int Chinese { get => _chinese; set => _chinese = value; }
        public int English { get => _english; set => _english = value; }
        public int Math { get => _math; set => _math = value; }

        public Student(string name, char sex, int age, int chinese, int english, int math)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
            this.Chinese = chinese;
            this.English = english;
            this.Math = math;
        }

        public Student(string name, char sex) : this(name, sex, 18, 0, 0, 0)
        {

        }
    }
}
