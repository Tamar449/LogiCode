using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAO
{
    public enum DifficultyLevel
    {
       קל_מאד,
        קל,
        בינוני,
        למתקדמים
    }

    public class Course
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProgrammingLanguage { get; set; }
        public int TeacherId { get; set; }
        public int CountLessons { get; set; }
        public decimal Price { get; set; }
        public DifficultyLevel Difficulty { get; set; }
        public string ImageUrl { get; set; }

        public Teacher Teacher { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }

    }
}
