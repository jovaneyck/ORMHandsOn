using Microsoft.VisualStudio.TestTools.UnitTesting;
using ORMHandsOn;
using System.Collections.Generic;
using System.Linq;
using Test.ORM.Infrastructure;

namespace Test.ORM.Exercises
{
    [TestClass]
    public class WhenAddingAStudent : WithFreshDatabaseForEveryTest
    {
        [TestMethod]
        public void CanAddAndRetrieveAStudent()
        {
            var me = new Student("Jefke", 26);

            AddStudent(me);

            var allStudents = GetAllStudents();

            Assert.AreEqual(1, allStudents.Count, "Jefke should be the only student enrolled here.");
            Assert.AreEqual("Jefke", allStudents.Single().Name);
        }

        private void AddStudent(Student student)
        {
            using (var context = new EntityContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        private IList<Student> GetAllStudents()
        {
            using (var context = new EntityContext())
            {
                return context.Students.ToList();
            }
        }
    }
}
