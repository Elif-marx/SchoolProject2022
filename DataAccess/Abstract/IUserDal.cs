
using Entities.Concrete.School;

namespace DataAccess.Abstract
{
    public interface IUserDal:IDbService<User>
    {
        public User GetUserByEmailAndPassword(string email, string password);

        public List<OperationClaim> GetOperationClaims(int userId);
    }
}
