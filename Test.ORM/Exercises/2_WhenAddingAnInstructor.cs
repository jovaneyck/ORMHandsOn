using Microsoft.VisualStudio.TestTools.UnitTesting;
using ORMHandsOn;
using System.Collections.Generic;
using System.Linq;
using Test.ORM.Infrastructure;

namespace Test.ORM.Exercises
{
    [TestClass]
    public class WhenAddingAnInstructor : WithFreshDatabaseForEveryTest
    {
        [TestMethod]
        public void CanAddAndRetrieveAnInstructor()
        {
            var me = new Instructor("Jo", "Advanced");

            AddInstructor(me);

            var allInstructors = GetAllInstructors();

            Assert.AreEqual(1, allInstructors.Count,
                @"There should be one and only one instructor in the database. 
                If you think you have everything configured correctly, try checking the following things:
                Are you saving your changes (i.e. committing the transaction)?");
            Assert.AreEqual("Advanced", allInstructors.Single().SkillLevel, "I'm supposed to be Advanced in this ORM stuff!");
        }

        private void AddInstructor(Instructor instructor)
        {
            throw new System.NotImplementedException("implement logic to add an instructor to the database here");
        }

        private IList<Instructor> GetAllInstructors()
        {
            throw new System.NotImplementedException("implement logic to retrieve all instructors from the database here");
        }
    }
}