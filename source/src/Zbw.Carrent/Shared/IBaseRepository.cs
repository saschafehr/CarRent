﻿namespace Zbw.Carrent.Shared
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        List<T> GetAll();

        void Clear();
    }
}
