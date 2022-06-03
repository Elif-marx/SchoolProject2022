using SchoolProject2022.Entities;
using System.Collections.Generic;
using System.Linq;
using WebUI.DataAccess.EFRepository;

namespace SchoolProject2022.DataAccess.EFRepository.DalLayer.SQLServer
{
    public class UserDal : IUserDal
    {
        public User Add(User entity)
        {
            using (var dbContext = new SchoolProjectDbContext())
            {
                //return dbContext.Set<Department>().Find(id);
                dbContext.Users.Add(entity);
                dbContext.SaveChanges();
                return entity;
            }
        }

        public void Delete(User entity)
        {
            using (var DbContext = new SchoolProjectDbContext() )
            {
                DbContext.Users.Remove(entity);
                DbContext.SaveChanges();
            }
        }

        public User Get(int id)
        {
            using (var DbContext = new SchoolProjectDbContext() )
            {
                return DbContext.Users.Find(id)!;
            }
        }

        public List<User> GetList()
        {
            using (var dbContext = new SchoolProjectDbContext())
            {
                return dbContext.Users.ToList();
            } 
        }

        public List<OperationClaim> GetOperationClaims(int userId)
        {
            using (var DbContext = new SchoolProjectDbContext())
            {
                var claims = from p in DbContext.UserOperationClaims
                            where p.UserId == userId
                            select new OperationClaim()
                            {
                                Name = p.OperationClaim.Name,
                                Id = p.OperationClaimId
                            };
                return claims.ToList();
            }
        }

        public User GetUserByEmailAndPassword(string email, string password)
        {
            using (var DbContext = new SchoolProjectDbContext())
            {
                return DbContext.Users.FirstOrDefault(p => p.Email == email && p.Password == password);
            }
        }

        public void Update(User entity)
        {
            using (var DbContext = new SchoolProjectDbContext())
            {
                DbContext.Users.Update(entity);
                DbContext.SaveChanges();
            }
        }
    }
}
