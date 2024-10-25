using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Enums;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="János",
                    LastName="Jegy",
                    BirthsDay=new DateTime(2011,10,10),
                    SchoolYear=9,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevel="érettségi"
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Szonja",
                    LastName="Stréber",
                    BirthsDay=new DateTime(2012,4,4),
                    SchoolYear=10,
                    SchoolClass = SchoolClassType.ClassB,
                    EducationLevel="érettségi"
                }
            };

            // Students
            modelBuilder.Entity<Student>().HasData(students);

            List<Teacher> techers = new List<Teacher>
            {
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Feleltető",
                    LastName="Ferenc",
                    BirthsDay=new DateTime(2001,8,1),
                    IsWoomen=false,
                    IsHeadTeacher=false
                },
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Aranyos",
                    LastName="Aranka",
                    BirthsDay=new DateTime(2002,2,24),
                    IsWoomen=true,
                    IsHeadTeacher=true
                }
            };

            modelBuilder.Entity<Teacher>().HasData(techers);
            List<User> users = new List<User>
            {
                new User
                {
                    Id=Guid.NewGuid(),
                    Username="User01",
                    Registered = new DateTime(2018,5,12),
                    Languages=3,
                    Nationality="Dutch",
                    IsWoomen = false,
                },
                new User
                {
                    Id=Guid.NewGuid(),
                    Username="User02",
                    Registered = new DateTime(2018,6,18),
                    Languages=2,
                    Nationality="French",
                    IsWoomen = true,
                }
            };
            modelBuilder.Entity<User>().HasData(users);
            List<Admin> admins = new List<Admin>
            {
                new Admin
                {
                    Id=Guid.NewGuid(),
                    Username="Admin01",
                    Registered = new DateTime(2016,9,27),
                    SecurityLevel=3,
                    Nationality="Danish",
                    IsWoomen = false,
                    IsOwner=false,
                },
                new Admin
                {
                    Id=Guid.NewGuid(),
                    Username="Admin02",
                    Registered = new DateTime(2017,1,5),
                    SecurityLevel=4,
                    Nationality="German",
                    IsWoomen = true,
                    IsOwner = true,
                }
            };
            modelBuilder.Entity<Admin>().HasData(admins);
            List<Server> servers = new List<Server>
            {
                new Server
                {
                    Id=Guid.NewGuid(),
                    ServerName="Server01",
                    Created = new DateTime(2020,1,5),
                    NumOfUsers=32,
                    Owner="Owner25",
                    IsPrivate = false,
                },
                new Server
                {
                    Id=Guid.NewGuid(),
                    ServerName="Server02",
                    Created = new DateTime(2019,12,25),
                    NumOfUsers=4,
                    Owner="Owner28",
                    IsPrivate = true,
                }
            };
            modelBuilder.Entity<Server>().HasData(servers);
        }
    }
}
