using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete.School
{
    public class Exam:IEntity
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int ExamTypeId { get; set; }
        public int SemesterId { get; set; }
        public DateTime ExamDate { get; set; }
        public int Duration { get; set; }

    }
}
