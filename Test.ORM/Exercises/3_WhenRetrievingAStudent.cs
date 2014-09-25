using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ORMHandsOn;
using Test.ORM.Infrastructure;

namespace Test.ORM.Exercises
{
    [TestClass]
    public class WhenRetrievingAStudent : WithFreshDatabaseForEveryTest
    {
        [TestInitialize]
        public void SetUp()
        {
            (new TestDataSeeder()).SeedDatabaseWithStudentEnrolledInCourses(1, "Paulien", 3);
        }

        [TestMethod]
        public void AlsoRetrievesCoursesSheIsEnrolledIn()
        {
            var coursesPaulienIsEnrolledIn = FindCoursesStudentIsEnrolledIn("Paulien");

            Assert.IsNotNull(coursesPaulienIsEnrolledIn);
            Assert.AreEqual(3, coursesPaulienIsEnrolledIn.Count, "Paulien should be enrolled in 3 courses");
        }

        private ICollection<Course> FindCoursesStudentIsEnrolledIn(string studentName)
        {
            throw new NotImplementedException("Write logic to retrieve all Paulien's courses here.");
        }
    }
}
