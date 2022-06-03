
using Entities.Concrete.School;

namespace DataAccess.Abstract
{ 
    public interface IStudentDal:IDbService<Student>
    {
        void BulkInsert(List<Student> list);
    }
}
