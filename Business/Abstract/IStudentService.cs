using Entities.Concrete.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStudentService
    {
        Student Get(Expression<Func<Student, bool>> filter);
        List<Student> GetList(Expression<Func<Student, bool>> filter);
        Student Add(Student entity);
        void Update(Student entity);
        void Delete(Student entity);
    }
}
