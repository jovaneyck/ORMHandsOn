using System.Data.Entity;

namespace ORMHandsOn
{
    public class EntityContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentConfiguration());
            //Add a mapping from SQL<->Entities for every entity here.
        }
    }
}