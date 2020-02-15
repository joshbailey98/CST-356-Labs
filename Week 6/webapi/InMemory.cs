using System.Collections.Generic;
using webapi;

namespace webapi
{
    public static class InMemory
    {
        public static List<Student> Students = new List<Student> {
            new Student {
                Id = 1,
                StudentId = "asdf",
                EmailAddress = "asdf@gmail.com"
            },
            new Student {
                Id = 2,
                StudentId = "qwer",
                EmailAddress = "qwer@gmail.com"
            },
            new Student {
                Id = 3,
                StudentId = "zxcv",
                EmailAddress = "zxcv@gmail.com"
            },
            new Student {
                Id = 4,
                StudentId = "cvbn",
                EmailAddress = "cvbn@gmail.com"
            },
            new Student {
                Id = 5,
                StudentId = "dfgh",
                EmailAddress = "dfgh@gmail.com"
            }
        };

        public static List<Instructor> Instructors = new List<Instructor> {
            new Instructor {
                Id = 1,
                FirstName = "Jill",
                MiddleInitial = "R.",
                LastName = "Smith"
            },
            new Instructor {
                Id = 2,
                FirstName = "Michael",
                MiddleInitial = "B.",
                LastName = "James"
            },
            new Instructor {
                Id = 3,
                FirstName = "Tom",
                MiddleInitial = "D.",
                LastName = "Brown"
            },    
            new Instructor {
                Id = 4,
                FirstName = "Bob",
                MiddleInitial = "K.",
                LastName = "Roberts"
            },           
            new Instructor {
                Id = 5,
                FirstName = "Sarah",
                MiddleInitial = "M.",
                LastName = "Jane"
            },
        };
    }
}