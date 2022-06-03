using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EFRepository.Contexts;
using Entities.Concrete.School;

namespace DataAccess.Concrete.Ef
{
    public class UserDal : EfEntityRepositoryBase<User, SchoolProjectDbContext>, IUserDal
    {
        public User GetUserByEmailAndPassword(string email, string password)
        {
            using (var dbContext = new SchoolProjectDbContext())
            {
                //return dbContext.Set<Department>().Find(id);
                return dbContext.Users.FirstOrDefault(p => p.Email == email && p.Password == password);
            }
        }

        public List<OperationClaim> GetOperationClaims(int userId)
        {
            using (var dbContext = new SchoolProjectDbContext())
            {
                //return dbContext.Set<Department>().Find(id);

                var claims = from p in dbContext.UserOperationClaims
                             where p.UserId == userId
                             select new OperationClaim()
                             {
                                 Name = p.OperationClaim.Name,
                                 Id = p.OperationClaimId
                             };

                return claims.ToList();
            }
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetList()
        {
            throw new NotImplementedException();
        }
    }
}