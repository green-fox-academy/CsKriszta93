using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloneable
{
    public interface ICloneable
    {
        object Clone();
    }

    class Student : ICloneable
    {
        public string name;
        public int age;
        public string gender;
        public string previousOrganization;

        public Student(string name, int age, string gender, string previousOrganization)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.previousOrganization = previousOrganization;
        }

        public Student()
        {
            name = "Jane Doe";
            age = 20;
            gender = "male";
            previousOrganization = "BME";
        }

        public object Clone()
        {
            return new Student();
        }
    }
}
