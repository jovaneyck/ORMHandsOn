using System;
using ORMHandsOn;

namespace Test.ORM.Infrastructure
{
    /// <summary>
    /// Feeds the database with some initial data
    /// </summary>
    public class TestDataSeeder
    {
        public void SeedDatabaseWithStudentEnrolledInCourses(int id, string studentName, int numberOfCourses)
        {
            //very quick and dirty way to seed test data, this is NOT the ORM way :)
            using (var context = new EntityContext())
            {
                context.Database.ExecuteSqlCommand(String.Format("INSERT INTO Students (Id, Name, Age) VALUES ({0}, '{1}', 23)", id, studentName));
                const string insertCourseStatement = "INSERT INTO Courses (Name, Student_Id) VALUES ({0}, {1})";

                for (int courseNumber = 1; courseNumber <= numberOfCourses; courseNumber++)
                {
                    context.Database.ExecuteSqlCommand(insertCourseStatement, String.Format("Course number {0}", courseNumber), id);    
                }
            }
        }
    }
}
