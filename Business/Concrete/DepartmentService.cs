using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete.School;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentDal _departmentDal;
        public DepartmentService(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }
        public Department Add(Department entity)
        {
            return _departmentDal.Add(entity);  
        }

        public void Delete(Department entity)
        {
            _departmentDal.Delete(entity);
        }

        public Department Get(Expression<Func<Department, bool>> filter)
        {
            return _departmentDal.Get(filter);
        }

        public List<Department> GetList(Expression<Func<Department, bool>> filter)
        {
            return _departmentDal.GetList(filter).ToList();
        }

        public void Update(Department entity)
        {
            _departmentDal.Update(entity);
        }
    }
}
