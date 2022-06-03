using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EFRepository.Contexts;
using Entities.Concrete.School;

namespace DataAccess.Concrete.Ef
{
    public class StudentDal : EfEntityRepositoryBase<Student, SchoolProjectDbContext>, IStudentDal
    {
        public void BulkInsert(List<Student> list)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetList()
        {
            throw new NotImplementedException();
        }
    }
}