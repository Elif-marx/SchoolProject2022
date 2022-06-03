using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete.School
{
    public class Semester:IEntity
    {
        public int Id { get; set; }
        public int SemesterNumber { get; set; }
        public string Name { get; set; }
    }
}
