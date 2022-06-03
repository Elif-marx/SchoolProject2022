using SchoolProject2022.Entities;
using System.Collections.Generic;
using WebUI.DataAccess.EFRepository;

namespace SchoolProject2022.DataAccess.EFRepository.DalLayer.SQLServer
{
    public class StudentDal : IStudentDal
    {
        public Student Add(Student entity)
        {
            using (var dbContext = new SchoolProjectDbContext())
            {
                var result = dbContext.Students.Add(entity);
                dbContext.SaveChanges();
            }
            return entity;
        }

        public void BulkInsert(List<Student> list)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Student entity)
        {
            using (var dbContext = new SchoolProjectDbContext())
            {
                var result = dbContext.Students.Remove(entity);
                dbContext.SaveChanges();
            } 
        }

        public Student Get(int id)
        {
            using (var dbContext = new SchoolProjectDbContext())
            {
                //return dbContext.Set<Department>().Find(id);
                return dbContext.Students.Find(id)!;
            }
        }

        public List<Student> GetList()
        {
            using (var dbContext = new SchoolProjectDbContext())
            {
                var result = from p in dbContext.Students
                             select new Student()
                             {
                                 Id = p.Id,
                                 PhotoPath = p.PhotoPath,
                                 FirstName = p.FirstName,
                                 LastName = p.LastName,
                                 DepartmentId = p.DepartmentId,
                                 Department = p.Department

                             };
                return result.ToList();
            }
        }
        public void Update(Student entity)
        {
            using (var dbContext = new SchoolProjectDbContext())
            {
                var result =dbContext.Students.Update(entity);
                dbContext.SaveChanges();
            }
        }
    }
}
