using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ORMHandsOn;

namespace Test.ORM.Infrastructure
{
    [TestClass]
    public class WithFreshDatabaseForEveryTest
    {
        [ClassInitialize]
        public static void SetupOnce(TestContext context)
        {
            SetupDatabaseRecreate();
        }

        private static void SetupDatabaseRecreate()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<EntityContext>());
        }

        [TestInitialize]
        public void SetupForEachTest()
        {
            DeleteDatabase();
        }

        private void DeleteDatabase()
        {
            using (var ctx = new EntityContext())
            {
                ctx.Database.Delete();
            }
        }
    }
}
