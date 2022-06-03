using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete.School;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class StudentService:IStudentService
    {
        private readonly IStudentDal _studentDal;
        public StudentService(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }
    
        public Student Get(Expression<Func<Student, bool>> filter)
        {
            return _studentDal.Get(filter);
        }

        public List<Student> GetList(Expression<Func<Student, bool>> filter)
        {
            return _studentDal.GetList(filter).ToList();
        }

        public Student Add(Student entity)
        {
            _studentDal.Add(entity);
            return entity;  
        }

        public void Update(Student entity)
        {
            _studentDal.Update(entity);
        }

        public void Delete(Student entity)
        {
            _studentDal.Delete(entity);

        }
    }
}
