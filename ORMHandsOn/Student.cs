using System;
using System.Collections.Generic;

namespace ORMHandsOn
{
    public class Student
    {
        public long Id { get; protected set; }

        public string Name { get; private set; }
        public int Age { get; set; }

        /*virtual is necessary for EF to lazily load linked entities (called navigation properties)*/
        public virtual List<Course> EnrolledCourses { get; set; } 

        protected Student()
        {
            //EF needs a parameterless constructor to dehydrate objects
        }

        public Student(string name, int age) : this()
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return String.Format("{0}, age: {1}", Name, Age);
        }
    }
}
