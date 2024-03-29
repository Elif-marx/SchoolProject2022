﻿using System.Collections.Generic;

namespace DataAccess.Abstract
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
