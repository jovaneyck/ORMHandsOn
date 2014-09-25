using Microsoft.VisualStudio.TestTools.UnitTesting;
using ORMHandsOn;

namespace Test.ORM.Exercises
{
    [TestClass]
    public class WhenFetchingAStudentFromALargeDataSet : WithFreshDatabaseForEveryTest
    {
        private StudentRepository _students;

        [TestInitialize]
        public void SetUp()
        {
            _students = new SqlStudentRepository();
        }

        [TestMethod]
        public void ShouldNotRetrieveTheEntireDataSetWhenFetchinASingleStudent()
        {
            var bestStudent = _students.Find("1337");
        }
    }
}
