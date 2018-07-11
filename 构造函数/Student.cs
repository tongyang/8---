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

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Gender { get => _gender; set => _gender = value; }

        public Student(string name, int age, string gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
        }
    }
}
