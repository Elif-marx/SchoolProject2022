using Entities.Concrete.School;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        Department Get(Expression<Func<Department, bool>> filter);
        List<Department> GetList(Expression<Func<Department, bool>> filter);
        Department Add(Department entity);
        void Update(Department entity);
        void Delete(Department entity);
    }
}
