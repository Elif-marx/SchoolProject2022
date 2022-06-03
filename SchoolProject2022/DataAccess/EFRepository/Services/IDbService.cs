using System.Collections.Generic;

namespace SchoolProject2022.DataAccess.EFRepository.Services
{
    public interface IDbService<T >where T :class , new()
    {
        T Get(int id);
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetList();

    }
}
