namespace APILab.Migrations.School
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    //add-migration -ConfigurationTypeName APILab.Migrations.School.Configuration "InitialCreate"
    //update-database -ConfigurationTypeName APILab.Migrations.School.Configuration 

    internal sealed class Configuration : DbMigrationsConfiguration<APILab.Data.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\School";
        }

        protected override void Seed(APILab.Data.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Students.AddOrUpdate(
                s => new { s.FirstName, s.LastName },
                GetSampleStudents().ToArray()
            );
            context.SaveChanges();
        }

        public static List<Student> GetSampleStudents()
        {
            List<Student> students = new List<Student>() {
                new Student {
                    FirstName = "Ann",
                    LastName = "Lee",
                    Major = "Medicine",
                    DateOfBirth = Convert.ToDateTime("2004/09/09")
                },
                new Student {
                    FirstName = "Bob",
                    LastName = "Doe",
                    Major = "Engineering",
                    DateOfBirth = Convert.ToDateTime("2005/09/09")
                },
                new Student {
                    FirstName = "Sue",
                    LastName = "Douglas",
                    Major = "Pharmacy",
                    DateOfBirth = Convert.ToDateTime("2006/01/01")
                },
                new Student {
                    FirstName = "Tom",
                    LastName = "Brown",
                    Major = "Business",
                    DateOfBirth = Convert.ToDateTime("2000/09/09")
                },
                new Student {
                    FirstName = "Joe",
                    LastName = "Mason",
                    Major = "Health",
                    DateOfBirth = Convert.ToDateTime("2001/01/01")
                }
            };
            return students;
        }
    }
}
