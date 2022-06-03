using Core.Entities.Abstract;

namespace Entities.Concrete.School
{
    public class StudentCourse:IEntity
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int SemesterId { get; set; }
    }
}
