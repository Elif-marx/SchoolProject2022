using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete.School
{
    public class Course:IEntity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }

        [ForeignKey("LecturerId")]
        public int LecturerId { get; set; }

        [ForeignKey("SemesterId")]
        public int SemesterId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
