using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象复习
{
    class Person
    {
        string _name;
        char _gaden;
        int _age;

        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                if (_name == "童扬")
                {
                    _name += "徐娅";
                }
                return _name;
            }
        }

        public static Person PersonWithName(string name)
        {
            Person person = new Person();
            person.Name = name;
            return person;
        }
    }
}
