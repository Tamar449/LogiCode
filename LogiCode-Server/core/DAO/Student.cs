﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAO
{
    public class Student : User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<StudentLesson> StudentLessons { get; set; }

    }
}
                                                                            